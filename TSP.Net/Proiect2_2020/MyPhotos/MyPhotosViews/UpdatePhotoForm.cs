using MyPhotoAPI;
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
    public partial class UpdatePhotoForm : Form
    {
        Form1 form1;
        PhotoAPI photoAPI;
        public UpdatePhotoForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            photoAPI = new PhotoAPI();
        }

       
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void UpdatePhotoButton_Click(object sender, EventArgs e)
        {
            string cuurentName = this.textBox1.Text;
            string newName = this.NameTextBox.Text;
            string newPath = this.PathTextBox.Text;
            string newLocation = this.LocationTextBox.Text;
            string newTags = this.TagsTextBox.Text;
            string newDate = this.DateTextBox.Text;

            photoAPI.UpdatePhoto(cuurentName, newName, newPath, newLocation, newTags, newDate);

            this.textBox1.Text = "";
            this.NameTextBox.Text = "";
            this.PathTextBox.Text = "";
            this.LocationTextBox.Text = "";
            this.TagsTextBox.Text = "";
            this.DateTextBox.Text = "";


        }
    }
}
