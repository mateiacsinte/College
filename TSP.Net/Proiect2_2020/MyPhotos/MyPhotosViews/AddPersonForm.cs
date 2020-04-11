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
    public partial class AddPersonForm : Form
    {
        Form1 form1;
        public AddPersonForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }

        private void AddLocationsButton_Click(object sender, EventArgs e)
        {
            string firstName = this.FirstNameTextBox.Text;
            string lastName = this.LastNameTextBox.Text;
            string photos = this.PhotosTextBox1.Text;

            PhotoClient client = new PhotoClient();
            client.photoService.AddPerson(firstName, lastName, photos);
        }
    }
}
