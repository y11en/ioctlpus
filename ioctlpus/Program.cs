using CommandLine;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ioctlpus.Utilities.NativeMethods;

namespace ioctlpus
{
    static class Program
    {
        public static byte[] StringToByteArray(string hex)
        {
            if (hex.Length % 2 == 1)
            {
                throw new Exception("The binary string cannot have an odd number of digits");
            }
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = "0x" + BitConverter.ToString(ba).Replace("-", " 0x");
            return hex;
        }

        // args options
        class Options
        {
            [Option("cli", HelpText = "Run IOCTLpus in CLI mode.")]
            public bool Cli { get; set; }

            [Option("guid", HelpText = "Path/GUID of the driver to interact with.", Default = null)]
            public string Guid { get; set; }

            [Option("ioctl", HelpText = "IOCTL code.", Default = null)]
            public string Ioctl { get; set; }

            [Option('i', "input-size", HelpText = "Input Size (decimal).", Default = 32)]
            public int Input_size { get; set; }

            [Option('o', "output-size", HelpText = "Output Size (decimal).", Default = 32)]
            public int Output_size { get; set; }

            [Option("input", HelpText = "Input buffer.", Default = null)]
            public string Input_buffer { get; set; }

            [Option('r', "repeat", HelpText = "# of times to repeat the IOCTL request.", Default = 0)]
            public int Repeat { get; set; }

            [Option("access-mask", HelpText = "Access Mask.", Default = "20000000")]
            public string Access_mask { get; set; }

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // handle args parsing
            Parser.Default.ParseArguments<Options>(args).WithParsed(opts =>
            {
                // if the cli arg parameter is specified the software will run in CLI mode
                if (opts.Cli)
                {
                    Console.WriteLine("IOCTLpus CLI Mode\n--------------------\n");
                    // hanlde some required parameters
                    if (opts.Guid == null)
                    {
                        Console.WriteLine("Required option 'guid' is missing.");
                        return;
                    }
                    if (opts.Ioctl == null)
                    {
                        Console.WriteLine("Required option 'ioctl' is missing.");
                        return;
                    }
                    if (opts.Input_buffer == null)
                    {
                        Console.WriteLine("Required option 'input' is missing.");
                        return;
                    }
                    // if we gathered every parameter we can proceed and perform the IOCTL request printing out the result
                    uint fa_mask = Convert.ToUInt32(opts.Access_mask, 16);
                    SafeFileHandle sfh = CreateFile(
                        opts.Guid.Trim(),
                        (FileAccess)fa_mask,
                        FileShare.ReadWrite,
                        IntPtr.Zero,
                        FileMode.Open,
                        FileAttributes.Normal,
                        IntPtr.Zero);

                    int errorCode = 0;

                    uint ioctl = Convert.ToUInt32(opts.Ioctl.Trim(), 16);
                    uint returnedBytes = 0;
                    uint inputSize = (uint)opts.Input_size;
                    uint outputSize = (uint)opts.Output_size;
                    byte[] outputBuffer = new byte[outputSize];
                    byte[] inputBuffer = new byte[inputSize];

                    if (sfh.IsInvalid)
                    {
                        string errorMessage = new Win32Exception(Marshal.GetLastWin32Error()).Message;
                        Console.WriteLine(errorMessage);
                        return;
                    }
                    else
                    {
                        // grab the opts.Input_buffer transform it into a byte array
                        byte[] hbInput = StringToByteArray(opts.Input_buffer);
                        long hbInputLength = hbInput.Length;
                        MemSet(Marshal.UnsafeAddrOfPinnedArrayElement(inputBuffer, 0), 0, (int)hbInputLength);

                        for (int i = 0; i < inputSize; i++)
                        {
                            inputBuffer[i] = hbInput[i];
                        }
                        MemSet(Marshal.UnsafeAddrOfPinnedArrayElement(outputBuffer, 0), 0, (int)outputBuffer.Length);
                        DeviceIoControl(sfh, ioctl, inputBuffer, inputSize, outputBuffer, outputSize, ref returnedBytes, IntPtr.Zero);

                        errorCode = Marshal.GetLastWin32Error();
                        string errorMessage = new Win32Exception(Marshal.GetLastWin32Error()).Message;
                        sfh.Close();
                        // print out returning values
                        Console.WriteLine("GUID:\t\t" + opts.Guid);
                        Console.WriteLine("IOCTL:\t\t0x{0:X}", ioctl);
                        Console.WriteLine("Input Buffer:\t" + ByteArrayToString(inputBuffer));
                        Console.WriteLine("Returned Bytes:\t{0:D}", returnedBytes);
                        Console.WriteLine("Output Buffer:\t" + ByteArrayToString(outputBuffer));
                        Console.WriteLine("Error:\t\t0x{0:X} - " + errorMessage, errorCode);
                    }
                }
                // run IOCTLpus in GUI mode
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    try
                    {
                        Console.WriteLine("[!] Do not close this window. - IOCTLpus");
                        Application.Run(new MainForm());
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                }
            });
        }
    }
}
