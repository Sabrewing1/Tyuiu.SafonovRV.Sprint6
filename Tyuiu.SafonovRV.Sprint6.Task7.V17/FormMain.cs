using Tyuiu.SafonovRV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task7.V17
{
    
        

        public partial class FormMain : Form
        {
            public FormMain()
            {
                InitializeComponent();
                openFileDialogTask_SRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
                saveFileDialogMatrix_SRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            }
            static string openFilePath;
            static int rows;
            static int columns;

            DataService ds = new DataService();

            public static int[,] LoadFromFileData(string filePath)
            {
                string fileData = File.ReadAllText(filePath);

                fileData = fileData.Replace("\n", "\r");
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                rows = lines.Length;
                columns = lines[0].Split(';').Length;

                int[,] arrayValues = new int[rows, columns];

                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lines[r].Split(';');
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                    }
                }
                return arrayValues;
            }
            private void buttonDone_IME_Click(object sender, EventArgs e)
            {
                int[,] arrayValues = new int[rows, columns];
                arrayValues = ds.GetMatrix(openFilePath);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_SRV.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonSave_SRV.Enabled = true;
            }

            private void buttonInfo_IME_Click(object sender, EventArgs e)
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }

            private void buttonOpenFile_SRV_Click(object sender, EventArgs e)
            {
                openFileDialogTask_SRV.ShowDialog();
                openFilePath = openFileDialogTask_SRV.FileName;

                int[,] arrayValues = LoadFromFileData(openFilePath);

                dataGridViewIn_SRV.ColumnCount = columns;
                dataGridViewIn_SRV.RowCount = rows;
                dataGridViewOut_SRV.ColumnCount = columns;
                dataGridViewOut_SRV.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_SRV.Columns[i].Width = 35;
                    dataGridViewOut_SRV.Columns[i].Width = 35;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewIn_SRV.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDone_SRV.Enabled = true;
            }

            private void buttonSave_IME_Click(object sender, EventArgs e)
            {
                saveFileDialogMatrix_SRV.FileName = "OutPutFileTask7V17.csv";
                saveFileDialogMatrix_SRV.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix_SRV.ShowDialog();

                string path = saveFileDialogMatrix_SRV.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_SRV.RowCount;
                int columns = dataGridViewOut_SRV.Columns.Count;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str += dataGridViewOut_SRV.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewOut_SRV.Rows[i].Cells[j].Value;
                        }
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            private void File_Load_IME(object sender, EventArgs e)
            {
                dataGridViewIn_SRV.ColumnCount = 50;
                dataGridViewOut_SRV.ColumnCount = 50;

                dataGridViewOut_SRV.RowCount = 50;
                dataGridViewIn_SRV.RowCount = 50;
                panelInput_SRV.Width = this.Width / 2;
                panelOut_SRV.Width = this.Width / 2;
            }

            private void buttonInfo_SRV_MouseEnter(object sender, EventArgs e)
            {
                toolTipButton_SRV.ToolTipTitle = "Справка";
            }

            private void buttonDone_SRV_MouseEnter(object sender, EventArgs e)
            {
                toolTipButton_SRV.ToolTipTitle = "Выполнить";
            }

            private void buttonSave_SRV_MouseEnter(object sender, EventArgs e)
            {
                toolTipButton_SRV.ToolTipTitle = "Сохранить в файл";
            }

            private void buttonOpenFile_SRV_MouseEnter(object sender, EventArgs e)
            {
                toolTipButton_SRV.ToolTipTitle = "Открыть файл";
            }

            private void buttonOpenFile_SRV_MouseMove(object sender, MouseEventArgs e)
            {
                Cursor = Cursors.Hand;
                base.OnMouseMove(e);
            }

            private void buttonOpenFile_SRV_MouseLeave(object sender, EventArgs e)
            {
                Cursor = Cursors.Arrow;
                base.OnMouseLeave(e);
            }

            private void buttonDone_SRV_MouseMove(object sender, MouseEventArgs e)
            {
                Cursor = Cursors.Hand;
                base.OnMouseMove(e);
            }

            private void buttonDone_SRV_MouseLeave(object sender, EventArgs e)
            {
                Cursor = Cursors.Arrow;
                base.OnMouseLeave(e);
            }

            private void buttonSave_SRV_MouseMove(object sender, MouseEventArgs e)
            {
                Cursor = Cursors.Hand;
                base.OnMouseMove(e);
            }

            private void buttonSave_SRV_MouseLeave(object sender, EventArgs e)
            {
                Cursor = Cursors.Arrow;
                base.OnMouseLeave(e);
            }

            private void buttonInfo_SRV_MouseMove(object sender, MouseEventArgs e)
            {
                Cursor = Cursors.Hand;
                base.OnMouseMove(e);
            }

            private void buttonInfo_SRV_MouseLeave(object sender, EventArgs e)
            {
                Cursor = Cursors.Arrow;
                base.OnMouseLeave(e);
            }

            private void textBoxTask_SRV_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridViewOut_SRV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }
    }
