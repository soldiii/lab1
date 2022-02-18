namespace CompilerLab
{
    partial class Compiler
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripIcons = new System.Windows.Forms.MenuStrip();
            this.createIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTexts = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.menuStripIcons.SuspendLayout();
            this.menuStripTexts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripIcons
            // 
            this.menuStripIcons.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createIconToolStripMenuItem,
            this.openIconToolStripMenuItem,
            this.saveIconToolStripMenuItem,
            this.undoIconToolStripMenuItem,
            this.redoIconToolStripMenuItem,
            this.copyIconToolStripMenuItem,
            this.cutIconToolStripMenuItem,
            this.PasteIconToolStripMenuItem});
            this.menuStripIcons.Location = new System.Drawing.Point(0, 24);
            this.menuStripIcons.Name = "menuStripIcons";
            this.menuStripIcons.Size = new System.Drawing.Size(685, 40);
            this.menuStripIcons.TabIndex = 0;
            this.menuStripIcons.Text = "menuStrip1";
            // 
            // createIconToolStripMenuItem
            // 
            this.createIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.file_solid;
            this.createIconToolStripMenuItem.Name = "createIconToolStripMenuItem";
            this.createIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.createIconToolStripMenuItem.Click += new System.EventHandler(this.CreateIconToolStripMenuItem_Click);
            // 
            // openIconToolStripMenuItem
            // 
            this.openIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.folder_open_solid;
            this.openIconToolStripMenuItem.Name = "openIconToolStripMenuItem";
            this.openIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.openIconToolStripMenuItem.Click += new System.EventHandler(this.OpenIconToolStripMenuItem_Click);
            // 
            // saveIconToolStripMenuItem
            // 
            this.saveIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.floppy_disk_solid;
            this.saveIconToolStripMenuItem.Name = "saveIconToolStripMenuItem";
            this.saveIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.saveIconToolStripMenuItem.Click += new System.EventHandler(this.SaveIconToolStripMenuItem_Click);
            // 
            // undoIconToolStripMenuItem
            // 
            this.undoIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.rotate_left_solid;
            this.undoIconToolStripMenuItem.Name = "undoIconToolStripMenuItem";
            this.undoIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.undoIconToolStripMenuItem.Click += new System.EventHandler(this.UndoIconToolStripMenuItem1_Click);
            // 
            // redoIconToolStripMenuItem
            // 
            this.redoIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.rotate_right_solid;
            this.redoIconToolStripMenuItem.Name = "redoIconToolStripMenuItem";
            this.redoIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.redoIconToolStripMenuItem.Click += new System.EventHandler(this.RedoIconToolStripMenuItem_Click);
            // 
            // copyIconToolStripMenuItem
            // 
            this.copyIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.copy_solid;
            this.copyIconToolStripMenuItem.Name = "copyIconToolStripMenuItem";
            this.copyIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.copyIconToolStripMenuItem.Click += new System.EventHandler(this.CopyIconToolStripMenuItem_Click);
            // 
            // cutIconToolStripMenuItem
            // 
            this.cutIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.scissors_solid;
            this.cutIconToolStripMenuItem.Name = "cutIconToolStripMenuItem";
            this.cutIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.cutIconToolStripMenuItem.Click += new System.EventHandler(this.CutIconToolStripMenuItem_Click);
            // 
            // PasteIconToolStripMenuItem
            // 
            this.PasteIconToolStripMenuItem.Image = global::CompilerLab.Properties.Resources.paste_solid;
            this.PasteIconToolStripMenuItem.Name = "PasteIconToolStripMenuItem";
            this.PasteIconToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.PasteIconToolStripMenuItem.Click += new System.EventHandler(this.PasteIconToolStripMenuItem_Click);
            // 
            // menuStripTexts
            // 
            this.menuStripTexts.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripTexts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripTexts.Location = new System.Drawing.Point(0, 0);
            this.menuStripTexts.Name = "menuStripTexts";
            this.menuStripTexts.Size = new System.Drawing.Size(685, 24);
            this.menuStripTexts.TabIndex = 1;
            this.menuStripTexts.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllВсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Повторить";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить все";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // selectAllВсеToolStripMenuItem
            // 
            this.selectAllВсеToolStripMenuItem.Name = "selectAllВсеToolStripMenuItem";
            this.selectAllВсеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllВсеToolStripMenuItem.Text = "Выделить все";
            this.selectAllВсеToolStripMenuItem.Click += new System.EventHandler(this.SelectAllВсеToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.пускToolStripMenuItem.Text = "Пуск";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReferenceToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ReferenceToolStripMenuItem
            // 
            this.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            this.ReferenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReferenceToolStripMenuItem.Text = "Вызов справки";
            this.ReferenceToolStripMenuItem.Click += new System.EventHandler(this.ReferenceToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 67);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(776, 169);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 258);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(776, 169);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(12, 431);
            this.labelDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(0, 13);
            this.labelDebug.TabIndex = 4;
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.menuStripIcons);
            this.Controls.Add(this.menuStripTexts);
            this.MainMenuStrip = this.menuStripIcons;
            this.Name = "Compiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compiler_FormClosing);
            this.menuStripIcons.ResumeLayout(false);
            this.menuStripIcons.PerformLayout();
            this.menuStripTexts.ResumeLayout(false);
            this.menuStripTexts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripIcons;
        private System.Windows.Forms.ToolStripMenuItem createIconToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripTexts;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteIconToolStripMenuItem;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label labelDebug;
    }
}

