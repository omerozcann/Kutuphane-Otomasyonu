
namespace kutuphane
{
    partial class okurgirisFrm
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
            this.aditxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.okurlardgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.okurlardgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // aditxt
            // 
            this.aditxt.Location = new System.Drawing.Point(77, 25);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(151, 22);
            this.aditxt.TabIndex = 1;
            // 
            // teltxt
            // 
            this.teltxt.Location = new System.Drawing.Point(77, 53);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(151, 22);
            this.teltxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon";
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(77, 81);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(151, 22);
            this.epostatxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eposta";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(190, 120);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(109, 120);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 7;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // cikisbtn
            // 
            this.cikisbtn.Location = new System.Drawing.Point(28, 120);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(75, 23);
            this.cikisbtn.TabIndex = 8;
            this.cikisbtn.Text = "Çıkış";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // okurlardgv
            // 
            this.okurlardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.okurlardgv.Location = new System.Drawing.Point(12, 149);
            this.okurlardgv.Name = "okurlardgv";
            this.okurlardgv.RowHeadersWidth = 51;
            this.okurlardgv.RowTemplate.Height = 24;
            this.okurlardgv.Size = new System.Drawing.Size(253, 121);
            this.okurlardgv.TabIndex = 9;
            // 
            // okurgirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 282);
            this.Controls.Add(this.okurlardgv);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aditxt);
            this.Controls.Add(this.label1);
            this.Name = "okurgirisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okur Giriş Formu";
            this.Load += new System.EventHandler(this.okurgirisFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.okurlardgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aditxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.DataGridView okurlardgv;
    }
}