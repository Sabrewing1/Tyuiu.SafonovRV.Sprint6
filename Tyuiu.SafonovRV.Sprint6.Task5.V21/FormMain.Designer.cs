
namespace Tyuiu.SafonovRV.Sprint6.Task5.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonDone = new Button();
            buttonOpen = new Button();
            buttonInfo = new Button();
            chartOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxIn = new GroupBox();
            dataGridViewNums = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOut).BeginInit();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(618, 76);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(533, 30);
            label1.TabIndex = 0;
            label1.Text = "Прочитать данные из файла InPutFileTask5V21.txt, вывести в dataGridView все числа, кратные 3. \r\nПостроить диаграмму по этим значениям";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(647, 19);
            buttonDone.Margin = new Padding(3, 2, 3, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 68);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.CornflowerBlue;
            buttonOpen.Location = new Point(775, 19);
            buttonOpen.Margin = new Padding(3, 2, 3, 2);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(122, 68);
            buttonOpen.TabIndex = 5;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.MediumTurquoise;
            buttonInfo.Location = new Point(903, 19);
            buttonInfo.Margin = new Padding(3, 2, 3, 2);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.RightToLeft = RightToLeft.Yes;
            buttonInfo.Size = new Size(122, 68);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonHelp_Click;
            // 
            // chartOut
            // 
            chartOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartOut.BackColor = SystemColors.ControlLightLight;
            chartArea2.Name = "ChartArea1";
            chartOut.ChartAreas.Add(chartArea2);
            chartOut.Location = new Point(395, 228);
            chartOut.Margin = new Padding(3, 2, 3, 2);
            chartOut.Name = "chartOut";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartOut.Series.Add(series2);
            chartOut.Size = new Size(697, 440);
            chartOut.TabIndex = 9;
            chartOut.Text = "chart1";
            // 
            // groupBoxIn
            // 
            groupBoxIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxIn.Controls.Add(dataGridViewNums);
            groupBoxIn.Location = new Point(12, 210);
            groupBoxIn.Margin = new Padding(3, 2, 3, 2);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Padding = new Padding(3, 2, 3, 2);
            groupBoxIn.Size = new Size(352, 507);
            groupBoxIn.TabIndex = 10;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Вывод данных:";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 18);
            dataGridViewNums.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(346, 487);
            dataGridViewNums.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 728);
            Controls.Add(groupBoxIn);
            Controls.Add(chartOut);
            Controls.Add(buttonInfo);
            Controls.Add(buttonOpen);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 I Таск 5 I Вариант 21 I Сафонов Р.В";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartOut).EndInit();
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button buttonDone;
        private Button buttonOpen;
        private Button buttonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOut;
        private GroupBox groupBoxIn;
        private DataGridView dataGridViewNums;
    }
}
