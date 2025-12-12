namespace Tyuiu.UlukhanovDV.Sprint6.Task1.V5
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
            textBoxCondition = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxIn = new GroupBox();
            groupBoxInStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxInStart = new GroupBox();
            textBoxStart = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOut = new GroupBox();
            groupBoxRes = new GroupBox();
            textBoxResult = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxIn.SuspendLayout();
            groupBoxInStop.SuspendLayout();
            groupBoxInStart.SuspendLayout();
            groupBoxOut.SuspendLayout();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(6, 19);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(185, 81);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Написать программу, которая выводит таблицу значений функции (произвести табулирование)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCondition);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(groupBoxInStop);
            groupBoxIn.Controls.Add(groupBoxInStart);
            groupBoxIn.Location = new Point(16, 251);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(312, 100);
            groupBoxIn.TabIndex = 2;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод данных";
            // 
            // groupBoxInStop
            // 
            groupBoxInStop.Controls.Add(textBoxStop);
            groupBoxInStop.Location = new Point(159, 31);
            groupBoxInStop.Name = "groupBoxInStop";
            groupBoxInStop.Size = new Size(132, 57);
            groupBoxInStop.TabIndex = 1;
            groupBoxInStop.TabStop = false;
            groupBoxInStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 22);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(82, 23);
            textBoxStop.TabIndex = 3;
            // 
            // groupBoxInStart
            // 
            groupBoxInStart.Controls.Add(textBoxStart);
            groupBoxInStart.Location = new Point(6, 31);
            groupBoxInStart.Name = "groupBoxInStart";
            groupBoxInStart.Size = new Size(132, 57);
            groupBoxInStart.TabIndex = 0;
            groupBoxInStart.TabStop = false;
            groupBoxInStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 22);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(82, 23);
            textBoxStart.TabIndex = 3;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MidnightBlue;
            buttonHelp.ForeColor = SystemColors.ButtonHighlight;
            buttonHelp.Location = new Point(354, 305);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(86, 46);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(128, 64, 0);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(446, 305);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(86, 46);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(groupBoxRes);
            groupBoxOut.Location = new Point(558, 12);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(209, 339);
            groupBoxOut.TabIndex = 5;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(6, 22);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(197, 302);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(11, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(176, 268);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 367);
            Controls.Add(groupBoxOut);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxIn);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 5 | Улуханов Д.В.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxIn.ResumeLayout(false);
            groupBoxInStop.ResumeLayout(false);
            groupBoxInStop.PerformLayout();
            groupBoxInStart.ResumeLayout(false);
            groupBoxInStart.PerformLayout();
            groupBoxOut.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxCondition;
        private GroupBox groupBox1;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxInStop;
        private GroupBox groupBoxInStart;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxOut;
        private GroupBox groupBoxRes;
        private TextBox textBoxResult;
    }
}
