using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerLab
{
    public partial class Compiler : Form
    {
        public Compiler()
        {
            InitializeComponent();
            undoIconToolStripMenuItem.Enabled = false;
            redoIconToolStripMenuItem.Enabled = false;
        }

        private bool isSaved;

        private string path = "";

        private Stack<string> undoList = new Stack<string>();
        private Stack<string> redoList = new Stack<string>();


        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "*"+ (path==""? "Безымянный.txt" : Path.GetFileName(path));
            isSaved = false;
            undoList.Push(inputTextBox.Text);

            undoIconToolStripMenuItem.Enabled = undoList.Count != 0;
            redoIconToolStripMenuItem.Enabled = redoList.Count != 0;
        }

        private void CreateIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void OpenIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void UndoIconToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void RedoIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }

        private void SelectAllВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.SelectAll();
        }

        private void CopyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Copy();
        }

        private void CutIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Cut();
        }

        private void PasteIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Paste();
        }

        private void Create()
        {
            if (!isSaved)
            {
                if (wouldSaveFile())
                {
                    Save();
                }
            }
            inputTextBox.Clear();
            undoList.Clear();
            redoList.Clear();
            undoIconToolStripMenuItem.Enabled = false;
            redoIconToolStripMenuItem.Enabled = false;
            path = "";
            this.Text = "*" + (path == "" ? "Безымянный.txt" : Path.GetFileName(path));
        }
        private void Open()
        {
            if (!isSaved)
            {
                if (wouldSaveFile())
                {
                    Save();
                }
            }

            using (OpenFileDialog saveFileDialog = new OpenFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    path = saveFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = saveFileDialog.OpenFile();

                    using (var writer = new StreamReader(fileStream))
                    {
                        inputTextBox.Text = writer.ReadToEnd();
                    }

                    path = saveFileDialog.FileName;
                }

                isSaved = true;
                this.Text = "*" + (path == "" ? "Безымянный.txt" : Path.GetFileName(path));
            }
            undoList.Clear();
            redoList.Clear();
            undoIconToolStripMenuItem.Enabled = false;
            redoIconToolStripMenuItem.Enabled = false;
        }

        private bool wouldSaveFile()
        {
            return MessageBox.Show("Сохранить изменения?", "Compiler", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }


        private void Save()
        {
            if (path=="")
            {
                SaveAs();
            }
            else
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(inputTextBox.Text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            isSaved = true;
            this.Text = Path.GetFileNameWithoutExtension(path);
        }

        private void SaveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(path);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    path = saveFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = saveFileDialog.OpenFile();

                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write(inputTextBox.Text);
                    }
                }
            }
            isSaved = true;
            this.Text = "*" + (path == "" ? "Безымянный.txt" : Path.GetFileName(path));
        }

        private void Undo()
        {
            if (undoList.Count!=0 && inputTextBox.Text == undoList.Peek())
            {
                string value = undoList.Pop();
                redoList.Push(value);
            }

            if (inputTextBox.Text.Length == 1)
            {
                inputTextBox.Text = "";
                undoIconToolStripMenuItem.Enabled = false;
            }

            if (undoList.Count != 0)
            {
                string value = undoList.Pop();
                redoList.Push(value);
                inputTextBox.Text = value;
            }

        }

        private void Redo()
        {
            if (redoList.Count != 0 && inputTextBox.Text == redoList.Peek())
            {
                redoList.Pop();
            }
            if (redoList.Count != 0)
            {
                string value = redoList.Pop();
                inputTextBox.Text = value;
            }
            else
            {
                redoIconToolStripMenuItem.Enabled = false;
            }

        }
    }
}
