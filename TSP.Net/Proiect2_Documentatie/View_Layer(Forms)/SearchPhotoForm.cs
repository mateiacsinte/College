using MyPhotoAPI;
using MyPhotos.Context;
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
        private PhotoAPI photoAPI;
        public SearchPhotoForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            photoAPI = new PhotoAPI();
        }

        private void FiltetPhotoButton_Click(object sender, EventArgs e)
        {
            /*
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);
            
            imgs.Images.Add(Image.FromFile("D:\\Facultate\\Anul III S2\\Proiect1_2020\\Photos\\1551754_234639693383322_1198971708_n.jpg"));
            imgs.Images.Add(Image.FromFile("D:\\Facultate\\Anul III S2\\Proiect1_2020\\Photos\\16797989_708695309311089_7328371282394362814_o.jpg"));
           
            this.listView1.LargeImageList = imgs;

            
          
            this.listView1.Items.Add(new ListViewItem() { ImageIndex = 0 ,Text = "Hallllo", Tag = "puaaa"}); 
            this.listView1.Items.Add(new ListViewItem() { ImageIndex = 1, Text = "afnaf", Tag = "fsfs"});
            */
            this.listView1.Clear();
            string name = this.NameTextBox.Text;
            string people = this.PeopleTextBox.Text;
            string path = this.PathTextBox.Text;
            string locations = this.LocationTextBox.Text;
            string tags = this.TagsTextBox.Text;
            string date = this.DateTextBox.Text;

            IEnumerable<Photo> chosenPhotos = photoAPI.FilterPhotos(name, people, path, locations, tags, date);

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            this.listView1.LargeImageList = imgs;

            foreach (Photo currentPhoto in chosenPhotos)
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
