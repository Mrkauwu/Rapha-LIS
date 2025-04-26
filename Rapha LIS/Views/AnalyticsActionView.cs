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
    public partial class AnalyticsActionView : MaterialForm, IAnalyticsActionView
    {
        private string message = string.Empty;
        private bool isSuccessful;
        private bool isEdit;


        public AnalyticsActionView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += (s, e) =>
            {
                AnalyticsSaveRequested?.Invoke(this, EventArgs.Empty);
            };

            btnsumit.Click += (s, e) =>
            {
                AnalyticsSubmitRequested?.Invoke(this, EventArgs.Empty);
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
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public DateTime DateCreated => DateTime.Now;

        public int Id { get; set; }
        public string? Result
        {
            get { return txtResult.Text; }
            set { txtResult.Text = value; }
        }

        public event EventHandler? AnalyticsSaveRequested;
        public event EventHandler? AnalyticsSubmitRequested;
    }
}
