using Guna.UI2.WinForms;
using MaterialSkin;
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


namespace Rapha_LIS.Views
{
    public partial class Rapha_LIS : MaterialForm, IPatientControlView, IUserControlView, IPatientAnalyticsView, IPatientResult
    {
        private bool isEdit;
        private bool isEditUser;
        private bool isEditResult;
        public Rapha_LIS()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
            (Primary)0xFFFFFF,  // Clean white background for a clinical look
            (Primary)0xE3F2FD,  // Soft blue for a calming, medical feel
            (Primary)0x64B5F6,  // Standard blue for professional contrast
            (Accent)0x1E88E5,  // Orange for energy and urgency in alerts
            TextShade.BLACK
);
            lblUserControl.Font = new Font(lblUserControl.Font.FontFamily, 26, FontStyle.Regular);
            lblPatientControl.Font = new Font(lblUserControl.Font.FontFamily, 26, FontStyle.Regular);
            lblAnalytics.Font = new Font(lblUserControl.Font.FontFamily, 26, FontStyle.Regular);

            dgvPatientControl.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvUserControl.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAnalyticsPatients.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvPatientResult.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }


        //Patient Control

        private void AssociateAndRaiseViewEvents()
        {
            // PatientControl TabPage
            btnAddPatient.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            txtPatientControlSearch.TextChanged += (s, e) => StartSearchTimer("Patient");

            // User Control TabPage
            btnAddUser.Click += (s, e) => UserAddRequested?.Invoke(this, EventArgs.Empty);
            txtUserControlSearch.TextChanged += (s, e) => StartSearchTimer("User");

            // Analytics TabPage
            txtAnalyticsSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchRequestedByHIR?.Invoke(this, EventArgs.Empty); };

            // Result TabPage
            txtSearchPatientResult.TextChanged += (s, e) => StartSearchTimer("Result");

            timer1.Tick += (s, e) =>
            {
                timer1.Stop();

                switch (timer1.Tag?.ToString())
                {
                    case "Patient":
                        SearchRequestedByName?.Invoke(this, EventArgs.Empty);
                        break;
                    case "User":
                        UserSearchRequestedByName?.Invoke(this, EventArgs.Empty);
                        break;
                    case "Result":
                        ResultSearchRequested?.Invoke(this, EventArgs.Empty);
                        break;
                }
            };
        }

        private void StartSearchTimer(string searchType)
        {
            timer1.Stop();
            timer1.Tag = searchType;
            timer1.Start();
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public string SearchQueryByName
        {
            get { return txtPatientControlSearch.Text; }
            set { txtPatientControlSearch.Text = value; }
        }

        public void BindPatientControlList(BindingSource patientControlList)
        {

            dgvPatientControl.DataSource = patientControlList;

        }

        //User Control

        public string UserSearchQueryByName
        {
            get { return txtUserControlSearch.Text; }
            set { txtUserControlSearch.Text = value; }
        }

        public bool UserIsEdit
        {
            get { return isEditUser; }
            set { isEditUser = value; }
        }

        public void BindUserControlList(BindingSource userControlList)
        {
            dgvUserControl.DataSource = userControlList;
        }

        private void dgvUserControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserActionRequested?.Invoke(this, EventArgs.Empty);
        }

        public string SearchQueryByHIR
        {
            get { return txtAnalyticsSearch.Text; }
            set { txtAnalyticsSearch.Text = value; }
        }

        public void BindPatientAnalyticsList(BindingSource patientAnalyticsList)
        {
            dgvAnalyticsPatients.DataSource = patientAnalyticsList;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void dgvAnalyticsPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AnalyticsActionRequested?.Invoke(this, EventArgs.Empty);
        }

        //Patient Result
        public string ResultSearchQuery
        {
            get { return txtSearchPatientResult.Text; }
            set { txtSearchPatientResult.Text = value; }
        }

        public bool EditResult
        {
            get { return isEditResult; }
            set { isEditResult = value; }
        }

        public void BindPatientResult(BindingSource resultBindingSource)
        {
            dgvPatientResult.DataSource = resultBindingSource;
        }

        private void dgvPatientControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActionRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgvAnalyticsPatients_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AnalyticsActionRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgvPatientResult_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ResultActionRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgvUserControl_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            UserActionRequested?.Invoke(this, EventArgs.Empty);
        }

        private void txtUserControlSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnalyticsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rapha_LIS_Load(object sender, EventArgs e)
        {

        }

        //IPatientControlView Eventhandler
        public event EventHandler? SearchRequestedByName;
        public event EventHandler? AddRequested;
        public event EventHandler? ActionRequested;

        //IUserControlView EventHandler
        public event EventHandler? UserSearchRequestedByName;
        public event EventHandler? UserAddRequested;
        public event EventHandler? UserActionRequested;

        //IPatientAnalyticsView EventHandler
        public event EventHandler? SearchRequestedByHIR;
        public event EventHandler? AnalyticsActionRequested;

        //IPatientResult EventHandler
        public event EventHandler? ResultSearchRequested;
        public event EventHandler? ResultActionRequested;
    }
}
