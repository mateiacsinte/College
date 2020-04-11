using MyPhotoAPI;
using MyPhotosClient.ClientPhotoService;
using System;
using System.Windows.Forms;

namespace MyPhotosViews
{
    public partial class DeletePhotoForm : Form
    {
        Form1 form1;
       
        public DeletePhotoForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
          
        }

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            string photoName = this.NameTextBox.Text;
            string photoLocation = this.LocationTextBox.Text;
            string photoTag = this.TagsTextBox.Text;

            PhotoClient client = new PhotoClient();
            client.photoService.DeletePhotos(photoName, photoLocation, photoTag);

            this.NameTextBox.Text = "";
            this.LocationTextBox.Text = "";
            this.TagsTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show(); 
        }

      
    }
}
