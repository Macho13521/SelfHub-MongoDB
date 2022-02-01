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
            this.dodanylogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodanyemail = new System.Windows.Forms.TextBox();
            this.dodanywiek = new System.Windows.Forms.NumericUpDown();
            this.szukanepole = new System.Windows.Forms.TextBox();
            this.szukanawartosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.znalezioneID = new System.Windows.Forms.Label();
            this.aktualizowanepole = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.aktualizowanawartosc = new System.Windows.Forms.TextBox();
            this.znalezionylogin = new System.Windows.Forms.Label();
            this.znalezionehaslo = new System.Windows.Forms.Label();
            this.znalezionyemail = new System.Windows.Forms.Label();
            this.znalezionywiek = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dodanywiek)).BeginInit();
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
            // dodanylogin
            // 
            this.dodanylogin.Location = new System.Drawing.Point(136, 12);
            this.dodanylogin.Name = "dodanylogin";
            this.dodanylogin.Size = new System.Drawing.Size(100, 23);
            this.dodanylogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
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
            // dodanywiek
            // 
            this.dodanywiek.Location = new System.Drawing.Point(136, 95);
            this.dodanywiek.Name = "dodanywiek";
            this.dodanywiek.Size = new System.Drawing.Size(100, 23);
            this.dodanywiek.TabIndex = 9;
            // 
            // szukanepole
            // 
            this.szukanepole.Location = new System.Drawing.Point(328, 39);
            this.szukanepole.Name = "szukanepole";
            this.szukanepole.Size = new System.Drawing.Size(100, 23);
            this.szukanepole.TabIndex = 10;
            // 
            // szukanawartosc
            // 
            this.szukanawartosc.Location = new System.Drawing.Point(445, 39);
            this.szukanawartosc.Name = "szukanawartosc";
            this.szukanawartosc.Size = new System.Drawing.Size(100, 23);
            this.szukanawartosc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pole";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wartość";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "SzukajID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // znalezioneID
            // 
            this.znalezioneID.AutoSize = true;
            this.znalezioneID.Location = new System.Drawing.Point(575, 9);
            this.znalezioneID.Name = "znalezioneID";
            this.znalezioneID.Size = new System.Drawing.Size(18, 15);
            this.znalezioneID.TabIndex = 15;
            this.znalezioneID.Text = "ID";
            // 
            // aktualizowanepole
            // 
            this.aktualizowanepole.Location = new System.Drawing.Point(545, 201);
            this.aktualizowanepole.Name = "aktualizowanepole";
            this.aktualizowanepole.Size = new System.Drawing.Size(100, 23);
            this.aktualizowanepole.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Aktualizuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // aktualizowanawartosc
            // 
            this.aktualizowanawartosc.Location = new System.Drawing.Point(651, 201);
            this.aktualizowanawartosc.Name = "aktualizowanawartosc";
            this.aktualizowanawartosc.Size = new System.Drawing.Size(100, 23);
            this.aktualizowanawartosc.TabIndex = 25;
            // 
            // znalezionylogin
            // 
            this.znalezionylogin.AutoSize = true;
            this.znalezionylogin.Location = new System.Drawing.Point(575, 39);
            this.znalezionylogin.Name = "znalezionylogin";
            this.znalezionylogin.Size = new System.Drawing.Size(38, 15);
            this.znalezionylogin.TabIndex = 26;
            this.znalezionylogin.Text = "label7";
            // 
            // znalezionehaslo
            // 
            this.znalezionehaslo.AutoSize = true;
            this.znalezionehaslo.Location = new System.Drawing.Point(575, 62);
            this.znalezionehaslo.Name = "znalezionehaslo";
            this.znalezionehaslo.Size = new System.Drawing.Size(38, 15);
            this.znalezionehaslo.TabIndex = 27;
            this.znalezionehaslo.Text = "label7";
            // 
            // znalezionyemail
            // 
            this.znalezionyemail.AutoSize = true;
            this.znalezionyemail.Location = new System.Drawing.Point(575, 86);
            this.znalezionyemail.Name = "znalezionyemail";
            this.znalezionyemail.Size = new System.Drawing.Size(38, 15);
            this.znalezionyemail.TabIndex = 28;
            this.znalezionyemail.Text = "label7";
            // 
            // znalezionywiek
            // 
            this.znalezionywiek.AutoSize = true;
            this.znalezionywiek.Location = new System.Drawing.Point(575, 114);
            this.znalezionywiek.Name = "znalezionywiek";
            this.znalezionywiek.Size = new System.Drawing.Size(38, 15);
            this.znalezionywiek.TabIndex = 29;
            this.znalezionywiek.Text = "label7";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.znalezionywiek);
            this.Controls.Add(this.znalezionyemail);
            this.Controls.Add(this.znalezionehaslo);
            this.Controls.Add(this.znalezionylogin);
            this.Controls.Add(this.aktualizowanawartosc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.aktualizowanepole);
            this.Controls.Add(this.znalezioneID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.szukanawartosc);
            this.Controls.Add(this.szukanepole);
            this.Controls.Add(this.dodanywiek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodanyemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodanylogin);
            this.Controls.Add(this.dodanehaslo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dodanywiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox dodanehaslo;
        private TextBox dodanylogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dodanyemail;
        private NumericUpDown dodanywiek;
        private TextBox szukanepole;
        private TextBox szukanawartosc;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label znalezioneID;
        private TextBox aktualizowanepole;
        private Button button3;
        private TextBox aktualizowanawartosc;
        private Label znalezionylogin;
        private Label znalezionehaslo;
        private Label znalezionyemail;
        private Label znalezionywiek;
        private Button button4;
    }
}