namespace Tutorial2_5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cardFacePictureBox = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            cardBackPictureBox = new PictureBox();
            label1 = new Label();
            showBackButton = new Button();
            showFaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardFacePictureBox
            // 
            cardFacePictureBox.Image = (Image)resources.GetObject("cardFacePictureBox.Image");
            cardFacePictureBox.Location = new Point(51, 12);
            cardFacePictureBox.Name = "cardFacePictureBox";
            cardFacePictureBox.Size = new Size(400, 489);
            cardFacePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFacePictureBox.TabIndex = 0;
            cardFacePictureBox.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 1;
            // 
            // cardBackPictureBox
            // 
            cardBackPictureBox.ErrorImage = (Image)resources.GetObject("cardBackPictureBox.ErrorImage");
            cardBackPictureBox.Image = Properties.Resources.Backface_Blue1;
            cardBackPictureBox.Location = new Point(713, 12);
            cardBackPictureBox.Name = "cardBackPictureBox";
            cardBackPictureBox.Size = new Size(400, 489);
            cardBackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBackPictureBox.TabIndex = 2;
            cardBackPictureBox.TabStop = false;
            cardBackPictureBox.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 540);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // showBackButton
            // 
            showBackButton.Location = new Point(743, 549);
            showBackButton.Name = "showBackButton";
            showBackButton.Size = new Size(348, 39);
            showBackButton.TabIndex = 4;
            showBackButton.Text = "顯示背面";
            showBackButton.UseVisualStyleBackColor = true;
            showBackButton.Click += button1_Click;
            // 
            // showFaceButton
            // 
            showFaceButton.Location = new Point(68, 532);
            showFaceButton.Name = "showFaceButton";
            showFaceButton.Size = new Size(368, 39);
            showFaceButton.TabIndex = 5;
            showFaceButton.Text = "顯示正面";
            showFaceButton.UseVisualStyleBackColor = true;
            showFaceButton.Click += showFaceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(showFaceButton);
            Controls.Add(showBackButton);
            Controls.Add(label1);
            Controls.Add(cardBackPictureBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(cardFacePictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBackPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cardFacePictureBox;
        private DateTimePicker dateTimePicker1;
        private PictureBox cardBackPictureBox;
        private Label label1;
        private Button showBackButton;
        private Button showFaceButton;
    }
}
