
namespace A_Star_Algoritmasi
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
			this.button_Uret_Coz = new System.Windows.Forms.Button();
			this.label_Kontrol = new System.Windows.Forms.Label();
			this.label_Baslangic_Durumu = new System.Windows.Forms.Label();
			this.label_Bitis_Durumu = new System.Windows.Forms.Label();
			this.textBox_Adimlar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Uret_Coz
			// 
			this.button_Uret_Coz.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_Uret_Coz.ForeColor = System.Drawing.Color.Black;
			this.button_Uret_Coz.Location = new System.Drawing.Point(228, 511);
			this.button_Uret_Coz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_Uret_Coz.Name = "button_Uret_Coz";
			this.button_Uret_Coz.Size = new System.Drawing.Size(431, 134);
			this.button_Uret_Coz.TabIndex = 2;
			this.button_Uret_Coz.Text = "Üret ve Çöz";
			this.button_Uret_Coz.UseVisualStyleBackColor = false;
			this.button_Uret_Coz.Click += new System.EventHandler(this.button_Uret_Click_1);
			// 
			// label_Kontrol
			// 
			this.label_Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Kontrol.ForeColor = System.Drawing.Color.Black;
			this.label_Kontrol.Location = new System.Drawing.Point(246, 18);
			this.label_Kontrol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Kontrol.Name = "label_Kontrol";
			this.label_Kontrol.Size = new System.Drawing.Size(364, 60);
			this.label_Kontrol.TabIndex = 4;
			this.label_Kontrol.Text = "Hoşgeldiniz";
			this.label_Kontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Baslangic_Durumu
			// 
			this.label_Baslangic_Durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Baslangic_Durumu.Location = new System.Drawing.Point(8, 46);
			this.label_Baslangic_Durumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Baslangic_Durumu.Name = "label_Baslangic_Durumu";
			this.label_Baslangic_Durumu.Size = new System.Drawing.Size(187, 357);
			this.label_Baslangic_Durumu.TabIndex = 6;
			// 
			// label_Bitis_Durumu
			// 
			this.label_Bitis_Durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Bitis_Durumu.Location = new System.Drawing.Point(8, 46);
			this.label_Bitis_Durumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Bitis_Durumu.Name = "label_Bitis_Durumu";
			this.label_Bitis_Durumu.Size = new System.Drawing.Size(187, 357);
			this.label_Bitis_Durumu.TabIndex = 6;
			// 
			// textBox_Adimlar
			// 
			this.textBox_Adimlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Adimlar.Location = new System.Drawing.Point(825, 78);
			this.textBox_Adimlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_Adimlar.Multiline = true;
			this.textBox_Adimlar.Name = "textBox_Adimlar";
			this.textBox_Adimlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_Adimlar.Size = new System.Drawing.Size(190, 554);
			this.textBox_Adimlar.TabIndex = 7;
			this.textBox_Adimlar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(827, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 65);
			this.label2.TabIndex = 8;
			this.label2.Text = "Adımlar";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_Baslangic_Durumu);
			this.groupBox1.Location = new System.Drawing.Point(179, 93);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(203, 408);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Başlangıç Durumu";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label_Bitis_Durumu);
			this.groupBox2.Location = new System.Drawing.Point(498, 93);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(203, 408);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hedef Durum";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 646);
			this.Controls.Add(this.label_Kontrol);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button_Uret_Coz);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_Adimlar);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1046, 693);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1046, 693);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " 8 Taş Oyunu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Uret_Coz;
        private System.Windows.Forms.Label label_Kontrol;
        private System.Windows.Forms.Label label_Baslangic_Durumu;
        private System.Windows.Forms.Label label_Bitis_Durumu;
        private System.Windows.Forms.TextBox textBox_Adimlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

