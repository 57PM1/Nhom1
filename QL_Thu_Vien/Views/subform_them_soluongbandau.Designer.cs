namespace DoAnCNPM.Views
{
    partial class subform_them_soluongbandau
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
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_themsoluong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(263, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(64, 29);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vui lòng nhập số :";
            // 
            // txt_themsoluong
            // 
            this.txt_themsoluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_themsoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_themsoluong.Location = new System.Drawing.Point(171, 12);
            this.txt_themsoluong.Name = "txt_themsoluong";
            this.txt_themsoluong.Size = new System.Drawing.Size(73, 29);
            this.txt_themsoluong.TabIndex = 3;
            // 
            // subform_them_soluongbandau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 53);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_themsoluong);
            this.Name = "subform_them_soluongbandau";
            this.Text = "subform_them_soluongbandau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_themsoluong;
    }
}