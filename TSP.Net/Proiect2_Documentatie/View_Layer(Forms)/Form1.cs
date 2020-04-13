
using MyPhotoAPI;
using System;
using System.Windows.Forms;



namespace MyPhotosViews
{
    public partial class Form1 : Form
    {
        public PhotoAPI photoAPI;

        public AddPhotoForm addPhotoForm;
        public UpdatePhotoForm updatePhotoForm;
        public DeletePhotoForm deletePhotoForm;
        public AddLocationForm addLocationForm;
        public AddTagForm addTagForm;
        public SearchPhotoForm searchPhotoForm;
        public AddPersonForm addPersonForm;

        public Form1()
        {
            InitializeComponent();
            InitializeForms();


            photoAPI = new PhotoAPI();
        }

        private void InitializeForms()
        {
            addPhotoForm = new AddPhotoForm(this);
            addPhotoForm.Hide();

            updatePhotoForm = new UpdatePhotoForm(this);
            updatePhotoForm.Hide();

            deletePhotoForm = new DeletePhotoForm(this);
            deletePhotoForm.Hide();

            addLocationForm = new AddLocationForm(this);
            addLocationForm.Hide();

            addTagForm = new AddTagForm(this);
            addTagForm.Hide();

            searchPhotoForm = new SearchPhotoForm(this);
            searchPhotoForm.Hide();

            addPersonForm = new AddPersonForm(this);
            addPersonForm.Hide();
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.addPhotoForm.Show();
        }

        private void buttonUpdatePhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.updatePhotoForm.Show();
        }

        private void buttonDeletePhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.deletePhotoForm.Show();
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.addLocationForm.Show();
        }

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.addTagForm.Show();
        }

        private void buttonSearchPhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.searchPhotoForm.Show();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.addPersonForm.Show();
        }
    }
}
