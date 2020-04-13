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
    public partial class AddLocationForm : Form
    {
        Form1 form1;
        PhotoAPI photoAPI;
        public AddLocationForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            photoAPI = new PhotoAPI();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.Show();
        }

        private void AddLocationsButton_Click(object sender, EventArgs e)
        {
            string photoName = this.NameTextBox.Text;
            string locations = this.LocationTextBox.Text;

            photoAPI.AddLocations(photoName, locations);

            this.NameTextBox.Text = "";
            this.LocationTextBox.Text = "";
        }
    }
}
