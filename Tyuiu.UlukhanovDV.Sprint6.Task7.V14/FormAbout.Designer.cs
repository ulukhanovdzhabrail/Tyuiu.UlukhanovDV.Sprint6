namespace Tyuiu.UlukhanovDV.Sprint6.Task7.V14
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_UDV = new PictureBox();
            labelInfo_UDV = new Label();
            buttonOK_UDV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_UDV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_UDV
            // 
            pictureBox_UDV.Location = new Point(28, 33);
            pictureBox_UDV.Name = "pictureBox_UDV";
            pictureBox_UDV.Size = new Size(106, 139);
            pictureBox_UDV.TabIndex = 0;
            pictureBox_UDV.TabStop = false;
            // 
            // labelInfo_UDV
            // 
            labelInfo_UDV.AutoSize = true;
            labelInfo_UDV.Location = new Point(167, 36);
            labelInfo_UDV.Name = "labelInfo_UDV";
            labelInfo_UDV.Size = new Size(295, 105);
            labelInfo_UDV.TabIndex = 1;
            labelInfo_UDV.Text = resources.GetString("labelInfo_UDV.Text");
            // 
            // buttonOK_UDV
            // 
            buttonOK_UDV.BackColor = SystemColors.ButtonHighlight;
            buttonOK_UDV.Location = new Point(345, 149);
            buttonOK_UDV.Name = "buttonOK_UDV";
            buttonOK_UDV.Size = new Size(117, 23);
            buttonOK_UDV.TabIndex = 0;
            buttonOK_UDV.Text = "Ок";
            buttonOK_UDV.UseVisualStyleBackColor = false;
            buttonOK_UDV.Click += buttonOK_UDV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(buttonOK_UDV);
            Controls.Add(labelInfo_UDV);
            Controls.Add(pictureBox_UDV);
            MaximumSize = new Size(500, 250);
            MinimumSize = new Size(500, 250);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_UDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_UDV;
        private Label labelInfo_UDV;
        private Button buttonOK_UDV;
    }
}