namespace chuong4_part1
{
    partial class FrmChaoMung
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.btnChaoMung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.Location = new System.Drawing.Point(156, 34);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(44, 24);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLop.Location = new System.Drawing.Point(156, 78);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(42, 24);
            this.lbLop.TabIndex = 3;
            this.lbLop.Text = "Lớp";
            // 
            // btnChaoMung
            // 
            this.btnChaoMung.Location = new System.Drawing.Point(235, 138);
            this.btnChaoMung.Name = "btnChaoMung";
            this.btnChaoMung.Size = new System.Drawing.Size(75, 23);
            this.btnChaoMung.TabIndex = 4;
            this.btnChaoMung.Text = "Chào Mừng";
            this.btnChaoMung.UseVisualStyleBackColor = true;
            this.btnChaoMung.Click += new System.EventHandler(this.btnChaoMung_Click);
            // 
            // FrmChaoMung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 243);
            this.Controls.Add(this.btnChaoMung);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmChaoMung";
            this.Text = "FrmChaoMung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Button btnChaoMung;
    }
}