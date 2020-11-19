namespace Example5
{
    partial class PizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePizza = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tabPageBeverages = new System.Windows.Forms.TabPage();
            this.tabPageSpeciality = new System.Windows.Forms.TabPage();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboSize = new System.Windows.Forms.ComboBox();
            this.cmboCrust = new System.Windows.Forms.ComboBox();
            this.lblBevTitle = new System.Windows.Forms.Label();
            this.lblSodaBev = new System.Windows.Forms.Label();
            this.lblWaterQuant = new System.Windows.Forms.Label();
            this.lblBevPrices = new System.Windows.Forms.Label();
            this.lblQuantBev = new System.Windows.Forms.Label();
            this.txtBxSodaQuant = new System.Windows.Forms.TextBox();
            this.txtBxWaterQuant = new System.Windows.Forms.TextBox();
            this.cmboSpec = new System.Windows.Forms.ComboBox();
            this.lblSpecTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageBeverages.SuspendLayout();
            this.tabPageSpeciality.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePizza);
            this.tabControl1.Controls.Add(this.tabPageBeverages);
            this.tabControl1.Controls.Add(this.tabPageSpeciality);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePizza
            // 
            this.tabPagePizza.Controls.Add(this.cmboCrust);
            this.tabPagePizza.Controls.Add(this.cmboSize);
            this.tabPagePizza.Controls.Add(this.label3);
            this.tabPagePizza.Controls.Add(this.lblSize);
            this.tabPagePizza.Controls.Add(this.lblToppings);
            this.tabPagePizza.Controls.Add(this.checkedListBox1);
            this.tabPagePizza.Controls.Add(this.pictureBox1);
            this.tabPagePizza.Controls.Add(this.lblTitle1);
            this.tabPagePizza.Location = new System.Drawing.Point(4, 29);
            this.tabPagePizza.Name = "tabPagePizza";
            this.tabPagePizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizza.Size = new System.Drawing.Size(580, 433);
            this.tabPagePizza.TabIndex = 0;
            this.tabPagePizza.Text = "Pizza";
            this.tabPagePizza.UseVisualStyleBackColor = true;
            this.tabPagePizza.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Peperoni",
            "Mushroom",
            "Green Pepper",
            "Olives",
            "Chicken",
            "Sausage",
            "Pineapple",
            "Extra Cheese",
            "Prosciutto",
            "Ham"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 264);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 142);
            this.checkedListBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 241);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(159, 16);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(189, 29);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Pizza Selections";
            // 
            // tabPageBeverages
            // 
            this.tabPageBeverages.Controls.Add(this.txtBxWaterQuant);
            this.tabPageBeverages.Controls.Add(this.txtBxSodaQuant);
            this.tabPageBeverages.Controls.Add(this.lblQuantBev);
            this.tabPageBeverages.Controls.Add(this.lblBevPrices);
            this.tabPageBeverages.Controls.Add(this.lblWaterQuant);
            this.tabPageBeverages.Controls.Add(this.lblSodaBev);
            this.tabPageBeverages.Controls.Add(this.lblBevTitle);
            this.tabPageBeverages.Location = new System.Drawing.Point(4, 29);
            this.tabPageBeverages.Name = "tabPageBeverages";
            this.tabPageBeverages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBeverages.Size = new System.Drawing.Size(580, 433);
            this.tabPageBeverages.TabIndex = 1;
            this.tabPageBeverages.Text = "Beverages";
            this.tabPageBeverages.UseVisualStyleBackColor = true;
            // 
            // tabPageSpeciality
            // 
            this.tabPageSpeciality.Controls.Add(this.lblSpecTitle);
            this.tabPageSpeciality.Controls.Add(this.cmboSpec);
            this.tabPageSpeciality.Location = new System.Drawing.Point(4, 29);
            this.tabPageSpeciality.Name = "tabPageSpeciality";
            this.tabPageSpeciality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpeciality.Size = new System.Drawing.Size(580, 433);
            this.tabPageSpeciality.TabIndex = 2;
            this.tabPageSpeciality.Text = "Speciality Items";
            this.tabPageSpeciality.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(224, 472);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(115, 40);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(22, 224);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(166, 20);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Toppings - $1.50 each";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(52, 77);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type of Crust";
            // 
            // cmboSize
            // 
            this.cmboSize.FormattingEnabled = true;
            this.cmboSize.Items.AddRange(new object[] {
            "Small (6\") - $6.50",
            "Medium (12\") - $12.95",
            "Large (24\") - $25.9"});
            this.cmboSize.Location = new System.Drawing.Point(17, 112);
            this.cmboSize.Name = "cmboSize";
            this.cmboSize.Size = new System.Drawing.Size(171, 28);
            this.cmboSize.TabIndex = 6;
            // 
            // cmboCrust
            // 
            this.cmboCrust.FormattingEnabled = true;
            this.cmboCrust.Items.AddRange(new object[] {
            "Thin & Crispy Crust",
            "Chicago style",
            "New York style",
            "Philadelphia crust"});
            this.cmboCrust.Location = new System.Drawing.Point(329, 112);
            this.cmboCrust.Name = "cmboCrust";
            this.cmboCrust.Size = new System.Drawing.Size(157, 28);
            this.cmboCrust.TabIndex = 7;
            // 
            // lblBevTitle
            // 
            this.lblBevTitle.AutoSize = true;
            this.lblBevTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBevTitle.Location = new System.Drawing.Point(189, 25);
            this.lblBevTitle.Name = "lblBevTitle";
            this.lblBevTitle.Size = new System.Drawing.Size(204, 29);
            this.lblBevTitle.TabIndex = 0;
            this.lblBevTitle.Text = "Drink Selections";
            // 
            // lblSodaBev
            // 
            this.lblSodaBev.AutoSize = true;
            this.lblSodaBev.Location = new System.Drawing.Point(190, 150);
            this.lblSodaBev.Name = "lblSodaBev";
            this.lblSodaBev.Size = new System.Drawing.Size(51, 20);
            this.lblSodaBev.TabIndex = 1;
            this.lblSodaBev.Text = "Soda:";
            // 
            // lblWaterQuant
            // 
            this.lblWaterQuant.AutoSize = true;
            this.lblWaterQuant.Location = new System.Drawing.Point(190, 277);
            this.lblWaterQuant.Name = "lblWaterQuant";
            this.lblWaterQuant.Size = new System.Drawing.Size(56, 20);
            this.lblWaterQuant.TabIndex = 2;
            this.lblWaterQuant.Text = "Water:";
            // 
            // lblBevPrices
            // 
            this.lblBevPrices.AutoSize = true;
            this.lblBevPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBevPrices.Location = new System.Drawing.Point(117, 357);
            this.lblBevPrices.Name = "lblBevPrices";
            this.lblBevPrices.Size = new System.Drawing.Size(390, 29);
            this.lblBevPrices.TabIndex = 3;
            this.lblBevPrices.Text = "Soda costs $1.75 - Water is free!";
            // 
            // lblQuantBev
            // 
            this.lblQuantBev.AutoSize = true;
            this.lblQuantBev.Location = new System.Drawing.Point(342, 99);
            this.lblQuantBev.Name = "lblQuantBev";
            this.lblQuantBev.Size = new System.Drawing.Size(68, 20);
            this.lblQuantBev.TabIndex = 4;
            this.lblQuantBev.Text = "Quantity";
            // 
            // txtBxSodaQuant
            // 
            this.txtBxSodaQuant.Location = new System.Drawing.Point(325, 147);
            this.txtBxSodaQuant.Name = "txtBxSodaQuant";
            this.txtBxSodaQuant.Size = new System.Drawing.Size(100, 26);
            this.txtBxSodaQuant.TabIndex = 5;
            // 
            // txtBxWaterQuant
            // 
            this.txtBxWaterQuant.Location = new System.Drawing.Point(325, 271);
            this.txtBxWaterQuant.Name = "txtBxWaterQuant";
            this.txtBxWaterQuant.Size = new System.Drawing.Size(100, 26);
            this.txtBxWaterQuant.TabIndex = 6;
            // 
            // cmboSpec
            // 
            this.cmboSpec.FormattingEnabled = true;
            this.cmboSpec.Items.AddRange(new object[] {
            "Wings - $5.00",
            "Cheese sticks - $4.00",
            "Garlic Bread - $3.00"});
            this.cmboSpec.Location = new System.Drawing.Point(214, 106);
            this.cmboSpec.Name = "cmboSpec";
            this.cmboSpec.Size = new System.Drawing.Size(121, 28);
            this.cmboSpec.TabIndex = 0;
            // 
            // lblSpecTitle
            // 
            this.lblSpecTitle.AutoSize = true;
            this.lblSpecTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecTitle.Location = new System.Drawing.Point(175, 15);
            this.lblSpecTitle.Name = "lblSpecTitle";
            this.lblSpecTitle.Size = new System.Drawing.Size(197, 29);
            this.lblSpecTitle.TabIndex = 1;
            this.lblSpecTitle.Text = "Speciality Items";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 524);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tabControl1);
            this.Name = "PizzaForm";
            this.Text = "B & D Pizza Express";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePizza.ResumeLayout(false);
            this.tabPagePizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageBeverages.ResumeLayout(false);
            this.tabPageBeverages.PerformLayout();
            this.tabPageSpeciality.ResumeLayout(false);
            this.tabPageSpeciality.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePizza;
        private System.Windows.Forms.TabPage tabPageBeverages;
        private System.Windows.Forms.TabPage tabPageSpeciality;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmboCrust;
        private System.Windows.Forms.ComboBox cmboSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.TextBox txtBxWaterQuant;
        private System.Windows.Forms.TextBox txtBxSodaQuant;
        private System.Windows.Forms.Label lblQuantBev;
        private System.Windows.Forms.Label lblBevPrices;
        private System.Windows.Forms.Label lblWaterQuant;
        private System.Windows.Forms.Label lblSodaBev;
        private System.Windows.Forms.Label lblBevTitle;
        private System.Windows.Forms.Label lblSpecTitle;
        private System.Windows.Forms.ComboBox cmboSpec;
    }
}

