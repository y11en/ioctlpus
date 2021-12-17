namespace ioctlpus
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnStarRequest = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.tbFilters = new System.Windows.Forms.TextBox();
            this.tlpPanes = new System.Windows.Forms.TableLayoutPanel();
            this.gbRightPane = new System.Windows.Forms.GroupBox();
            this.hbOutput = new Be.Windows.Forms.HexBox();
            this.gbLeftPane = new System.Windows.Forms.GroupBox();
            this.hbInput = new Be.Windows.Forms.HexBox();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReqParams = new System.Windows.Forms.Panel();
            this.lblInputAccessMask = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbAccessMask = new System.Windows.Forms.TextBox();
            this.lblOutputSize = new System.Windows.Forms.Label();
            this.nudOutputSize = new System.Windows.Forms.NumericUpDown();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.lblInputSize = new System.Windows.Forms.Label();
            this.lblIOCTLCode = new System.Windows.Forms.Label();
            this.tbIOCTL = new System.Windows.Forms.TextBox();
            this.tbDevicePath = new System.Windows.Forms.TextBox();
            this.lblDevPath = new System.Windows.Forms.Label();
            this.nudInputSize = new System.Windows.Forms.NumericUpDown();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbRequestHistory = new System.Windows.Forms.GroupBox();
            this.tlvRequestHistory = new BrightIdeasSoftware.TreeListView();
            this.olvColumnRequest = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRetVal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBytesReturned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tlpPanes.SuspendLayout();
            this.gbRightPane.SuspendLayout();
            this.gbLeftPane.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnlReqParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.gbRequestHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDB.Enabled = false;
            this.btnSaveDB.Image = global::ioctlpus.Properties.Resources.database_save;
            this.btnSaveDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveDB.Location = new System.Drawing.Point(1091, 95);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(32, 32);
            this.btnSaveDB.TabIndex = 14;
            this.toolTip.SetToolTip(this.btnSaveDB, "Save database");
            this.btnSaveDB.UseVisualStyleBackColor = true;
            // 
            // btnStarRequest
            // 
            this.btnStarRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRequest.Image = global::ioctlpus.Properties.Resources.star;
            this.btnStarRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStarRequest.Location = new System.Drawing.Point(1091, 133);
            this.btnStarRequest.Name = "btnStarRequest";
            this.btnStarRequest.Size = new System.Drawing.Size(32, 32);
            this.btnStarRequest.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnStarRequest, "Mark selected request as favourite");
            this.btnStarRequest.UseVisualStyleBackColor = true;
            this.btnStarRequest.Click += new System.EventHandler(this.btnStarRequest_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::ioctlpus.Properties.Resources.cog;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(1091, 19);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRequest.Enabled = false;
            this.btnDeleteRequest.Image = global::ioctlpus.Properties.Resources.delete;
            this.btnDeleteRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteRequest.Location = new System.Drawing.Point(1091, 171);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteRequest.TabIndex = 16;
            this.toolTip.SetToolTip(this.btnDeleteRequest, "Delete request");
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::ioctlpus.Properties.Resources.help;
            this.btnAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAbout.Location = new System.Drawing.Point(1091, 234);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(32, 32);
            this.btnAbout.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDB.Enabled = false;
            this.btnOpenDB.Image = global::ioctlpus.Properties.Resources.database_add;
            this.btnOpenDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenDB.Location = new System.Drawing.Point(1091, 57);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(32, 32);
            this.btnOpenDB.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnOpenDB, "Load database");
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // tbFilters
            // 
            this.tbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilters.Enabled = false;
            this.tbFilters.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.tbFilters.Location = new System.Drawing.Point(6, 244);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Size = new System.Drawing.Size(1079, 20);
            this.tbFilters.TabIndex = 11;
            this.toolTip.SetToolTip(this.tbFilters, "Filter request view");
            this.tbFilters.TextChanged += new System.EventHandler(this.tbFilters_TextChanged);
            // 
            // tlpPanes
            // 
            this.tlpPanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPanes.ColumnCount = 2;
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.Controls.Add(this.gbRightPane, 1, 0);
            this.tlpPanes.Controls.Add(this.gbLeftPane, 0, 0);
            this.tlpPanes.Location = new System.Drawing.Point(3, 118);
            this.tlpPanes.Name = "tlpPanes";
            this.tlpPanes.RowCount = 1;
            this.tlpPanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanes.Size = new System.Drawing.Size(1129, 204);
            this.tlpPanes.TabIndex = 0;
            // 
            // gbRightPane
            // 
            this.gbRightPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRightPane.Controls.Add(this.hbOutput);
            this.gbRightPane.Location = new System.Drawing.Point(567, 3);
            this.gbRightPane.Name = "gbRightPane";
            this.gbRightPane.Size = new System.Drawing.Size(559, 198);
            this.gbRightPane.TabIndex = 1;
            this.gbRightPane.TabStop = false;
            this.gbRightPane.Text = "Output Buffer";
            // 
            // hbOutput
            // 
            this.hbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbOutput.BytesPerLine = 8;
            this.hbOutput.ColumnInfoVisible = true;
            this.hbOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.hbOutput.GroupSeparatorVisible = true;
            this.hbOutput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbOutput.LineInfoVisible = true;
            this.hbOutput.Location = new System.Drawing.Point(6, 19);
            this.hbOutput.Name = "hbOutput";
            this.hbOutput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbOutput.Size = new System.Drawing.Size(547, 173);
            this.hbOutput.StringViewVisible = true;
            this.hbOutput.TabIndex = 9;
            this.hbOutput.UseFixedBytesPerLine = true;
            this.hbOutput.VScrollBarVisible = true;
            // 
            // gbLeftPane
            // 
            this.gbLeftPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLeftPane.Controls.Add(this.hbInput);
            this.gbLeftPane.Location = new System.Drawing.Point(3, 3);
            this.gbLeftPane.Name = "gbLeftPane";
            this.gbLeftPane.Size = new System.Drawing.Size(558, 198);
            this.gbLeftPane.TabIndex = 0;
            this.gbLeftPane.TabStop = false;
            this.gbLeftPane.Text = "Input Buffer";
            // 
            // hbInput
            // 
            this.hbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbInput.BytesPerLine = 8;
            this.hbInput.ColumnInfoVisible = true;
            this.hbInput.Font = new System.Drawing.Font("Consolas", 9F);
            this.hbInput.GroupSeparatorVisible = true;
            this.hbInput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbInput.LineInfoVisible = true;
            this.hbInput.Location = new System.Drawing.Point(6, 19);
            this.hbInput.Name = "hbInput";
            this.hbInput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbInput.Size = new System.Drawing.Size(546, 173);
            this.hbInput.StringViewVisible = true;
            this.hbInput.TabIndex = 6;
            this.hbInput.UseFixedBytesPerLine = true;
            this.hbInput.VScrollBarVisible = true;
            this.hbInput.ByteProviderChanged += new System.EventHandler(this.hbInput_ByteProviderChanged);
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.ColumnCount = 1;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Controls.Add(this.pnlReqParams, 0, 0);
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpTop.Size = new System.Drawing.Size(1129, 109);
            this.tlpTop.TabIndex = 2;
            // 
            // pnlReqParams
            // 
            this.pnlReqParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReqParams.Controls.Add(this.lblInputAccessMask);
            this.pnlReqParams.Controls.Add(this.btnSend);
            this.pnlReqParams.Controls.Add(this.tbAccessMask);
            this.pnlReqParams.Controls.Add(this.lblOutputSize);
            this.pnlReqParams.Controls.Add(this.nudOutputSize);
            this.pnlReqParams.Controls.Add(this.lblRepeat);
            this.pnlReqParams.Controls.Add(this.nudRepeat);
            this.pnlReqParams.Controls.Add(this.lblInputSize);
            this.pnlReqParams.Controls.Add(this.lblIOCTLCode);
            this.pnlReqParams.Controls.Add(this.tbIOCTL);
            this.pnlReqParams.Controls.Add(this.tbDevicePath);
            this.pnlReqParams.Controls.Add(this.lblDevPath);
            this.pnlReqParams.Controls.Add(this.nudInputSize);
            this.pnlReqParams.Location = new System.Drawing.Point(3, 3);
            this.pnlReqParams.MinimumSize = new System.Drawing.Size(1123, 103);
            this.pnlReqParams.Name = "pnlReqParams";
            this.pnlReqParams.Size = new System.Drawing.Size(1123, 103);
            this.pnlReqParams.TabIndex = 0;
            // 
            // lblInputAccessMask
            // 
            this.lblInputAccessMask.AutoSize = true;
            this.lblInputAccessMask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInputAccessMask.Location = new System.Drawing.Point(184, 34);
            this.lblInputAccessMask.Name = "lblInputAccessMask";
            this.lblInputAccessMask.Size = new System.Drawing.Size(74, 13);
            this.lblInputAccessMask.TabIndex = 13;
            this.lblInputAccessMask.Text = "Access Mask:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSend.Image = global::ioctlpus.Properties.Resources.lightning;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(1026, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 78);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "&Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbAccessMask
            // 
            this.tbAccessMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAccessMask.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.tbAccessMask.Location = new System.Drawing.Point(264, 32);
            this.tbAccessMask.MaxLength = 8;
            this.tbAccessMask.Name = "tbAccessMask";
            this.tbAccessMask.Size = new System.Drawing.Size(90, 20);
            this.tbAccessMask.TabIndex = 3;
            this.tbAccessMask.TextChanged += new System.EventHandler(this.tbAccessMask_TextChanged);
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.AutoSize = true;
            this.lblOutputSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOutputSize.Location = new System.Drawing.Point(567, 81);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(91, 13);
            this.lblOutputSize.TabIndex = 10;
            this.lblOutputSize.Text = "Output Size (hex):";
            // 
            // nudOutputSize
            // 
            this.nudOutputSize.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.nudOutputSize.Hexadecimal = true;
            this.nudOutputSize.Location = new System.Drawing.Point(664, 80);
            this.nudOutputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudOutputSize.Name = "nudOutputSize";
            this.nudOutputSize.Size = new System.Drawing.Size(65, 20);
            this.nudOutputSize.TabIndex = 5;
            this.nudOutputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudOutputSize.ValueChanged += new System.EventHandler(this.nudOutputSize_ValueChanged);
            // 
            // lblRepeat
            // 
            this.lblRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRepeat.Location = new System.Drawing.Point(376, 8);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(45, 13);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "Repeat:";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRepeat.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.nudRepeat.Location = new System.Drawing.Point(427, 6);
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(65, 20);
            this.nudRepeat.TabIndex = 7;
            // 
            // lblInputSize
            // 
            this.lblInputSize.AutoSize = true;
            this.lblInputSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInputSize.Location = new System.Drawing.Point(3, 81);
            this.lblInputSize.Name = "lblInputSize";
            this.lblInputSize.Size = new System.Drawing.Size(83, 13);
            this.lblInputSize.TabIndex = 6;
            this.lblInputSize.Text = "Input Size (hex):";
            // 
            // lblIOCTLCode
            // 
            this.lblIOCTLCode.AutoSize = true;
            this.lblIOCTLCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIOCTLCode.Location = new System.Drawing.Point(18, 34);
            this.lblIOCTLCode.Name = "lblIOCTLCode";
            this.lblIOCTLCode.Size = new System.Drawing.Size(69, 13);
            this.lblIOCTLCode.TabIndex = 5;
            this.lblIOCTLCode.Text = "IOCTL Code:";
            // 
            // tbIOCTL
            // 
            this.tbIOCTL.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.tbIOCTL.Location = new System.Drawing.Point(88, 32);
            this.tbIOCTL.Name = "tbIOCTL";
            this.tbIOCTL.Size = new System.Drawing.Size(90, 20);
            this.tbIOCTL.TabIndex = 2;
            this.tbIOCTL.TextChanged += new System.EventHandler(this.tbIOCTL_TextChanged);
            // 
            // tbDevicePath
            // 
            this.tbDevicePath.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.tbDevicePath.Location = new System.Drawing.Point(88, 6);
            this.tbDevicePath.Name = "tbDevicePath";
            this.tbDevicePath.Size = new System.Drawing.Size(266, 20);
            this.tbDevicePath.TabIndex = 1;
            this.tbDevicePath.TextChanged += new System.EventHandler(this.tbDevicePath_TextChanged);
            // 
            // lblDevPath
            // 
            this.lblDevPath.AutoSize = true;
            this.lblDevPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDevPath.Location = new System.Drawing.Point(18, 8);
            this.lblDevPath.Name = "lblDevPath";
            this.lblDevPath.Size = new System.Drawing.Size(70, 13);
            this.lblDevPath.TabIndex = 2;
            this.lblDevPath.Text = "Path / GUID:";
            // 
            // nudInputSize
            // 
            this.nudInputSize.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.nudInputSize.Hexadecimal = true;
            this.nudInputSize.Location = new System.Drawing.Point(88, 80);
            this.nudInputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudInputSize.Name = "nudInputSize";
            this.nudInputSize.Size = new System.Drawing.Size(57, 20);
            this.nudInputSize.TabIndex = 4;
            this.nudInputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudInputSize.ValueChanged += new System.EventHandler(this.nudInputSize_ValueChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Controls.Add(this.gbRequestHistory, 0, 2);
            this.tlpMain.Controls.Add(this.tlpPanes, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1135, 614);
            this.tlpMain.TabIndex = 0;
            // 
            // gbRequestHistory
            // 
            this.gbRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRequestHistory.Controls.Add(this.btnSaveDB);
            this.gbRequestHistory.Controls.Add(this.tbFilters);
            this.gbRequestHistory.Controls.Add(this.btnStarRequest);
            this.gbRequestHistory.Controls.Add(this.btnSettings);
            this.gbRequestHistory.Controls.Add(this.btnDeleteRequest);
            this.gbRequestHistory.Controls.Add(this.btnAbout);
            this.gbRequestHistory.Controls.Add(this.btnOpenDB);
            this.gbRequestHistory.Controls.Add(this.tlvRequestHistory);
            this.gbRequestHistory.Location = new System.Drawing.Point(3, 328);
            this.gbRequestHistory.Name = "gbRequestHistory";
            this.gbRequestHistory.Size = new System.Drawing.Size(1129, 283);
            this.gbRequestHistory.TabIndex = 3;
            this.gbRequestHistory.TabStop = false;
            this.gbRequestHistory.Text = "Request History";
            // 
            // tlvRequestHistory
            // 
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRequest);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRetVal);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnBytesReturned);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnTime);
            this.tlvRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvRequestHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRequest,
            this.olvColumnRetVal,
            this.olvColumnBytesReturned,
            this.olvColumnTime});
            this.tlvRequestHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlvRequestHistory.HideSelection = false;
            this.tlvRequestHistory.Location = new System.Drawing.Point(6, 19);
            this.tlvRequestHistory.Name = "tlvRequestHistory";
            this.tlvRequestHistory.OwnerDraw = true;
            this.tlvRequestHistory.ShowGroups = false;
            this.tlvRequestHistory.Size = new System.Drawing.Size(1079, 219);
            this.tlvRequestHistory.TabIndex = 10;
            this.tlvRequestHistory.UseCompatibleStateImageBehavior = false;
            this.tlvRequestHistory.View = System.Windows.Forms.View.Details;
            this.tlvRequestHistory.VirtualMode = true;
            // 
            // olvColumnRequest
            // 
            this.olvColumnRequest.AspectName = "RequestName";
            this.olvColumnRequest.CellPadding = null;
            this.olvColumnRequest.MinimumWidth = 230;
            this.olvColumnRequest.Text = "Request";
            this.olvColumnRequest.Width = 315;
            // 
            // olvColumnRetVal
            // 
            this.olvColumnRetVal.AspectName = "ReturnValueString";
            this.olvColumnRetVal.CellPadding = null;
            this.olvColumnRetVal.IsEditable = false;
            this.olvColumnRetVal.MinimumWidth = 260;
            this.olvColumnRetVal.Text = "Return Value";
            this.olvColumnRetVal.Width = 388;
            // 
            // olvColumnBytesReturned
            // 
            this.olvColumnBytesReturned.AspectName = "BytesReturned";
            this.olvColumnBytesReturned.CellPadding = null;
            this.olvColumnBytesReturned.IsEditable = false;
            this.olvColumnBytesReturned.MinimumWidth = 90;
            this.olvColumnBytesReturned.Text = "Bytes Returned";
            this.olvColumnBytesReturned.Width = 103;
            // 
            // olvColumnTime
            // 
            this.olvColumnTime.AspectName = "Timestamp";
            this.olvColumnTime.CellPadding = null;
            this.olvColumnTime.FillsFreeSpace = true;
            this.olvColumnTime.IsEditable = false;
            this.olvColumnTime.Text = "Time";
            this.olvColumnTime.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1159, 638);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 677);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "IOCTLpus";
            this.tlpPanes.ResumeLayout(false);
            this.gbRightPane.ResumeLayout(false);
            this.gbLeftPane.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.pnlReqParams.ResumeLayout(false);
            this.pnlReqParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.gbRequestHistory.ResumeLayout(false);
            this.gbRequestHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tlpPanes;
        private System.Windows.Forms.GroupBox gbRightPane;
        private System.Windows.Forms.GroupBox gbLeftPane;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Panel pnlReqParams;
        private System.Windows.Forms.Label lblInputAccessMask;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbAccessMask;
        private System.Windows.Forms.Label lblOutputSize;
        private System.Windows.Forms.NumericUpDown nudOutputSize;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Label lblInputSize;
        private System.Windows.Forms.Label lblIOCTLCode;
        private System.Windows.Forms.TextBox tbIOCTL;
        private System.Windows.Forms.TextBox tbDevicePath;
        private System.Windows.Forms.Label lblDevPath;
        private System.Windows.Forms.NumericUpDown nudInputSize;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbRequestHistory;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.TextBox tbFilters;
        private System.Windows.Forms.Button btnStarRequest;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOpenDB;
        private BrightIdeasSoftware.TreeListView tlvRequestHistory;
        private BrightIdeasSoftware.OLVColumn olvColumnRequest;
        private BrightIdeasSoftware.OLVColumn olvColumnRetVal;
        private BrightIdeasSoftware.OLVColumn olvColumnBytesReturned;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        public Be.Windows.Forms.HexBox hbOutput;
        public Be.Windows.Forms.HexBox hbInput;
    }
}

