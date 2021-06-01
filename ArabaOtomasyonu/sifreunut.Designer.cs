namespace ArabaOtomasyonu
{
    partial class sifreunut
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreunut));
            this.kaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaill1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttekrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydet
            // 
            this.kaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet.ImageIndex = 1;
            this.kaydet.ImageList = this.ımageList1;
            this.kaydet.Location = new System.Drawing.Point(280, 329);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(129, 48);
            this.kaydet.TabIndex = 11;
            this.kaydet.Text = "Kaydet";
            this.kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.png");
            this.ımageList1.Images.SetKeyName(1, "indir-removebg-preview.png");
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtsifre.Location = new System.Drawing.Point(280, 191);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(189, 34);
            this.txtsifre.TabIndex = 9;
            // 
            // txtadi
            // 
            this.txtadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtadi.Location = new System.Drawing.Point(280, 75);
            this.txtadi.Multiline = true;
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(189, 34);
            this.txtadi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(205, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(190, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtmaill1
            // 
            this.txtmaill1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmaill1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtmaill1.Location = new System.Drawing.Point(280, 133);
            this.txtmaill1.Multiline = true;
            this.txtmaill1.Name = "txtmaill1";
            this.txtmaill1.Size = new System.Drawing.Size(189, 34);
            this.txtmaill1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(227, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-mail";
            // 
            // txttekrar
            // 
            this.txttekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttekrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttekrar.Location = new System.Drawing.Point(280, 257);
            this.txttekrar.Multiline = true;
            this.txttekrar.Name = "txttekrar";
            this.txttekrar.Size = new System.Drawing.Size(189, 34);
            this.txttekrar.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(159, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yeni Şifre Tekrar";
            // 
            // sifreunut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaill1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sifreunut";
            this.Text = "Şifremi unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaill1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttekrar;
        private System.Windows.Forms.Label label4;
    }
}