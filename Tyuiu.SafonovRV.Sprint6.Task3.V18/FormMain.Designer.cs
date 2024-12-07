
namespace Tyuiu.SafonovRV.Sprint6.Task3.V18
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
            groupBoxOutput_SRV = new GroupBox();
            dataGridViewResult_SRV = new DataGridView();
            labelResult_SMA = new Label();
            dataGridViewTask_SRV = new DataGridView();
            buttonExecute_SRV = new Button();
            buttonAbout_SRV = new Button();
            groupBoxTask_SMA = new GroupBox();
            pictureBoxTask_SRV = new PictureBox();
            groupBoxOutput_SRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SRV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_SRV).BeginInit();
            groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SRV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutput_SRV
            // 
            groupBoxOutput_SRV.Controls.Add(dataGridViewResult_SRV);
            groupBoxOutput_SRV.Controls.Add(labelResult_SMA);
            groupBoxOutput_SRV.Location = new Point(716, 44);
            groupBoxOutput_SRV.Name = "groupBoxOutput_SRV";
            groupBoxOutput_SRV.Size = new Size(255, 304);
            groupBoxOutput_SRV.TabIndex = 5;
            groupBoxOutput_SRV.TabStop = false;
            groupBoxOutput_SRV.Text = "Вывод данных";
            groupBoxOutput_SRV.Enter += groupBoxOutput_SRV_Enter;
            // 
            // dataGridViewResult_SRV
            // 
            dataGridViewResult_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SRV.Location = new Point(41, 55);
            dataGridViewResult_SRV.Name = "dataGridViewResult_SRV";
            dataGridViewResult_SRV.RowHeadersVisible = false;
            dataGridViewResult_SRV.Size = new Size(163, 163);
            dataGridViewResult_SRV.TabIndex = 4;
            // 
            // labelResult_SMA
            // 
            labelResult_SMA.AutoSize = true;
            labelResult_SMA.Location = new Point(6, 22);
            labelResult_SMA.Name = "labelResult_SMA";
            labelResult_SMA.Size = new Size(63, 15);
            labelResult_SMA.TabIndex = 4;
            labelResult_SMA.Text = "Результат:";
            // 
            // dataGridViewTask_SRV
            // 
            dataGridViewTask_SRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_SRV.Location = new Point(494, 99);
            dataGridViewTask_SRV.Name = "dataGridViewTask_SRV";
            dataGridViewTask_SRV.RowHeadersVisible = false;
            dataGridViewTask_SRV.Size = new Size(163, 163);
            dataGridViewTask_SRV.TabIndex = 8;
            // 
            // buttonExecute_SRV
            // 
            buttonExecute_SRV.Location = new Point(141, 273);
            buttonExecute_SRV.Name = "buttonExecute_SRV";
            buttonExecute_SRV.Size = new Size(281, 43);
            buttonExecute_SRV.TabIndex = 7;
            buttonExecute_SRV.Text = "Выполнить";
            buttonExecute_SRV.UseVisualStyleBackColor = true;
            // 
            // buttonAbout_SRV
            // 
            buttonAbout_SRV.Location = new Point(18, 273);
            buttonAbout_SRV.Name = "buttonAbout_SRV";
            buttonAbout_SRV.Size = new Size(117, 43);
            buttonAbout_SRV.TabIndex = 6;
            buttonAbout_SRV.Text = "Справка";
            buttonAbout_SRV.UseVisualStyleBackColor = true;
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(pictureBoxTask_SRV);
            groupBoxTask_SMA.Location = new Point(12, 12);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(410, 255);
            groupBoxTask_SMA.TabIndex = 4;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // pictureBoxTask_SRV
            // 
            pictureBoxTask_SRV.Image = (Image)resources.GetObject("pictureBoxTask_SRV.Image");
            pictureBoxTask_SRV.Location = new Point(6, 22);
            pictureBoxTask_SRV.Name = "pictureBoxTask_SRV";
            pictureBoxTask_SRV.Size = new Size(396, 226);
            pictureBoxTask_SRV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_SRV.TabIndex = 0;
            pictureBoxTask_SRV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 495);
            Controls.Add(groupBoxOutput_SRV);
            Controls.Add(dataGridViewTask_SRV);
            Controls.Add(buttonExecute_SRV);
            Controls.Add(buttonAbout_SRV);
            Controls.Add(groupBoxTask_SMA);
            Name = "FormMain";
            Text = "Спринт 6 I Таск 3 I Вариант 18 I Сафонов Р.В";
            Load += FormMain_Load;
            groupBoxOutput_SRV.ResumeLayout(false);
            groupBoxOutput_SRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SRV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_SRV).EndInit();
            groupBoxTask_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SRV).EndInit();
            ResumeLayout(false);
        }

        private void groupBoxOutput_SRV_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxOutput_SRV;
        private DataGridView dataGridViewResult_SRV;
        private Label labelResult_SMA;
        private DataGridView dataGridViewTask_SRV;
        private Button buttonExecute_SRV;
        private Button buttonAbout_SRV;
        private GroupBox groupBoxTask_SMA;
        private PictureBox pictureBoxTask_SRV;
    }
}
