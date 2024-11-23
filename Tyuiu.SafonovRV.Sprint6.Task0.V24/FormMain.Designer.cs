
namespace Tyuiu.SafonovRV.Sprint6.Task0.V24
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
            buttonDone = new Button();
            pictureBoxFormula = new PictureBox();
            textBoxResult = new TextBox();
            textBox_Condition = new TextBox();
            textBoxTask = new TextBox();
            textBox_input = new TextBox();
            buttonHelp_Click = new Button();
            groupBoxOfValue_x = new GroupBox();
            textBoxEnter_X = new TextBox();
            groupBoxAnswerWindowUp = new GroupBox();
            groupBoxAnswerWindowDown = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxOfValue_x.SuspendLayout();
            groupBoxAnswerWindowUp.SuspendLayout();
            groupBoxAnswerWindowDown.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(624, 399);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(125, 39);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDoneClick;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(607, 12);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(175, 61);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(21, 43);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(161, 23);
            textBoxResult.TabIndex = 2;
            // 
            // textBox_Condition
            // 
            textBox_Condition.Location = new Point(26, 12);
            textBox_Condition.Multiline = true;
            textBox_Condition.Name = "textBox_Condition";
            textBox_Condition.ReadOnly = true;
            textBox_Condition.Size = new Size(556, 23);
            textBox_Condition.TabIndex = 5;
            textBox_Condition.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(26, 41);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(556, 218);
            textBoxTask.TabIndex = 6;
            textBoxTask.Text = "Вариант 24  Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(26, 280);
            textBox_input.Name = "textBox_input";
            textBox_input.ReadOnly = true;
            textBox_input.Size = new Size(78, 23);
            textBox_input.TabIndex = 7;
            textBox_input.Text = "Ввод данных";
            // 
            // buttonHelp_Click
            // 
            buttonHelp_Click.FlatStyle = FlatStyle.Flat;
            buttonHelp_Click.Location = new Point(563, 399);
            buttonHelp_Click.Name = "buttonHelp_Click";
            buttonHelp_Click.Size = new Size(55, 39);
            buttonHelp_Click.TabIndex = 10;
            buttonHelp_Click.Text = "?";
            buttonHelp_Click.UseVisualStyleBackColor = true;
            buttonHelp_Click.Click += buttonHelpClick;
            // 
            // groupBoxOfValue_x
            // 
            groupBoxOfValue_x.Controls.Add(textBoxEnter_X);
            groupBoxOfValue_x.Location = new Point(26, 323);
            groupBoxOfValue_x.Name = "groupBoxOfValue_x";
            groupBoxOfValue_x.Size = new Size(200, 100);
            groupBoxOfValue_x.TabIndex = 11;
            groupBoxOfValue_x.TabStop = false;
            groupBoxOfValue_x.Text = "Переменная Х";
            // 
            // textBoxEnter_X
            // 
            textBoxEnter_X.Location = new Point(0, 33);
            textBoxEnter_X.Name = "textBoxEnter_X";
            textBoxEnter_X.Size = new Size(100, 23);
            textBoxEnter_X.TabIndex = 0;
            textBoxEnter_X.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxAnswerWindowUp
            // 
            groupBoxAnswerWindowUp.Controls.Add(groupBoxAnswerWindowDown);
            groupBoxAnswerWindowUp.Location = new Point(549, 280);
            groupBoxAnswerWindowUp.Name = "groupBoxAnswerWindowUp";
            groupBoxAnswerWindowUp.Size = new Size(200, 100);
            groupBoxAnswerWindowUp.TabIndex = 12;
            groupBoxAnswerWindowUp.TabStop = false;
            groupBoxAnswerWindowUp.Text = "Вывод данных";
            // 
            // groupBoxAnswerWindowDown
            // 
            groupBoxAnswerWindowDown.Controls.Add(textBoxResult);
            groupBoxAnswerWindowDown.Location = new Point(6, 22);
            groupBoxAnswerWindowDown.Name = "groupBoxAnswerWindowDown";
            groupBoxAnswerWindowDown.Size = new Size(188, 72);
            groupBoxAnswerWindowDown.TabIndex = 0;
            groupBoxAnswerWindowDown.TabStop = false;
            groupBoxAnswerWindowDown.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(groupBoxAnswerWindowUp);
            Controls.Add(groupBoxOfValue_x);
            Controls.Add(buttonHelp_Click);
            Controls.Add(textBox_input);
            Controls.Add(textBoxTask);
            Controls.Add(textBox_Condition);
            Controls.Add(pictureBoxFormula);
            Controls.Add(buttonDone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 I Таск 0 I Вариант 24 I Сафонов Р.В";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxOfValue_x.ResumeLayout(false);
            groupBoxOfValue_x.PerformLayout();
            groupBoxAnswerWindowUp.ResumeLayout(false);
            groupBoxAnswerWindowDown.ResumeLayout(false);
            groupBoxAnswerWindowDown.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonDone_ChangeUICues(object sender, UICuesEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonDone;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxResult;
        private TextBox textBox_Condition;
        private TextBox textBoxTask;
        private TextBox textBox_input;
        private Button buttonHelp_Click;
        private GroupBox groupBoxOfValue_x;
        private TextBox textBoxEnter_X;
        private GroupBox groupBoxAnswerWindowUp;
        private GroupBox groupBoxAnswerWindowDown;
    }
}
