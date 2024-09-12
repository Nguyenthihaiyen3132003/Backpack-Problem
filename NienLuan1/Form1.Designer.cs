using NienLuan1.Properties;
using System.Resources;

namespace NienLuan1
{
    partial class Form1
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
            this.PnNhap = new System.Windows.Forms.Panel();
            this.Nudtl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnXong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuddv = new System.Windows.Forms.NumericUpDown();
            this.BtnTinh = new System.Windows.Forms.Button();
            this.PnXuat = new System.Windows.Forms.FlowLayoutPanel();
            this.PnNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuddv)).BeginInit();
            this.SuspendLayout();
            // 
            // PnNhap
            // 
            this.PnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnNhap.Controls.Add(this.Nudtl);
            this.PnNhap.Controls.Add(this.label2);
            this.PnNhap.Controls.Add(this.BtnXong);
            this.PnNhap.Controls.Add(this.label1);
            this.PnNhap.Controls.Add(this.Nuddv);
            this.PnNhap.Controls.Add(this.BtnTinh);
            this.PnNhap.Location = new System.Drawing.Point(-4, 0);
            this.PnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.PnNhap.Name = "PnNhap";
            this.PnNhap.Size = new System.Drawing.Size(443, 758);
            this.PnNhap.TabIndex = 0;
            // 
            // Nudtl
            // 
            this.Nudtl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nudtl.Location = new System.Drawing.Point(332, 123);
            this.Nudtl.Margin = new System.Windows.Forms.Padding(4);
            this.Nudtl.Name = "Nudtl";
            this.Nudtl.Size = new System.Drawing.Size(104, 38);
            this.Nudtl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trọng Lượng Balo";
            // 
            // BtnXong
            // 
            this.BtnXong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnXong.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnXong.Location = new System.Drawing.Point(4, 260);
            this.BtnXong.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXong.Name = "BtnXong";
            this.BtnXong.Size = new System.Drawing.Size(435, 79);
            this.BtnXong.TabIndex = 3;
            this.BtnXong.Text = "Xong";
            this.BtnXong.UseVisualStyleBackColor = false;
            this.BtnXong.Click += new System.EventHandler(this.BtnXong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Loại Đồ Vật";
            // 
            // Nuddv
            // 
            this.Nuddv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nuddv.Location = new System.Drawing.Point(335, 37);
            this.Nuddv.Margin = new System.Windows.Forms.Padding(4);
            this.Nuddv.Name = "Nuddv";
            this.Nuddv.Size = new System.Drawing.Size(104, 38);
            this.Nuddv.TabIndex = 2;
            // 
            // BtnTinh
            // 
            this.BtnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTinh.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnTinh.Location = new System.Drawing.Point(4, 358);
            this.BtnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTinh.Name = "BtnTinh";
            this.BtnTinh.Size = new System.Drawing.Size(435, 75);
            this.BtnTinh.TabIndex = 5;
            this.BtnTinh.Text = "Tính ";
            this.BtnTinh.UseVisualStyleBackColor = false;
            this.BtnTinh.Click += new System.EventHandler(this.BtnTinh_Click);
            // 
            // PnXuat
            // 
            this.PnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnXuat.AutoScroll = true;
            this.PnXuat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PnXuat.Location = new System.Drawing.Point(441, 0);
            this.PnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnXuat.Name = "PnXuat";
            this.PnXuat.Size = new System.Drawing.Size(1172, 758);
            this.PnXuat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 762);
            this.Controls.Add(this.PnXuat);
            this.Controls.Add(this.PnNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Niên Luận 1";
            this.PnNhap.ResumeLayout(false);
            this.PnNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuddv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nuddv;
        private System.Windows.Forms.Button BtnTinh;
        private System.Windows.Forms.Button BtnXong;
        private System.Windows.Forms.NumericUpDown Nudtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel PnXuat;
    }
}