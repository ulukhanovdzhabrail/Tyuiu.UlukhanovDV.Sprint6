namespace Tyuiu.UlukhanovDV.Sprint6.Task5.V22
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
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            groupBoxCondition = new GroupBox();
            textBoxCondition = new TextBox();
            panelLeft = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewNums = new DataGridView();
            splitterOutData = new Splitter();
            panel1 = new Panel();
            formsPlotBars = new ScottPlot.WinForms.FormsPlot();
            panelTop.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            panel1.SuspendLayout();
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
            panelTop.Size = new Size(793, 100);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top;
            buttonHelp.BackColor = Color.Navy;
            buttonHelp.ForeColor = SystemColors.ButtonHighlight;
            buttonHelp.Location = new Point(454, 19);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 53);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Crimson;
            buttonDone.ForeColor = SystemColors.ButtonHighlight;
            buttonDone.Location = new Point(688, 19);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 53);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top;
            buttonOpenFile.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile.ForeColor = SystemColors.WindowText;
            buttonOpenFile.Location = new Point(571, 19);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(93, 53);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxCondition);
            groupBoxCondition.Dock = DockStyle.Left;
            groupBoxCondition.Location = new Point(0, 0);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(435, 100);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Dock = DockStyle.Fill;
            textBoxCondition.Location = new Point(3, 19);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(429, 78);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView.Дан список из 20 чисел. Вывести все числа, больше 5.  Построить диаграмму по этим значениям.";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxOut);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 100);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(247, 372);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewNums);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(247, 372);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 19);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersVisible = false;
            dataGridViewNums.Size = new Size(241, 350);
            dataGridViewNums.TabIndex = 0;
            // 
            // splitterOutData
            // 
            splitterOutData.Location = new Point(247, 100);
            splitterOutData.Name = "splitterOutData";
            splitterOutData.Size = new Size(3, 372);
            splitterOutData.TabIndex = 2;
            splitterOutData.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlotBars);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 372);
            panel1.TabIndex = 3;
            // 
            // formsPlotBars
            // 
            formsPlotBars.DisplayScale = 1F;
            formsPlotBars.Dock = DockStyle.Fill;
            formsPlotBars.Location = new Point(0, 0);
            formsPlotBars.Name = "formsPlotBars";
            formsPlotBars.Size = new Size(543, 372);
            formsPlotBars.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 472);
            Controls.Add(panel1);
            Controls.Add(splitterOutData);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            MinimumSize = new Size(809, 511);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Улуханов Д.В.";
            panelTop.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private GroupBox groupBoxCondition;
        private TextBox textBoxCondition;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Panel panelLeft;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewNums;
        private Splitter splitterOutData;
        private Panel panel1;
        private ScottPlot.WinForms.FormsPlot formsPlotBars;
    }
}
