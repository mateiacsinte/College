namespace MyPhotosViews
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
            this.buttonSearchPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.buttonDeletePhoto = new System.Windows.Forms.Button();
            this.buttonUpdatePhoto = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearchPhoto
            // 
            this.buttonSearchPhoto.Location = new System.Drawing.Point(101, 243);
            this.buttonSearchPhoto.Name = "buttonSearchPhoto";
            this.buttonSearchPhoto.Size = new System.Drawing.Size(110, 44);
            this.buttonSearchPhoto.TabIndex = 0;
            this.buttonSearchPhoto.Text = "Search Photo";
            this.buttonSearchPhoto.UseVisualStyleBackColor = true;
            this.buttonSearchPhoto.Click += new System.EventHandler(this.buttonSearchPhoto_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(92, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Photos";
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Location = new System.Drawing.Point(101, 367);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(110, 44);
            this.buttonAddPhoto.TabIndex = 2;
            this.buttonAddPhoto.Text = "Add Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Location = new System.Drawing.Point(467, 367);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(110, 44);
            this.buttonAddTag.TabIndex = 3;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Location = new System.Drawing.Point(294, 243);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(110, 44);
            this.buttonAddLocation.TabIndex = 4;
            this.buttonAddLocation.Text = "Add Location";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // buttonDeletePhoto
            // 
            this.buttonDeletePhoto.Location = new System.Drawing.Point(294, 367);
            this.buttonDeletePhoto.Name = "buttonDeletePhoto";
            this.buttonDeletePhoto.Size = new System.Drawing.Size(110, 44);
            this.buttonDeletePhoto.TabIndex = 5;
            this.buttonDeletePhoto.Text = "Delete Photo";
            this.buttonDeletePhoto.UseVisualStyleBackColor = true;
            this.buttonDeletePhoto.Click += new System.EventHandler(this.buttonDeletePhoto_Click);
            // 
            // buttonUpdatePhoto
            // 
            this.buttonUpdatePhoto.Location = new System.Drawing.Point(467, 243);
            this.buttonUpdatePhoto.Name = "buttonUpdatePhoto";
            this.buttonUpdatePhoto.Size = new System.Drawing.Size(110, 44);
            this.buttonUpdatePhoto.TabIndex = 6;
            this.buttonUpdatePhoto.Text = "Update Photo";
            this.buttonUpdatePhoto.UseVisualStyleBackColor = true;
            this.buttonUpdatePhoto.Click += new System.EventHandler(this.buttonUpdatePhoto_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(616, 367);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(110, 44);
            this.AddPersonButton.TabIndex = 7;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.buttonUpdatePhoto);
            this.Controls.Add(this.buttonDeletePhoto);
            this.Controls.Add(this.buttonAddLocation);
            this.Controls.Add(this.buttonAddTag);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchPhoto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Button buttonDeletePhoto;
        private System.Windows.Forms.Button buttonUpdatePhoto;
        private System.Windows.Forms.Button AddPersonButton;
    }
}

