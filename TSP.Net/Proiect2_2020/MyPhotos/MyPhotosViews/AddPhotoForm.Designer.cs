﻿namespace MyPhotosViews
{
    partial class AddPhotoForm
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
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.TagsTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InsertPhotoButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPhotoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPhotoPanel
            // 
            this.AddPhotoPanel.Controls.Add(this.backButton);
            this.AddPhotoPanel.Controls.Add(this.DateTextBox);
            this.AddPhotoPanel.Controls.Add(this.TagsTextBox);
            this.AddPhotoPanel.Controls.Add(this.LocationTextBox);
            this.AddPhotoPanel.Controls.Add(this.PathTextBox);
            this.AddPhotoPanel.Controls.Add(this.NameTextBox);
            this.AddPhotoPanel.Controls.Add(this.InsertPhotoButton);
            this.AddPhotoPanel.Controls.Add(this.DateLabel);
            this.AddPhotoPanel.Controls.Add(this.label5);
            this.AddPhotoPanel.Controls.Add(this.label4);
            this.AddPhotoPanel.Controls.Add(this.label3);
            this.AddPhotoPanel.Controls.Add(this.label2);
            this.AddPhotoPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPhotoPanel.Location = new System.Drawing.Point(156, 3);
            this.AddPhotoPanel.Name = "AddPhotoPanel";
            this.AddPhotoPanel.Size = new System.Drawing.Size(530, 579);
            this.AddPhotoPanel.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 491);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 43);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(238, 422);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(250, 22);
            this.DateTextBox.TabIndex = 10;
            // 
            // TagsTextBox
            // 
            this.TagsTextBox.Location = new System.Drawing.Point(238, 358);
            this.TagsTextBox.Name = "TagsTextBox";
            this.TagsTextBox.Size = new System.Drawing.Size(250, 22);
            this.TagsTextBox.TabIndex = 9;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(238, 287);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(250, 22);
            this.LocationTextBox.TabIndex = 8;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(238, 222);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(250, 22);
            this.PathTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(238, 153);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // InsertPhotoButton
            // 
            this.InsertPhotoButton.Location = new System.Drawing.Point(380, 491);
            this.InsertPhotoButton.Name = "InsertPhotoButton";
            this.InsertPhotoButton.Size = new System.Drawing.Size(108, 43);
            this.InsertPhotoButton.TabIndex = 5;
            this.InsertPhotoButton.Text = "Insert Photo";
            this.InsertPhotoButton.UseVisualStyleBackColor = true;
            this.InsertPhotoButton.Click += new System.EventHandler(this.InsertPhotoButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateLabel.Location = new System.Drawing.Point(37, 422);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(109, 25);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Photo Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Photo Tags";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Photo Locations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Photo Path";
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
            // AddPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 561);
            this.Controls.Add(this.AddPhotoPanel);
            this.Name = "AddPhotoForm";
            this.Text = "AddPhotoForm";
            this.AddPhotoPanel.ResumeLayout(false);
            this.AddPhotoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddPhotoPanel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox TagsTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button InsertPhotoButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}