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
			this.TargetBrowseButton = new System.Windows.Forms.Button();
			this.TargetTextBox = new System.Windows.Forms.TextBox();
			this.FilterTextBox = new System.Windows.Forms.TextBox();
			this.RunPresetSelection = new System.Windows.Forms.ComboBox();
			this.ExecuteButton = new System.Windows.Forms.Button();
			this.ClearLogOutputButton = new System.Windows.Forms.Button();
			this.SaveLogOutputButton = new System.Windows.Forms.Button();
			this.BrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.BrowseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.WindowSplitContainer = new System.Windows.Forms.SplitContainer();
			this.UprightSplitContainer = new System.Windows.Forms.SplitContainer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BusyStatusLabel = new System.Windows.Forms.Label();
			this.BusyIndicator = new System.Windows.Forms.Panel();
			this.WindowLayout = new System.Windows.Forms.TableLayoutPanel();
			this.HelpHintTextbox = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.RunExpertSelection = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.CommandLabel = new System.Windows.Forms.Label();
			this.ToggleUseExpert = new System.Windows.Forms.CheckBox();
			this.TargetPanel = new System.Windows.Forms.Panel();
			this.ToggleUseLineHightlight = new System.Windows.Forms.CheckBox();
			this.SupportButton = new System.Windows.Forms.Button();
			this.ToggleUseScrollToEnd = new System.Windows.Forms.CheckBox();
			this.ToggleUseVerbose = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.FilterLabel = new System.Windows.Forms.Label();
			this.ToggleUseTarget = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.WindowSplitContainer)).BeginInit();
			this.WindowSplitContainer.Panel1.SuspendLayout();
			this.WindowSplitContainer.Panel2.SuspendLayout();
			this.WindowSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UprightSplitContainer)).BeginInit();
			this.UprightSplitContainer.Panel1.SuspendLayout();
			this.UprightSplitContainer.Panel2.SuspendLayout();
			this.UprightSplitContainer.SuspendLayout();
			this.panel3.SuspendLayout();
			this.WindowLayout.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.TargetPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OutputBox
			// 
			this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputBox.HideSelection = false;
			this.OutputBox.Location = new System.Drawing.Point(0, 0);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.OutputBox.ShowSelectionMargin = true;
			this.OutputBox.Size = new System.Drawing.Size(579, 211);
			this.OutputBox.TabIndex = 0;
			this.OutputBox.TabStop = false;
			this.OutputBox.Text = "";
			this.OutputBox.WordWrap = false;
			this.OutputBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OutputBox_LinkClicked);
			this.OutputBox.SelectionChanged += new System.EventHandler(this.OutputBox_SelectionChanged);
			this.OutputBox.Click += new System.EventHandler(this.OutputBox_OnClick);
			this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
			this.OutputBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OutputBox_MouseUp);
			// 
			// DropZonePanel
			// 
			this.DropZonePanel.AllowDrop = true;
			this.DropZonePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.DropZonePanel.BackgroundImage = global::DisunityGuiHelper.Properties.Resources.DropZoneImage;
			this.DropZonePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.DropZonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DropZonePanel.Location = new System.Drawing.Point(5, 38);
			this.DropZonePanel.MaximumSize = new System.Drawing.Size(100, 75);
			this.DropZonePanel.MinimumSize = new System.Drawing.Size(100, 75);
			this.DropZonePanel.Name = "DropZonePanel";
			this.DropZonePanel.Size = new System.Drawing.Size(100, 75);
			this.DropZonePanel.TabIndex = 0;
			this.DropZonePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropZonePanel_OnDragDrop);
			this.DropZonePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropZonePanel_OnDragEnter);
			// 
			// TargetBrowseButton
			// 
			this.TargetBrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.TargetBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TargetBrowseButton.Location = new System.Drawing.Point(5, 7);
			this.TargetBrowseButton.Name = "TargetBrowseButton";
			this.TargetBrowseButton.Size = new System.Drawing.Size(100, 25);
			this.TargetBrowseButton.TabIndex = 1;
			this.TargetBrowseButton.Text = "Browse";
			this.TargetBrowseButton.UseVisualStyleBackColor = true;
			this.TargetBrowseButton.Click += new System.EventHandler(this.TargetBrowseButton_OnClick);
			// 
			// TargetTextBox
			// 
			this.TargetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.WindowLayout.SetColumnSpan(this.TargetTextBox, 2);
			this.TargetTextBox.Enabled = false;
			this.TargetTextBox.Location = new System.Drawing.Point(3, 3);
			this.TargetTextBox.Name = "TargetTextBox";
			this.TargetTextBox.ReadOnly = true;
			this.TargetTextBox.Size = new System.Drawing.Size(459, 20);
			this.TargetTextBox.TabIndex = 1;
			this.TargetTextBox.TabStop = false;
			// 
			// FilterTextBox
			// 
			this.FilterTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.FilterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilterTextBox.Location = new System.Drawing.Point(0, 0);
			this.FilterTextBox.Name = "FilterTextBox";
			this.FilterTextBox.Size = new System.Drawing.Size(259, 20);
			this.FilterTextBox.TabIndex = 0;
			this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_OnTextChanged);
			this.FilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterTextBox_OnKeyPress);
			// 
			// RunPresetSelection
			// 
			this.RunPresetSelection.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.RunPresetSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RunPresetSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RunPresetSelection.FormattingEnabled = true;
			this.RunPresetSelection.Location = new System.Drawing.Point(3, 0);
			this.RunPresetSelection.Name = "RunPresetSelection";
			this.RunPresetSelection.Size = new System.Drawing.Size(100, 21);
			this.RunPresetSelection.TabIndex = 0;
			this.RunPresetSelection.SelectionChangeCommitted += new System.EventHandler(this.RunPresetSelection_OnChangeCommitted);
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExecuteButton.Location = new System.Drawing.Point(5, 119);
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.Size = new System.Drawing.Size(100, 25);
			this.ExecuteButton.TabIndex = 0;
			this.ExecuteButton.Text = "Execute";
			this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_OnClick);
			// 
			// ClearLogOutputButton
			// 
			this.ClearLogOutputButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClearLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearLogOutputButton.Location = new System.Drawing.Point(125, 2);
			this.ClearLogOutputButton.Name = "ClearLogOutputButton";
			this.ClearLogOutputButton.Size = new System.Drawing.Size(60, 24);
			this.ClearLogOutputButton.TabIndex = 3;
			this.ClearLogOutputButton.Text = "Clear";
			this.ClearLogOutputButton.UseVisualStyleBackColor = true;
			this.ClearLogOutputButton.Click += new System.EventHandler(this.ClearLogOutputButton_OnClick);
			// 
			// SaveLogOutputButton
			// 
			this.SaveLogOutputButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.SaveLogOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveLogOutputButton.Location = new System.Drawing.Point(125, 29);
			this.SaveLogOutputButton.Name = "SaveLogOutputButton";
			this.SaveLogOutputButton.Size = new System.Drawing.Size(60, 25);
			this.SaveLogOutputButton.TabIndex = 4;
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
			this.WindowSplitContainer.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.WindowSplitContainer.Panel1.Controls.Add(this.UprightSplitContainer);
			this.WindowSplitContainer.Panel1MinSize = 100;
			// 
			// WindowSplitContainer.Panel2
			// 
			this.WindowSplitContainer.Panel2.Controls.Add(this.OutputBox);
			this.WindowSplitContainer.Size = new System.Drawing.Size(579, 387);
			this.WindowSplitContainer.SplitterDistance = 175;
			this.WindowSplitContainer.SplitterWidth = 1;
			this.WindowSplitContainer.TabIndex = 2;
			// 
			// UprightSplitContainer
			// 
			this.UprightSplitContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.UprightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UprightSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.UprightSplitContainer.IsSplitterFixed = true;
			this.UprightSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.UprightSplitContainer.Name = "UprightSplitContainer";
			// 
			// UprightSplitContainer.Panel1
			// 
			this.UprightSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.UprightSplitContainer.Panel1.Controls.Add(this.DropZonePanel);
			this.UprightSplitContainer.Panel1.Controls.Add(this.TargetBrowseButton);
			this.UprightSplitContainer.Panel1.Controls.Add(this.ExecuteButton);
			this.UprightSplitContainer.Panel1.Controls.Add(this.panel3);
			this.UprightSplitContainer.Panel1MinSize = 110;
			// 
			// UprightSplitContainer.Panel2
			// 
			this.UprightSplitContainer.Panel2.Controls.Add(this.WindowLayout);
			this.UprightSplitContainer.Panel2MinSize = 300;
			this.UprightSplitContainer.Size = new System.Drawing.Size(579, 175);
			this.UprightSplitContainer.SplitterDistance = 110;
			this.UprightSplitContainer.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.BusyStatusLabel);
			this.panel3.Controls.Add(this.BusyIndicator);
			this.panel3.Location = new System.Drawing.Point(20, 149);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(67, 22);
			this.panel3.TabIndex = 7;
			// 
			// BusyStatusLabel
			// 
			this.BusyStatusLabel.AutoEllipsis = true;
			this.BusyStatusLabel.Location = new System.Drawing.Point(24, 4);
			this.BusyStatusLabel.Name = "BusyStatusLabel";
			this.BusyStatusLabel.Size = new System.Drawing.Size(38, 13);
			this.BusyStatusLabel.TabIndex = 2;
			this.BusyStatusLabel.Text = "Ready";
			// 
			// BusyIndicator
			// 
			this.BusyIndicator.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.BusyIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BusyIndicator.Location = new System.Drawing.Point(3, 3);
			this.BusyIndicator.MaximumSize = new System.Drawing.Size(15, 15);
			this.BusyIndicator.MinimumSize = new System.Drawing.Size(15, 15);
			this.BusyIndicator.Name = "BusyIndicator";
			this.BusyIndicator.Size = new System.Drawing.Size(15, 15);
			this.BusyIndicator.TabIndex = 1;
			// 
			// WindowLayout
			// 
			this.WindowLayout.ColumnCount = 2;
			this.WindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.WindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.WindowLayout.Controls.Add(this.HelpHintTextbox, 1, 3);
			this.WindowLayout.Controls.Add(this.TargetTextBox, 0, 0);
			this.WindowLayout.Controls.Add(this.panel4, 1, 2);
			this.WindowLayout.Controls.Add(this.panel5, 1, 1);
			this.WindowLayout.Controls.Add(this.panel2, 0, 1);
			this.WindowLayout.Controls.Add(this.TargetPanel, 0, 3);
			this.WindowLayout.Controls.Add(this.panel1, 0, 2);
			this.WindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WindowLayout.Location = new System.Drawing.Point(0, 0);
			this.WindowLayout.Name = "WindowLayout";
			this.WindowLayout.RowCount = 4;
			this.WindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.WindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.WindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.WindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.WindowLayout.Size = new System.Drawing.Size(465, 175);
			this.WindowLayout.TabIndex = 0;
			// 
			// HelpHintTextbox
			// 
			this.HelpHintTextbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.HelpHintTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HelpHintTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HelpHintTextbox.Location = new System.Drawing.Point(203, 88);
			this.HelpHintTextbox.Multiline = true;
			this.HelpHintTextbox.Name = "HelpHintTextbox";
			this.HelpHintTextbox.ReadOnly = true;
			this.HelpHintTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.HelpHintTextbox.Size = new System.Drawing.Size(259, 84);
			this.HelpHintTextbox.TabIndex = 0;
			this.HelpHintTextbox.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.FilterTextBox);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(203, 58);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(259, 24);
			this.panel4.TabIndex = 9;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.RunPresetSelection);
			this.panel5.Controls.Add(this.RunExpertSelection);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(203, 28);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(259, 24);
			this.panel5.TabIndex = 16;
			// 
			// RunExpertSelection
			// 
			this.RunExpertSelection.AcceptsReturn = true;
			this.RunExpertSelection.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.RunExpertSelection.Location = new System.Drawing.Point(109, 1);
			this.RunExpertSelection.Name = "RunExpertSelection";
			this.RunExpertSelection.Size = new System.Drawing.Size(100, 20);
			this.RunExpertSelection.TabIndex = 1;
			this.RunExpertSelection.TextChanged += new System.EventHandler(this.RunExpertSelection_OnTextChanged);
			this.RunExpertSelection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunExpertSelection_OnKeyPress);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.CommandLabel);
			this.panel2.Controls.Add(this.ToggleUseExpert);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(194, 24);
			this.panel2.TabIndex = 15;
			// 
			// CommandLabel
			// 
			this.CommandLabel.AutoSize = true;
			this.CommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommandLabel.Location = new System.Drawing.Point(129, 5);
			this.CommandLabel.Name = "CommandLabel";
			this.CommandLabel.Size = new System.Drawing.Size(61, 13);
			this.CommandLabel.TabIndex = 8;
			this.CommandLabel.Text = "Command";
			// 
			// ToggleUseExpert
			// 
			this.ToggleUseExpert.AutoSize = true;
			this.ToggleUseExpert.Location = new System.Drawing.Point(12, 4);
			this.ToggleUseExpert.Name = "ToggleUseExpert";
			this.ToggleUseExpert.Size = new System.Drawing.Size(86, 17);
			this.ToggleUseExpert.TabIndex = 0;
			this.ToggleUseExpert.Text = "Expert Mode";
			this.ToggleUseExpert.UseVisualStyleBackColor = true;
			this.ToggleUseExpert.CheckedChanged += new System.EventHandler(this.ToggleUseExpert_OnCheckedChanged);
			// 
			// TargetPanel
			// 
			this.TargetPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TargetPanel.Controls.Add(this.ToggleUseLineHightlight);
			this.TargetPanel.Controls.Add(this.SupportButton);
			this.TargetPanel.Controls.Add(this.ToggleUseScrollToEnd);
			this.TargetPanel.Controls.Add(this.ClearLogOutputButton);
			this.TargetPanel.Controls.Add(this.SaveLogOutputButton);
			this.TargetPanel.Controls.Add(this.ToggleUseVerbose);
			this.TargetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TargetPanel.Location = new System.Drawing.Point(3, 88);
			this.TargetPanel.Name = "TargetPanel";
			this.TargetPanel.Size = new System.Drawing.Size(194, 84);
			this.TargetPanel.TabIndex = 14;
			// 
			// ToggleUseLineHightlight
			// 
			this.ToggleUseLineHightlight.AutoSize = true;
			this.ToggleUseLineHightlight.Location = new System.Drawing.Point(10, 59);
			this.ToggleUseLineHightlight.Name = "ToggleUseLineHightlight";
			this.ToggleUseLineHightlight.Size = new System.Drawing.Size(94, 17);
			this.ToggleUseLineHightlight.TabIndex = 2;
			this.ToggleUseLineHightlight.Text = "Mark Highlight";
			this.ToggleUseLineHightlight.UseVisualStyleBackColor = true;
			this.ToggleUseLineHightlight.CheckedChanged += new System.EventHandler(this.ToggleUseLineHightlight_CheckedChanged);
			// 
			// SupportButton
			// 
			this.SupportButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SupportButton.Location = new System.Drawing.Point(125, 56);
			this.SupportButton.Name = "SupportButton";
			this.SupportButton.Size = new System.Drawing.Size(60, 23);
			this.SupportButton.TabIndex = 5;
			this.SupportButton.Text = "Support";
			this.SupportButton.UseVisualStyleBackColor = true;
			this.SupportButton.Click += new System.EventHandler(this.SupportButton_OnClick);
			// 
			// ToggleUseScrollToEnd
			// 
			this.ToggleUseScrollToEnd.AutoSize = true;
			this.ToggleUseScrollToEnd.Location = new System.Drawing.Point(10, 33);
			this.ToggleUseScrollToEnd.Name = "ToggleUseScrollToEnd";
			this.ToggleUseScrollToEnd.Size = new System.Drawing.Size(72, 17);
			this.ToggleUseScrollToEnd.TabIndex = 1;
			this.ToggleUseScrollToEnd.Text = "Autoscroll";
			this.ToggleUseScrollToEnd.UseVisualStyleBackColor = true;
			this.ToggleUseScrollToEnd.CheckedChanged += new System.EventHandler(this.ToggleUseScrollToEnd_OnCheckedChanged);
			// 
			// ToggleUseVerbose
			// 
			this.ToggleUseVerbose.AutoSize = true;
			this.ToggleUseVerbose.Location = new System.Drawing.Point(10, 8);
			this.ToggleUseVerbose.Name = "ToggleUseVerbose";
			this.ToggleUseVerbose.Size = new System.Drawing.Size(65, 17);
			this.ToggleUseVerbose.TabIndex = 0;
			this.ToggleUseVerbose.Text = "Verbose";
			this.ToggleUseVerbose.UseVisualStyleBackColor = true;
			this.ToggleUseVerbose.CheckedChanged += new System.EventHandler(this.ToggleUseVerbose_OnCheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.FilterLabel);
			this.panel1.Controls.Add(this.ToggleUseTarget);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 58);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(194, 24);
			this.panel1.TabIndex = 15;
			// 
			// FilterLabel
			// 
			this.FilterLabel.AutoSize = true;
			this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FilterLabel.Location = new System.Drawing.Point(155, 4);
			this.FilterLabel.Name = "FilterLabel";
			this.FilterLabel.Size = new System.Drawing.Size(35, 13);
			this.FilterLabel.TabIndex = 6;
			this.FilterLabel.Text = "Filter";
			// 
			// ToggleUseTarget
			// 
			this.ToggleUseTarget.AutoSize = true;
			this.ToggleUseTarget.Location = new System.Drawing.Point(12, 4);
			this.ToggleUseTarget.Name = "ToggleUseTarget";
			this.ToggleUseTarget.Size = new System.Drawing.Size(79, 17);
			this.ToggleUseTarget.TabIndex = 0;
			this.ToggleUseTarget.Text = "Use Target";
			this.ToggleUseTarget.UseVisualStyleBackColor = true;
			this.ToggleUseTarget.CheckedChanged += new System.EventHandler(this.ToggleUseTarget_OnCheckedChanged);
			// 
			// ToolWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(579, 387);
			this.Controls.Add(this.WindowSplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(595, 425);
			this.Name = "ToolWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Disunity Graphical Interface";
			this.WindowSplitContainer.Panel1.ResumeLayout(false);
			this.WindowSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WindowSplitContainer)).EndInit();
			this.WindowSplitContainer.ResumeLayout(false);
			this.UprightSplitContainer.Panel1.ResumeLayout(false);
			this.UprightSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UprightSplitContainer)).EndInit();
			this.UprightSplitContainer.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.WindowLayout.ResumeLayout(false);
			this.WindowLayout.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.TargetPanel.ResumeLayout(false);
			this.TargetPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox OutputBox;
		private System.Windows.Forms.Panel DropZonePanel;
		private System.Windows.Forms.Button ClearLogOutputButton;
		private System.Windows.Forms.Button SaveLogOutputButton;
		private System.Windows.Forms.Button ExecuteButton;
		private System.Windows.Forms.ComboBox RunPresetSelection;
		private System.Windows.Forms.Button TargetBrowseButton;
		private System.Windows.Forms.TextBox TargetTextBox;
		private System.Windows.Forms.OpenFileDialog BrowseFileDialog;
		private System.Windows.Forms.FolderBrowserDialog BrowseFolderDialog;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private System.Windows.Forms.SplitContainer WindowSplitContainer;
		private System.Windows.Forms.TextBox FilterTextBox;
		private System.Windows.Forms.Label FilterLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label BusyStatusLabel;
		private System.Windows.Forms.Panel BusyIndicator;
		private System.Windows.Forms.Label CommandLabel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.CheckBox ToggleUseVerbose;
		private System.Windows.Forms.CheckBox ToggleUseExpert;
		private System.Windows.Forms.TextBox RunExpertSelection;
		private System.Windows.Forms.TextBox HelpHintTextbox;
		private System.Windows.Forms.Panel TargetPanel;
		private System.Windows.Forms.CheckBox ToggleUseTarget;
		private System.Windows.Forms.CheckBox ToggleUseScrollToEnd;
		private System.Windows.Forms.SplitContainer UprightSplitContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel WindowLayout;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button SupportButton;
		private System.Windows.Forms.CheckBox ToggleUseLineHightlight;
	}
}

