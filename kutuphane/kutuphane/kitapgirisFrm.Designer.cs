
namespace kutuphane
{
    partial class kitapgirisFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.kitapaditxt = new System.Windows.Forms.TextBox();
            this.yayinevitxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turucmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.kitaplardgv = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplardgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // kitapaditxt
            // 
            this.kitapaditxt.Location = new System.Drawing.Point(90, 25);
            this.kitapaditxt.Name = "kitapaditxt";
            this.kitapaditxt.Size = new System.Drawing.Size(174, 22);
            this.kitapaditxt.TabIndex = 1;
            // 
            // yayinevitxt
            // 
            this.yayinevitxt.Location = new System.Drawing.Point(90, 53);
            this.yayinevitxt.Name = "yayinevitxt";
            this.yayinevitxt.Size = new System.Drawing.Size(174, 22);
            this.yayinevitxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yayınevi";
            // 
            // turucmb
            // 
            this.turucmb.FormattingEnabled = true;
            this.turucmb.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Çizgi Roman",
            "Anı"});
            this.turucmb.Location = new System.Drawing.Point(90, 81);
            this.turucmb.Name = "turucmb";
            this.turucmb.Size = new System.Drawing.Size(174, 24);
            this.turucmb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Türü";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(189, 123);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // cikisbtn
            // 
            this.cikisbtn.Location = new System.Drawing.Point(26, 123);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(75, 23);
            this.cikisbtn.TabIndex = 7;
            this.cikisbtn.Text = "Çıkış";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // kitaplardgv
            // 
            this.kitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplardgv.Location = new System.Drawing.Point(12, 161);
            this.kitaplardgv.Name = "kitaplardgv";
            this.kitaplardgv.RowHeadersWidth = 51;
            this.kitaplardgv.RowTemplate.Height = 24;
            this.kitaplardgv.Size = new System.Drawing.Size(286, 171);
            this.kitaplardgv.TabIndex = 8;
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(108, 123);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 9;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // kitapgirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 344);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kitaplardgv);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turucmb);
            this.Controls.Add(this.yayinevitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapaditxt);
            this.Controls.Add(this.label1);
            this.Name = "kitapgirisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)(this.kitaplardgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapaditxt;
        private System.Windows.Forms.TextBox yayinevitxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turucmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.DataGridView kitaplardgv;
        private System.Windows.Forms.Button listelebtn;
    }
}