namespace PE4
{
    partial class guessingGameAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "How quickly can you guess the random number?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "What number (0-100)?";
            // 
            // txtBxNumber
            // 
            this.txtBxNumber.Location = new System.Drawing.Point(383, 139);
            this.txtBxNumber.Name = "txtBxNumber";
            this.txtBxNumber.Size = new System.Drawing.Size(100, 35);
            this.txtBxNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guess Count:";
            // 
            // btnGuess
            // 
            this.btnGuess.ForeColor = System.Drawing.Color.Black;
            this.btnGuess.Location = new System.Drawing.Point(256, 319);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(122, 48);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(484, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 37);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(406, 246);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 27);
            this.lblCount.TabIndex = 6;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(72, 340);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(0, 27);
            this.lblDirections.TabIndex = 7;
            // 
            // guessingGameAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(613, 444);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "guessingGameAppForm";
            this.Text = "Guessing Game App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ForeColorChanged += new System.EventHandler(this.guessingGameAppForm_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDirections;
    }
}

