namespace Tyuiu.UlukhanovDV.Sprint6.Task0.V21
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
            buttonDone = new Button();
            textBoxIn = new TextBox();
            textBoxResult = new TextBox();
            textBoxTask = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(487, 265);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(136, 39);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(6, 19);
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(86, 23);
            textBoxIn.TabIndex = 1;
            textBoxIn.KeyPress += textBoxIn_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(86, 23);
            textBoxResult.TabIndex = 2;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Window;
            textBoxTask.Location = new Point(9, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(289, 107);
            textBoxTask.TabIndex = 3;
            textBoxTask.Text = "Вычислить выражение по формуле. при x=2, результат вывести в TextBox, округлить до трёх знаков после запятой.";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 45);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Location = new Point(9, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 90);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxIn);
            groupBox5.Location = new Point(9, 25);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(128, 59);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Переменная X";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(178, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(160, 90);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxResult);
            groupBox4.Location = new Point(6, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(128, 59);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxTask);
            groupBox3.Location = new Point(9, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(329, 143);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(437, 265);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(38, 39);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 316);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Улуханов Д. В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxIn;
        private TextBox textBoxResult;
        private TextBox textBoxTask;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonHelp;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
    }
}
