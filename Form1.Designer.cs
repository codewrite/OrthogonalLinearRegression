namespace OrthogonalLinearRegression
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eqnCTextBox = new System.Windows.Forms.TextBox();
            this.eqnCLabel = new System.Windows.Forms.Label();
            this.eqnBTextBox = new System.Windows.Forms.TextBox();
            this.eqnBlabel = new System.Windows.Forms.Label();
            this.eqnATextBox = new System.Windows.Forms.TextBox();
            this.eqnALabel = new System.Windows.Forms.Label();
            this.drawLineButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pixelGridUserControl = new OrthogonalLinearRegression.PixelGridUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(25, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 25);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 275);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 100);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.drawLineButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(285, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 275);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eqnCTextBox);
            this.groupBox1.Controls.Add(this.eqnCLabel);
            this.groupBox1.Controls.Add(this.eqnBTextBox);
            this.groupBox1.Controls.Add(this.eqnBlabel);
            this.groupBox1.Controls.Add(this.eqnATextBox);
            this.groupBox1.Controls.Add(this.eqnALabel);
            this.groupBox1.Location = new System.Drawing.Point(5, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ax + By = C";
            // 
            // eqnCTextBox
            // 
            this.eqnCTextBox.Location = new System.Drawing.Point(22, 57);
            this.eqnCTextBox.Name = "eqnCTextBox";
            this.eqnCTextBox.ReadOnly = true;
            this.eqnCTextBox.Size = new System.Drawing.Size(60, 20);
            this.eqnCTextBox.TabIndex = 5;
            // 
            // eqnCLabel
            // 
            this.eqnCLabel.AutoSize = true;
            this.eqnCLabel.Location = new System.Drawing.Point(5, 60);
            this.eqnCLabel.Name = "eqnCLabel";
            this.eqnCLabel.Size = new System.Drawing.Size(14, 13);
            this.eqnCLabel.TabIndex = 4;
            this.eqnCLabel.Text = "C";
            // 
            // eqnBTextBox
            // 
            this.eqnBTextBox.Location = new System.Drawing.Point(22, 37);
            this.eqnBTextBox.Name = "eqnBTextBox";
            this.eqnBTextBox.ReadOnly = true;
            this.eqnBTextBox.Size = new System.Drawing.Size(60, 20);
            this.eqnBTextBox.TabIndex = 3;
            // 
            // eqnBlabel
            // 
            this.eqnBlabel.AutoSize = true;
            this.eqnBlabel.Location = new System.Drawing.Point(5, 40);
            this.eqnBlabel.Name = "eqnBlabel";
            this.eqnBlabel.Size = new System.Drawing.Size(14, 13);
            this.eqnBlabel.TabIndex = 2;
            this.eqnBlabel.Text = "B";
            // 
            // eqnATextBox
            // 
            this.eqnATextBox.Location = new System.Drawing.Point(22, 17);
            this.eqnATextBox.Name = "eqnATextBox";
            this.eqnATextBox.ReadOnly = true;
            this.eqnATextBox.Size = new System.Drawing.Size(60, 20);
            this.eqnATextBox.TabIndex = 1;
            // 
            // eqnALabel
            // 
            this.eqnALabel.AutoSize = true;
            this.eqnALabel.Location = new System.Drawing.Point(5, 20);
            this.eqnALabel.Name = "eqnALabel";
            this.eqnALabel.Size = new System.Drawing.Size(14, 13);
            this.eqnALabel.TabIndex = 0;
            this.eqnALabel.Text = "A";
            // 
            // drawLineButton
            // 
            this.drawLineButton.Location = new System.Drawing.Point(10, 10);
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(80, 23);
            this.drawLineButton.TabIndex = 0;
            this.drawLineButton.Text = "Draw &Line";
            this.drawLineButton.UseVisualStyleBackColor = true;
            this.drawLineButton.Click += new System.EventHandler(this.drawLineButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pixelGridUserControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(25, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(260, 275);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Resize += new System.EventHandler(this.mainPanel_Resize);
            // 
            // pixelGridUserControl1
            // 
            this.pixelGridUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pixelGridUserControl.Location = new System.Drawing.Point(0, 0);
            this.pixelGridUserControl.Name = "pixelGridUserControl1";
            this.pixelGridUserControl.Size = new System.Drawing.Size(256, 256);
            this.pixelGridUserControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 310);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(180, 130);
            this.Name = "Form1";
            this.Text = "Orthogonal Linear Regression";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button drawLineButton;
        private System.Windows.Forms.Panel mainPanel;
        private PixelGridUserControl pixelGridUserControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox eqnCTextBox;
        private System.Windows.Forms.Label eqnCLabel;
        private System.Windows.Forms.TextBox eqnBTextBox;
        private System.Windows.Forms.Label eqnBlabel;
        private System.Windows.Forms.TextBox eqnATextBox;
        private System.Windows.Forms.Label eqnALabel;
        private System.Windows.Forms.Label label1;

    }
}

