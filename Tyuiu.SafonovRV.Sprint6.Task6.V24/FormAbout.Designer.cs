namespace Tyuiu.SafonovRV.Sprint6.Task6.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.TextBoxInfo_SRV = new System.Windows.Forms.TextBox();
            this.ButtonOk_NVR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxInfo_SRV
            // 
            this.TextBoxInfo_SRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInfo_SRV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInfo_SRV.Location = new System.Drawing.Point(181, 12);
            this.TextBoxInfo_SRV.Multiline = true;
            this.TextBoxInfo_SRV.Name = "TextBoxInfo_SRV";
            this.TextBoxInfo_SRV.ReadOnly = true;
            this.TextBoxInfo_SRV.Size = new System.Drawing.Size(395, 250);
            this.TextBoxInfo_SRV.TabIndex = 0;
            this.TextBoxInfo_SRV.TabStop = false;
            this.TextBoxInfo_SRV.Text = resources.GetString("TextBoxInfo_SRV.Text");
            this.TextBoxInfo_SRV.TextChanged += new System.EventHandler(this.TextBoxInfo_NVR_TextChanged);
            // 
            // ButtonOk_NVR
            // 
            this.ButtonOk_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOk_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOk_NVR.Location = new System.Drawing.Point(492, 316);
            this.ButtonOk_NVR.Name = "ButtonOk_NVR";
            this.ButtonOk_NVR.Size = new System.Drawing.Size(96, 31);
            this.ButtonOk_NVR.TabIndex = 1;
            this.ButtonOk_NVR.Text = "Ок";
            this.ButtonOk_NVR.UseVisualStyleBackColor = false;
            this.ButtonOk_NVR.Click += new System.EventHandler(this.ButtonOk_NVR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.NasyrovaVR.Sprint6.Task6.V24.Properties.Resources.фотка;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 166);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonOk_NVR);
            this.Controls.Add(this.TextBoxInfo_SRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInfo_SRV;
        private System.Windows.Forms.Button ButtonOk_NVR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}