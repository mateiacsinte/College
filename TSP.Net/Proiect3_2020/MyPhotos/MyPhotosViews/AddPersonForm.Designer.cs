namespace MyPhotosViews
{
    partial class AddPersonForm
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
            this.AddPhotoPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.AddLocationsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhotosTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPhotoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPhotoPanel
            // 
            this.AddPhotoPanel.Controls.Add(this.PhotosTextBox1);
            this.AddPhotoPanel.Controls.Add(this.label1);
            this.AddPhotoPanel.Controls.Add(this.backButton);
            this.AddPhotoPanel.Controls.Add(this.LastNameTextBox);
            this.AddPhotoPanel.Controls.Add(this.FirstNameTextBox);
            this.AddPhotoPanel.Controls.Add(this.AddLocationsButton);
            this.AddPhotoPanel.Controls.Add(this.label4);
            this.AddPhotoPanel.Controls.Add(this.label2);
            this.AddPhotoPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPhotoPanel.Location = new System.Drawing.Point(135, -41);
            this.AddPhotoPanel.Name = "AddPhotoPanel";
            this.AddPhotoPanel.Size = new System.Drawing.Size(530, 532);
            this.AddPhotoPanel.TabIndex = 14;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 459);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 43);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(238, 252);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(238, 153);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // AddLocationsButton
            // 
            this.AddLocationsButton.Location = new System.Drawing.Point(380, 459);
            this.AddLocationsButton.Name = "AddLocationsButton";
            this.AddLocationsButton.Size = new System.Drawing.Size(108, 43);
            this.AddLocationsButton.TabIndex = 5;
            this.AddLocationsButton.Text = "Add Person";
            this.AddLocationsButton.UseVisualStyleBackColor = true;
            this.AddLocationsButton.Click += new System.EventHandler(this.AddLocationsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Photos";
            // 
            // PhotosTextBox1
            // 
            this.PhotosTextBox1.Location = new System.Drawing.Point(238, 348);
            this.PhotosTextBox1.Name = "PhotosTextBox1";
            this.PhotosTextBox1.Size = new System.Drawing.Size(250, 22);
            this.PhotosTextBox1.TabIndex = 13;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 477);
            this.Controls.Add(this.AddPhotoPanel);
            this.Name = "AddPersonForm";
            this.Text = "AddPersonForm";
            this.AddPhotoPanel.ResumeLayout(false);
            this.AddPhotoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddPhotoPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button AddLocationsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhotosTextBox1;
        private System.Windows.Forms.Label label1;
    }
}