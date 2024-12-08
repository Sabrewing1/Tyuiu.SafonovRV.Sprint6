
namespace Tyuiu.SafonovRV.Sprint6.Task4.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxRes = new TextBox();
            groupBox2 = new GroupBox();
            groupBoxZn = new GroupBox();
            label4 = new Label();
            textBoxStop = new TextBox();
            label1 = new Label();
            textBoxStart = new TextBox();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBoxUs = new GroupBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2.SuspendLayout();
            groupBoxZn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(9, 162);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(268, 386);
            textBoxRes.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBoxZn);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 90);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBoxZn
            // 
            groupBoxZn.Controls.Add(label4);
            groupBoxZn.Controls.Add(textBoxStop);
            groupBoxZn.Controls.Add(label1);
            groupBoxZn.Controls.Add(textBoxStart);
            groupBoxZn.Location = new Point(317, 9);
            groupBoxZn.Name = "groupBoxZn";
            groupBoxZn.Size = new Size(298, 71);
            groupBoxZn.TabIndex = 21;
            groupBoxZn.TabStop = false;
            groupBoxZn.Text = "Значение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 19);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Конец шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(155, 37);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(15, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(651, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 48);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(789, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 18;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(973, 9);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 71);
            buttonInfo.TabIndex = 19;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // groupBoxUs
            // 
            groupBoxUs.Location = new Point(9, 12);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(314, 80);
            groupBoxUs.TabIndex = 22;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(367, 159);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(797, 389);
            chartFunc.TabIndex = 23;
            chartFunc.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F);
            title1.ForeColor = Color.LightSeaGreen;
            title1.Name = "Title1";
            title1.Text = "График функции Sin(x)";
            chartFunc.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 610);
            Controls.Add(chartFunc);
            Controls.Add(groupBoxUs);
            Controls.Add(groupBox2);
            Controls.Add(textBoxRes);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox2.ResumeLayout(false);
            groupBoxZn.ResumeLayout(false);
            groupBoxZn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxRes;
        private GroupBox groupBox2;
        private GroupBox groupBoxZn;
        private Label label4;
        private TextBox textBoxStop;
        private Label label1;
        private TextBox textBoxStart;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonInfo;
        private GroupBox groupBoxUs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
    }
}
