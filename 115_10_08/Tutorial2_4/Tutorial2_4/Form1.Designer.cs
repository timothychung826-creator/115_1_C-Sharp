namespace Tutorial2_4
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
            germanypictureBox = new PictureBox();
            francepictureBox = new PictureBox();
            finlandpictureBox = new PictureBox();
            countrylabel = new Label();
            ((System.ComponentModel.ISupportInitialize)germanypictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finlandpictureBox).BeginInit();
            SuspendLayout();
            // 
            // germanypictureBox
            // 
            germanypictureBox.Image = Properties.Resources.Germany;
            germanypictureBox.Location = new Point(334, 174);
            germanypictureBox.Name = "germanypictureBox";
            germanypictureBox.Size = new Size(121, 71);
            germanypictureBox.TabIndex = 1;
            germanypictureBox.TabStop = false;
            germanypictureBox.Click += pictureBox2_Click;
            // 
            // francepictureBox
            // 
            francepictureBox.Image = Properties.Resources.France;
            francepictureBox.Location = new Point(589, 174);
            francepictureBox.Name = "francepictureBox";
            francepictureBox.Size = new Size(121, 71);
            francepictureBox.TabIndex = 2;
            francepictureBox.TabStop = false;
            // 
            // finlandpictureBox
            // 
            finlandpictureBox.Image = Properties.Resources.Finland;
            finlandpictureBox.Location = new Point(64, 174);
            finlandpictureBox.Name = "finlandpictureBox";
            finlandpictureBox.Size = new Size(120, 71);
            finlandpictureBox.TabIndex = 3;
            finlandpictureBox.TabStop = false;
            finlandpictureBox.Click += picturBox4_Click;
            // 
            // countrylabel
            // 
            countrylabel.AutoSize = true;
            countrylabel.Location = new Point(394, 320);
            countrylabel.Name = "countrylabel";
            countrylabel.Size = new Size(61, 23);
            countrylabel.TabIndex = 4;
            countrylabel.Text = "label1";
            countrylabel.Click += countrylabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countrylabel);
            Controls.Add(finlandpictureBox);
            Controls.Add(francepictureBox);
            Controls.Add(germanypictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)germanypictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)finlandpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox germanypictureBox;
        private PictureBox francepictureBox;
        private PictureBox finlandpictureBox;
        private Label countrylabel;
    }
}
