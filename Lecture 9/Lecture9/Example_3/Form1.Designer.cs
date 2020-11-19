using System.Windows.Forms;

namespace Example_3
{
    partial class Form1
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
            this.lstBxTrees = new System.Windows.Forms.ListBox();
            this.cmboFlowers = new System.Windows.Forms.ComboBox();
            this.lblTrees = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFlower = new System.Windows.Forms.Label();
            this.txtBxResultFlowers = new System.Windows.Forms.TextBox();
            this.txtBxResultTrees = new System.Windows.Forms.TextBox();
            this.lblFlowerAnswer = new System.Windows.Forms.Label();
            this.lblTreeAnswer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxTrees
            // 
            this.lstBxTrees.FormattingEnabled = true;
            this.lstBxTrees.ItemHeight = 29;
            this.lstBxTrees.Items.AddRange(new object[] {
            "Maple",
            "Oak",
            "Palm",
            "Pine",
            "Spruce",
            "Walnut"});
            this.lstBxTrees.Location = new System.Drawing.Point(304, 151);
            this.lstBxTrees.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstBxTrees.Name = "lstBxTrees";
            this.lstBxTrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxTrees.Size = new System.Drawing.Size(197, 178);
            this.lstBxTrees.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstBxTrees, "Press and hold the Ctrl key for multiple selections!");
            // 
            // cmboFlowers
            // 
            this.cmboFlowers.FormattingEnabled = true;
            this.cmboFlowers.Items.AddRange(new object[] {
            "Roses",
            "Orchids",
            "Tulips ",
            "Daisies",
            "Asters",
            "Mums"});
            this.cmboFlowers.Location = new System.Drawing.Point(15, 151);
            this.cmboFlowers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmboFlowers.Name = "cmboFlowers";
            this.cmboFlowers.Size = new System.Drawing.Size(199, 37);
            this.cmboFlowers.TabIndex = 1;
            this.cmboFlowers.SelectedIndexChanged += new System.EventHandler(this.cmboFlowers_SelectedIndexChanged);
            // 
            // lblTrees
            // 
            this.lblTrees.AutoSize = true;
            this.lblTrees.Location = new System.Drawing.Point(364, 100);
            this.lblTrees.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTrees.Name = "lblTrees";
            this.lblTrees.Size = new System.Drawing.Size(82, 29);
            this.lblTrees.TabIndex = 2;
            this.lblTrees.Text = "Trees";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(167, 58);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(246, 29);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Make your selection";
            // 
            // lblFlower
            // 
            this.lblFlower.AutoSize = true;
            this.lblFlower.ForeColor = System.Drawing.Color.Yellow;
            this.lblFlower.Location = new System.Drawing.Point(55, 100);
            this.lblFlower.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFlower.Name = "lblFlower";
            this.lblFlower.Size = new System.Drawing.Size(107, 29);
            this.lblFlower.TabIndex = 4;
            this.lblFlower.Text = "Flowers";
            // 
            // txtBxResultFlowers
            // 
            this.txtBxResultFlowers.Location = new System.Drawing.Point(34, 470);
            this.txtBxResultFlowers.Name = "txtBxResultFlowers";
            this.txtBxResultFlowers.Size = new System.Drawing.Size(107, 35);
            this.txtBxResultFlowers.TabIndex = 5;
            // 
            // txtBxResultTrees
            // 
            this.txtBxResultTrees.AcceptsTab = true;
            this.txtBxResultTrees.Location = new System.Drawing.Point(300, 433);
            this.txtBxResultTrees.Multiline = true;
            this.txtBxResultTrees.Name = "txtBxResultTrees";
            this.txtBxResultTrees.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBxResultTrees.Size = new System.Drawing.Size(201, 72);
            this.txtBxResultTrees.TabIndex = 6;
            // 
            // lblFlowerAnswer
            // 
            this.lblFlowerAnswer.AutoSize = true;
            this.lblFlowerAnswer.Location = new System.Drawing.Point(10, 415);
            this.lblFlowerAnswer.Name = "lblFlowerAnswer";
            this.lblFlowerAnswer.Size = new System.Drawing.Size(228, 29);
            this.lblFlowerAnswer.TabIndex = 7;
            this.lblFlowerAnswer.Text = "Flower preference";
            // 
            // lblTreeAnswer
            // 
            this.lblTreeAnswer.AutoSize = true;
            this.lblTreeAnswer.Location = new System.Drawing.Point(299, 389);
            this.lblTreeAnswer.Name = "lblTreeAnswer";
            this.lblTreeAnswer.Size = new System.Drawing.Size(216, 29);
            this.lblTreeAnswer.TabIndex = 8;
            this.lblTreeAnswer.Text = "Tree preferences";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.exitToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.menuHelp,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menuColor,
            this.toolStripSeparator2,
            this.menuFont});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(270, 34);
            this.menuColor.Text = "Color";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(270, 34);
            this.menuFont.Text = "Font";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 29);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(78, 29);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(123, 581);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(137, 29);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Add water!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(602, 653);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTreeAnswer);
            this.Controls.Add(this.lblFlowerAnswer);
            this.Controls.Add(this.txtBxResultTrees);
            this.Controls.Add(this.txtBxResultFlowers);
            this.Controls.Add(this.lblFlower);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTrees);
            this.Controls.Add(this.cmboFlowers);
            this.Controls.Add(this.lstBxTrees);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Gardening Guide";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxTrees;
        private System.Windows.Forms.ComboBox cmboFlowers;
        private System.Windows.Forms.Label lblTrees;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblFlower;
        private System.Windows.Forms.TextBox txtBxResultFlowers;
        private System.Windows.Forms.TextBox txtBxResultTrees;
        private Label lblFlowerAnswer;
        private Label lblTreeAnswer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem menuColor;
        private ToolStripMenuItem menuFont;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuAbout;
        private Label lblOutput;
        private ToolTip toolTip1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}

