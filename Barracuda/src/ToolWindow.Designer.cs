namespace Barracuda
{
    partial class ToolWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolWindow));
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.ClearLogOutputButton = new System.Windows.Forms.Button();
            this.SaveLogOutputButton = new System.Windows.Forms.Button();
            this.BrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.CommandParamCombo = new System.Windows.Forms.ComboBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.PathPanel = new System.Windows.Forms.Panel();
            this.FindFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CommandParamHintTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.BrowseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SplitContainerTopDown = new System.Windows.Forms.SplitContainer();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PathPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTopDown)).BeginInit();
            this.SplitContainerTopDown.Panel1.SuspendLayout();
            this.SplitContainerTopDown.Panel2.SuspendLayout();
            this.SplitContainerTopDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(3, 63);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(90, 21);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_OnClick);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.HideSelection = false;
            this.OutputBox.Location = new System.Drawing.Point(0, 0);
            this.OutputBox.MinimumSize = new System.Drawing.Size(4, 100);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.OutputBox.Size = new System.Drawing.Size(484, 225);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            this.OutputBox.WordWrap = false;
            // 
            // ClearLogOutputButton
            // 
            this.ClearLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLogOutputButton.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLogOutputButton.Location = new System.Drawing.Point(65, 103);
            this.ClearLogOutputButton.Name = "ClearLogOutputButton";
            this.ClearLogOutputButton.Size = new System.Drawing.Size(53, 23);
            this.ClearLogOutputButton.TabIndex = 2;
            this.ClearLogOutputButton.Text = "Clear";
            this.ClearLogOutputButton.UseVisualStyleBackColor = true;
            this.ClearLogOutputButton.Click += new System.EventHandler(this.ClearLogOutputButton_OnClick);
            // 
            // SaveLogOutputButton
            // 
            this.SaveLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLogOutputButton.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLogOutputButton.Location = new System.Drawing.Point(6, 103);
            this.SaveLogOutputButton.Name = "SaveLogOutputButton";
            this.SaveLogOutputButton.Size = new System.Drawing.Size(53, 23);
            this.SaveLogOutputButton.TabIndex = 3;
            this.SaveLogOutputButton.Text = "Save";
            this.SaveLogOutputButton.UseVisualStyleBackColor = true;
            this.SaveLogOutputButton.Click += new System.EventHandler(this.SaveLogOutputButton_OnClick);
            // 
            // BrowseFileDialog
            // 
            this.BrowseFileDialog.Title = "Target Unity Asset";
            // 
            // FindFileButton
            // 
            this.FindFileButton.Location = new System.Drawing.Point(3, 3);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(90, 21);
            this.FindFileButton.TabIndex = 4;
            this.FindFileButton.Text = "Find";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_OnClick);
            // 
            // CommandParamCombo
            // 
            this.CommandParamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandParamCombo.FormattingEnabled = true;
            this.CommandParamCombo.Items.AddRange(new object[] {
            "<command>",
            "List",
            "Info",
            "Info-Stats",
            "Dump",
            "Dump-Struct",
            "Extract",
            "Extract-Raw",
            "FixRefs",
            "Split",
            "Unbundle",
            "Learn"});
            this.CommandParamCombo.Location = new System.Drawing.Point(3, 36);
            this.CommandParamCombo.Name = "CommandParamCombo";
            this.CommandParamCombo.Size = new System.Drawing.Size(90, 21);
            this.CommandParamCombo.TabIndex = 5;
            this.CommandParamCombo.SelectionChangeCommitted += new System.EventHandler(this.CommandParamCombo_OnSelectionChangeCommitted);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.SplitContainer);
            this.ControlPanel.Controls.Add(this.SaveLogOutputButton);
            this.ControlPanel.Controls.Add(this.ClearLogOutputButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(484, 133);
            this.ControlPanel.TabIndex = 6;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.IsSplitterFixed = true;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ButtonPanel);
            this.SplitContainer.Panel1MinSize = 100;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.PathPanel);
            this.SplitContainer.Size = new System.Drawing.Size(484, 97);
            this.SplitContainer.SplitterDistance = 102;
            this.SplitContainer.TabIndex = 8;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.FindFileButton);
            this.ButtonPanel.Controls.Add(this.CommandParamCombo);
            this.ButtonPanel.Controls.Add(this.ExecuteButton);
            this.ButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(97, 90);
            this.ButtonPanel.TabIndex = 7;
            // 
            // PathPanel
            // 
            this.PathPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathPanel.Controls.Add(this.FindFilePathTextBox);
            this.PathPanel.Controls.Add(this.CommandParamHintTextBox);
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathPanel.Location = new System.Drawing.Point(0, 0);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Padding = new System.Windows.Forms.Padding(3);
            this.PathPanel.Size = new System.Drawing.Size(378, 94);
            this.PathPanel.TabIndex = 7;
            // 
            // FindFilePathTextBox
            // 
            this.FindFilePathTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindFilePathTextBox.Location = new System.Drawing.Point(3, 3);
            this.FindFilePathTextBox.Name = "FindFilePathTextBox";
            this.FindFilePathTextBox.ReadOnly = true;
            this.FindFilePathTextBox.Size = new System.Drawing.Size(372, 20);
            this.FindFilePathTextBox.TabIndex = 7;
            // 
            // CommandParamHintTextBox
            // 
            this.CommandParamHintTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommandParamHintTextBox.Location = new System.Drawing.Point(3, 39);
            this.CommandParamHintTextBox.Multiline = true;
            this.CommandParamHintTextBox.Name = "CommandParamHintTextBox";
            this.CommandParamHintTextBox.ReadOnly = true;
            this.CommandParamHintTextBox.Size = new System.Drawing.Size(372, 52);
            this.CommandParamHintTextBox.TabIndex = 8;
            // 
            // SplitContainerTopDown
            // 
            this.SplitContainerTopDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerTopDown.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainerTopDown.IsSplitterFixed = true;
            this.SplitContainerTopDown.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerTopDown.Name = "SplitContainerTopDown";
            this.SplitContainerTopDown.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerTopDown.Panel1
            // 
            this.SplitContainerTopDown.Panel1.Controls.Add(this.ControlPanel);
            this.SplitContainerTopDown.Panel1MinSize = 133;
            // 
            // SplitContainerTopDown.Panel2
            // 
            this.SplitContainerTopDown.Panel2.Controls.Add(this.OutputBox);
            this.SplitContainerTopDown.Size = new System.Drawing.Size(484, 362);
            this.SplitContainerTopDown.SplitterDistance = 133;
            this.SplitContainerTopDown.TabIndex = 8;
            // 
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.SplitContainerTopDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 325);
            this.Name = "ToolWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Disunity GUI";
            this.ControlPanel.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PathPanel.ResumeLayout(false);
            this.PathPanel.PerformLayout();
            this.SplitContainerTopDown.Panel1.ResumeLayout(false);
            this.SplitContainerTopDown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTopDown)).EndInit();
            this.SplitContainerTopDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button ClearLogOutputButton;
        private System.Windows.Forms.Button SaveLogOutputButton;
        private System.Windows.Forms.OpenFileDialog BrowseFileDialog;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.ComboBox CommandParamCombo;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.TextBox CommandParamHintTextBox;
        private System.Windows.Forms.TextBox FindFilePathTextBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolderDialog;
        private System.Windows.Forms.Panel PathPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.SplitContainer SplitContainerTopDown;
    }
}

