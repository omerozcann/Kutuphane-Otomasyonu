
namespace kutuphane
{
    partial class kutuphaneFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.okurgirbtn = new System.Windows.Forms.Button();
            this.kitapgirbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.teslimbtn = new System.Windows.Forms.Button();
            this.oduncverdgv = new System.Windows.Forms.DataGridView();
            this.oduncverbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisdtp = new System.Windows.Forms.DateTimePicker();
            this.basladtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.okurlardgv = new System.Windows.Forms.DataGridView();
            this.okurarabtn = new System.Windows.Forms.Button();
            this.okuraratxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kitaplardgv = new System.Windows.Forms.DataGridView();
            this.kitaparabtn = new System.Windows.Forms.Button();
            this.kitaparatxt = new System.Windows.Forms.TextBox();
            this.odunclistelebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncverdgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okurlardgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplardgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cikisbtn);
            this.groupBox1.Controls.Add(this.okurgirbtn);
            this.groupBox1.Controls.Add(this.kitapgirbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontroller";
            // 
            // cikisbtn
            // 
            this.cikisbtn.Location = new System.Drawing.Point(12, 32);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(89, 26);
            this.cikisbtn.TabIndex = 2;
            this.cikisbtn.Text = "Çıkış";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // okurgirbtn
            // 
            this.okurgirbtn.Location = new System.Drawing.Point(218, 32);
            this.okurgirbtn.Name = "okurgirbtn";
            this.okurgirbtn.Size = new System.Drawing.Size(89, 26);
            this.okurgirbtn.TabIndex = 1;
            this.okurgirbtn.Text = "Okur Girişi";
            this.okurgirbtn.UseVisualStyleBackColor = true;
            this.okurgirbtn.Click += new System.EventHandler(this.okurgirbtn_Click);
            // 
            // kitapgirbtn
            // 
            this.kitapgirbtn.Location = new System.Drawing.Point(114, 32);
            this.kitapgirbtn.Name = "kitapgirbtn";
            this.kitapgirbtn.Size = new System.Drawing.Size(89, 26);
            this.kitapgirbtn.TabIndex = 0;
            this.kitapgirbtn.Text = "Kitap Girişi";
            this.kitapgirbtn.UseVisualStyleBackColor = true;
            this.kitapgirbtn.Click += new System.EventHandler(this.kitapgirbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Verme";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.odunclistelebtn);
            this.groupBox5.Controls.Add(this.teslimbtn);
            this.groupBox5.Controls.Add(this.oduncverdgv);
            this.groupBox5.Controls.Add(this.oduncverbtn);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.bitisdtp);
            this.groupBox5.Controls.Add(this.basladtp);
            this.groupBox5.Location = new System.Drawing.Point(418, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 342);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ödünç Ver";
            // 
            // teslimbtn
            // 
            this.teslimbtn.Location = new System.Drawing.Point(137, 97);
            this.teslimbtn.Name = "teslimbtn";
            this.teslimbtn.Size = new System.Drawing.Size(89, 23);
            this.teslimbtn.TabIndex = 5;
            this.teslimbtn.Text = "Teslim Et";
            this.teslimbtn.UseVisualStyleBackColor = true;
            this.teslimbtn.Click += new System.EventHandler(this.teslimbtn_Click);
            // 
            // oduncverdgv
            // 
            this.oduncverdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncverdgv.Location = new System.Drawing.Point(6, 137);
            this.oduncverdgv.Name = "oduncverdgv";
            this.oduncverdgv.RowHeadersWidth = 51;
            this.oduncverdgv.RowTemplate.Height = 24;
            this.oduncverdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oduncverdgv.Size = new System.Drawing.Size(337, 199);
            this.oduncverdgv.TabIndex = 4;
            // 
            // oduncverbtn
            // 
            this.oduncverbtn.Location = new System.Drawing.Point(232, 97);
            this.oduncverbtn.Name = "oduncverbtn";
            this.oduncverbtn.Size = new System.Drawing.Size(89, 23);
            this.oduncverbtn.TabIndex = 4;
            this.oduncverbtn.Text = "Ödünç Ver";
            this.oduncverbtn.UseVisualStyleBackColor = true;
            this.oduncverbtn.Click += new System.EventHandler(this.oduncverbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç:";
            // 
            // bitisdtp
            // 
            this.bitisdtp.Location = new System.Drawing.Point(121, 58);
            this.bitisdtp.Name = "bitisdtp";
            this.bitisdtp.Size = new System.Drawing.Size(200, 22);
            this.bitisdtp.TabIndex = 1;
            // 
            // basladtp
            // 
            this.basladtp.Location = new System.Drawing.Point(121, 30);
            this.basladtp.Name = "basladtp";
            this.basladtp.Size = new System.Drawing.Size(200, 22);
            this.basladtp.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.okurlardgv);
            this.groupBox4.Controls.Add(this.okurarabtn);
            this.groupBox4.Controls.Add(this.okuraratxt);
            this.groupBox4.Location = new System.Drawing.Point(212, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 342);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Okurlar";
            // 
            // okurlardgv
            // 
            this.okurlardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.okurlardgv.Location = new System.Drawing.Point(6, 68);
            this.okurlardgv.Name = "okurlardgv";
            this.okurlardgv.RowHeadersWidth = 51;
            this.okurlardgv.RowTemplate.Height = 24;
            this.okurlardgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.okurlardgv.Size = new System.Drawing.Size(188, 268);
            this.okurlardgv.TabIndex = 3;
            // 
            // okurarabtn
            // 
            this.okurarabtn.Location = new System.Drawing.Point(140, 30);
            this.okurarabtn.Name = "okurarabtn";
            this.okurarabtn.Size = new System.Drawing.Size(44, 23);
            this.okurarabtn.TabIndex = 2;
            this.okurarabtn.Text = "Ara";
            this.okurarabtn.UseVisualStyleBackColor = true;
            this.okurarabtn.Click += new System.EventHandler(this.okurarabtn_Click);
            // 
            // okuraratxt
            // 
            this.okuraratxt.Location = new System.Drawing.Point(6, 31);
            this.okuraratxt.Name = "okuraratxt";
            this.okuraratxt.Size = new System.Drawing.Size(128, 22);
            this.okuraratxt.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kitaplardgv);
            this.groupBox3.Controls.Add(this.kitaparabtn);
            this.groupBox3.Controls.Add(this.kitaparatxt);
            this.groupBox3.Location = new System.Drawing.Point(6, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 342);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitaplar";
            // 
            // kitaplardgv
            // 
            this.kitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplardgv.Location = new System.Drawing.Point(6, 68);
            this.kitaplardgv.MultiSelect = false;
            this.kitaplardgv.Name = "kitaplardgv";
            this.kitaplardgv.RowHeadersWidth = 51;
            this.kitaplardgv.RowTemplate.Height = 24;
            this.kitaplardgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kitaplardgv.Size = new System.Drawing.Size(188, 268);
            this.kitaplardgv.TabIndex = 3;
            // 
            // kitaparabtn
            // 
            this.kitaparabtn.Location = new System.Drawing.Point(140, 30);
            this.kitaparabtn.Name = "kitaparabtn";
            this.kitaparabtn.Size = new System.Drawing.Size(44, 23);
            this.kitaparabtn.TabIndex = 2;
            this.kitaparabtn.Text = "Ara";
            this.kitaparabtn.UseVisualStyleBackColor = true;
            this.kitaparabtn.Click += new System.EventHandler(this.kitaparabtn_Click);
            // 
            // kitaparatxt
            // 
            this.kitaparatxt.Location = new System.Drawing.Point(6, 31);
            this.kitaparatxt.Name = "kitaparatxt";
            this.kitaparatxt.Size = new System.Drawing.Size(128, 22);
            this.kitaparatxt.TabIndex = 1;
            // 
            // odunclistelebtn
            // 
            this.odunclistelebtn.Location = new System.Drawing.Point(42, 97);
            this.odunclistelebtn.Name = "odunclistelebtn";
            this.odunclistelebtn.Size = new System.Drawing.Size(89, 23);
            this.odunclistelebtn.TabIndex = 6;
            this.odunclistelebtn.Text = "Listele";
            this.odunclistelebtn.UseVisualStyleBackColor = true;
            this.odunclistelebtn.Click += new System.EventHandler(this.odunclistelebtn_Click);
            // 
            // kutuphaneFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "kutuphaneFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncverdgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okurlardgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplardgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button okurgirbtn;
        private System.Windows.Forms.Button kitapgirbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView kitaplardgv;
        private System.Windows.Forms.Button kitaparabtn;
        private System.Windows.Forms.TextBox kitaparatxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView okurlardgv;
        private System.Windows.Forms.Button okurarabtn;
        private System.Windows.Forms.TextBox okuraratxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisdtp;
        private System.Windows.Forms.DateTimePicker basladtp;
        private System.Windows.Forms.Button oduncverbtn;
        private System.Windows.Forms.DataGridView oduncverdgv;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.Button teslimbtn;
        private System.Windows.Forms.Button odunclistelebtn;
    }
}

