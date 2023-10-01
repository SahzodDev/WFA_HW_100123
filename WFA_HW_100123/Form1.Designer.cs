namespace WFA_HW_100123
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
            gbParametreler = new GroupBox();
            btnUret = new Button();
            txtSifreUzunlugu = new TextBox();
            txtSifreSayisi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            chkOzelKarakter = new CheckBox();
            chkRakam = new CheckBox();
            chkBuyukHarf = new CheckBox();
            chkKucukHarf = new CheckBox();
            lstSifreler = new ListBox();
            gbParametreler.SuspendLayout();
            SuspendLayout();
            // 
            // gbParametreler
            // 
            gbParametreler.Controls.Add(btnUret);
            gbParametreler.Controls.Add(txtSifreUzunlugu);
            gbParametreler.Controls.Add(txtSifreSayisi);
            gbParametreler.Controls.Add(label2);
            gbParametreler.Controls.Add(label1);
            gbParametreler.Controls.Add(chkOzelKarakter);
            gbParametreler.Controls.Add(chkRakam);
            gbParametreler.Controls.Add(chkBuyukHarf);
            gbParametreler.Controls.Add(chkKucukHarf);
            gbParametreler.Location = new Point(0, 0);
            gbParametreler.Name = "gbParametreler";
            gbParametreler.Size = new Size(533, 556);
            gbParametreler.TabIndex = 0;
            gbParametreler.TabStop = false;
            gbParametreler.Text = "PARAMETRELER";
            // 
            // btnUret
            // 
            btnUret.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUret.Location = new Point(187, 450);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(300, 85);
            btnUret.TabIndex = 9;
            btnUret.Text = "ÜRET";
            btnUret.UseVisualStyleBackColor = true;
            btnUret.Click += btnUret_Click;
            // 
            // txtSifreUzunlugu
            // 
            txtSifreUzunlugu.Location = new Point(187, 376);
            txtSifreUzunlugu.Name = "txtSifreUzunlugu";
            txtSifreUzunlugu.Size = new Size(300, 27);
            txtSifreUzunlugu.TabIndex = 7;
            // 
            // txtSifreSayisi
            // 
            txtSifreSayisi.Location = new Point(187, 318);
            txtSifreSayisi.Name = "txtSifreSayisi";
            txtSifreSayisi.Size = new Size(300, 27);
            txtSifreSayisi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 376);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 5;
            label2.Text = "Şifre Uzunluğu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 320);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 4;
            label1.Text = "Şifre Sayısı :";
            // 
            // chkOzelKarakter
            // 
            chkOzelKarakter.AutoSize = true;
            chkOzelKarakter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkOzelKarakter.Location = new Point(23, 212);
            chkOzelKarakter.Name = "chkOzelKarakter";
            chkOzelKarakter.Size = new Size(147, 29);
            chkOzelKarakter.TabIndex = 3;
            chkOzelKarakter.Text = "Özel Karakter";
            chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            chkRakam.AutoSize = true;
            chkRakam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkRakam.Location = new Point(23, 157);
            chkRakam.Name = "chkRakam";
            chkRakam.Size = new Size(90, 29);
            chkRakam.TabIndex = 2;
            chkRakam.Text = "Rakam";
            chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            chkBuyukHarf.AutoSize = true;
            chkBuyukHarf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkBuyukHarf.Location = new Point(23, 107);
            chkBuyukHarf.Name = "chkBuyukHarf";
            chkBuyukHarf.Size = new Size(126, 29);
            chkBuyukHarf.TabIndex = 1;
            chkBuyukHarf.Text = "Büyük Harf";
            chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            chkKucukHarf.AutoSize = true;
            chkKucukHarf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkKucukHarf.Location = new Point(23, 61);
            chkKucukHarf.Name = "chkKucukHarf";
            chkKucukHarf.Size = new Size(126, 29);
            chkKucukHarf.TabIndex = 0;
            chkKucukHarf.Text = "Küçük Harf";
            chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // lstSifreler
            // 
            lstSifreler.FormattingEnabled = true;
            lstSifreler.ItemHeight = 20;
            lstSifreler.Location = new Point(539, 12);
            lstSifreler.Name = "lstSifreler";
            lstSifreler.Size = new Size(455, 544);
            lstSifreler.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 563);
            Controls.Add(lstSifreler);
            Controls.Add(gbParametreler);
            Name = "Form1";
            Text = "Form1";
            gbParametreler.ResumeLayout(false);
            gbParametreler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametreler;
        private TextBox txtSifreUzunlugu;
        private TextBox txtSifreSayisi;
        private Label label2;
        private Label label1;
        private CheckBox chkOzelKarakter;
        private CheckBox chkRakam;
        private CheckBox chkBuyukHarf;
        private CheckBox chkKucukHarf;
        private ListBox lstSifreler;
        private Button btnUret;
    }
}