using MaterialSkin.Controls;
using Rapha_LIS.Models;
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
    public partial class UserActionView : MaterialForm, IUserActionVIew
    {
        private string message = string.Empty;
        private bool isSuccessful;
        private bool isEdit;

        public event EventHandler? UserSaveRequested;
        public event EventHandler? UserDeleteRequested;


        public UserActionView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += (s, e) =>
            {
                UserSaveRequested?.Invoke(this, EventArgs.Empty);
            };

            btnDelete.Click += (s, e) =>
            {
                UserDeleteRequested?.Invoke(this, EventArgs.Empty);
            };

        }

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

        public DateTime Birthdate { get; set; }


        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
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
                }
                else //Edit False
                {
                    btnSave.Visible = true;
                    btnDelete.Visible = false;
                    btnSave.Location = new Point(318, 369); 
                }
            }
        }

        public DateTime DateCreated => DateTime.Now;

        public int Id { get; set; }
        public bool DeleteButtonVisible { set { btnDelete.Visible = value; } }

 
    }
}
