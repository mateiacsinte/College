using MyPhotoAPI;
using MyPhotos.Context;
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
    public partial class SearchPhotoForm : Form
    {
        private Form1 form1;
       
        public SearchPhotoForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
           
        }

        private void FiltetPhotoButton_Click(object sender, EventArgs e)
        {
         
            this.listView1.Clear();
            string name = this.NameTextBox.Text;
            string people = this.PeopleTextBox.Text;
            string path = this.PathTextBox.Text;
            string locations = this.LocationTextBox.Text;
            string tags = this.TagsTextBox.Text;
            string date = this.DateTextBox.Text;

            var photoClient = new PhotoClient();
            IEnumerable<MyPhotosClient.ClientPhotoService.Photo> chosenPhotos = photoClient.photoService.FilterPhotos(name, people, path, locations, tags, date);
            
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            this.listView1.LargeImageList = imgs;

            foreach (MyPhotosClient.ClientPhotoService.Photo currentPhoto in chosenPhotos)
                imgs.Images.Add(Image.FromFile(currentPhoto.Path));

            for (int i = 0; i < imgs.Images.Count; i++)
                this.listView1.Items.Add(new ListViewItem() { ImageIndex = i });

            this.NameTextBox.Text = "";
            this.PeopleTextBox.Text = "";
            this.PathTextBox.Text = "";
            this.LocationTextBox.Text = "";
            this.TagsTextBox.Text = "";
            this.DateTextBox.Text = "";
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }
    }
}
