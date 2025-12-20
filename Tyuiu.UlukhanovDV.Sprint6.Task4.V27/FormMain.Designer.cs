namespace Tyuiu.UlukhanovDV.Sprint6.Task4.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            textBoxStop = new TextBox();
            groupBox3 = new GroupBox();
            textBoxStart = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonSave = new Button();
            groupBox5 = new GroupBox();
            textBoxRes = new TextBox();
            formsPlotFunction = new ScottPlot.WinForms.FormsPlot();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            splitter1 = new Splitter();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(407, 83);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(455, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 112);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStop);
            groupBox4.Location = new Point(169, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(157, 83);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Конец шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 37);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(130, 23);
            textBoxStop.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(157, 83);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Старт шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(130, 23);
            textBoxStart.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.SaddleBrown;
            buttonHelp.ForeColor = SystemColors.ButtonHighlight;
            buttonHelp.Location = new Point(806, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(107, 51);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Navy;
            buttonDone.ForeColor = SystemColors.ButtonHighlight;
            buttonDone.Location = new Point(992, 20);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 51);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.BackColor = Color.DarkViolet;
            buttonSave.ForeColor = SystemColors.ButtonHighlight;
            buttonSave.Location = new Point(879, 79);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(220, 49);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxRes);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(419, 322);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод данных";
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(3, 19);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(413, 300);
            textBoxRes.TabIndex = 0;
            // 
            // formsPlotFunction
            // 
            formsPlotFunction.DisplayScale = 1F;
            formsPlotFunction.Dock = DockStyle.Fill;
            formsPlotFunction.Location = new Point(0, 0);
            formsPlotFunction.Name = "formsPlotFunction";
            formsPlotFunction.Size = new Size(661, 322);
            formsPlotFunction.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 140);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(groupBox5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 322);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlotFunction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(446, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 322);
            panel3.TabIndex = 6;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(419, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(9, 322);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 462);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1050, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 27 | Улуханов Д.В.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStop;
        private GroupBox groupBox3;
        private TextBox textBoxStart;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonSave;
        private GroupBox groupBox5;
        private TextBox textBoxRes;
        private ScottPlot.WinForms.FormsPlot formsPlotFunction;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
    }
}
