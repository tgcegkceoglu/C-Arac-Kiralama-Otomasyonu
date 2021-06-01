namespace ArabaOtomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(120, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(167, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtadi
            // 
            this.txtadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtadi.Location = new System.Drawing.Point(218, 55);
            this.txtadi.Multiline = true;
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(189, 34);
            this.txtadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtsifre.Location = new System.Drawing.Point(218, 188);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(189, 34);
            this.txtsifre.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Gainsboro;
            this.btngiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiris.ImageKey = "login.png";
            this.btngiris.ImageList = this.ımageList1;
            this.btngiris.Location = new System.Drawing.Point(123, 252);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(128, 48);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.button1_Click);
            this.btngiris.MouseLeave += new System.EventHandler(this.btngiris_MouseLeave);
            this.btngiris.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            this.ımageList1.Images.SetKeyName(1, "user-login-5867.png");
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkayıtol.ImageKey = "user-login-5867.png";
            this.btnkayıtol.ImageList = this.ımageList1;
            this.btnkayıtol.Location = new System.Drawing.Point(268, 252);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(129, 48);
            this.btnkayıtol.TabIndex = 5;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkayıtol.UseVisualStyleBackColor = true;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            this.btnkayıtol.MouseLeave += new System.EventHandler(this.btnkayıtol_MouseLeave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(120, 327);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtmail
            // 
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtmail.Location = new System.Drawing.Point(218, 126);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(189, 34);
            this.txtmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(157, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-Mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 481);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label3;
    }
}

