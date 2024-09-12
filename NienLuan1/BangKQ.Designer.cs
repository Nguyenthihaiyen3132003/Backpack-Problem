namespace NienLuan1
{
    partial class BangKQ
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbtlcl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbgtcl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(623, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trọng Lượng Còn Lại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Lbtlcl);
            this.panel1.Location = new System.Drawing.Point(564, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 159);
            this.panel1.TabIndex = 0;
            // 
            // Lbtlcl
            // 
            this.Lbtlcl.AutoSize = true;
            this.Lbtlcl.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbtlcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbtlcl.Location = new System.Drawing.Point(4, 30);
            this.Lbtlcl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbtlcl.Name = "Lbtlcl";
            this.Lbtlcl.Size = new System.Drawing.Size(98, 114);
            this.Lbtlcl.TabIndex = 0;
            this.Lbtlcl.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Lbgtcl);
            this.panel2.Location = new System.Drawing.Point(31, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 159);
            this.panel2.TabIndex = 0;
            // 
            // Lbgtcl
            // 
            this.Lbgtcl.AutoSize = true;
            this.Lbgtcl.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbgtcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbgtcl.Location = new System.Drawing.Point(4, 30);
            this.Lbgtcl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbgtcl.Name = "Lbgtcl";
            this.Lbgtcl.Size = new System.Drawing.Size(98, 114);
            this.Lbgtcl.TabIndex = 0;
            this.Lbgtcl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(87, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Giá Trị Lớn Nhất";
            // 
            // BangKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BangKQ";
            this.Size = new System.Drawing.Size(1105, 256);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbtlcl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbgtcl;
        private System.Windows.Forms.Label label2;
    }
}