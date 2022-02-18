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
        public Compiler(OpenFileDialog openFileDialog = null)
        {
            InitializeComponent();
            StringPath = openFileDialog?.FileName??"";
            IsSaved = true;
            undoIconToolStripMenuItem.Enabled = false;
            redoIconToolStripMenuItem.Enabled = false;
            if (openFileDialog == null)
            {
                labelDebug.Text = "Файл создан";
            }
            else
            {

                var fileStream = openFileDialog.OpenFile();

                using (var writer = new StreamReader(fileStream))
                {
                    inputTextBox.Text = writer.ReadToEnd();
                }
                labelDebug.Text = "Файл открыт";
            }
            initialText = inputTextBox.Text;
        }

        public string StringPath
        {
            get
            {
                return stringPath;
            }
            set
            {
                stringPath = value;
                if (IsSaved)
                {
                    this.Text = (stringPath == "" ? "Безымянный.txt" : Path.GetFileNameWithoutExtension(StringPath));
                }
                else
                {
                    this.Text = "*" + (stringPath == "" ? "Безымянный.txt" : Path.GetFileNameWithoutExtension(StringPath));
                }
            }
        }

        public bool IsSaved
        { 
            get
            {
                return isSaved;
            }
            set 
            { 
                isSaved = value;
                if (IsSaved)
                {
                    this.Text = (stringPath == "" ? "Безымянный.txt" : Path.GetFileNameWithoutExtension(StringPath));
                }
                else
                {
                    this.Text = "*" + (stringPath == "" ? "Безымянный.txt" : Path.GetFileNameWithoutExtension(StringPath));
                }
            }
        }

        private bool isSaved;
        private int countUndo;
        private string initialText;
        private string stringPath;

        private void Create()
        {
            Compiler compiler = new Compiler();
            compiler.Show();
            labelDebug.Text = "Файл создан в новом окне";
        }

        private void Open()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using (var writer = new StreamReader(fileStream))
                    {
                        inputTextBox.Text = writer.ReadToEnd();
                    }
                    labelDebug.Text = "Файл открыт";

                }

                IsSaved = true;
                labelDebug.Text = "Файл открыт в текущем окне";
            }
        }

        private void OpenNewTab()
        {

            using (OpenFileDialog saveFileDialog = new OpenFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Compiler compiler = new Compiler(saveFileDialog);
                    compiler.Show();

                }

                IsSaved = true;
                labelDebug.Text = "Файл открыт в новом окне";
            }
        }

        private bool WouldSaveFile()
        {
            return MessageBox.Show("Сохранить изменения?", "Compiler", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }


        private void Save()
        {
            if (StringPath == "")
            {
                SaveAs();
            }
            else
            {
                using (FileStream fs = File.Create(StringPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(inputTextBox.Text);
                    fs.Write(info, 0, info.Length);
                }
            }
            IsSaved = true;
            labelDebug.Text = "Файл сохранен";
        }

        private void SaveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(stringPath);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Read the contents of the file into a stream
                    var fileStream = saveFileDialog.OpenFile();

                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write(inputTextBox.Text);
                    }

                    //Get the path of specified file
                    StringPath = saveFileDialog.FileName;
                }
            }
            IsSaved = true;
            labelDebug.Text = "Файл сохранен как";
        }

        private void Undo()
        {
            countUndo++;
            inputTextBox.Undo();
            labelDebug.Text = "Операция отменена";
        }

        private void Redo()
        {
            countUndo = countUndo > 0 ? countUndo - 1:0;
            inputTextBox.Redo();
            labelDebug.Text = "Операция возвращена";
        }

        private void Reference()
        {
            System.Diagnostics.Process.Start("menu.chm");
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
            undoIconToolStripMenuItem.Enabled = initialText != inputTextBox.Text;
            redoIconToolStripMenuItem.Enabled = countUndo > 0;           
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
            if (inputTextBox.Text.Length == 0)
            {
                Open();
            }
            else
            {
                OpenNewTab();
            }
        }

        private void OpenIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length == 0)
            {
                Open();
            }
            else
            {
                OpenNewTab();
            }
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
            labelDebug.Text = "Текст вырезан";
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Copy();
            labelDebug.Text = "Текст скопирован";
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Paste();
            labelDebug.Text = "Текст вставлен";
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            labelDebug.Text = "Поле ввода очищено";
        }

        private void SelectAllВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.SelectAll();
            labelDebug.Text = "Весь текст выделен";
        }

        private void CopyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Copy();
            labelDebug.Text = "Текст скопирован";
        }

        private void CutIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Cut();
            labelDebug.Text = "Текст вырезан";
        }

        private void PasteIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Paste();
            labelDebug.Text = "Текст вставлен";
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            //undoIconToolStripMenuItem.Enabled = rtb.CanUndo;
            int i = rtb.SelectionStart;
            this.SuspendLayout();
            rtb.Undo();
            rtb.Redo();
            this.ResumeLayout();
            rtb.SelectionStart = i;
        }

        private void Compiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSaved)
            {
                if (WouldSaveFile())
                {
                    Save();
                }
            }
        }

        private void ReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference();
        }
    }
}
