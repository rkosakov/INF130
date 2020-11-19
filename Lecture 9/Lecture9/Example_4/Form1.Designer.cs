namespace Example_4
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblLeson = new System.Windows.Forms.Label();
            this.chBxSwim = new System.Windows.Forms.CheckBox();
            this.chBxSnorkel = new System.Windows.Forms.CheckBox();
            this.chBxDive = new System.Windows.Forms.CheckBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.groupBxLevel = new System.Windows.Forms.GroupBox();
            this.radBtnAdvanced = new System.Windows.Forms.RadioButton();
            this.radBtnIntermediate = new System.Windows.Forms.RadioButton();
            this.radBtnBeginner = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBxTotal = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBxLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(65, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(202, 43);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(271, 35);
            this.txtBxName.TabIndex = 1;
            // 
            // lblLeson
            // 
            this.lblLeson.AutoSize = true;
            this.lblLeson.ForeColor = System.Drawing.Color.Yellow;
            this.lblLeson.Location = new System.Drawing.Point(41, 115);
            this.lblLeson.Name = "lblLeson";
            this.lblLeson.Size = new System.Drawing.Size(165, 29);
            this.lblLeson.TabIndex = 2;
            this.lblLeson.Text = "Select Lesson";
            // 
            // chBxSwim
            // 
            this.chBxSwim.AutoSize = true;
            this.chBxSwim.ForeColor = System.Drawing.Color.Yellow;
            this.chBxSwim.Location = new System.Drawing.Point(46, 166);
            this.chBxSwim.Name = "chBxSwim";
            this.chBxSwim.Size = new System.Drawing.Size(158, 33);
            this.chBxSwim.TabIndex = 3;
            this.chBxSwim.Text = "Swim - $50";
            this.chBxSwim.UseVisualStyleBackColor = true;
            this.chBxSwim.Click += new System.EventHandler(this.CheckChanged);
            // 
            // chBxSnorkel
            // 
            this.chBxSnorkel.AutoSize = true;
            this.chBxSnorkel.ForeColor = System.Drawing.Color.Yellow;
            this.chBxSnorkel.Location = new System.Drawing.Point(46, 205);
            this.chBxSnorkel.Name = "chBxSnorkel";
            this.chBxSnorkel.Size = new System.Drawing.Size(181, 33);
            this.chBxSnorkel.TabIndex = 4;
            this.chBxSnorkel.Text = "Snorkel - $25";
            this.chBxSnorkel.UseVisualStyleBackColor = true;
            this.chBxSnorkel.Click += new System.EventHandler(this.CheckChanged);
            // 
            // chBxDive
            // 
            this.chBxDive.AutoSize = true;
            this.chBxDive.ForeColor = System.Drawing.Color.Yellow;
            this.chBxDive.Location = new System.Drawing.Point(48, 244);
            this.chBxDive.Name = "chBxDive";
            this.chBxDive.Size = new System.Drawing.Size(159, 33);
            this.chBxDive.TabIndex = 5;
            this.chBxDive.Text = "Dive - $100";
            this.chBxDive.UseVisualStyleBackColor = true;
            this.chBxDive.Click += new System.EventHandler(this.CheckChanged);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.Color.Yellow;
            this.lblDirections.Location = new System.Drawing.Point(41, 297);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(242, 29);
            this.lblDirections.TabIndex = 6;
            this.lblDirections.Text = "Check all that Apply";
            // 
            // groupBxLevel
            // 
            this.groupBxLevel.Controls.Add(this.radBtnAdvanced);
            this.groupBxLevel.Controls.Add(this.radBtnIntermediate);
            this.groupBxLevel.Controls.Add(this.radBtnBeginner);
            this.groupBxLevel.ForeColor = System.Drawing.Color.Yellow;
            this.groupBxLevel.Location = new System.Drawing.Point(300, 115);
            this.groupBxLevel.Name = "groupBxLevel";
            this.groupBxLevel.Size = new System.Drawing.Size(293, 174);
            this.groupBxLevel.TabIndex = 11;
            this.groupBxLevel.TabStop = false;
            this.groupBxLevel.Text = "Skill Level";
            // 
            // radBtnAdvanced
            // 
            this.radBtnAdvanced.AutoSize = true;
            this.radBtnAdvanced.Location = new System.Drawing.Point(23, 128);
            this.radBtnAdvanced.Name = "radBtnAdvanced";
            this.radBtnAdvanced.Size = new System.Drawing.Size(144, 33);
            this.radBtnAdvanced.TabIndex = 2;
            this.radBtnAdvanced.Text = "Advanced";
            this.radBtnAdvanced.UseVisualStyleBackColor = true;
            this.radBtnAdvanced.Click += new System.EventHandler(this.CheckChanged);
            // 
            // radBtnIntermediate
            // 
            this.radBtnIntermediate.AutoSize = true;
            this.radBtnIntermediate.Location = new System.Drawing.Point(23, 89);
            this.radBtnIntermediate.Name = "radBtnIntermediate";
            this.radBtnIntermediate.Size = new System.Drawing.Size(172, 33);
            this.radBtnIntermediate.TabIndex = 1;
            this.radBtnIntermediate.Text = "Intermediate";
            this.radBtnIntermediate.UseVisualStyleBackColor = true;
            this.radBtnIntermediate.Click += new System.EventHandler(this.CheckChanged);
            // 
            // radBtnBeginner
            // 
            this.radBtnBeginner.AutoSize = true;
            this.radBtnBeginner.Location = new System.Drawing.Point(23, 50);
            this.radBtnBeginner.Name = "radBtnBeginner";
            this.radBtnBeginner.Size = new System.Drawing.Size(136, 33);
            this.radBtnBeginner.TabIndex = 0;
            this.radBtnBeginner.Text = "Beginner";
            this.radBtnBeginner.UseVisualStyleBackColor = true;
            this.radBtnBeginner.Click += new System.EventHandler(this.CheckChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotal.Location = new System.Drawing.Point(43, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 29);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // txtBxTotal
            // 
            this.txtBxTotal.Enabled = false;
            this.txtBxTotal.ForeColor = System.Drawing.Color.Black;
            this.txtBxTotal.Location = new System.Drawing.Point(152, 378);
            this.txtBxTotal.Name = "txtBxTotal";
            this.txtBxTotal.Size = new System.Drawing.Size(131, 35);
            this.txtBxTotal.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lblInfo.Location = new System.Drawing.Point(355, 384);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 29);
            this.lblInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(652, 463);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBxLevel);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.chBxDive);
            this.Controls.Add(this.chBxSnorkel);
            this.Controls.Add(this.chBxSwim);
            this.Controls.Add(this.lblLeson);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.groupBxLevel.ResumeLayout(false);
            this.groupBxLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblLeson;
        private System.Windows.Forms.CheckBox chBxSwim;
        private System.Windows.Forms.CheckBox chBxSnorkel;
        private System.Windows.Forms.CheckBox chBxDive;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.GroupBox groupBxLevel;
        private System.Windows.Forms.RadioButton radBtnAdvanced;
        private System.Windows.Forms.RadioButton radBtnIntermediate;
        private System.Windows.Forms.RadioButton radBtnBeginner;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBxTotal;
        private System.Windows.Forms.Label lblInfo;
    }
}

