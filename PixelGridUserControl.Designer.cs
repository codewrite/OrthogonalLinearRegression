namespace OrthogonalLinearRegression
{
    partial class PixelGridUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PixlPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PixlPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PixlPictureBox
            // 
            this.PixlPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PixlPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PixlPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PixlPictureBox.Name = "PixlPictureBox";
            this.PixlPictureBox.Size = new System.Drawing.Size(256, 256);
            this.PixlPictureBox.TabIndex = 0;
            this.PixlPictureBox.TabStop = false;
            this.PixlPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PixlPictureBox_Paint);
            this.PixlPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PixlPictureBox_MouseClick);
            this.PixlPictureBox.Resize += new System.EventHandler(this.PixlPictureBox_Resize);
            // 
            // PixelGridUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PixlPictureBox);
            this.Name = "PixelGridUserControl";
            this.Size = new System.Drawing.Size(256, 256);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PixelGridUserControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PixlPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PixlPictureBox;
    }
}
