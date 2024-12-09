namespace Tyuiu.NasyrovaVR.Sprint6.Task6.V24
{
    partial class FormMain_SRV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SRV));
            this.PanelTop_SRV = new System.Windows.Forms.Panel();
            this.ButtonInfo_SRV = new System.Windows.Forms.Button();
            this.ButtonDone_SRV = new System.Windows.Forms.Button();
            this.ButtonOpen_SRV = new System.Windows.Forms.Button();
            this.PanelTask_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxTask_SRV = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_SRV = new System.Windows.Forms.TextBox();
            this.PanelLeft_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxInput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxInput_SRV = new System.Windows.Forms.TextBox();
            this.PanelFill_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxOutput_SRV = new System.Windows.Forms.TextBox();
            this.Splitter_NVR = new System.Windows.Forms.Splitter();
            this.OpenFileDialog_NVR = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.PanelTop_SRV.SuspendLayout();
            this.PanelTask_NVR.SuspendLayout();
            this.GroupBoxTask_SRV.SuspendLayout();
            this.PanelLeft_NVR.SuspendLayout();
            this.GroupBoxInput_NVR.SuspendLayout();
            this.PanelFill_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop_SRV
            // 
            this.PanelTop_SRV.Controls.Add(this.ButtonInfo_SRV);
            this.PanelTop_SRV.Controls.Add(this.ButtonDone_SRV);
            this.PanelTop_SRV.Controls.Add(this.ButtonOpen_SRV);
            this.PanelTop_SRV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_SRV.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_SRV.Name = "PanelTop_SRV";
            this.PanelTop_SRV.Size = new System.Drawing.Size(834, 94);
            this.PanelTop_SRV.TabIndex = 0;
            // 
            // ButtonInfo_SRV
            // 
            this.ButtonInfo_SRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_SRV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonInfo_SRV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_SRV.BackgroundImage")));
            this.ButtonInfo_SRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_SRV.Location = new System.Drawing.Point(719, 12);
            this.ButtonInfo_SRV.Name = "ButtonInfo_SRV";
            this.ButtonInfo_SRV.Size = new System.Drawing.Size(103, 76);
            this.ButtonInfo_SRV.TabIndex = 2;
            this.ToolTip_NVR.SetToolTip(this.ButtonInfo_SRV, "Сведения о программе");
            this.ButtonInfo_SRV.UseVisualStyleBackColor = false;
            this.ButtonInfo_SRV.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonDone_SRV
            // 
            this.ButtonDone_SRV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDone_SRV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDone_SRV.BackgroundImage")));
            this.ButtonDone_SRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDone_SRV.Location = new System.Drawing.Point(114, 12);
            this.ButtonDone_SRV.Name = "ButtonDone_SRV";
            this.ButtonDone_SRV.Size = new System.Drawing.Size(99, 76);
            this.ButtonDone_SRV.TabIndex = 1;
            this.ToolTip_NVR.SetToolTip(this.ButtonDone_SRV, "Выводит первое слово каждой строки в результирующею строку");
            this.ButtonDone_SRV.UseVisualStyleBackColor = false;
            this.ButtonDone_SRV.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            // 
            // ButtonOpen_SRV
            // 
            this.ButtonOpen_SRV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOpen_SRV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_SRV.BackgroundImage")));
            this.ButtonOpen_SRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_SRV.Location = new System.Drawing.Point(12, 12);
            this.ButtonOpen_SRV.Name = "ButtonOpen_SRV";
            this.ButtonOpen_SRV.Size = new System.Drawing.Size(96, 76);
            this.ButtonOpen_SRV.TabIndex = 0;
            this.ToolTip_NVR.SetToolTip(this.ButtonOpen_SRV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.ButtonOpen_SRV.UseVisualStyleBackColor = false;
            this.ButtonOpen_SRV.Click += new System.EventHandler(this.ButtonOpen_NVR_Click);
            // 
            // PanelTask_NVR
            // 
            this.PanelTask_NVR.Controls.Add(this.GroupBoxTask_SRV);
            this.PanelTask_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTask_NVR.Location = new System.Drawing.Point(0, 94);
            this.PanelTask_NVR.Name = "PanelTask_NVR";
            this.PanelTask_NVR.Size = new System.Drawing.Size(834, 100);
            this.PanelTask_NVR.TabIndex = 1;
            // 
            // GroupBoxTask_SRV
            // 
            this.GroupBoxTask_SRV.Controls.Add(this.TextBoxTask_SRV);
            this.GroupBoxTask_SRV.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxTask_SRV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_SRV.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxTask_SRV.Name = "GroupBoxTask_SRV";
            this.GroupBoxTask_SRV.Size = new System.Drawing.Size(834, 100);
            this.GroupBoxTask_SRV.TabIndex = 0;
            this.GroupBoxTask_SRV.TabStop = false;
            this.GroupBoxTask_SRV.Text = "Условие";
            // 
            // TextBoxTask_SRV
            // 
            this.TextBoxTask_SRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_SRV.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxTask_SRV.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_SRV.Location = new System.Drawing.Point(3, 22);
            this.TextBoxTask_SRV.Multiline = true;
            this.TextBoxTask_SRV.Name = "TextBoxTask_SRV";
            this.TextBoxTask_SRV.ReadOnly = true;
            this.TextBoxTask_SRV.Size = new System.Drawing.Size(828, 61);
            this.TextBoxTask_SRV.TabIndex = 0;
            this.TextBoxTask_SRV.TabStop = false;
            this.TextBoxTask_SRV.Text = resources.GetString("TextBoxTask_SRV.Text");
            // 
            // PanelLeft_NVR
            // 
            this.PanelLeft_NVR.Controls.Add(this.GroupBoxInput_NVR);
            this.PanelLeft_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_NVR.Location = new System.Drawing.Point(0, 194);
            this.PanelLeft_NVR.Name = "PanelLeft_NVR";
            this.PanelLeft_NVR.Size = new System.Drawing.Size(399, 217);
            this.PanelLeft_NVR.TabIndex = 2;
            // 
            // GroupBoxInput_NVR
            // 
            this.GroupBoxInput_NVR.Controls.Add(this.TextBoxInput_SRV);
            this.GroupBoxInput_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxInput_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_NVR.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxInput_NVR.Name = "GroupBoxInput_NVR";
            this.GroupBoxInput_NVR.Size = new System.Drawing.Size(399, 217);
            this.GroupBoxInput_NVR.TabIndex = 0;
            this.GroupBoxInput_NVR.TabStop = false;
            this.GroupBoxInput_NVR.Text = "Ввод";
            // 
            // TextBoxInput_SRV
            // 
            this.TextBoxInput_SRV.BackColor = System.Drawing.Color.White;
            this.TextBoxInput_SRV.Location = new System.Drawing.Point(12, 16);
            this.TextBoxInput_SRV.Multiline = true;
            this.TextBoxInput_SRV.Name = "TextBoxInput_SRV";
            this.TextBoxInput_SRV.ReadOnly = true;
            this.TextBoxInput_SRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInput_SRV.Size = new System.Drawing.Size(381, 195);
            this.TextBoxInput_SRV.TabIndex = 0;
            // 
            // PanelFill_NVR
            // 
            this.PanelFill_NVR.Controls.Add(this.GroupBoxOutput_NVR);
            this.PanelFill_NVR.Controls.Add(this.Splitter_NVR);
            this.PanelFill_NVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill_NVR.Location = new System.Drawing.Point(399, 194);
            this.PanelFill_NVR.Name = "PanelFill_NVR";
            this.PanelFill_NVR.Size = new System.Drawing.Size(435, 217);
            this.PanelFill_NVR.TabIndex = 3;
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.TextBoxOutput_SRV);
            this.GroupBoxOutput_NVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(3, 0);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(432, 217);
            this.GroupBoxOutput_NVR.TabIndex = 1;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод";
            // 
            // TextBoxOutput_SRV
            // 
            this.TextBoxOutput_SRV.BackColor = System.Drawing.Color.White;
            this.TextBoxOutput_SRV.Location = new System.Drawing.Point(6, 16);
            this.TextBoxOutput_SRV.Multiline = true;
            this.TextBoxOutput_SRV.Name = "TextBoxOutput_SRV";
            this.TextBoxOutput_SRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxOutput_SRV.Size = new System.Drawing.Size(423, 195);
            this.TextBoxOutput_SRV.TabIndex = 0;
            // 
            // Splitter_NVR
            // 
            this.Splitter_NVR.Location = new System.Drawing.Point(0, 0);
            this.Splitter_NVR.Name = "Splitter_NVR";
            this.Splitter_NVR.Size = new System.Drawing.Size(3, 217);
            this.Splitter_NVR.TabIndex = 0;
            this.Splitter_NVR.TabStop = false;
            // 
            // OpenFileDialog_NVR
            // 
            this.OpenFileDialog_NVR.FileName = "openFileDialog1";
            // 
            // ToolTip_NVR
            // 
            this.ToolTip_NVR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_NVR.ToolTipTitle = "Подсказка";
            // 
            // FormMain_SRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.PanelFill_NVR);
            this.Controls.Add(this.PanelLeft_NVR);
            this.Controls.Add(this.PanelTask_NVR);
            this.Controls.Add(this.PanelTop_SRV);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain_SRV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Сафонов Р.В";
            this.PanelTop_SRV.ResumeLayout(false);
            this.PanelTask_NVR.ResumeLayout(false);
            this.GroupBoxTask_SRV.ResumeLayout(false);
            this.GroupBoxTask_SRV.PerformLayout();
            this.PanelLeft_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.PerformLayout();
            this.PanelFill_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop_SRV;
        private System.Windows.Forms.Panel PanelTask_NVR;
        private System.Windows.Forms.Panel PanelLeft_NVR;
        private System.Windows.Forms.Panel PanelFill_NVR;
        private System.Windows.Forms.Splitter Splitter_NVR;
        private System.Windows.Forms.GroupBox GroupBoxTask_SRV;
        private System.Windows.Forms.GroupBox GroupBoxInput_NVR;
        private System.Windows.Forms.TextBox TextBoxInput_SRV;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.TextBox TextBoxOutput_SRV;
        private System.Windows.Forms.Button ButtonInfo_SRV;
        private System.Windows.Forms.Button ButtonDone_SRV;
        private System.Windows.Forms.Button ButtonOpen_SRV;
        private System.Windows.Forms.TextBox TextBoxTask_SRV;
        private System.Windows.Forms.ToolTip ToolTip_NVR;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_NVR;
    }
}

