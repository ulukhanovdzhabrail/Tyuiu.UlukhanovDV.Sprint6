namespace Tyuiu.UlukhanovDV.Sprint6.Task3.V2
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
            groupBoxIn = new GroupBox();
            dataGridViewCondition = new DataGridView();
            textBox = new TextBox();
            groupBoxOut = new GroupBox();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition).BeginInit();
            groupBoxOut.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewCondition);
            groupBoxIn.Controls.Add(textBox);
            groupBoxIn.Location = new Point(18, 24);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(505, 296);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Условие";
            // 
            // dataGridViewCondition
            // 
            dataGridViewCondition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCondition.ColumnHeadersVisible = false;
            dataGridViewCondition.Location = new Point(230, 45);
            dataGridViewCondition.Name = "dataGridViewCondition";
            dataGridViewCondition.RowHeadersVisible = false;
            dataGridViewCondition.Size = new Size(137, 128);
            dataGridViewCondition.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Location = new Point(6, 45);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(178, 226);
            textBox.TabIndex = 0;
            textBox.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n-12  -4 -20   5  -5\r\n\r\n   2  15   1 -20   7\r\n\r\n  15 -15   2  11   5\r\n\r\n -19  -9  16   0   1\r\n\r\n  17  16   5  12  -8\r\n";
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(groupBoxResult);
            groupBoxOut.Location = new Point(539, 24);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(292, 296);
            groupBoxOut.TabIndex = 1;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(6, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(273, 260);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Location = new Point(6, 23);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(137, 128);
            dataGridViewResult.TabIndex = 0;
            dataGridViewResult.CellContentClick += dataGridViewResult_CellContentClick;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(464, 334);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(367, 31);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(18, 334);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(367, 31);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 383);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Улуханов Д.В.";
            Load += FormMain_Load;
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition).EndInit();
            groupBoxOut.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIn;
        private TextBox textBox;
        private DataGridView dataGridViewCondition;
        private GroupBox groupBoxOut;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewResult;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
