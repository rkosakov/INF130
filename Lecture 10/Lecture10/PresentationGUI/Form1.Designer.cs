namespace PresentationGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxStudentSleep = new System.Windows.Forms.TextBox();
            this.txtBXPersonSleep = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sleep Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sleep Amount for most people";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(122, 44);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(116, 26);
            this.txtBxName.TabIndex = 5;
            // 
            // txtBxStudentSleep
            // 
            this.txtBxStudentSleep.Location = new System.Drawing.Point(317, 227);
            this.txtBxStudentSleep.Name = "txtBxStudentSleep";
            this.txtBxStudentSleep.Size = new System.Drawing.Size(132, 26);
            this.txtBxStudentSleep.TabIndex = 6;
            // 
            // txtBXPersonSleep
            // 
            this.txtBXPersonSleep.Location = new System.Drawing.Point(297, 290);
            this.txtBXPersonSleep.Name = "txtBXPersonSleep";
            this.txtBXPersonSleep.Size = new System.Drawing.Size(130, 26);
            this.txtBXPersonSleep.TabIndex = 7;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(122, 153);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(116, 26);
            this.txtBxID.TabIndex = 9;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(122, 95);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(116, 26);
            this.txtBxAge.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(191, 384);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 35);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show Student";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBXPersonSleep);
            this.Controls.Add(this.txtBxStudentSleep);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxStudentSleep;
        private System.Windows.Forms.TextBox txtBXPersonSleep;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.Button btnShow;
    }
}

