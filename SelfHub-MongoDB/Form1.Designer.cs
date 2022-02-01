namespace SelfHub_MongoDB
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
            this.button1 = new System.Windows.Forms.Button();
            this.dodanehaslo = new System.Windows.Forms.TextBox();
            this.dodanynick = new System.Windows.Forms.TextBox();
            this.dodanywiek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodanyemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodanehaslo
            // 
            this.dodanehaslo.Location = new System.Drawing.Point(136, 54);
            this.dodanehaslo.Name = "dodanehaslo";
            this.dodanehaslo.Size = new System.Drawing.Size(100, 23);
            this.dodanehaslo.TabIndex = 1;
            // 
            // dodanynick
            // 
            this.dodanynick.Location = new System.Drawing.Point(136, 12);
            this.dodanynick.Name = "dodanynick";
            this.dodanynick.Size = new System.Drawing.Size(100, 23);
            this.dodanynick.TabIndex = 2;
            // 
            // dodanywiek
            // 
            this.dodanywiek.Location = new System.Drawing.Point(136, 92);
            this.dodanywiek.Name = "dodanywiek";
            this.dodanywiek.Size = new System.Drawing.Size(100, 23);
            this.dodanywiek.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // dodanyemail
            // 
            this.dodanyemail.Location = new System.Drawing.Point(136, 137);
            this.dodanyemail.Name = "dodanyemail";
            this.dodanyemail.Size = new System.Drawing.Size(100, 23);
            this.dodanyemail.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodanyemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodanywiek);
            this.Controls.Add(this.dodanynick);
            this.Controls.Add(this.dodanehaslo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox dodanehaslo;
        private TextBox dodanynick;
        private TextBox dodanywiek;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dodanyemail;
    }
}