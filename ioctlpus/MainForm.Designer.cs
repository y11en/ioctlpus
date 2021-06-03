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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReqParams = new System.Windows.Forms.Panel();
            this.lblInputAccessMask = new System.Windows.Forms.Label();
            this.tbAccessMask = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlPanes = new System.Windows.Forms.Panel();
            this.pnlLeftPanePrePost = new System.Windows.Forms.Panel();
            this.InPostCall = new System.Windows.Forms.RadioButton();
            this.InPanePreCall = new System.Windows.Forms.RadioButton();
            this.pnlRightPanePrePost = new System.Windows.Forms.Panel();
            this.OutPanePostCall = new System.Windows.Forms.RadioButton();
            this.OutPanePreCall = new System.Windows.Forms.RadioButton();
            this.pnlLeftPaneView = new System.Windows.Forms.Panel();
            this.InPaneStringsView = new System.Windows.Forms.CheckBox();
            this.InPaneStructEdit = new System.Windows.Forms.CheckBox();
            this.InPaneStructView = new System.Windows.Forms.CheckBox();
            this.InPaneHexView = new System.Windows.Forms.CheckBox();
            this.pnlRightPaneView = new System.Windows.Forms.Panel();
            this.OutPaneStringsView = new System.Windows.Forms.CheckBox();
            this.OutPaneStuctEdit = new System.Windows.Forms.CheckBox();
            this.OutPaneStructView = new System.Windows.Forms.CheckBox();
            this.OutPaneHexView = new System.Windows.Forms.CheckBox();
            this.lblRightPane = new System.Windows.Forms.Label();
            this.lblLeftPane = new System.Windows.Forms.Label();
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
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRequestHistory = new System.Windows.Forms.GroupBox();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.tbFilters = new System.Windows.Forms.TextBox();
            this.btnStarRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.tlvRequestHistory = new BrightIdeasSoftware.TreeListView();
            this.olvColumnRequest = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRetVal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBytesReturned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tlpPanes = new System.Windows.Forms.TableLayoutPanel();
            this.gbRightPane = new System.Windows.Forms.GroupBox();
            this.hbOutput = new Be.Windows.Forms.HexBox();
            this.gbLeftPane = new System.Windows.Forms.GroupBox();
            this.hbInput = new Be.Windows.Forms.HexBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnlReqParams.SuspendLayout();
            this.pnlPanes.SuspendLayout();
            this.pnlLeftPanePrePost.SuspendLayout();
            this.pnlRightPanePrePost.SuspendLayout();
            this.pnlLeftPaneView.SuspendLayout();
            this.pnlRightPaneView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).BeginInit();
            this.gbRequestHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).BeginInit();
            this.tlpPanes.SuspendLayout();
            this.gbRightPane.SuspendLayout();
            this.gbLeftPane.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpMain.Size = new System.Drawing.Size(780, 615);
            this.tlpMain.TabIndex = 0;
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
            this.tlpTop.Size = new System.Drawing.Size(774, 109);
            this.tlpTop.TabIndex = 2;
            // 
            // pnlReqParams
            // 
            this.pnlReqParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReqParams.Controls.Add(this.lblInputAccessMask);
            this.pnlReqParams.Controls.Add(this.tbAccessMask);
            this.pnlReqParams.Controls.Add(this.btnSettings);
            this.pnlReqParams.Controls.Add(this.btnAbout);
            this.pnlReqParams.Controls.Add(this.pnlPanes);
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
            this.pnlReqParams.Controls.Add(this.btnSend);
            this.pnlReqParams.Location = new System.Drawing.Point(3, 3);
            this.pnlReqParams.Name = "pnlReqParams";
            this.pnlReqParams.Size = new System.Drawing.Size(768, 103);
            this.pnlReqParams.TabIndex = 0;
            // 
            // lblInputAccessMask
            // 
            this.lblInputAccessMask.AutoSize = true;
            this.lblInputAccessMask.Location = new System.Drawing.Point(106, 76);
            this.lblInputAccessMask.Name = "lblInputAccessMask";
            this.lblInputAccessMask.Size = new System.Drawing.Size(74, 13);
            this.lblInputAccessMask.TabIndex = 13;
            this.lblInputAccessMask.Text = "Access Mask:";
            // 
            // tbAccessMask
            // 
            this.tbAccessMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAccessMask.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccessMask.Location = new System.Drawing.Point(181, 74);
            this.tbAccessMask.MaxLength = 8;
            this.tbAccessMask.Name = "tbAccessMask";
            this.tbAccessMask.Size = new System.Drawing.Size(90, 20);
            this.tbAccessMask.TabIndex = 12;
            this.tbAccessMask.TextChanged += new System.EventHandler(this.tbAccessMask_TextChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Enabled = false;
            this.btnSettings.Image = global::ioctlpus.Properties.Resources.cog;
            this.btnSettings.Location = new System.Drawing.Point(730, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSettings, "Options");
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::ioctlpus.Properties.Resources.help;
            this.btnAbout.Location = new System.Drawing.Point(730, 46);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(32, 32);
            this.btnAbout.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlPanes
            // 
            this.pnlPanes.Controls.Add(this.pnlLeftPanePrePost);
            this.pnlPanes.Controls.Add(this.pnlRightPanePrePost);
            this.pnlPanes.Controls.Add(this.pnlLeftPaneView);
            this.pnlPanes.Controls.Add(this.pnlRightPaneView);
            this.pnlPanes.Controls.Add(this.lblRightPane);
            this.pnlPanes.Controls.Add(this.lblLeftPane);
            this.pnlPanes.Location = new System.Drawing.Point(452, 3);
            this.pnlPanes.Name = "pnlPanes";
            this.pnlPanes.Size = new System.Drawing.Size(275, 78);
            this.pnlPanes.TabIndex = 11;
            // 
            // pnlLeftPanePrePost
            // 
            this.pnlLeftPanePrePost.Controls.Add(this.InPostCall);
            this.pnlLeftPanePrePost.Controls.Add(this.InPanePreCall);
            this.pnlLeftPanePrePost.Location = new System.Drawing.Point(73, 4);
            this.pnlLeftPanePrePost.Name = "pnlLeftPanePrePost";
            this.pnlLeftPanePrePost.Size = new System.Drawing.Size(63, 32);
            this.pnlLeftPanePrePost.TabIndex = 27;
            // 
            // InPostCall
            // 
            this.InPostCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPostCall.Enabled = false;
            this.InPostCall.Image = global::ioctlpus.Properties.Resources.control_end_blue;
            this.InPostCall.Location = new System.Drawing.Point(31, 0);
            this.InPostCall.Name = "InPostCall";
            this.InPostCall.Size = new System.Drawing.Size(32, 32);
            this.InPostCall.TabIndex = 1;
            this.toolTip.SetToolTip(this.InPostCall, "Post-Call");
            this.InPostCall.UseVisualStyleBackColor = true;
            // 
            // InPanePreCall
            // 
            this.InPanePreCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPanePreCall.Checked = true;
            this.InPanePreCall.Image = global::ioctlpus.Properties.Resources.control_start_blue;
            this.InPanePreCall.Location = new System.Drawing.Point(0, 0);
            this.InPanePreCall.Name = "InPanePreCall";
            this.InPanePreCall.Size = new System.Drawing.Size(32, 32);
            this.InPanePreCall.TabIndex = 0;
            this.InPanePreCall.TabStop = true;
            this.toolTip.SetToolTip(this.InPanePreCall, "Pre-Call");
            this.InPanePreCall.UseVisualStyleBackColor = true;
            // 
            // pnlRightPanePrePost
            // 
            this.pnlRightPanePrePost.Controls.Add(this.OutPanePostCall);
            this.pnlRightPanePrePost.Controls.Add(this.OutPanePreCall);
            this.pnlRightPanePrePost.Location = new System.Drawing.Point(73, 42);
            this.pnlRightPanePrePost.Name = "pnlRightPanePrePost";
            this.pnlRightPanePrePost.Size = new System.Drawing.Size(63, 32);
            this.pnlRightPanePrePost.TabIndex = 26;
            // 
            // OutPanePostCall
            // 
            this.OutPanePostCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPanePostCall.Checked = true;
            this.OutPanePostCall.Image = global::ioctlpus.Properties.Resources.control_end_blue;
            this.OutPanePostCall.Location = new System.Drawing.Point(31, 0);
            this.OutPanePostCall.Name = "OutPanePostCall";
            this.OutPanePostCall.Size = new System.Drawing.Size(32, 32);
            this.OutPanePostCall.TabIndex = 1;
            this.OutPanePostCall.TabStop = true;
            this.toolTip.SetToolTip(this.OutPanePostCall, "Post-Call");
            this.OutPanePostCall.UseVisualStyleBackColor = true;
            // 
            // OutPanePreCall
            // 
            this.OutPanePreCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPanePreCall.Enabled = false;
            this.OutPanePreCall.Image = global::ioctlpus.Properties.Resources.control_start_blue;
            this.OutPanePreCall.Location = new System.Drawing.Point(0, 0);
            this.OutPanePreCall.Name = "OutPanePreCall";
            this.OutPanePreCall.Size = new System.Drawing.Size(32, 32);
            this.OutPanePreCall.TabIndex = 0;
            this.toolTip.SetToolTip(this.OutPanePreCall, "Pre-Call");
            this.OutPanePreCall.UseVisualStyleBackColor = true;
            // 
            // pnlLeftPaneView
            // 
            this.pnlLeftPaneView.Controls.Add(this.InPaneStringsView);
            this.pnlLeftPaneView.Controls.Add(this.InPaneStructEdit);
            this.pnlLeftPaneView.Controls.Add(this.InPaneStructView);
            this.pnlLeftPaneView.Controls.Add(this.InPaneHexView);
            this.pnlLeftPaneView.Location = new System.Drawing.Point(142, 4);
            this.pnlLeftPaneView.Name = "pnlLeftPaneView";
            this.pnlLeftPaneView.Size = new System.Drawing.Size(125, 32);
            this.pnlLeftPaneView.TabIndex = 25;
            // 
            // InPaneStringsView
            // 
            this.InPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneStringsView.Checked = true;
            this.InPaneStringsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_view_list;
            this.InPaneStringsView.Location = new System.Drawing.Point(31, 0);
            this.InPaneStringsView.Name = "InPaneStringsView";
            this.InPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.InPaneStringsView.TabIndex = 2;
            this.toolTip.SetToolTip(this.InPaneStringsView, "Strings View");
            this.InPaneStringsView.UseVisualStyleBackColor = true;
            this.InPaneStringsView.CheckedChanged += new System.EventHandler(this.InPaneStringsView_CheckedChanged);
            // 
            // InPaneStructEdit
            // 
            this.InPaneStructEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneStructEdit.Enabled = false;
            this.InPaneStructEdit.Image = global::ioctlpus.Properties.Resources.application_edit;
            this.InPaneStructEdit.Location = new System.Drawing.Point(93, 0);
            this.InPaneStructEdit.Name = "InPaneStructEdit";
            this.InPaneStructEdit.Size = new System.Drawing.Size(32, 32);
            this.InPaneStructEdit.TabIndex = 0;
            this.toolTip.SetToolTip(this.InPaneStructEdit, "Struct Editor");
            this.InPaneStructEdit.UseVisualStyleBackColor = true;
            // 
            // InPaneStructView
            // 
            this.InPaneStructView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneStructView.Enabled = false;
            this.InPaneStructView.Image = global::ioctlpus.Properties.Resources.application_side_tree;
            this.InPaneStructView.Location = new System.Drawing.Point(62, 0);
            this.InPaneStructView.Name = "InPaneStructView";
            this.InPaneStructView.Size = new System.Drawing.Size(32, 32);
            this.InPaneStructView.TabIndex = 3;
            this.toolTip.SetToolTip(this.InPaneStructView, "Struct View");
            this.InPaneStructView.UseVisualStyleBackColor = true;
            // 
            // InPaneHexView
            // 
            this.InPaneHexView.AccessibleDescription = "test";
            this.InPaneHexView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneHexView.Checked = true;
            this.InPaneHexView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InPaneHexView.Image = global::ioctlpus.Properties.Resources.application_view_columns;
            this.InPaneHexView.Location = new System.Drawing.Point(0, 0);
            this.InPaneHexView.Name = "InPaneHexView";
            this.InPaneHexView.Size = new System.Drawing.Size(32, 32);
            this.InPaneHexView.TabIndex = 1;
            this.toolTip.SetToolTip(this.InPaneHexView, "Hex View");
            this.InPaneHexView.UseVisualStyleBackColor = true;
            this.InPaneHexView.CheckedChanged += new System.EventHandler(this.InPaneHexView_CheckedChanged);
            // 
            // pnlRightPaneView
            // 
            this.pnlRightPaneView.Controls.Add(this.OutPaneStringsView);
            this.pnlRightPaneView.Controls.Add(this.OutPaneStuctEdit);
            this.pnlRightPaneView.Controls.Add(this.OutPaneStructView);
            this.pnlRightPaneView.Controls.Add(this.OutPaneHexView);
            this.pnlRightPaneView.Location = new System.Drawing.Point(142, 42);
            this.pnlRightPaneView.Name = "pnlRightPaneView";
            this.pnlRightPaneView.Size = new System.Drawing.Size(125, 32);
            this.pnlRightPaneView.TabIndex = 24;
            // 
            // OutPaneStringsView
            // 
            this.OutPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneStringsView.Checked = true;
            this.OutPaneStringsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_view_list;
            this.OutPaneStringsView.Location = new System.Drawing.Point(31, 0);
            this.OutPaneStringsView.Name = "OutPaneStringsView";
            this.OutPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneStringsView.TabIndex = 1;
            this.toolTip.SetToolTip(this.OutPaneStringsView, "Strings View");
            this.OutPaneStringsView.UseVisualStyleBackColor = true;
            this.OutPaneStringsView.CheckedChanged += new System.EventHandler(this.OutPaneStringsView_CheckedChanged);
            // 
            // OutPaneStuctEdit
            // 
            this.OutPaneStuctEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneStuctEdit.Enabled = false;
            this.OutPaneStuctEdit.Image = global::ioctlpus.Properties.Resources.application_edit;
            this.OutPaneStuctEdit.Location = new System.Drawing.Point(93, 0);
            this.OutPaneStuctEdit.Name = "OutPaneStuctEdit";
            this.OutPaneStuctEdit.Size = new System.Drawing.Size(32, 32);
            this.OutPaneStuctEdit.TabIndex = 3;
            this.toolTip.SetToolTip(this.OutPaneStuctEdit, "Struct Editor");
            this.OutPaneStuctEdit.UseVisualStyleBackColor = true;
            // 
            // OutPaneStructView
            // 
            this.OutPaneStructView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneStructView.Enabled = false;
            this.OutPaneStructView.Image = global::ioctlpus.Properties.Resources.application_side_tree;
            this.OutPaneStructView.Location = new System.Drawing.Point(62, 0);
            this.OutPaneStructView.Name = "OutPaneStructView";
            this.OutPaneStructView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneStructView.TabIndex = 2;
            this.toolTip.SetToolTip(this.OutPaneStructView, "Struct View");
            this.OutPaneStructView.UseVisualStyleBackColor = true;
            // 
            // OutPaneHexView
            // 
            this.OutPaneHexView.AccessibleDescription = "";
            this.OutPaneHexView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneHexView.Checked = true;
            this.OutPaneHexView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutPaneHexView.Image = global::ioctlpus.Properties.Resources.application_view_columns;
            this.OutPaneHexView.Location = new System.Drawing.Point(0, 0);
            this.OutPaneHexView.Name = "OutPaneHexView";
            this.OutPaneHexView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneHexView.TabIndex = 0;
            this.toolTip.SetToolTip(this.OutPaneHexView, "Hex View");
            this.OutPaneHexView.UseVisualStyleBackColor = true;
            this.OutPaneHexView.CheckedChanged += new System.EventHandler(this.OutPaneHexView_CheckedChanged);
            // 
            // lblRightPane
            // 
            this.lblRightPane.AutoSize = true;
            this.lblRightPane.Location = new System.Drawing.Point(5, 51);
            this.lblRightPane.Name = "lblRightPane";
            this.lblRightPane.Size = new System.Drawing.Size(70, 13);
            this.lblRightPane.TabIndex = 12;
            this.lblRightPane.Text = "Output Pane:";
            this.lblRightPane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeftPane
            // 
            this.lblLeftPane.AutoSize = true;
            this.lblLeftPane.Location = new System.Drawing.Point(5, 14);
            this.lblLeftPane.Name = "lblLeftPane";
            this.lblLeftPane.Size = new System.Drawing.Size(62, 13);
            this.lblLeftPane.TabIndex = 7;
            this.lblLeftPane.Text = "Input Pane:";
            this.lblLeftPane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.AutoSize = true;
            this.lblOutputSize.Location = new System.Drawing.Point(244, 53);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(65, 13);
            this.lblOutputSize.TabIndex = 10;
            this.lblOutputSize.Text = "Output Size:";
            // 
            // nudOutputSize
            // 
            this.nudOutputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOutputSize.Hexadecimal = true;
            this.nudOutputSize.Location = new System.Drawing.Point(315, 52);
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
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(279, 30);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(45, 13);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "Repeat:";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRepeat.Location = new System.Drawing.Point(330, 28);
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(50, 20);
            this.nudRepeat.TabIndex = 3;
            // 
            // lblInputSize
            // 
            this.lblInputSize.AutoSize = true;
            this.lblInputSize.Location = new System.Drawing.Point(97, 52);
            this.lblInputSize.Name = "lblInputSize";
            this.lblInputSize.Size = new System.Drawing.Size(83, 13);
            this.lblInputSize.TabIndex = 6;
            this.lblInputSize.Text = "(hex) Input Size:";
            // 
            // lblIOCTLCode
            // 
            this.lblIOCTLCode.AutoSize = true;
            this.lblIOCTLCode.Location = new System.Drawing.Point(111, 30);
            this.lblIOCTLCode.Name = "lblIOCTLCode";
            this.lblIOCTLCode.Size = new System.Drawing.Size(69, 13);
            this.lblIOCTLCode.TabIndex = 5;
            this.lblIOCTLCode.Text = "IOCTL Code:";
            // 
            // tbIOCTL
            // 
            this.tbIOCTL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIOCTL.Location = new System.Drawing.Point(181, 27);
            this.tbIOCTL.Name = "tbIOCTL";
            this.tbIOCTL.Size = new System.Drawing.Size(90, 20);
            this.tbIOCTL.TabIndex = 2;
            this.tbIOCTL.TextChanged += new System.EventHandler(this.tbIOCTL_TextChanged);
            // 
            // tbDevicePath
            // 
            this.tbDevicePath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDevicePath.Location = new System.Drawing.Point(181, 4);
            this.tbDevicePath.Name = "tbDevicePath";
            this.tbDevicePath.Size = new System.Drawing.Size(199, 20);
            this.tbDevicePath.TabIndex = 1;
            this.tbDevicePath.TextChanged += new System.EventHandler(this.tbDevicePath_TextChanged);
            // 
            // lblDevPath
            // 
            this.lblDevPath.AutoSize = true;
            this.lblDevPath.Location = new System.Drawing.Point(110, 7);
            this.lblDevPath.Name = "lblDevPath";
            this.lblDevPath.Size = new System.Drawing.Size(70, 13);
            this.lblDevPath.TabIndex = 2;
            this.lblDevPath.Text = "Path / GUID:";
            // 
            // nudInputSize
            // 
            this.nudInputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputSize.Hexadecimal = true;
            this.nudInputSize.Location = new System.Drawing.Point(181, 51);
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
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = global::ioctlpus.Properties.Resources.lightning;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 78);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbRequestHistory
            // 
            this.gbRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRequestHistory.Controls.Add(this.btnSaveDB);
            this.gbRequestHistory.Controls.Add(this.tbFilters);
            this.gbRequestHistory.Controls.Add(this.btnStarRequest);
            this.gbRequestHistory.Controls.Add(this.btnDeleteRequest);
            this.gbRequestHistory.Controls.Add(this.btnOpenDB);
            this.gbRequestHistory.Controls.Add(this.tlvRequestHistory);
            this.gbRequestHistory.Location = new System.Drawing.Point(3, 328);
            this.gbRequestHistory.Name = "gbRequestHistory";
            this.gbRequestHistory.Size = new System.Drawing.Size(774, 284);
            this.gbRequestHistory.TabIndex = 3;
            this.gbRequestHistory.TabStop = false;
            this.gbRequestHistory.Text = "Request History";
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDB.Enabled = false;
            this.btnSaveDB.Image = global::ioctlpus.Properties.Resources.database_save;
            this.btnSaveDB.Location = new System.Drawing.Point(736, 57);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(32, 32);
            this.btnSaveDB.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSaveDB, "Save Database");
            this.btnSaveDB.UseVisualStyleBackColor = true;
            // 
            // tbFilters
            // 
            this.tbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilters.Enabled = false;
            this.tbFilters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilters.Location = new System.Drawing.Point(6, 255);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Size = new System.Drawing.Size(724, 20);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.TextChanged += new System.EventHandler(this.tbFilters_TextChanged);
            // 
            // btnStarRequest
            // 
            this.btnStarRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRequest.Image = global::ioctlpus.Properties.Resources.star;
            this.btnStarRequest.Location = new System.Drawing.Point(736, 95);
            this.btnStarRequest.Name = "btnStarRequest";
            this.btnStarRequest.Size = new System.Drawing.Size(32, 32);
            this.btnStarRequest.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnStarRequest, "Star Request");
            this.btnStarRequest.UseVisualStyleBackColor = true;
            this.btnStarRequest.Click += new System.EventHandler(this.btnStarRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRequest.Enabled = false;
            this.btnDeleteRequest.Image = global::ioctlpus.Properties.Resources.delete;
            this.btnDeleteRequest.Location = new System.Drawing.Point(736, 133);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteRequest.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnDeleteRequest, "Remove Request");
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDB.Enabled = false;
            this.btnOpenDB.Image = global::ioctlpus.Properties.Resources.database_add;
            this.btnOpenDB.Location = new System.Drawing.Point(736, 19);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(32, 32);
            this.btnOpenDB.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnOpenDB, "Load Database");
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
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
            this.tlvRequestHistory.Size = new System.Drawing.Size(724, 230);
            this.tlvRequestHistory.TabIndex = 0;
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
            this.olvColumnRequest.Width = 230;
            // 
            // olvColumnRetVal
            // 
            this.olvColumnRetVal.AspectName = "ReturnValueString";
            this.olvColumnRetVal.CellPadding = null;
            this.olvColumnRetVal.IsEditable = false;
            this.olvColumnRetVal.MinimumWidth = 260;
            this.olvColumnRetVal.Text = "Return Value";
            this.olvColumnRetVal.Width = 260;
            // 
            // olvColumnBytesReturned
            // 
            this.olvColumnBytesReturned.AspectName = "BytesReturned";
            this.olvColumnBytesReturned.CellPadding = null;
            this.olvColumnBytesReturned.IsEditable = false;
            this.olvColumnBytesReturned.MinimumWidth = 90;
            this.olvColumnBytesReturned.Text = "Bytes Returned";
            this.olvColumnBytesReturned.Width = 90;
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
            this.tlpPanes.Size = new System.Drawing.Size(774, 204);
            this.tlpPanes.TabIndex = 0;
            // 
            // gbRightPane
            // 
            this.gbRightPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRightPane.Controls.Add(this.hbOutput);
            this.gbRightPane.Location = new System.Drawing.Point(390, 3);
            this.gbRightPane.Name = "gbRightPane";
            this.gbRightPane.Size = new System.Drawing.Size(381, 198);
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
            this.hbOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbOutput.GroupSeparatorVisible = true;
            this.hbOutput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbOutput.LineInfoVisible = true;
            this.hbOutput.Location = new System.Drawing.Point(6, 19);
            this.hbOutput.Name = "hbOutput";
            this.hbOutput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbOutput.Size = new System.Drawing.Size(369, 173);
            this.hbOutput.StringViewVisible = true;
            this.hbOutput.TabIndex = 0;
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
            this.gbLeftPane.Size = new System.Drawing.Size(381, 198);
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
            this.hbInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbInput.GroupSeparatorVisible = true;
            this.hbInput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbInput.LineInfoVisible = true;
            this.hbInput.Location = new System.Drawing.Point(6, 19);
            this.hbInput.Name = "hbInput";
            this.hbInput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbInput.Size = new System.Drawing.Size(369, 173);
            this.hbInput.StringViewVisible = true;
            this.hbInput.TabIndex = 0;
            this.hbInput.UseFixedBytesPerLine = true;
            this.hbInput.VScrollBarVisible = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 639);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "IOCTLpus";
            this.tlpMain.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.pnlReqParams.ResumeLayout(false);
            this.pnlReqParams.PerformLayout();
            this.pnlPanes.ResumeLayout(false);
            this.pnlPanes.PerformLayout();
            this.pnlLeftPanePrePost.ResumeLayout(false);
            this.pnlRightPanePrePost.ResumeLayout(false);
            this.pnlLeftPaneView.ResumeLayout(false);
            this.pnlRightPaneView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).EndInit();
            this.gbRequestHistory.ResumeLayout(false);
            this.gbRequestHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).EndInit();
            this.tlpPanes.ResumeLayout(false);
            this.gbRightPane.ResumeLayout(false);
            this.gbLeftPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPanes;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private Be.Windows.Forms.HexBox hbInput;
        private Be.Windows.Forms.HexBox hbOutput;
        private System.Windows.Forms.Panel pnlReqParams;
        private System.Windows.Forms.Label lblIOCTLCode;
        private System.Windows.Forms.TextBox tbIOCTL;
        private System.Windows.Forms.TextBox tbDevicePath;
        private System.Windows.Forms.Label lblDevPath;
        private System.Windows.Forms.NumericUpDown nudInputSize;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblInputSize;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Label lblOutputSize;
        private System.Windows.Forms.NumericUpDown nudOutputSize;
        private System.Windows.Forms.GroupBox gbLeftPane;
        private System.Windows.Forms.GroupBox gbRightPane;
        private System.Windows.Forms.GroupBox gbRequestHistory;
        private System.Windows.Forms.Button btnStarRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnOpenDB;
        private BrightIdeasSoftware.TreeListView tlvRequestHistory;
        private BrightIdeasSoftware.OLVColumn olvColumnRequest;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        private BrightIdeasSoftware.OLVColumn olvColumnRetVal;
        private BrightIdeasSoftware.OLVColumn olvColumnBytesReturned;
        private System.Windows.Forms.TextBox tbFilters;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Panel pnlPanes;
        private System.Windows.Forms.Label lblRightPane;
        private System.Windows.Forms.Label lblLeftPane;
        private System.Windows.Forms.Panel pnlRightPaneView;
        private System.Windows.Forms.CheckBox OutPaneStuctEdit;
        private System.Windows.Forms.CheckBox OutPaneStructView;
        private System.Windows.Forms.CheckBox OutPaneHexView;
        private System.Windows.Forms.Panel pnlLeftPaneView;
        private System.Windows.Forms.CheckBox InPaneStructEdit;
        private System.Windows.Forms.CheckBox InPaneStructView;
        private System.Windows.Forms.CheckBox InPaneHexView;
        private System.Windows.Forms.Panel pnlLeftPanePrePost;
        private System.Windows.Forms.RadioButton InPostCall;
        private System.Windows.Forms.RadioButton InPanePreCall;
        private System.Windows.Forms.Panel pnlRightPanePrePost;
        private System.Windows.Forms.RadioButton OutPanePostCall;
        private System.Windows.Forms.RadioButton OutPanePreCall;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox InPaneStringsView;
        private System.Windows.Forms.CheckBox OutPaneStringsView;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblInputAccessMask;
        private System.Windows.Forms.TextBox tbAccessMask;
    }
}

