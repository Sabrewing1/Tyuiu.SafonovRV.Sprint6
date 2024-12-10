namespace Tyuiu.SafonovRV.Sprint6.Task6.V24
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
            ButtonOpen_SRV = new Button();
            ButtonDone_SRV = new Button();
            ButtonInfo_SRV = new Button();
            PanelTop_SRV = new Panel();
            groupBox1 = new GroupBox();
            TextBoxTask_SRV = new TextBox();
            GroupBoxInput_SRV = new GroupBox();
            TextBoxInput_SRV = new TextBox();
            GroupBoxOutput_SRV = new GroupBox();
            TextBoxOutput_SRV = new TextBox();
            PanelTop_SRV.SuspendLayout();
            groupBox1.SuspendLayout();
            GroupBoxInput_SRV.SuspendLayout();
            GroupBoxOutput_SRV.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonOpen_SRV
            // 
            resources.ApplyResources(ButtonOpen_SRV, "ButtonOpen_SRV");
            ButtonOpen_SRV.Name = "ButtonOpen_SRV";
            ButtonOpen_SRV.UseVisualStyleBackColor = true;
            ButtonOpen_SRV.Click += ButtonOpen_SRV_Click;
            // 
            // ButtonDone_SRV
            // 
            resources.ApplyResources(ButtonDone_SRV, "ButtonDone_SRV");
            ButtonDone_SRV.Name = "ButtonDone_SRV";
            ButtonDone_SRV.UseVisualStyleBackColor = true;
            ButtonDone_SRV.Click += ButtonDone_SRV_Click;
            // 
            // ButtonInfo_SRV
            // 
            resources.ApplyResources(ButtonInfo_SRV, "ButtonInfo_SRV");
            ButtonInfo_SRV.Name = "ButtonInfo_SRV";
            ButtonInfo_SRV.UseVisualStyleBackColor = true;
            ButtonInfo_SRV.Click += ButtonInfo_SRV_Click;
            // 
            // PanelTop_SRV
            // 
            PanelTop_SRV.Controls.Add(ButtonInfo_SRV);
            PanelTop_SRV.Controls.Add(ButtonDone_SRV);
            PanelTop_SRV.Controls.Add(ButtonOpen_SRV);
            resources.ApplyResources(PanelTop_SRV, "PanelTop_SRV");
            PanelTop_SRV.Name = "PanelTop_SRV";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxTask_SRV);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // TextBoxTask_SRV
            // 
            TextBoxTask_SRV.BackColor = SystemColors.Menu;
            resources.ApplyResources(TextBoxTask_SRV, "TextBoxTask_SRV");
            TextBoxTask_SRV.Name = "TextBoxTask_SRV";
            // 
            // GroupBoxInput_SRV
            // 
            GroupBoxInput_SRV.Controls.Add(TextBoxInput_SRV);
            resources.ApplyResources(GroupBoxInput_SRV, "GroupBoxInput_SRV");
            GroupBoxInput_SRV.Name = "GroupBoxInput_SRV";
            GroupBoxInput_SRV.TabStop = false;
            // 
            // TextBoxInput_SRV
            // 
            resources.ApplyResources(TextBoxInput_SRV, "TextBoxInput_SRV");
            TextBoxInput_SRV.Name = "TextBoxInput_SRV";
            // 
            // GroupBoxOutput_SRV
            // 
            GroupBoxOutput_SRV.Controls.Add(TextBoxOutput_SRV);
            resources.ApplyResources(GroupBoxOutput_SRV, "GroupBoxOutput_SRV");
            GroupBoxOutput_SRV.Name = "GroupBoxOutput_SRV";
            GroupBoxOutput_SRV.TabStop = false;
            // 
            // TextBoxOutput_SRV
            // 
            resources.ApplyResources(TextBoxOutput_SRV, "TextBoxOutput_SRV");
            TextBoxOutput_SRV.Name = "TextBoxOutput_SRV";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxOutput_SRV);
            Controls.Add(GroupBoxInput_SRV);
            Controls.Add(groupBox1);
            Controls.Add(PanelTop_SRV);
            Name = "FormMain";
            Load += FormMain_Load;
            PanelTop_SRV.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBoxInput_SRV.ResumeLayout(false);
            GroupBoxInput_SRV.PerformLayout();
            GroupBoxOutput_SRV.ResumeLayout(false);
            GroupBoxOutput_SRV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonOpen_SRV;
        private Button ButtonDone_SRV;
        private Button ButtonInfo_SRV;
        private Panel PanelTop_SRV;
        private GroupBox groupBox1;
        private TextBox TextBoxTask_SRV;
        private GroupBox GroupBoxInput_SRV;
        private TextBox TextBoxInput_SRV;
        private GroupBox GroupBoxOutput_SRV;
        private TextBox TextBoxOutput_SRV;
    }
}
