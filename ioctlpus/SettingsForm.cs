using System;
using System.Windows.Forms;

namespace ioctlpus
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;

        public SettingsForm()
        {
            InitializeComponent();
            numNumberBytesIn.Value = 8;
            numNumberBytesOut.Value = 8;
        }
        private void InPaneStringsView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneStringsView.Checked == true)
            {
                mainForm.hbInput.StringViewVisible = true;
            }
            else
            {
                mainForm.hbInput.StringViewVisible = false;
            }
        }
        private void OutPaneStringsView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneStringsView.Checked == true)
            {
                mainForm.hbOutput.StringViewVisible = true;
            }
            else
            {
                mainForm.hbOutput.StringViewVisible = false;
            }
        }

        private void InPaneSeparatorView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneSeparatorView.Checked == true)
            {
                mainForm.hbInput.GroupSeparatorVisible = true;
            }
            else
            {
                mainForm.hbInput.GroupSeparatorVisible = false;
            }
        }

        private void OutPaneSeparatorView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneSeparatorView.Checked == true)
            {
                mainForm.hbOutput.GroupSeparatorVisible = true;
            }
            else
            {
                mainForm.hbOutput.GroupSeparatorVisible = false;
            }
        }

        private void InPaneBarView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneBarView.Checked == true)
            {
                mainForm.hbInput.ColumnInfoVisible = true;
                mainForm.hbInput.LineInfoVisible = true;
            }
            else
            {
                mainForm.hbInput.ColumnInfoVisible = false;
                mainForm.hbInput.LineInfoVisible = false;
            }
        }

        private void OutPaneBarView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneBarView.Checked == true)
            {
                mainForm.hbOutput.ColumnInfoVisible = true;
                mainForm.hbOutput.LineInfoVisible = true;
            }
            else
            {
                mainForm.hbOutput.ColumnInfoVisible = false;
                mainForm.hbOutput.LineInfoVisible = false;
            }
        }

        private void numNumberBytesIn_ValueChanged(object sender, EventArgs e)
        {
            mainForm.hbInput.BytesPerLine = (int)numNumberBytesIn.Value;
        }

        private void numNumberBytesOut_ValueChanged(object sender, EventArgs e)
        {
            mainForm.hbOutput.BytesPerLine = (int)numNumberBytesOut.Value;
        }
    }
}
