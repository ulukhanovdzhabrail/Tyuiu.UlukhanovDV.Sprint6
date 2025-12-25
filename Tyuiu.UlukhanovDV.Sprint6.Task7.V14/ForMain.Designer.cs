namespace Tyuiu.UlukhanovDV.Sprint6.Task7.V14
{
    partial class ForMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForMain));
            buttonOpenFile_UDV = new Button();
            panelTop_UDV = new Panel();
            buttonHelp_UDV = new Button();
            buttonSave_UDV = new Button();
            groupBoxCondition_UDV = new GroupBox();
            textBoxCondition_UDV = new TextBox();
            buttonDone_UDV = new Button();
            toolTip_UDV = new ToolTip(components);
            panelLeft_UDV = new Panel();
            groupBoxInput_UDV = new GroupBox();
            dataGridViewInput_UDV = new DataGridView();
            splitterInput_UDV = new Splitter();
            panelFill_UDV = new Panel();
            groupBoxOutput_UDV = new GroupBox();
            dataGridViewOutput_UDV = new DataGridView();
            openFileDialogTask_UDV = new OpenFileDialog();
            saveFileDialog_UDV = new SaveFileDialog();
            panelTop_UDV.SuspendLayout();
            groupBoxCondition_UDV.SuspendLayout();
            panelLeft_UDV.SuspendLayout();
            groupBoxInput_UDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_UDV).BeginInit();
            panelFill_UDV.SuspendLayout();
            groupBoxOutput_UDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_UDV).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_UDV
            // 
            buttonOpenFile_UDV.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile_UDV.Cursor = Cursors.Hand;
            buttonOpenFile_UDV.Image = (Image)resources.GetObject("buttonOpenFile_UDV.Image");
            buttonOpenFile_UDV.Location = new Point(3, 3);
            buttonOpenFile_UDV.Name = "buttonOpenFile_UDV";
            buttonOpenFile_UDV.Size = new Size(84, 52);
            buttonOpenFile_UDV.TabIndex = 0;
            toolTip_UDV.SetToolTip(buttonOpenFile_UDV, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_UDV.UseVisualStyleBackColor = false;
            buttonOpenFile_UDV.Click += buttonOpenFile_UDV_Click;
            // 
            // panelTop_UDV
            // 
            panelTop_UDV.Controls.Add(buttonHelp_UDV);
            panelTop_UDV.Controls.Add(buttonSave_UDV);
            panelTop_UDV.Controls.Add(groupBoxCondition_UDV);
            panelTop_UDV.Controls.Add(buttonDone_UDV);
            panelTop_UDV.Controls.Add(buttonOpenFile_UDV);
            panelTop_UDV.Dock = DockStyle.Top;
            panelTop_UDV.Location = new Point(0, 0);
            panelTop_UDV.Name = "panelTop_UDV";
            panelTop_UDV.Size = new Size(939, 129);
            panelTop_UDV.TabIndex = 1;
            // 
            // buttonHelp_UDV
            // 
            buttonHelp_UDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_UDV.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_UDV.Cursor = Cursors.Hand;
            buttonHelp_UDV.Image = (Image)resources.GetObject("buttonHelp_UDV.Image");
            buttonHelp_UDV.Location = new Point(852, 3);
            buttonHelp_UDV.Name = "buttonHelp_UDV";
            buttonHelp_UDV.Size = new Size(84, 52);
            buttonHelp_UDV.TabIndex = 2;
            toolTip_UDV.SetToolTip(buttonHelp_UDV, "Сведения о программе");
            buttonHelp_UDV.UseVisualStyleBackColor = false;
            buttonHelp_UDV.Click += buttonHelp_UDV_Click;
            // 
            // buttonSave_UDV
            // 
            buttonSave_UDV.Anchor = AnchorStyles.Top;
            buttonSave_UDV.BackColor = SystemColors.ButtonHighlight;
            buttonSave_UDV.Cursor = Cursors.Hand;
            buttonSave_UDV.Enabled = false;
            buttonSave_UDV.Image = (Image)resources.GetObject("buttonSave_UDV.Image");
            buttonSave_UDV.Location = new Point(183, 3);
            buttonSave_UDV.Name = "buttonSave_UDV";
            buttonSave_UDV.Size = new Size(84, 52);
            buttonSave_UDV.TabIndex = 2;
            toolTip_UDV.SetToolTip(buttonSave_UDV, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_UDV.UseVisualStyleBackColor = false;
            buttonSave_UDV.Click += buttonSave_UDV_Click;
            // 
            // groupBoxCondition_UDV
            // 
            groupBoxCondition_UDV.Controls.Add(textBoxCondition_UDV);
            groupBoxCondition_UDV.Dock = DockStyle.Bottom;
            groupBoxCondition_UDV.Location = new Point(0, 61);
            groupBoxCondition_UDV.Name = "groupBoxCondition_UDV";
            groupBoxCondition_UDV.Size = new Size(939, 68);
            groupBoxCondition_UDV.TabIndex = 3;
            groupBoxCondition_UDV.TabStop = false;
            groupBoxCondition_UDV.Text = "Условие";
            // 
            // textBoxCondition_UDV
            // 
            textBoxCondition_UDV.Dock = DockStyle.Fill;
            textBoxCondition_UDV.Location = new Point(3, 19);
            textBoxCondition_UDV.Multiline = true;
            textBoxCondition_UDV.Name = "textBoxCondition_UDV";
            textBoxCondition_UDV.ReadOnly = true;
            textBoxCondition_UDV.Size = new Size(933, 46);
            textBoxCondition_UDV.TabIndex = 0;
            textBoxCondition_UDV.Text = resources.GetString("textBoxCondition_UDV.Text");
            // 
            // buttonDone_UDV
            // 
            buttonDone_UDV.Anchor = AnchorStyles.Top;
            buttonDone_UDV.BackColor = SystemColors.ButtonHighlight;
            buttonDone_UDV.Cursor = Cursors.Hand;
            buttonDone_UDV.Enabled = false;
            buttonDone_UDV.Image = (Image)resources.GetObject("buttonDone_UDV.Image");
            buttonDone_UDV.Location = new Point(93, 3);
            buttonDone_UDV.Name = "buttonDone_UDV";
            buttonDone_UDV.Size = new Size(84, 52);
            buttonDone_UDV.TabIndex = 2;
            toolTip_UDV.SetToolTip(buttonDone_UDV, "Выполнить обработку данных");
            buttonDone_UDV.UseVisualStyleBackColor = false;
            buttonDone_UDV.Click += buttonDone_UDV_Click;
            // 
            // panelLeft_UDV
            // 
            panelLeft_UDV.Controls.Add(groupBoxInput_UDV);
            panelLeft_UDV.Dock = DockStyle.Left;
            panelLeft_UDV.Location = new Point(0, 129);
            panelLeft_UDV.Name = "panelLeft_UDV";
            panelLeft_UDV.Size = new Size(312, 401);
            panelLeft_UDV.TabIndex = 2;
            // 
            // groupBoxInput_UDV
            // 
            groupBoxInput_UDV.Controls.Add(dataGridViewInput_UDV);
            groupBoxInput_UDV.Dock = DockStyle.Fill;
            groupBoxInput_UDV.Location = new Point(0, 0);
            groupBoxInput_UDV.Name = "groupBoxInput_UDV";
            groupBoxInput_UDV.Size = new Size(312, 401);
            groupBoxInput_UDV.TabIndex = 0;
            groupBoxInput_UDV.TabStop = false;
            groupBoxInput_UDV.Text = "Ввод";
            // 
            // dataGridViewInput_UDV
            // 
            dataGridViewInput_UDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_UDV.ColumnHeadersVisible = false;
            dataGridViewInput_UDV.Dock = DockStyle.Fill;
            dataGridViewInput_UDV.Location = new Point(3, 19);
            dataGridViewInput_UDV.Name = "dataGridViewInput_UDV";
            dataGridViewInput_UDV.ReadOnly = true;
            dataGridViewInput_UDV.RowHeadersVisible = false;
            dataGridViewInput_UDV.Size = new Size(306, 379);
            dataGridViewInput_UDV.TabIndex = 0;
            // 
            // splitterInput_UDV
            // 
            splitterInput_UDV.Location = new Point(312, 129);
            splitterInput_UDV.Name = "splitterInput_UDV";
            splitterInput_UDV.Size = new Size(3, 401);
            splitterInput_UDV.TabIndex = 3;
            splitterInput_UDV.TabStop = false;
            // 
            // panelFill_UDV
            // 
            panelFill_UDV.Controls.Add(groupBoxOutput_UDV);
            panelFill_UDV.Dock = DockStyle.Fill;
            panelFill_UDV.Location = new Point(315, 129);
            panelFill_UDV.Name = "panelFill_UDV";
            panelFill_UDV.Size = new Size(624, 401);
            panelFill_UDV.TabIndex = 4;
            // 
            // groupBoxOutput_UDV
            // 
            groupBoxOutput_UDV.Controls.Add(dataGridViewOutput_UDV);
            groupBoxOutput_UDV.Dock = DockStyle.Fill;
            groupBoxOutput_UDV.Location = new Point(0, 0);
            groupBoxOutput_UDV.Name = "groupBoxOutput_UDV";
            groupBoxOutput_UDV.Size = new Size(624, 401);
            groupBoxOutput_UDV.TabIndex = 0;
            groupBoxOutput_UDV.TabStop = false;
            groupBoxOutput_UDV.Text = "Вывод";
            // 
            // dataGridViewOutput_UDV
            // 
            dataGridViewOutput_UDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_UDV.ColumnHeadersVisible = false;
            dataGridViewOutput_UDV.Dock = DockStyle.Fill;
            dataGridViewOutput_UDV.Location = new Point(3, 19);
            dataGridViewOutput_UDV.Name = "dataGridViewOutput_UDV";
            dataGridViewOutput_UDV.ReadOnly = true;
            dataGridViewOutput_UDV.RowHeadersVisible = false;
            dataGridViewOutput_UDV.Size = new Size(618, 379);
            dataGridViewOutput_UDV.TabIndex = 0;
            // 
            // openFileDialogTask_UDV
            // 
            openFileDialogTask_UDV.FileName = "openFileDialog1";
            // 
            // ForMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 530);
            Controls.Add(panelFill_UDV);
            Controls.Add(splitterInput_UDV);
            Controls.Add(panelLeft_UDV);
            Controls.Add(panelTop_UDV);
            MinimumSize = new Size(955, 569);
            Name = "ForMain";
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Улуханов Д.В.";
            panelTop_UDV.ResumeLayout(false);
            groupBoxCondition_UDV.ResumeLayout(false);
            groupBoxCondition_UDV.PerformLayout();
            panelLeft_UDV.ResumeLayout(false);
            groupBoxInput_UDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_UDV).EndInit();
            panelFill_UDV.ResumeLayout(false);
            groupBoxOutput_UDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_UDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_UDV;
        private Panel panelTop_UDV;
        private ToolTip toolTip_UDV;
        private Button buttonDone_UDV;
        private GroupBox groupBoxCondition_UDV;
        private TextBox textBoxCondition_UDV;
        private Button buttonSave_UDV;
        private Button buttonHelp_UDV;
        private Panel panelLeft_UDV;
        private GroupBox groupBoxInput_UDV;
        private DataGridView dataGridViewInput_UDV;
        private Splitter splitterInput_UDV;
        private Panel panelFill_UDV;
        private GroupBox groupBoxOutput_UDV;
        private DataGridView dataGridViewOutput_UDV;
        private OpenFileDialog openFileDialogTask_UDV;
        private SaveFileDialog saveFileDialog_UDV;
    }
}
