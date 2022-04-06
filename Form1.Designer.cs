namespace FilesViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goBack = new System.Windows.Forms.ToolStripButton();
            this.goForward = new System.Windows.Forms.ToolStripButton();
            this.pathLabel = new System.Windows.Forms.ToolStripLabel();
            this.pathText = new System.Windows.Forms.ToolStripTextBox();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.fullName = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.LAT = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBack,
            this.goForward,
            this.pathLabel,
            this.pathText,
            this.openButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1400, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // goBack
            // 
            this.goBack.AutoSize = false;
            this.goBack.BackColor = System.Drawing.SystemColors.Control;
            this.goBack.CheckOnClick = true;
            this.goBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBack.Image = ((System.Drawing.Image)(resources.GetObject("goBack.Image")));
            this.goBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(28, 28);
            this.goBack.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // goForward
            // 
            this.goForward.AutoSize = false;
            this.goForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goForward.Image = ((System.Drawing.Image)(resources.GetObject("goForward.Image")));
            this.goForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(28, 28);
            this.goForward.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(51, 37);
            this.pathLabel.Text = "Path: ";
            // 
            // pathText
            // 
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(500, 40);
            this.pathText.Text = "C:\\Users";
            this.pathText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathText_KeyDown);
            this.pathText.DoubleClick += new System.EventHandler(this.pathText_DoubleClick);
            // 
            // openButton
            // 
            this.openButton.AutoSize = false;
            this.openButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openButton.CheckOnClick = true;
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(45, 25);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(12, 388);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(67, 15);
            this.fullName.TabIndex = 2;
            this.fullName.Text = "Full Name: ";
            this.fullName.Visible = false;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(12, 415);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(50, 15);
            this.length.TabIndex = 3;
            this.length.Text = "Length: ";
            this.length.Visible = false;
            // 
            // LAT
            // 
            this.LAT.AutoSize = true;
            this.LAT.Location = new System.Drawing.Point(12, 442);
            this.LAT.Name = "LAT";
            this.LAT.Size = new System.Drawing.Size(102, 15);
            this.LAT.TabIndex = 4;
            this.LAT.Text = "Last Access Time: ";
            this.LAT.Visible = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(0, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1400, 319);
            this.listBox.TabIndex = 5;
            this.listBox.Visible = false;
            this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyDown);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.LAT);
            this.Controls.Add(this.length);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Files Viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton goBack;
        private ToolStripButton goForward;
        private ToolStripLabel pathLabel;
        private ToolStripTextBox pathText;
        private ToolStripButton openButton;
        private Label fullName;
        private Label length;
        private Label LAT;
        private ListBox listBox;
    }
}