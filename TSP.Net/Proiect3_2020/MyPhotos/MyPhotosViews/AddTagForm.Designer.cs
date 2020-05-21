namespace MyPhotosViews
{
    partial class AddTagForm
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
            this.TagsTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddTagsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPhotoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPhotoPanel
            // 
            this.AddPhotoPanel.Controls.Add(this.backButton);
            this.AddPhotoPanel.Controls.Add(this.TagsTextBox);
            this.AddPhotoPanel.Controls.Add(this.NameTextBox);
            this.AddPhotoPanel.Controls.Add(this.AddTagsButton);
            this.AddPhotoPanel.Controls.Add(this.label4);
            this.AddPhotoPanel.Controls.Add(this.label2);
            this.AddPhotoPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPhotoPanel.Location = new System.Drawing.Point(135, -41);
            this.AddPhotoPanel.Name = "AddPhotoPanel";
            this.AddPhotoPanel.Size = new System.Drawing.Size(530, 528);
            this.AddPhotoPanel.TabIndex = 14;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 436);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 43);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TagsTextBox
            // 
            this.TagsTextBox.Location = new System.Drawing.Point(238, 252);
            this.TagsTextBox.Name = "TagsTextBox";
            this.TagsTextBox.Size = new System.Drawing.Size(250, 22);
            this.TagsTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(238, 153);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // AddTagsButton
            // 
            this.AddTagsButton.Location = new System.Drawing.Point(380, 436);
            this.AddTagsButton.Name = "AddTagsButton";
            this.AddTagsButton.Size = new System.Drawing.Size(108, 43);
            this.AddTagsButton.TabIndex = 5;
            this.AddTagsButton.Text = "Add Tags";
            this.AddTagsButton.UseVisualStyleBackColor = true;
            this.AddTagsButton.Click += new System.EventHandler(this.AddTagsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Photo Name";
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPhotoPanel);
            this.Name = "AddTagForm";
            this.Text = "AddTagForm";
            this.AddPhotoPanel.ResumeLayout(false);
            this.AddPhotoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddPhotoPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox TagsTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddTagsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}