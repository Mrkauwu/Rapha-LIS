using MaterialSkin;
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

namespace Rapha_LIS.Views
{
    public partial class SigninView : MaterialForm, ISigninView
    {
        public SigninView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.AcceptButton = btnSignin;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(

            (Primary)0xFFFFFF,  // Clean white background
            (Primary)0xF3E5F5,  // Very light purple for a premium look
    (Primary)0xCE93D8,  // Soft purple contrast
    (Accent)0xBA68C8,   // Vibrant purple accent
    TextShade.BLACK     // Dark text for easy reading
            );
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSignin.Click += (s, e) =>
            {
                SigninRequested?.Invoke(this, EventArgs.Empty);
            };

            txtUsername.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SigninRequested?.Invoke(this, EventArgs.Empty);
                    e.SuppressKeyPress = true; // Prevent "ding" sound
                }
            };

            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SigninRequested?.Invoke(this, EventArgs.Empty);
                    e.SuppressKeyPress = true; // Prevent "ding" sound
                }
            };


        }

        public string? Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string? Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public event EventHandler? SigninRequested;
    }
}
