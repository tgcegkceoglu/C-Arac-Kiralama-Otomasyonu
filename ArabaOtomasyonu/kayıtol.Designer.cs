namespace ArabaOtomasyonu
{
    partial class Kayıtol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıtol));
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtadi1 = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre1 = new System.Windows.Forms.TextBox();
            this.txtmail1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkayıtol.ImageIndex = 0;
            this.btnkayıtol.ImageList = this.ımageList1;
            this.btnkayıtol.Location = new System.Drawing.Point(150, 275);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(149, 51);
            this.btnkayıtol.TabIndex = 13;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkayıtol.UseVisualStyleBackColor = true;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user-login-5867.png");
            // 
            // txtadi1
            // 
            this.txtadi1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadi1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtadi1.Location = new System.Drawing.Point(150, 83);
            this.txtadi1.Multiline = true;
            this.txtadi1.Name = "txtadi1";
            this.txtadi1.Size = new System.Drawing.Size(189, 34);
            this.txtadi1.TabIndex = 10;
            this.txtadi1.TextChanged += new System.EventHandler(this.txtadi1_TextChanged);
            // 
            // txtmail
            // 
            this.txtmail.AutoSize = true;
            this.txtmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtmail.Location = new System.Drawing.Point(91, 140);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(47, 17);
            this.txtmail.TabIndex = 9;
            this.txtmail.Text = "E-Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(376, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(91, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şifre";
            // 
            // txtsifre1
            // 
            this.txtsifre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtsifre1.Location = new System.Drawing.Point(150, 210);
            this.txtsifre1.Multiline = true;
            this.txtsifre1.Name = "txtsifre1";
            this.txtsifre1.Size = new System.Drawing.Size(189, 34);
            this.txtsifre1.TabIndex = 16;
            this.txtsifre1.TextChanged += new System.EventHandler(this.txtsifre1_TextChanged);
            // 
            // txtmail1
            // 
            this.txtmail1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtmail1.Location = new System.Drawing.Point(150, 140);
            this.txtmail1.Multiline = true;
            this.txtmail1.Name = "txtmail1";
            this.txtmail1.Size = new System.Drawing.Size(189, 34);
            this.txtmail1.TabIndex = 17;
            this.txtmail1.TextChanged += new System.EventHandler(this.txtmail1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kayıtol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 440);
            this.Controls.Add(this.txtmail1);
            this.Controls.Add(this.txtsifre1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.txtadi1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kayıtol";
            this.Text = "Kayıt Ol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtadi1;
        private System.Windows.Forms.Label txtmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre1;
        private System.Windows.Forms.TextBox txtmail1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}