namespace Tyuiu.UlukhanovDV.Sprint6.Task6.V19
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            groupBoxCondition = new GroupBox();
            textBoxIn = new TextBox();
            panelLeft = new Panel();
            groupBoxText = new GroupBox();
            textBoxTextInFile = new TextBox();
            splitterIn = new Splitter();
            panelFill = new Panel();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelTop.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxText.SuspendLayout();
            panelFill.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Controls.Add(groupBoxCondition);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(834, 125);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ButtonHighlight;
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.DialogResult = DialogResult.OK;
            buttonHelp.Dock = DockStyle.Right;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(732, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(102, 55);
            buttonHelp.TabIndex = 1;
            toolTip.SetToolTip(buttonHelp, "Автор работы");
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top;
            buttonDone.BackColor = SystemColors.ButtonHighlight;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(115, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(102, 55);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Производит поиск в файле вхождений символов и\r\n конкатенирует строки в которых находятся эти символы");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile.Cursor = Cursors.Hand;
            buttonOpenFile.Dock = DockStyle.Left;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(0, 0);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(109, 55);
            buttonOpenFile.TabIndex = 1;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxIn);
            groupBoxCondition.Dock = DockStyle.Bottom;
            groupBoxCondition.Location = new Point(0, 55);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(834, 70);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(828, 48);
            textBoxIn.TabIndex = 0;
            textBoxIn.Text = resources.GetString("textBoxIn.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxText);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 125);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 346);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxText
            // 
            groupBoxText.Controls.Add(textBoxTextInFile);
            groupBoxText.Dock = DockStyle.Fill;
            groupBoxText.Location = new Point(0, 0);
            groupBoxText.Name = "groupBoxText";
            groupBoxText.Size = new Size(250, 346);
            groupBoxText.TabIndex = 0;
            groupBoxText.TabStop = false;
            groupBoxText.Text = "Ввод";
            // 
            // textBoxTextInFile
            // 
            textBoxTextInFile.Dock = DockStyle.Fill;
            textBoxTextInFile.Location = new Point(3, 19);
            textBoxTextInFile.Multiline = true;
            textBoxTextInFile.Name = "textBoxTextInFile";
            textBoxTextInFile.ReadOnly = true;
            textBoxTextInFile.ScrollBars = ScrollBars.Vertical;
            textBoxTextInFile.Size = new Size(244, 324);
            textBoxTextInFile.TabIndex = 2;
            // 
            // splitterIn
            // 
            splitterIn.Location = new Point(250, 125);
            splitterIn.Name = "splitterIn";
            splitterIn.Size = new Size(3, 346);
            splitterIn.TabIndex = 2;
            splitterIn.TabStop = false;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(groupBoxResult);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(253, 125);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(581, 346);
            panelFill.TabIndex = 3;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(581, 346);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(575, 324);
            textBoxResult.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialogTask_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 471);
            Controls.Add(panelFill);
            Controls.Add(splitterIn);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            MinimumSize = new Size(850, 510);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 19 | Улуханов Д.В.";
            panelTop.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxText.ResumeLayout(false);
            groupBoxText.PerformLayout();
            panelFill.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private GroupBox groupBoxCondition;
        private TextBox textBoxIn;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private Panel panelLeft;
        private GroupBox groupBoxText;
        private TextBox textBoxTextInFile;
        private Splitter splitterIn;
        private Panel panelFill;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
