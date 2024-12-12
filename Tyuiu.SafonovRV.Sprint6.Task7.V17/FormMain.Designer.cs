
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
            panelInput_SRV = new Panel();
            buttonOpenFile_SRV = new Button();
            buttonSave_SRV = new Button();
            buttonDone_SRV = new Button();
            buttonInfo_SRV = new Button();
            groupBoxCondition_SRV = new GroupBox();
            groupBoxInPut_SRV = new GroupBox();
            dataGridViewIn_SRV = new DataGridView();
            groupBoxOutPut_SRV = new GroupBox();
            dataGridViewOut_SRV = new DataGridView();
            openFileDialogTask_SRV = new OpenFileDialog();
            saveFileDialogMatrix_SRV = new SaveFileDialog();
            panelInput_SRV.SuspendLayout();
            groupBoxCondition_SRV.SuspendLayout();
            groupBoxInPut_SRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SRV).BeginInit();
            groupBoxOutPut_SRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SRV).BeginInit();
            SuspendLayout();
            // 
            // panelInput_SRV
            // 
            panelInput_SRV.Controls.Add(buttonOpenFile_SRV);
            panelInput_SRV.Controls.Add(buttonSave_SRV);
            panelInput_SRV.Controls.Add(buttonDone_SRV);
            panelInput_SRV.Controls.Add(buttonInfo_SRV);
            panelInput_SRV.Dock = DockStyle.Top;
            panelInput_SRV.Location = new Point(0, 0);
            panelInput_SRV.Name = "panelInput_SRV";
            panelInput_SRV.Size = new Size(1219, 100);
            panelInput_SRV.TabIndex = 0;
            // 
            // buttonOpenFile_SRV
            // 
            buttonOpenFile_SRV.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_SRV.BackgroundImage");
            buttonOpenFile_SRV.Location = new Point(3, 3);
            buttonOpenFile_SRV.Name = "buttonOpenFile_SRV";
            buttonOpenFile_SRV.Size = new Size(32, 32);
            buttonOpenFile_SRV.TabIndex = 1;
            buttonOpenFile_SRV.UseVisualStyleBackColor = true;
            buttonOpenFile_SRV.Click += buttonDone_SRV_Click;
            // 
            // buttonSave_SRV
            // 
            buttonSave_SRV.BackColor = SystemColors.ActiveCaption;
            buttonSave_SRV.BackgroundImage = (Image)resources.GetObject("buttonSave_SRV.BackgroundImage");
            buttonSave_SRV.Location = new Point(77, 3);
            buttonSave_SRV.Name = "buttonSave_SRV";
            buttonSave_SRV.Size = new Size(33, 32);
            buttonSave_SRV.TabIndex = 3;
            buttonSave_SRV.UseVisualStyleBackColor = false;
            buttonSave_SRV.Click += buttonSave_SRV_Click;
            // 
            // buttonDone_SRV
            // 
            buttonDone_SRV.BackgroundImage = (Image)resources.GetObject("buttonDone_SRV.BackgroundImage");
            buttonDone_SRV.Location = new Point(37, 3);
            buttonDone_SRV.Name = "buttonDone_SRV";
            buttonDone_SRV.Size = new Size(34, 32);
            buttonDone_SRV.TabIndex = 2;
            buttonDone_SRV.UseVisualStyleBackColor = true;
            buttonDone_SRV.Click += buttonDone_SRV_Click;
            // 
            // buttonInfo_SRV
            // 
            buttonInfo_SRV.BackgroundImage = (Image)resources.GetObject("buttonInfo_SRV.BackgroundImage");
            buttonInfo_SRV.Location = new Point(1167, 12);
            buttonInfo_SRV.Name = "buttonInfo_SRV";
            buttonInfo_SRV.Size = new Size(35, 32);
            buttonInfo_SRV.TabIndex = 4;
            buttonInfo_SRV.UseVisualStyleBackColor = true;
            buttonInfo_SRV.Click += buttonInfo_SRV_Click;
            // 
            // groupBoxCondition_SRV
            // 
            groupBoxCondition_SRV.Controls.Add(groupBoxInPut_SRV);
            groupBoxCondition_SRV.Dock = DockStyle.Fill;
            groupBoxCondition_SRV.Location = new Point(0, 100);
            groupBoxCondition_SRV.Name = "groupBoxCondition_SRV";
            groupBoxCondition_SRV.RightToLeft = RightToLeft.No;
            groupBoxCondition_SRV.Size = new Size(1219, 564);
            groupBoxCondition_SRV.TabIndex = 1;
            groupBoxCondition_SRV.TabStop = false;
            groupBoxCondition_SRV.Text = resources.GetString("groupBoxCondition_SRV.Text");
            groupBoxCondition_SRV.Enter += groupBox1_Enter;
            // 
            // groupBoxInPut_SRV
            // 
            groupBoxInPut_SRV.Controls.Add(dataGridViewIn_SRV);
            groupBoxInPut_SRV.Location = new Point(12, 131);
            groupBoxInPut_SRV.Name = "groupBoxInPut_SRV";
            groupBoxInPut_SRV.Size = new Size(471, 427);
            groupBoxInPut_SRV.TabIndex = 2;
            groupBoxInPut_SRV.TabStop = false;
            groupBoxInPut_SRV.Text = "ВВОД";
            // 
            // dataGridViewIn_SRV
            // 
            dataGridViewIn_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SRV.Location = new Point(6, 22);
            dataGridViewIn_SRV.Name = "dataGridViewIn_SRV";
            dataGridViewIn_SRV.Size = new Size(446, 396);
            dataGridViewIn_SRV.TabIndex = 0;
            // 
            // groupBoxOutPut_SRV
            // 
            groupBoxOutPut_SRV.Controls.Add(dataGridViewOut_SRV);
            groupBoxOutPut_SRV.Location = new Point(631, 231);
            groupBoxOutPut_SRV.Name = "groupBoxOutPut_SRV";
            groupBoxOutPut_SRV.Size = new Size(581, 421);
            groupBoxOutPut_SRV.TabIndex = 3;
            groupBoxOutPut_SRV.TabStop = false;
            groupBoxOutPut_SRV.Text = "ВЫВОД";
            // 
            // dataGridViewOut_SRV
            // 
            dataGridViewOut_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SRV.Dock = DockStyle.Right;
            dataGridViewOut_SRV.Location = new Point(17, 19);
            dataGridViewOut_SRV.Name = "dataGridViewOut_SRV";
            dataGridViewOut_SRV.Size = new Size(561, 399);
            dataGridViewOut_SRV.TabIndex = 1;
            // 
            // openFileDialogTask_SRV
            // 
            openFileDialogTask_SRV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 664);
            Controls.Add(groupBoxOutPut_SRV);
            Controls.Add(groupBoxCondition_SRV);
            Controls.Add(panelInput_SRV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Сафонов Р.В";
           
            panelInput_SRV.ResumeLayout(false);
            groupBoxCondition_SRV.ResumeLayout(false);
            groupBoxInPut_SRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SRV).EndInit();
            groupBoxOutPut_SRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SRV).EndInit();
            ResumeLayout(false);
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button buttonSave_SRV;
        private Button buttonInfo_SRV;
        private Button buttonDone_SRV;
        private Button buttonOpenFile_SRV;
        private GroupBox groupBoxCondition_SRV;
        private GroupBox groupBoxInPut_SRV;
        private DataGridView dataGridViewIn_SRV;
        private GroupBox groupBoxOutPut_SRV;
        private DataGridView dataGridViewOut_SRV;
        private OpenFileDialog openFileDialogTask_SRV;
        private SaveFileDialog saveFileDialogMatrix_SRV;
        private Panel panelInput_SRV;
    }
}
