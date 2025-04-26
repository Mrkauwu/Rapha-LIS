using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Rapha_LIS.Views
{
    public partial class PatientActionView : MaterialForm, IPatientActionView
    {
        private string message = string.Empty;
        private bool isSuccessful;
        private bool isEdit;


        public PatientActionView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += (s, e) =>
            {
                SaveRequested?.Invoke(this, EventArgs.Empty);
            };

            btnDelete.Click += (s, e) =>
            {
                DeleteRequested?.Invoke(this, EventArgs.Empty);
            };

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        //private void PatientActionView_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true; // Cancel closing
        //    this.Hide(); // Just hide the form
        //}

        public string? FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }
        public string? LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string? MiddleInitial
        {
            get { return txtMiddleInitial.Text; }
            set { txtMiddleInitial.Text = value; }
        }

        public string Age
        {
            get { return txtAge.Text; }
            set { txtAge.Text = value; }
        }

        public string? Sex
        {
            get { return cmbSex.Text; }
            set { cmbSex.Text = value; }
        }

        public string? Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string? CivilStatus
        {
            get { return txtCivilStatus.Text; }
            set { txtCivilStatus.Text = value; }
        }
        public string? Religion
        {
            get { return txtReligion.Text; }
            set { txtReligion.Text = value; }
        }
        public string? Contact
        {
            get { return txtContact.Text; }
            set { txtContact.Text = value; }
        }


        public string? Test
        {
            get { return txtTest.Text; }
            set { txtTest.Text = value; }
        }

        public DateTime Birthdate { get; set; }


        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public void Message(string message)
        {
            MessageBox.Show(message);
        }

        private void PatientActionView_Load(object sender, EventArgs e)
        {

        }

        public bool IsEdit
        {
            get { return isEdit; }
            set
            {
                isEdit = value;

                if (isEdit)//Edit True
                {
                    btnSave.Location = new Point(207, 369);
                    btnDelete.Visible = true;
                    //btnDelete.Location = new Point(422, 369); // Set your exact location
                    //btnSave.Location = new Point(199, 369);
                }
                else //Edit False
                {
                    btnSave.Visible = true;
                    btnDelete.Visible = false;
                    btnSave.Location = new Point(318, 369); // Set your exact location
                }
            }
        }

        public DateTime DateCreated => DateTime.Now;
        public int Id { get; set; }
        public bool DeleteButtonVisible { set { btnDelete.Visible = value; } }

        public event EventHandler? SaveRequested;

        public event EventHandler? DeleteRequested;
    }
}
