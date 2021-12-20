using System;
using System.Windows.Forms;

namespace ioctlpus
{
    public partial class SettingsForm : Form
    {
        public MainForm _parent;
        public SettingsForm(MainForm parent)
        {
            InitializeComponent();
            this._parent = parent;
            // Set values and check buttons based on the status of hbInput/hbOutput
            // StringViewVisible
            if (this._parent.hbInput.StringViewVisible == true)
            {
                InPaneStringsView.Checked = true;
            }
            else
            {
                InPaneStringsView.Checked = false;
            }
            if (this._parent.hbOutput.StringViewVisible == true)
            {
                OutPaneStringsView.Checked = true;
            }
            else
            {
                OutPaneStringsView.Checked = false;
            }
            // GroupSeparatorVisible
            if (this._parent.hbInput.GroupSeparatorVisible == true)
            {
                InPaneSeparatorView.Checked = true;
            }
            else
            {
                InPaneSeparatorView.Checked = false;
            }
            if (this._parent.hbOutput.GroupSeparatorVisible == true)
            {
                OutPaneSeparatorView.Checked = true;
            }
            else
            {
                OutPaneSeparatorView.Checked = false;
            }
            // ColumnInfoVisible
            if (this._parent.hbInput.ColumnInfoVisible == true)
            {
                InPaneBarView.Checked = true;
            }
            else
            {
                InPaneBarView.Checked = false;
            }
            if (this._parent.hbOutput.ColumnInfoVisible == true)
            {
                OutPaneBarView.Checked = true;
            }
            else
            {
                OutPaneBarView.Checked = false;
            }
            // # of BytesPerLine 
            numNumberBytesIn.Value = this._parent.hbInput.BytesPerLine;
            numNumberBytesOut.Value = this._parent.hbOutput.BytesPerLine;
        }
        private void InPaneStringsView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneStringsView.Checked == true)
            {
                this._parent.hbInput.StringViewVisible = true;
            }
            else
            {
                this._parent.hbInput.StringViewVisible = false;
            }
        }
        private void OutPaneStringsView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneStringsView.Checked == true)
            {
                this._parent.hbOutput.StringViewVisible = true;
            }
            else
            {
                this._parent.hbOutput.StringViewVisible = false;
            }
        }

        private void InPaneSeparatorView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneSeparatorView.Checked == true)
            {
                this._parent.hbInput.GroupSeparatorVisible = true;
            }
            else
            {
                this._parent.hbInput.GroupSeparatorVisible = false;
            }
        }

        private void OutPaneSeparatorView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneSeparatorView.Checked == true)
            {
                this._parent.hbOutput.GroupSeparatorVisible = true;
            }
            else
            {
                this._parent.hbOutput.GroupSeparatorVisible = false;
            }
        }

        private void InPaneBarView_CheckedChanged(object sender, EventArgs e)
        {
            if (InPaneBarView.Checked == true)
            {
                this._parent.hbInput.ColumnInfoVisible = true;
                this._parent.hbInput.LineInfoVisible = true;
            }
            else
            {
                this._parent.hbInput.ColumnInfoVisible = false;
                this._parent.hbInput.LineInfoVisible = false;
            }
        }

        private void OutPaneBarView_CheckedChanged(object sender, EventArgs e)
        {
            if (OutPaneBarView.Checked == true)
            {
                this._parent.hbOutput.ColumnInfoVisible = true;
                this._parent.hbOutput.LineInfoVisible = true;
            }
            else
            {
                this._parent.hbOutput.ColumnInfoVisible = false;
                this._parent.hbOutput.LineInfoVisible = false;
            }
        }

        private void numNumberBytesIn_ValueChanged(object sender, EventArgs e)
        {
            this._parent.hbInput.BytesPerLine = (int)numNumberBytesIn.Value;
        }

        private void numNumberBytesOut_ValueChanged(object sender, EventArgs e)
        {
            this._parent.hbOutput.BytesPerLine = (int)numNumberBytesOut.Value;
        }
    }
}
