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
    public partial class AddTagForm : Form
    {
        Form1 form1;
        
        public AddTagForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }

        private void AddTagsButton_Click(object sender, EventArgs e)
        {
            string photoName = this.NameTextBox.Text;
            string photoTags = this.TagsTextBox.Text;

            PhotoClient client = new PhotoClient();
            client.photoService.AddTags(photoName, photoTags);

            this.NameTextBox.Text = "";
            this.TagsTextBox.Text = "";
        }
    }
}
