namespace WindowsFormsAppAPI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreturn_date = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtborrow_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudent_id = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 622);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(578, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(31, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(578, 502);
            this.txtOutput.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtreturn_date);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtborrow_date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtstudent_id);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.txtbookname);
            this.panel2.Location = new System.Drawing.Point(664, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 622);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Return Date:";
            // 
            // txtreturn_date
            // 
            this.txtreturn_date.Location = new System.Drawing.Point(149, 231);
            this.txtreturn_date.Multiline = true;
            this.txtreturn_date.Name = "txtreturn_date";
            this.txtreturn_date.Size = new System.Drawing.Size(460, 36);
            this.txtreturn_date.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(578, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "POST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrow Date:";
            // 
            // txtborrow_date
            // 
            this.txtborrow_date.Location = new System.Drawing.Point(149, 172);
            this.txtborrow_date.Multiline = true;
            this.txtborrow_date.Name = "txtborrow_date";
            this.txtborrow_date.Size = new System.Drawing.Size(460, 36);
            this.txtborrow_date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID:";
            // 
            // txtstudent_id
            // 
            this.txtstudent_id.Location = new System.Drawing.Point(149, 111);
            this.txtstudent_id.Multiline = true;
            this.txtstudent_id.Name = "txtstudent_id";
            this.txtstudent_id.Size = new System.Drawing.Size(460, 36);
            this.txtstudent_id.TabIndex = 2;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(26, 60);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(107, 25);
            this.user.TabIndex = 1;
            this.user.Text = "Book Name:";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(149, 49);
            this.txtbookname.Multiline = true;
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(460, 36);
            this.txtbookname.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtborrow_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudent_id;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtreturn_date;
        private System.Windows.Forms.Label label3;
    }
}

