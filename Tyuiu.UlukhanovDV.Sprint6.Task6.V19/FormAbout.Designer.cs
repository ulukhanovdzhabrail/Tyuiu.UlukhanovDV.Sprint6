namespace Tyuiu.UlukhanovDV.Sprint6.Task6.V19
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
            pictureBoxFoto = new PictureBox();
            labelInfo = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(23, 27);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(107, 142);
            pictureBoxFoto.TabIndex = 0;
            pictureBoxFoto.TabStop = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(151, 31);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(295, 105);
            labelInfo.TabIndex = 1;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(319, 146);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(127, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 193);
            Controls.Add(labelInfo);
            Controls.Add(pictureBoxFoto);
            Controls.Add(buttonOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFoto;
        private Label labelInfo;
        private Button buttonOK;
    }
}