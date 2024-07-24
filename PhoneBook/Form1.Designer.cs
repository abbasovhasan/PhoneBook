namespace PhoneBook
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
            grbSavePerson = new GroupBox();
            btnsave = new Button();
            txtSoyadi = new TextBox();
            txtTelefon = new TextBox();
            txtMail = new TextBox();
            txtAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.BackColor = SystemColors.ActiveCaption;
            grbSavePerson.Controls.Add(btnsave);
            grbSavePerson.Controls.Add(txtSoyadi);
            grbSavePerson.Controls.Add(txtTelefon);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(txtAdi);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Font = new Font("Segoe UI", 15F);
            grbSavePerson.Location = new Point(12, 12);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Size = new Size(420, 386);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            grbSavePerson.Text = "Kisi Ekle";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(127, 300);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(189, 52);
            btnsave.TabIndex = 5;
            btnsave.Text = "Kaydet";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += button1_Click;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(118, 131);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(210, 41);
            txtSoyadi.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(118, 187);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(210, 41);
            txtTelefon.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(118, 244);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(210, 41);
            txtMail.TabIndex = 4;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(118, 72);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(210, 41);
            txtAdi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 35);
            label4.TabIndex = 3;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 187);
            label3.Name = "label3";
            label3.Size = new Size(95, 35);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 131);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 1;
            label1.Text = "Soyadi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 35);
            label2.TabIndex = 0;
            label2.Text = "Adı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 684);
            Controls.Add(grbSavePerson);
            Name = "Form1";
            Text = "Form1";
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private TextBox txtSoyadi;
        private TextBox txtTelefon;
        private TextBox txtMail;
        private TextBox txtAdi;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnsave;
    }
}
