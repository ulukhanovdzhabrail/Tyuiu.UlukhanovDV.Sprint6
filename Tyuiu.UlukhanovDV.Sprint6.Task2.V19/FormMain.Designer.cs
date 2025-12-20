namespace Tyuiu.UlukhanovDV.Sprint6.Task2.V19
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
            groupBoxCondition = new GroupBox();
            textBoxCondition = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxStop = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStart = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOut = new GroupBox();
            groupBoxResult = new GroupBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            formsPlotFunction = new ScottPlot.WinForms.FormsPlot();
            groupBoxCondition.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxOut.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxCondition);
            groupBoxCondition.Location = new Point(21, 17);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(372, 203);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(6, 22);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(288, 111);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Написать программу, которая выводит таблицу значений функции (произвести табулирование)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(31, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStop);
            groupBox3.Location = new Point(163, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(141, 77);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 38);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(120, 23);
            textBoxStop.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Location = new Point(16, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 76);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(120, 23);
            textBoxStart.TabIndex = 2;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Navy;
            buttonHelp.ForeColor = SystemColors.ButtonHighlight;
            buttonHelp.Location = new Point(417, 370);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(123, 52);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.SaddleBrown;
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(546, 370);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(123, 52);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(groupBoxResult);
            groupBoxOut.Location = new Point(417, 17);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(525, 347);
            groupBoxOut.TabIndex = 4;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridView);
            groupBoxResult.Controls.Add(formsPlotFunction);
            groupBoxResult.Location = new Point(9, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(510, 316);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView.Location = new Point(15, 22);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(186, 275);
            dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 92;
            // 
            // formsPlotFunction
            // 
            formsPlotFunction.DisplayScale = 1F;
            formsPlotFunction.Location = new Point(197, 11);
            formsPlotFunction.Name = "formsPlotFunction";
            formsPlotFunction.Size = new Size(307, 286);
            formsPlotFunction.TabIndex = 0;
            formsPlotFunction.Load += formsPlotFunction_Load;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(groupBoxOut);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 19 | Улуханов Д.В.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxOut.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private TextBox textBoxCondition;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonHelp;
        private GroupBox groupBoxOut;
        private ScottPlot.WinForms.FormsPlot formsPlotFunction;
        private GroupBox groupBoxResult;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonDone;
    }
}
