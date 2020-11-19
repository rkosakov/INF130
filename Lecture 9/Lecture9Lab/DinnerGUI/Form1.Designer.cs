namespace DinnerGUI
{
    partial class OrderGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditEntree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lstBxEntree = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMilk = new System.Windows.Forms.RadioButton();
            this.radJuice = new System.Windows.Forms.RadioButton();
            this.radSoda = new System.Windows.Forms.RadioButton();
            this.radLemonade = new System.Windows.Forms.RadioButton();
            this.radTea = new System.Windows.Forms.RadioButton();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.cmbxSpecial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxWater = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(496, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlaceOrder,
            this.menuClearOrder,
            this.menuDisplayOrder,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "File";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditEntree,
            this.menuEditDrink,
            this.menuEditSpecial});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(58, 29);
            this.menuEdit.Text = "Edit";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 29);
            this.menuHelp.Text = "Help";
            // 
            // menuPlaceOrder
            // 
            this.menuPlaceOrder.Name = "menuPlaceOrder";
            this.menuPlaceOrder.Size = new System.Drawing.Size(270, 34);
            this.menuPlaceOrder.Text = "Place order";
            this.menuPlaceOrder.Click += new System.EventHandler(this.menuPlaceOrder_Click);
            // 
            // menuClearOrder
            // 
            this.menuClearOrder.Name = "menuClearOrder";
            this.menuClearOrder.Size = new System.Drawing.Size(270, 34);
            this.menuClearOrder.Text = "Clear Order";
            this.menuClearOrder.Click += new System.EventHandler(this.menuClearOrder_Click);
            // 
            // menuDisplayOrder
            // 
            this.menuDisplayOrder.Name = "menuDisplayOrder";
            this.menuDisplayOrder.Size = new System.Drawing.Size(270, 34);
            this.menuDisplayOrder.Text = "Display Order";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(270, 34);
            this.menuExit.Text = "Exit";
            // 
            // menuEditEntree
            // 
            this.menuEditEntree.Name = "menuEditEntree";
            this.menuEditEntree.Size = new System.Drawing.Size(270, 34);
            this.menuEditEntree.Text = "Edit Entree";
            // 
            // menuEditDrink
            // 
            this.menuEditDrink.Name = "menuEditDrink";
            this.menuEditDrink.Size = new System.Drawing.Size(270, 34);
            this.menuEditDrink.Text = "Edit Drink";
            // 
            // menuEditSpecial
            // 
            this.menuEditSpecial.Name = "menuEditSpecial";
            this.menuEditSpecial.Size = new System.Drawing.Size(270, 34);
            this.menuEditSpecial.Text = "Edit Special";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(270, 34);
            this.menuAbout.Text = "About";
            // 
            // lstBxEntree
            // 
            this.lstBxEntree.BackColor = System.Drawing.Color.Khaki;
            this.lstBxEntree.FormattingEnabled = true;
            this.lstBxEntree.ItemHeight = 23;
            this.lstBxEntree.Location = new System.Drawing.Point(12, 128);
            this.lstBxEntree.Name = "lstBxEntree";
            this.lstBxEntree.Size = new System.Drawing.Size(150, 96);
            this.lstBxEntree.TabIndex = 1;
            this.lstBxEntree.SelectedIndexChanged += new System.EventHandler(this.lstBxEntree_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entree Selection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCoffee);
            this.groupBox1.Controls.Add(this.radTea);
            this.groupBox1.Controls.Add(this.radLemonade);
            this.groupBox1.Controls.Add(this.radSoda);
            this.groupBox1.Controls.Add(this.radJuice);
            this.groupBox1.Controls.Add(this.radMilk);
            this.groupBox1.Location = new System.Drawing.Point(207, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drink Selection";
            // 
            // radMilk
            // 
            this.radMilk.AutoSize = true;
            this.radMilk.Location = new System.Drawing.Point(21, 29);
            this.radMilk.Name = "radMilk";
            this.radMilk.Size = new System.Drawing.Size(70, 27);
            this.radMilk.TabIndex = 0;
            this.radMilk.TabStop = true;
            this.radMilk.Text = "Milk";
            this.radMilk.UseVisualStyleBackColor = true;
            // 
            // radJuice
            // 
            this.radJuice.AutoSize = true;
            this.radJuice.Location = new System.Drawing.Point(21, 62);
            this.radJuice.Name = "radJuice";
            this.radJuice.Size = new System.Drawing.Size(80, 27);
            this.radJuice.TabIndex = 1;
            this.radJuice.TabStop = true;
            this.radJuice.Text = "Juice";
            this.radJuice.UseVisualStyleBackColor = true;
            // 
            // radSoda
            // 
            this.radSoda.AutoSize = true;
            this.radSoda.Location = new System.Drawing.Point(21, 95);
            this.radSoda.Name = "radSoda";
            this.radSoda.Size = new System.Drawing.Size(81, 27);
            this.radSoda.TabIndex = 2;
            this.radSoda.TabStop = true;
            this.radSoda.Text = "Soda";
            this.radSoda.UseVisualStyleBackColor = true;
            // 
            // radLemonade
            // 
            this.radLemonade.AutoSize = true;
            this.radLemonade.Location = new System.Drawing.Point(21, 125);
            this.radLemonade.Name = "radLemonade";
            this.radLemonade.Size = new System.Drawing.Size(127, 27);
            this.radLemonade.TabIndex = 3;
            this.radLemonade.TabStop = true;
            this.radLemonade.Text = "Lemonade";
            this.radLemonade.UseVisualStyleBackColor = true;
            // 
            // radTea
            // 
            this.radTea.AutoSize = true;
            this.radTea.Location = new System.Drawing.Point(21, 158);
            this.radTea.Name = "radTea";
            this.radTea.Size = new System.Drawing.Size(67, 27);
            this.radTea.TabIndex = 4;
            this.radTea.TabStop = true;
            this.radTea.Text = "Tea";
            this.radTea.UseVisualStyleBackColor = true;
            // 
            // radCoffee
            // 
            this.radCoffee.AutoSize = true;
            this.radCoffee.Location = new System.Drawing.Point(21, 191);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(94, 27);
            this.radCoffee.TabIndex = 5;
            this.radCoffee.TabStop = true;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.UseVisualStyleBackColor = true;
            // 
            // cmbxSpecial
            // 
            this.cmbxSpecial.BackColor = System.Drawing.Color.Khaki;
            this.cmbxSpecial.FormattingEnabled = true;
            this.cmbxSpecial.Items.AddRange(new object[] {
            "Whole Wheat",
            "Pumpernickel",
            "Seedles Rye",
            "Pita",
            "Sour Dough"});
            this.cmbxSpecial.Location = new System.Drawing.Point(12, 282);
            this.cmbxSpecial.Name = "cmbxSpecial";
            this.cmbxSpecial.Size = new System.Drawing.Size(169, 31);
            this.cmbxSpecial.TabIndex = 4;
            this.cmbxSpecial.SelectedIndexChanged += new System.EventHandler(this.cmbxSpecial_SelectedIndexChanged);
            this.cmbxSpecial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxSpecial_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Special Requests";
            // 
            // chBxWater
            // 
            this.chBxWater.AutoSize = true;
            this.chBxWater.Location = new System.Drawing.Point(12, 358);
            this.chBxWater.Name = "chBxWater";
            this.chBxWater.Size = new System.Drawing.Size(89, 27);
            this.chBxWater.TabIndex = 6;
            this.chBxWater.Text = "Water";
            this.chBxWater.UseVisualStyleBackColor = true;
            this.chBxWater.CheckedChanged += new System.EventHandler(this.chBxWater_CheckedChanged);
            // 
            // OrderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(496, 446);
            this.Controls.Add(this.chBxWater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxSpecial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxEntree);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderGUI";
            this.Text = "Student Union - Dinner by the Valley";
            this.Load += new System.EventHandler(this.OrderGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuPlaceOrder;
        private System.Windows.Forms.ToolStripMenuItem menuClearOrder;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayOrder;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditEntree;
        private System.Windows.Forms.ToolStripMenuItem menuEditDrink;
        private System.Windows.Forms.ToolStripMenuItem menuEditSpecial;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ListBox lstBxEntree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCoffee;
        private System.Windows.Forms.RadioButton radTea;
        private System.Windows.Forms.RadioButton radLemonade;
        private System.Windows.Forms.RadioButton radSoda;
        private System.Windows.Forms.RadioButton radJuice;
        private System.Windows.Forms.RadioButton radMilk;
        private System.Windows.Forms.ComboBox cmbxSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBxWater;
    }
}

