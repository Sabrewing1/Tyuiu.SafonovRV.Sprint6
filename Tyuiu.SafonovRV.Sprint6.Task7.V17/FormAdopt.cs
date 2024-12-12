using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SafonovRV.Sprint6.Task7.V17
{
    public partial class FormAdopt : Form
    {
        public FormAdopt()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAdopt));
            labelInfo_SRV = new TextBox();
            buttonOk_SRV = new Button();
            SuspendLayout();
            // 
            // labelInfo_SRV
            // 
            labelInfo_SRV.BackColor = SystemColors.Menu;
            labelInfo_SRV.Location = new Point(0, 0);
            labelInfo_SRV.Multiline = true;
            labelInfo_SRV.Name = "labelInfo_SRV";
            labelInfo_SRV.Size = new Size(343, 193);
            labelInfo_SRV.TabIndex = 0;
            labelInfo_SRV.Text = resources.GetString("labelInfo_SRV.Text");
            // 
            // buttonOk_SRV
            // 
            buttonOk_SRV.Location = new Point(351, 196);
            buttonOk_SRV.Name = "buttonOk_SRV";
            buttonOk_SRV.Size = new Size(75, 23);
            buttonOk_SRV.TabIndex = 1;
            buttonOk_SRV.Text = "OK";
            buttonOk_SRV.UseVisualStyleBackColor = true;
            // 
            // FormAdopt
            // 
            ClientSize = new Size(438, 228);
            Controls.Add(buttonOk_SRV);
            Controls.Add(labelInfo_SRV);
            Name = "FormAdopt";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox labelInfo_SRV;
        private Button buttonOk_SRV;
    }
}
