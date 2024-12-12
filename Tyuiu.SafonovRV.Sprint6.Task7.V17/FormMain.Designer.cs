
namespace Tyuiu.SafonovRV.Sprint6.Task7.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_SRV = new Panel();
            buttonOpenFile_SRV = new Button();
            buttonDone_SRV = new Button();
            buttonSave_SRV = new Button();
            buttonInfo_SRV = new Button();
            groupBoxCondition_SRV = new GroupBox();
            groupBoxInPut_SRV = new GroupBox();
            groupBoxOutPut_SRV = new GroupBox();
            dataGridViewIn_SRV = new DataGridView();
            dataGridViewOut_SRV = new DataGridView();
            panelButton_SRV.SuspendLayout();
            groupBoxInPut_SRV.SuspendLayout();
            groupBoxOutPut_SRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SRV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SRV).BeginInit();
            SuspendLayout();
            // 
            // panelButton_SRV
            // 
            panelButton_SRV.Controls.Add(buttonSave_SRV);
            panelButton_SRV.Controls.Add(buttonInfo_SRV);
            panelButton_SRV.Controls.Add(buttonDone_SRV);
            panelButton_SRV.Controls.Add(buttonOpenFile_SRV);
            panelButton_SRV.Location = new Point(0, 0);
            panelButton_SRV.Name = "panelButton_SRV";
            panelButton_SRV.Size = new Size(1212, 100);
            panelButton_SRV.TabIndex = 0;
            // 
            // buttonOpenFile_SRV
            // 
            buttonOpenFile_SRV.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_SRV.BackgroundImage");
            buttonOpenFile_SRV.Location = new Point(12, 12);
            buttonOpenFile_SRV.Name = "buttonOpenFile_SRV";
            buttonOpenFile_SRV.Size = new Size(32, 32);
            buttonOpenFile_SRV.TabIndex = 1;
            buttonOpenFile_SRV.UseVisualStyleBackColor = true;
            // 
            // buttonDone_SRV
            // 
            buttonDone_SRV.BackgroundImage = (Image)resources.GetObject("buttonDone_SRV.BackgroundImage");
            buttonDone_SRV.Location = new Point(50, 12);
            buttonDone_SRV.Name = "buttonDone_SRV";
            buttonDone_SRV.Size = new Size(34, 32);
            buttonDone_SRV.TabIndex = 2;
            buttonDone_SRV.UseVisualStyleBackColor = true;
            // 
            // buttonSave_SRV
            // 
            buttonSave_SRV.BackColor = SystemColors.ActiveCaption;
            buttonSave_SRV.BackgroundImage = (Image)resources.GetObject("buttonSave_SRV.BackgroundImage");
            buttonSave_SRV.Location = new Point(90, 12);
            buttonSave_SRV.Name = "buttonSave_SRV";
            buttonSave_SRV.Size = new Size(33, 32);
            buttonSave_SRV.TabIndex = 3;
            buttonSave_SRV.UseVisualStyleBackColor = false;
            // 
            // buttonInfo_SRV
            // 
            buttonInfo_SRV.BackgroundImage = (Image)resources.GetObject("buttonInfo_SRV.BackgroundImage");
            buttonInfo_SRV.Location = new Point(1129, 12);
            buttonInfo_SRV.Name = "buttonInfo_SRV";
            buttonInfo_SRV.Size = new Size(35, 32);
            buttonInfo_SRV.TabIndex = 4;
            buttonInfo_SRV.UseVisualStyleBackColor = true;
            // 
            // groupBoxCondition_SRV
            // 
            groupBoxCondition_SRV.Location = new Point(0, 106);
            groupBoxCondition_SRV.Name = "groupBoxCondition_SRV";
            groupBoxCondition_SRV.RightToLeft = RightToLeft.No;
            groupBoxCondition_SRV.Size = new Size(1212, 100);
            groupBoxCondition_SRV.TabIndex = 1;
            groupBoxCondition_SRV.TabStop = false;
            groupBoxCondition_SRV.Text = resources.GetString("groupBoxCondition_SRV.Text");
            groupBoxCondition_SRV.Enter += groupBox1_Enter;
            // 
            // groupBoxInPut_SRV
            // 
            groupBoxInPut_SRV.Controls.Add(dataGridViewIn_SRV);
            groupBoxInPut_SRV.Location = new Point(0, 212);
            groupBoxInPut_SRV.Name = "groupBoxInPut_SRV";
            groupBoxInPut_SRV.Size = new Size(604, 440);
            groupBoxInPut_SRV.TabIndex = 2;
            groupBoxInPut_SRV.TabStop = false;
            groupBoxInPut_SRV.Text = "ВВОД";
            // 
            // groupBoxOutPut_SRV
            // 
            groupBoxOutPut_SRV.Controls.Add(dataGridViewOut_SRV);
            groupBoxOutPut_SRV.Location = new Point(635, 212);
            groupBoxOutPut_SRV.Name = "groupBoxOutPut_SRV";
            groupBoxOutPut_SRV.Size = new Size(577, 440);
            groupBoxOutPut_SRV.TabIndex = 3;
            groupBoxOutPut_SRV.TabStop = false;
            groupBoxOutPut_SRV.Text = "ВЫВОД";
            // 
            // dataGridViewIn_SRV
            // 
            dataGridViewIn_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SRV.Location = new Point(3, 19);
            dataGridViewIn_SRV.Name = "dataGridViewIn_SRV";
            dataGridViewIn_SRV.Size = new Size(595, 415);
            dataGridViewIn_SRV.TabIndex = 0;
            // 
            // dataGridViewOut_SRV
            // 
            dataGridViewOut_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SRV.Location = new Point(6, 19);
            dataGridViewOut_SRV.Name = "dataGridViewOut_SRV";
            dataGridViewOut_SRV.Size = new Size(561, 415);
            dataGridViewOut_SRV.TabIndex = 1;
            dataGridViewOut_SRV.CellContentClick += dataGridViewOut_SRV_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 664);
            Controls.Add(groupBoxOutPut_SRV);
            Controls.Add(groupBoxInPut_SRV);
            Controls.Add(groupBoxCondition_SRV);
            Controls.Add(panelButton_SRV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Сафонов Р.В";
            Load += FormMain_Load;
            panelButton_SRV.ResumeLayout(false);
            groupBoxInPut_SRV.ResumeLayout(false);
            groupBoxOutPut_SRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SRV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SRV).EndInit();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelButton_SRV;
        private Button buttonSave_SRV;
        private Button buttonInfo_SRV;
        private Button buttonDone_SRV;
        private Button buttonOpenFile_SRV;
        private GroupBox groupBoxCondition_SRV;
        private GroupBox groupBoxInPut_SRV;
        private DataGridView dataGridViewIn_SRV;
        private GroupBox groupBoxOutPut_SRV;
        private DataGridView dataGridViewOut_SRV;
    }
}
