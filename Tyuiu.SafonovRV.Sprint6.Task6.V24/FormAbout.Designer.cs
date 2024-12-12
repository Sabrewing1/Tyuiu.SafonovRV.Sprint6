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
            TextBoxInfo_SRV = new TextBox();
            ButtonOk_SRV = new Button();
            SuspendLayout();
            // 
            // TextBoxInfo_SRV
            // 
            TextBoxInfo_SRV.BackColor = SystemColors.Menu;
            TextBoxInfo_SRV.Location = new Point(0, 0);
            TextBoxInfo_SRV.Multiline = true;
            TextBoxInfo_SRV.Name = "TextBoxInfo_SRV";
            TextBoxInfo_SRV.Size = new Size(379, 188);
            TextBoxInfo_SRV.TabIndex = 0;
            TextBoxInfo_SRV.Text = resources.GetString("TextBoxInfo_SRV.Text");
            TextBoxInfo_SRV.TextChanged += TextBoxInfo_SRV_TextChanged;
            // 
            // ButtonOk_SRV
            // 
            ButtonOk_SRV.Location = new Point(285, 155);
            ButtonOk_SRV.Name = "ButtonOk_SRV";
            ButtonOk_SRV.Size = new Size(75, 23);
            ButtonOk_SRV.TabIndex = 1;
            ButtonOk_SRV.Text = "OK";
            ButtonOk_SRV.UseVisualStyleBackColor = true;
            ButtonOk_SRV.Click += ButtonOk_SRV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 199);
            Controls.Add(ButtonOk_SRV);
            Controls.Add(TextBoxInfo_SRV);
            Name = "FormAbout";
            Text = "о программе";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxInfo_SRV;
        private Button ButtonOk_SRV;
    }
}