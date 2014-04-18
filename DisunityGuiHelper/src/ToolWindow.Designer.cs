namespace DisunityGuiHelper
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
			this.OutputBox = new System.Windows.Forms.RichTextBox();
			this.DropZonePanel = new System.Windows.Forms.Panel();
			this.BrowseTargetSplitContainer = new System.Windows.Forms.SplitContainer();
			this.BrowseTargetButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CommandSelectionHintText = new System.Windows.Forms.TextBox();
			this.BrowseTargetTextBox = new System.Windows.Forms.TextBox();
			this.ClassFilterTextBox = new System.Windows.Forms.TextBox();
			this.CommandSelectionCombo = new System.Windows.Forms.ComboBox();
			this.ExecuteButton = new System.Windows.Forms.Button();
			this.ClearLogOutputButton = new System.Windows.Forms.Button();
			this.SaveLogOutputButton = new System.Windows.Forms.Button();
			this.BrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.BrowseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.WindowSplitContainer = new System.Windows.Forms.SplitContainer();
			this.ControlAreaPanel = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BusyStatusLabel = new System.Windows.Forms.Label();
			this.BusyIndicator = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.BrowseTargetSplitContainer)).BeginInit();
			this.BrowseTargetSplitContainer.Panel1.SuspendLayout();
			this.BrowseTargetSplitContainer.Panel2.SuspendLayout();
			this.BrowseTargetSplitContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WindowSplitContainer)).BeginInit();
			this.WindowSplitContainer.Panel1.SuspendLayout();
			this.WindowSplitContainer.Panel2.SuspendLayout();
			this.WindowSplitContainer.SuspendLayout();
			this.ControlAreaPanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// OutputBox
			// 
			this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputBox.HideSelection = false;
			this.OutputBox.Location = new System.Drawing.Point(0, 28);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.OutputBox.Size = new System.Drawing.Size(664, 132);
			this.OutputBox.TabIndex = 0;
			this.OutputBox.Text = "";
			this.OutputBox.WordWrap = false;
			// 
			// DropZonePanel
			// 
			this.DropZonePanel.AllowDrop = true;
			this.DropZonePanel.AutoSize = true;
			this.DropZonePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.DropZonePanel.BackgroundImage = global::DisunityGuiHelper.Properties.Resources.DropZoneImage;
			this.DropZonePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.DropZonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DropZonePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DropZonePanel.Location = new System.Drawing.Point(0, 23);
			this.DropZonePanel.MaximumSize = new System.Drawing.Size(100, 75);
			this.DropZonePanel.MinimumSize = new System.Drawing.Size(100, 75);
			this.DropZonePanel.Name = "DropZonePanel";
			this.DropZonePanel.Size = new System.Drawing.Size(100, 75);
			this.DropZonePanel.TabIndex = 1;
			this.DropZonePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropZonePanel_OnDragDrop);
			this.DropZonePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropZonePanel_OnDragEnter);
			// 
			// BrowseTargetSplitContainer
			// 
			this.BrowseTargetSplitContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BrowseTargetSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.BrowseTargetSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.BrowseTargetSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.BrowseTargetSplitContainer.Name = "BrowseTargetSplitContainer";
			// 
			// BrowseTargetSplitContainer.Panel1
			// 
			this.BrowseTargetSplitContainer.Panel1.Controls.Add(this.BrowseTargetButton);
			this.BrowseTargetSplitContainer.Panel1.Controls.Add(this.DropZonePanel);
			this.BrowseTargetSplitContainer.Panel1MinSize = 100;
			// 
			// BrowseTargetSplitContainer.Panel2
			// 
			this.BrowseTargetSplitContainer.Panel2.Controls.Add(this.panel1);
			this.BrowseTargetSplitContainer.Panel2.Controls.Add(this.BrowseTargetTextBox);
			this.BrowseTargetSplitContainer.Size = new System.Drawing.Size(664, 98);
			this.BrowseTargetSplitContainer.SplitterDistance = 100;
			this.BrowseTargetSplitContainer.TabIndex = 0;
			// 
			// BrowseTargetButton
			// 
			this.BrowseTargetButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.BrowseTargetButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.BrowseTargetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BrowseTargetButton.Location = new System.Drawing.Point(0, 0);
			this.BrowseTargetButton.Name = "BrowseTargetButton";
			this.BrowseTargetButton.Size = new System.Drawing.Size(100, 23);
			this.BrowseTargetButton.TabIndex = 2;
			this.BrowseTargetButton.Text = "Target";
			this.BrowseTargetButton.UseVisualStyleBackColor = true;
			this.BrowseTargetButton.Click += new System.EventHandler(this.BrowseTargetButton_OnClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.CommandSelectionHintText);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 78);
			this.panel1.TabIndex = 6;
			// 
			// CommandSelectionHintText
			// 
			this.CommandSelectionHintText.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.CommandSelectionHintText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CommandSelectionHintText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommandSelectionHintText.Location = new System.Drawing.Point(0, 0);
			this.CommandSelectionHintText.Multiline = true;
			this.CommandSelectionHintText.Name = "CommandSelectionHintText";
			this.CommandSelectionHintText.ReadOnly = true;
			this.CommandSelectionHintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.CommandSelectionHintText.Size = new System.Drawing.Size(558, 76);
			this.CommandSelectionHintText.TabIndex = 0;
			// 
			// BrowseTargetTextBox
			// 
			this.BrowseTargetTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.BrowseTargetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BrowseTargetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BrowseTargetTextBox.Location = new System.Drawing.Point(0, 0);
			this.BrowseTargetTextBox.Name = "BrowseTargetTextBox";
			this.BrowseTargetTextBox.ReadOnly = true;
			this.BrowseTargetTextBox.Size = new System.Drawing.Size(560, 20);
			this.BrowseTargetTextBox.TabIndex = 1;
			// 
			// ClassFilterTextBox
			// 
			this.ClassFilterTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClassFilterTextBox.Enabled = false;
			this.ClassFilterTextBox.Location = new System.Drawing.Point(68, 1);
			this.ClassFilterTextBox.Name = "ClassFilterTextBox";
			this.ClassFilterTextBox.Size = new System.Drawing.Size(134, 20);
			this.ClassFilterTextBox.TabIndex = 5;
			this.ClassFilterTextBox.TextChanged += new System.EventHandler(this.ClassFilterTextBox_OnTextChanged);
			// 
			// CommandSelectionCombo
			// 
			this.CommandSelectionCombo.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.CommandSelectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CommandSelectionCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CommandSelectionCombo.FormattingEnabled = true;
			this.CommandSelectionCombo.Location = new System.Drawing.Point(65, 1);
			this.CommandSelectionCombo.Name = "CommandSelectionCombo";
			this.CommandSelectionCombo.Size = new System.Drawing.Size(100, 21);
			this.CommandSelectionCombo.TabIndex = 3;
			this.CommandSelectionCombo.SelectionChangeCommitted += new System.EventHandler(this.CommandSelectionCombo_OnSelectionChangeCommitted);
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExecuteButton.Location = new System.Drawing.Point(71, 3);
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
			this.ExecuteButton.TabIndex = 4;
			this.ExecuteButton.Text = "Execute";
			this.ExecuteButton.UseVisualStyleBackColor = true;
			this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_OnClick);
			// 
			// ClearLogOutputButton
			// 
			this.ClearLogOutputButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClearLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearLogOutputButton.Location = new System.Drawing.Point(534, 2);
			this.ClearLogOutputButton.Name = "ClearLogOutputButton";
			this.ClearLogOutputButton.Size = new System.Drawing.Size(60, 23);
			this.ClearLogOutputButton.TabIndex = 6;
			this.ClearLogOutputButton.Text = "Clear";
			this.ClearLogOutputButton.UseVisualStyleBackColor = true;
			this.ClearLogOutputButton.Click += new System.EventHandler(this.ClearLogOutputButton_OnClick);
			// 
			// SaveLogOutputButton
			// 
			this.SaveLogOutputButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.SaveLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveLogOutputButton.Location = new System.Drawing.Point(600, 2);
			this.SaveLogOutputButton.Name = "SaveLogOutputButton";
			this.SaveLogOutputButton.Size = new System.Drawing.Size(60, 23);
			this.SaveLogOutputButton.TabIndex = 5;
			this.SaveLogOutputButton.Text = "Save As";
			this.SaveLogOutputButton.UseVisualStyleBackColor = true;
			this.SaveLogOutputButton.Click += new System.EventHandler(this.SaveLogOutputButton_OnClick);
			// 
			// BrowseFileDialog
			// 
			this.BrowseFileDialog.Title = "Target Unity Asset";
			// 
			// WindowSplitContainer
			// 
			this.WindowSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
			this.WindowSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WindowSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.WindowSplitContainer.IsSplitterFixed = true;
			this.WindowSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.WindowSplitContainer.Name = "WindowSplitContainer";
			this.WindowSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// WindowSplitContainer.Panel1
			// 
			this.WindowSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.WindowSplitContainer.Panel1.Controls.Add(this.BrowseTargetSplitContainer);
			this.WindowSplitContainer.Panel1MinSize = 101;
			// 
			// WindowSplitContainer.Panel2
			// 
			this.WindowSplitContainer.Panel2.Controls.Add(this.OutputBox);
			this.WindowSplitContainer.Panel2.Controls.Add(this.ControlAreaPanel);
			this.WindowSplitContainer.Size = new System.Drawing.Size(664, 262);
			this.WindowSplitContainer.SplitterDistance = 101;
			this.WindowSplitContainer.SplitterWidth = 1;
			this.WindowSplitContainer.TabIndex = 2;
			// 
			// ControlAreaPanel
			// 
			this.ControlAreaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ControlAreaPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ControlAreaPanel.Controls.Add(this.panel5);
			this.ControlAreaPanel.Controls.Add(this.panel4);
			this.ControlAreaPanel.Controls.Add(this.panel3);
			this.ControlAreaPanel.Controls.Add(this.ExecuteButton);
			this.ControlAreaPanel.Controls.Add(this.ClearLogOutputButton);
			this.ControlAreaPanel.Controls.Add(this.SaveLogOutputButton);
			this.ControlAreaPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ControlAreaPanel.Location = new System.Drawing.Point(0, 0);
			this.ControlAreaPanel.Name = "ControlAreaPanel";
			this.ControlAreaPanel.Size = new System.Drawing.Size(664, 28);
			this.ControlAreaPanel.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.ClassFilterTextBox);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Location = new System.Drawing.Point(324, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(203, 23);
			this.panel5.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Class Filter";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.CommandSelectionCombo);
			this.panel4.Location = new System.Drawing.Point(152, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(166, 23);
			this.panel4.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Command";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.BusyStatusLabel);
			this.panel3.Controls.Add(this.BusyIndicator);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(68, 23);
			this.panel3.TabIndex = 7;
			// 
			// BusyStatusLabel
			// 
			this.BusyStatusLabel.AutoEllipsis = true;
			this.BusyStatusLabel.Location = new System.Drawing.Point(4, 5);
			this.BusyStatusLabel.Name = "BusyStatusLabel";
			this.BusyStatusLabel.Size = new System.Drawing.Size(38, 13);
			this.BusyStatusLabel.TabIndex = 2;
			this.BusyStatusLabel.Text = "Ready";
			// 
			// BusyIndicator
			// 
			this.BusyIndicator.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.BusyIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BusyIndicator.Location = new System.Drawing.Point(47, 4);
			this.BusyIndicator.MaximumSize = new System.Drawing.Size(15, 15);
			this.BusyIndicator.MinimumSize = new System.Drawing.Size(15, 15);
			this.BusyIndicator.Name = "BusyIndicator";
			this.BusyIndicator.Size = new System.Drawing.Size(15, 15);
			this.BusyIndicator.TabIndex = 1;
			// 
			// ToolWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(664, 262);
			this.Controls.Add(this.WindowSplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(550, 170);
			this.Name = "ToolWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Disunity Graphical Interface";
			this.BrowseTargetSplitContainer.Panel1.ResumeLayout(false);
			this.BrowseTargetSplitContainer.Panel1.PerformLayout();
			this.BrowseTargetSplitContainer.Panel2.ResumeLayout(false);
			this.BrowseTargetSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BrowseTargetSplitContainer)).EndInit();
			this.BrowseTargetSplitContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.WindowSplitContainer.Panel1.ResumeLayout(false);
			this.WindowSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WindowSplitContainer)).EndInit();
			this.WindowSplitContainer.ResumeLayout(false);
			this.ControlAreaPanel.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox OutputBox;
		private System.Windows.Forms.Panel DropZonePanel;
		private System.Windows.Forms.Button ClearLogOutputButton;
		private System.Windows.Forms.Button SaveLogOutputButton;
		private System.Windows.Forms.Button ExecuteButton;
		private System.Windows.Forms.ComboBox CommandSelectionCombo;
		private System.Windows.Forms.Button BrowseTargetButton;
		private System.Windows.Forms.TextBox BrowseTargetTextBox;
		private System.Windows.Forms.TextBox CommandSelectionHintText;
		private System.Windows.Forms.OpenFileDialog BrowseFileDialog;
		private System.Windows.Forms.FolderBrowserDialog BrowseFolderDialog;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private System.Windows.Forms.SplitContainer WindowSplitContainer;
		private System.Windows.Forms.Panel ControlAreaPanel;
		private System.Windows.Forms.TextBox ClassFilterTextBox;
		private System.Windows.Forms.SplitContainer BrowseTargetSplitContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label BusyStatusLabel;
		private System.Windows.Forms.Panel BusyIndicator;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
	}
}

