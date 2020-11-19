namespace Example2
{
    partial class ClubForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.lstBoxEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(72, 568);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(183, 46);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Add new one";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.FormattingEnabled = true;
            this.lstBoxEvents.ItemHeight = 29;
            this.lstBoxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Bike",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Movie",
            "Sport event"});
            this.lstBoxEvents.Location = new System.Drawing.Point(55, 108);
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxEvents.Size = new System.Drawing.Size(239, 178);
            this.lstBoxEvents.Sorted = true;
            this.lstBoxEvents.TabIndex = 1;
            this.lstBoxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBoxEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select event(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add an activity";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(138, 421);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(301, 35);
            this.txtBoxResult.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 579);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 6;
            // 
            // ClubForm
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(451, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxEvents);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClubForm";
            this.Text = "Computer Club outing sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}

