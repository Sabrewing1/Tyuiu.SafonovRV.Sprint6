namespace Tyuiu.SafonovRV.Sprint6.Task2.V9
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
            groupBoxviv_srv = new GroupBox();
            dataGrid_srv = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBoxstrtshaga_tia = new TextBox();
            textBoxtwo_srv = new TextBox();
            textBoxkon_tia = new TextBox();
            textBoxone_srv = new TextBox();
            buttonHelpClick_srv = new Button();
            buttonStrt_click_srv = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxviv_srv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_srv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxviv_srv
            // 
            groupBoxviv_srv.Controls.Add(dataGrid_srv);
            groupBoxviv_srv.Location = new Point(714, 50);
            groupBoxviv_srv.Margin = new Padding(3, 2, 3, 2);
            groupBoxviv_srv.Name = "groupBoxviv_srv";
            groupBoxviv_srv.Padding = new Padding(3, 2, 3, 2);
            groupBoxviv_srv.Size = new Size(554, 520);
            groupBoxviv_srv.TabIndex = 29;
            groupBoxviv_srv.TabStop = false;
            groupBoxviv_srv.Text = "Результат";
            // 
            // dataGrid_srv
            // 
            dataGrid_srv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_srv.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGrid_srv.Location = new Point(13, 29);
            dataGrid_srv.Margin = new Padding(3, 2, 3, 2);
            dataGrid_srv.Name = "dataGrid_srv";
            dataGrid_srv.RowHeadersVisible = false;
            dataGrid_srv.RowHeadersWidth = 51;
            dataGrid_srv.Size = new Size(105, 481);
            dataGrid_srv.TabIndex = 0;
            // 
            // x
            // 
            x.HeaderText = "X";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.Width = 50;
            // 
            // y
            // 
            y.HeaderText = "F(x)";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.Width = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxstrtshaga_tia);
            groupBox1.Controls.Add(textBoxtwo_srv);
            groupBox1.Controls.Add(textBoxkon_tia);
            groupBox1.Controls.Add(textBoxone_srv);
            groupBox1.Location = new Point(34, 450);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(428, 120);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxstrtshaga_tia
            // 
            textBoxstrtshaga_tia.Location = new Point(6, 62);
            textBoxstrtshaga_tia.Margin = new Padding(3, 2, 3, 2);
            textBoxstrtshaga_tia.Name = "textBoxstrtshaga_tia";
            textBoxstrtshaga_tia.ReadOnly = true;
            textBoxstrtshaga_tia.Size = new Size(129, 23);
            textBoxstrtshaga_tia.TabIndex = 19;
            textBoxstrtshaga_tia.Text = "Начало шага";
            // 
            // textBoxtwo_srv
            // 
            textBoxtwo_srv.Location = new Point(193, 87);
            textBoxtwo_srv.Margin = new Padding(3, 2, 3, 2);
            textBoxtwo_srv.Name = "textBoxtwo_srv";
            textBoxtwo_srv.Size = new Size(129, 23);
            textBoxtwo_srv.TabIndex = 18;
            // 
            // textBoxkon_tia
            // 
            textBoxkon_tia.Location = new Point(193, 62);
            textBoxkon_tia.Margin = new Padding(3, 2, 3, 2);
            textBoxkon_tia.Name = "textBoxkon_tia";
            textBoxkon_tia.ReadOnly = true;
            textBoxkon_tia.Size = new Size(129, 23);
            textBoxkon_tia.TabIndex = 17;
            textBoxkon_tia.Text = "Конец шага";
            // 
            // textBoxone_srv
            // 
            textBoxone_srv.Location = new Point(6, 89);
            textBoxone_srv.Margin = new Padding(3, 2, 3, 2);
            textBoxone_srv.Name = "textBoxone_srv";
            textBoxone_srv.Size = new Size(129, 23);
            textBoxone_srv.TabIndex = 13;
            // 
            // buttonHelpClick_srv
            // 
            buttonHelpClick_srv.BackColor = Color.CornflowerBlue;
            buttonHelpClick_srv.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_srv.Location = new Point(468, 512);
            buttonHelpClick_srv.Margin = new Padding(3, 2, 3, 2);
            buttonHelpClick_srv.Name = "buttonHelpClick_srv";
            buttonHelpClick_srv.Size = new Size(88, 56);
            buttonHelpClick_srv.TabIndex = 27;
            buttonHelpClick_srv.Text = "Справка";
            buttonHelpClick_srv.UseVisualStyleBackColor = false;
            buttonHelpClick_srv.Click += buttonHelpClick_tia_Click;
            // 
            // buttonStrt_click_srv
            // 
            buttonStrt_click_srv.BackColor = Color.FromArgb(0, 192, 0);
            buttonStrt_click_srv.Location = new Point(562, 512);
            buttonStrt_click_srv.Margin = new Padding(3, 2, 3, 2);
            buttonStrt_click_srv.Name = "buttonStrt_click_srv";
            buttonStrt_click_srv.Size = new Size(136, 58);
            buttonStrt_click_srv.TabIndex = 25;
            buttonStrt_click_srv.Text = "Выполнить";
            buttonStrt_click_srv.UseVisualStyleBackColor = false;
            buttonStrt_click_srv.Click += buttonStrt_click_srv_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 50);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(664, 315);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 160);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxviv_srv);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelpClick_srv);
            Controls.Add(buttonStrt_click_srv);
            Name = "FormMain";
            Text = "Спринт 6 I Таск 2 I Вариант 9 I Сафонов Р.В";
            Load += FormMain_Load;
            groupBoxviv_srv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_srv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxviv_srv;
        private DataGridView dataGrid_srv;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private GroupBox groupBox1;
        private TextBox textBoxstrtshaga_tia;
        private TextBox textBoxtwo_srv;
        private TextBox textBoxkon_tia;
        private TextBox textBoxone_srv;
        private Button buttonHelpClick_srv;
        private Button buttonStrt_click_srv;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}
