
namespace ioctlpus
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gbInputOptions = new System.Windows.Forms.GroupBox();
            this.numNumberBytesIn = new System.Windows.Forms.NumericUpDown();
            this.lblNumberBytesIn = new System.Windows.Forms.Label();
            this.InPaneStringsView = new System.Windows.Forms.CheckBox();
            this.InPaneBarView = new System.Windows.Forms.CheckBox();
            this.InPaneSeparatorView = new System.Windows.Forms.CheckBox();
            this.gbOutputOptions = new System.Windows.Forms.GroupBox();
            this.numNumberBytesOut = new System.Windows.Forms.NumericUpDown();
            this.lblNumberBytesOut = new System.Windows.Forms.Label();
            this.OutPaneStringsView = new System.Windows.Forms.CheckBox();
            this.OutPaneBarView = new System.Windows.Forms.CheckBox();
            this.OutPaneSeparatorView = new System.Windows.Forms.CheckBox();
            this.btnImportSettings = new System.Windows.Forms.Button();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbInputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberBytesIn)).BeginInit();
            this.gbOutputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberBytesOut)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInputOptions
            // 
            this.gbInputOptions.Controls.Add(this.numNumberBytesIn);
            this.gbInputOptions.Controls.Add(this.lblNumberBytesIn);
            this.gbInputOptions.Controls.Add(this.InPaneStringsView);
            this.gbInputOptions.Controls.Add(this.InPaneBarView);
            this.gbInputOptions.Controls.Add(this.InPaneSeparatorView);
            this.gbInputOptions.Location = new System.Drawing.Point(12, 12);
            this.gbInputOptions.Name = "gbInputOptions";
            this.gbInputOptions.Size = new System.Drawing.Size(200, 89);
            this.gbInputOptions.TabIndex = 0;
            this.gbInputOptions.TabStop = false;
            this.gbInputOptions.Text = "Input Panel Options";
            // 
            // numNumberBytesIn
            // 
            this.numNumberBytesIn.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesIn.Location = new System.Drawing.Point(85, 56);
            this.numNumberBytesIn.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numNumberBytesIn.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesIn.Name = "numNumberBytesIn";
            this.numNumberBytesIn.Size = new System.Drawing.Size(40, 20);
            this.numNumberBytesIn.TabIndex = 7;
            this.numNumberBytesIn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesIn.ValueChanged += new System.EventHandler(this.numNumberBytesIn_ValueChanged);
            // 
            // lblNumberBytesIn
            // 
            this.lblNumberBytesIn.AutoSize = true;
            this.lblNumberBytesIn.Location = new System.Drawing.Point(6, 58);
            this.lblNumberBytesIn.Name = "lblNumberBytesIn";
            this.lblNumberBytesIn.Size = new System.Drawing.Size(73, 13);
            this.lblNumberBytesIn.TabIndex = 6;
            this.lblNumberBytesIn.Text = "Bytes per line:";
            // 
            // InPaneStringsView
            // 
            this.InPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneStringsView.Checked = true;
            this.InPaneStringsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_string;
            this.InPaneStringsView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InPaneStringsView.Location = new System.Drawing.Point(6, 19);
            this.InPaneStringsView.Name = "InPaneStringsView";
            this.InPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.InPaneStringsView.TabIndex = 1;
            this.toolTip.SetToolTip(this.InPaneStringsView, "Display/hide string");
            this.InPaneStringsView.UseVisualStyleBackColor = true;
            this.InPaneStringsView.CheckedChanged += new System.EventHandler(this.InPaneStringsView_CheckedChanged);
            // 
            // InPaneBarView
            // 
            this.InPaneBarView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneBarView.Checked = true;
            this.InPaneBarView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InPaneBarView.Image = global::ioctlpus.Properties.Resources.application_bars;
            this.InPaneBarView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InPaneBarView.Location = new System.Drawing.Point(68, 19);
            this.InPaneBarView.Name = "InPaneBarView";
            this.InPaneBarView.Size = new System.Drawing.Size(32, 32);
            this.InPaneBarView.TabIndex = 5;
            this.toolTip.SetToolTip(this.InPaneBarView, "Display/hide hex bar");
            this.InPaneBarView.UseVisualStyleBackColor = true;
            this.InPaneBarView.CheckedChanged += new System.EventHandler(this.InPaneBarView_CheckedChanged);
            // 
            // InPaneSeparatorView
            // 
            this.InPaneSeparatorView.Appearance = System.Windows.Forms.Appearance.Button;
            this.InPaneSeparatorView.Checked = true;
            this.InPaneSeparatorView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InPaneSeparatorView.Image = global::ioctlpus.Properties.Resources.application_separator;
            this.InPaneSeparatorView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InPaneSeparatorView.Location = new System.Drawing.Point(37, 19);
            this.InPaneSeparatorView.Name = "InPaneSeparatorView";
            this.InPaneSeparatorView.Size = new System.Drawing.Size(32, 32);
            this.InPaneSeparatorView.TabIndex = 3;
            this.toolTip.SetToolTip(this.InPaneSeparatorView, "Display/hide separator");
            this.InPaneSeparatorView.UseVisualStyleBackColor = true;
            this.InPaneSeparatorView.CheckedChanged += new System.EventHandler(this.InPaneSeparatorView_CheckedChanged);
            // 
            // gbOutputOptions
            // 
            this.gbOutputOptions.Controls.Add(this.numNumberBytesOut);
            this.gbOutputOptions.Controls.Add(this.lblNumberBytesOut);
            this.gbOutputOptions.Controls.Add(this.OutPaneStringsView);
            this.gbOutputOptions.Controls.Add(this.OutPaneBarView);
            this.gbOutputOptions.Controls.Add(this.OutPaneSeparatorView);
            this.gbOutputOptions.Location = new System.Drawing.Point(218, 12);
            this.gbOutputOptions.Name = "gbOutputOptions";
            this.gbOutputOptions.Size = new System.Drawing.Size(200, 89);
            this.gbOutputOptions.TabIndex = 0;
            this.gbOutputOptions.TabStop = false;
            this.gbOutputOptions.Text = "Output Panel Options";
            // 
            // numNumberBytesOut
            // 
            this.numNumberBytesOut.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesOut.Location = new System.Drawing.Point(85, 56);
            this.numNumberBytesOut.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numNumberBytesOut.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesOut.Name = "numNumberBytesOut";
            this.numNumberBytesOut.Size = new System.Drawing.Size(41, 20);
            this.numNumberBytesOut.TabIndex = 8;
            this.numNumberBytesOut.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberBytesOut.ValueChanged += new System.EventHandler(this.numNumberBytesOut_ValueChanged);
            // 
            // lblNumberBytesOut
            // 
            this.lblNumberBytesOut.AutoSize = true;
            this.lblNumberBytesOut.Location = new System.Drawing.Point(6, 58);
            this.lblNumberBytesOut.Name = "lblNumberBytesOut";
            this.lblNumberBytesOut.Size = new System.Drawing.Size(73, 13);
            this.lblNumberBytesOut.TabIndex = 7;
            this.lblNumberBytesOut.Text = "Bytes per line:";
            // 
            // OutPaneStringsView
            // 
            this.OutPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneStringsView.Checked = true;
            this.OutPaneStringsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_string;
            this.OutPaneStringsView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OutPaneStringsView.Location = new System.Drawing.Point(6, 19);
            this.OutPaneStringsView.Name = "OutPaneStringsView";
            this.OutPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneStringsView.TabIndex = 2;
            this.toolTip.SetToolTip(this.OutPaneStringsView, "Display/hide string");
            this.OutPaneStringsView.UseVisualStyleBackColor = true;
            this.OutPaneStringsView.CheckedChanged += new System.EventHandler(this.OutPaneStringsView_CheckedChanged);
            // 
            // OutPaneBarView
            // 
            this.OutPaneBarView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneBarView.Checked = true;
            this.OutPaneBarView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutPaneBarView.Image = global::ioctlpus.Properties.Resources.application_bars;
            this.OutPaneBarView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OutPaneBarView.Location = new System.Drawing.Point(68, 19);
            this.OutPaneBarView.Name = "OutPaneBarView";
            this.OutPaneBarView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneBarView.TabIndex = 6;
            this.toolTip.SetToolTip(this.OutPaneBarView, "Display/hide hex bar");
            this.OutPaneBarView.UseVisualStyleBackColor = true;
            this.OutPaneBarView.CheckedChanged += new System.EventHandler(this.OutPaneBarView_CheckedChanged);
            // 
            // OutPaneSeparatorView
            // 
            this.OutPaneSeparatorView.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutPaneSeparatorView.Checked = true;
            this.OutPaneSeparatorView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutPaneSeparatorView.Image = global::ioctlpus.Properties.Resources.application_separator;
            this.OutPaneSeparatorView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OutPaneSeparatorView.Location = new System.Drawing.Point(37, 19);
            this.OutPaneSeparatorView.Name = "OutPaneSeparatorView";
            this.OutPaneSeparatorView.Size = new System.Drawing.Size(32, 32);
            this.OutPaneSeparatorView.TabIndex = 4;
            this.toolTip.SetToolTip(this.OutPaneSeparatorView, "Display/hide separator");
            this.OutPaneSeparatorView.UseVisualStyleBackColor = true;
            this.OutPaneSeparatorView.CheckedChanged += new System.EventHandler(this.OutPaneSeparatorView_CheckedChanged);
            // 
            // btnImportSettings
            // 
            this.btnImportSettings.Enabled = false;
            this.btnImportSettings.Image = global::ioctlpus.Properties.Resources.door_in;
            this.btnImportSettings.Location = new System.Drawing.Point(12, 107);
            this.btnImportSettings.Name = "btnImportSettings";
            this.btnImportSettings.Size = new System.Drawing.Size(32, 32);
            this.btnImportSettings.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnImportSettings, "Import settings");
            this.btnImportSettings.UseVisualStyleBackColor = true;
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Enabled = false;
            this.btnExportSettings.Image = global::ioctlpus.Properties.Resources.door_out;
            this.btnExportSettings.Location = new System.Drawing.Point(49, 107);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(32, 32);
            this.btnExportSettings.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnExportSettings, "Export settings");
            this.btnExportSettings.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 147);
            this.Controls.Add(this.btnExportSettings);
            this.Controls.Add(this.btnImportSettings);
            this.Controls.Add(this.gbOutputOptions);
            this.Controls.Add(this.gbInputOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 186);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IOCTLpus - Settings";
            this.gbInputOptions.ResumeLayout(false);
            this.gbInputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberBytesIn)).EndInit();
            this.gbOutputOptions.ResumeLayout(false);
            this.gbOutputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberBytesOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInputOptions;
        private System.Windows.Forms.GroupBox gbOutputOptions;
        private System.Windows.Forms.CheckBox InPaneBarView;
        private System.Windows.Forms.CheckBox InPaneSeparatorView;
        private System.Windows.Forms.CheckBox OutPaneStringsView;
        private System.Windows.Forms.CheckBox OutPaneBarView;
        private System.Windows.Forms.CheckBox OutPaneSeparatorView;
        private System.Windows.Forms.Button btnImportSettings;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblNumberBytesIn;
        private System.Windows.Forms.CheckBox InPaneStringsView;
        private System.Windows.Forms.Label lblNumberBytesOut;
        public System.Windows.Forms.NumericUpDown numNumberBytesIn;
        public System.Windows.Forms.NumericUpDown numNumberBytesOut;
    }
}