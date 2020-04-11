using MyPhotoAPI;
using MyPhotosClient.ClientPhotoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosViews
{
    public partial class AddPhotoForm : Form
    {
        Form1 form1;
        public AddPhotoForm(Form1 form1)
        {
            InitializeComponent(); 
            this.form1 = form1;
        }

        private void InsertPhotoButton_Click(object sender, EventArgs e)
        {
            string photoName = this.NameTextBox.Text;
            string photoPath = this.PathTextBox.Text;
            string photoDate = this.DateTextBox.Text;
            string photoTags = this.TagsTextBox.Text;
            string photoLocations = this.LocationTextBox.Text;

            PhotoClient client = new PhotoClient();
            client.photoService.AddPhoto(photoName, photoPath, photoLocations, photoTags, photoDate);

            this.NameTextBox.Text = "";
            this.PathTextBox.Text = "";
            this.DateTextBox.Text = "";
            this.TagsTextBox.Text = "";
            this.LocationTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }

    }
}
