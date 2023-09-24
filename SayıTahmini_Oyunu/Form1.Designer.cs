namespace SayıTahmini_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.txt_tahmin = new System.Windows.Forms.TextBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmininizi Giriniz :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "5";
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tahmin.Location = new System.Drawing.Point(201, 154);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(144, 46);
            this.btn_tahmin.TabIndex = 1;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = false;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // txt_tahmin
            // 
            this.txt_tahmin.Location = new System.Drawing.Point(201, 52);
            this.txt_tahmin.Name = "txt_tahmin";
            this.txt_tahmin.Size = new System.Drawing.Size(144, 30);
            this.txt_tahmin.TabIndex = 2;
            // 
            // btn_baslat
            // 
            this.btn_baslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_baslat.Location = new System.Drawing.Point(201, 212);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(144, 46);
            this.btn_baslat.TabIndex = 1;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = false;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tahmininiz 1 ile 10 arasında olmalıdır !!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tahmin);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.btn_tahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.TextBox txt_tahmin;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

