using Microsoft.Extensions.Configuration;
using Rapha_LIS.Models;
using Rapha_LIS.Presenters;
using Rapha_LIS.Repositories;
using Rapha_LIS.Views;

namespace Rapha_LIS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string? sqlConnectionString = config.GetConnectionString("DefaultConnection");
            //
            //Old
            /*var mainForm = new Rapha_LIS.Views.Rapha_LIS(); // This should be your main form

            // Initialize Patient Presenter
            IPatientControlView patientView = mainForm;
            IPatientActionView addPatientView = new PatientActionView();
            IPatientControlRepository patientRepository = new PatientRepository(sqlConnectionString ?? "");
            //Analytics
            IPatientAnalyticsView patientAnalyticsView = mainForm;
            IAnalyticsActionView analyticsActionView = new AnalyticsActionView();
            IAnalyticsRepository analyticsRepository = new PatientRepository(sqlConnectionString ?? "");
            //Result
            IPatientResult patientResult = mainForm;
            IResultActionView resultActionView = new ResultActionView();
            IPatientResultRepository patientResultRepository = new PatientRepository(sqlConnectionString ?? "");
            
            new PatientPresenter(patientView, patientRepository, addPatientView, patientAnalyticsView, analyticsRepository,
                                  analyticsActionView, patientResult, patientResultRepository, resultActionView);

            // Initialize User Presenter
            IUserControlView userControlView = mainForm;
            IUserActionVIew userActionView = new UserActionView();
            IUserControlRepository userControlRepository = new UserRepository(sqlConnectionString ?? "");
            new UserPresenter(userControlView, userControlRepository, userActionView);

            // Initialize Signin Presenter
            ISigninView signinView = new SigninView();
            ISigninRepository signinRepository = new UserRepository(sqlConnectionString ?? "");
            new SigninPresenter(signinView, signinRepository);

            // Run the application with the main form
            Application.Run(mainForm);
            */
            // Initialize Sign-in View
            using (SigninView signinView = new SigninView())
            {
                ISigninRepository signinRepository = new UserRepository(sqlConnectionString ?? "");
                SigninPresenter signinPresenter = new SigninPresenter(signinView, signinRepository);

                // Show sign-in form and check if login is successful
                if (signinView.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, proceed to main form
                    using (var mainForm = new Rapha_LIS.Views.Rapha_LIS())
                    {
                        // Initialize Patient Presenter
                        IPatientControlView patientView = mainForm;
                        IPatientActionView addPatientView = new PatientActionView();
                        IPatientControlRepository patientRepository = new PatientRepository(sqlConnectionString ?? "");

                        // Analytics 
                        IPatientAnalyticsView patientAnalyticsView = mainForm;
                        IAnalyticsActionView analyticsActionView = new AnalyticsActionView();
                        IAnalyticsRepository analyticsRepository = new PatientRepository(sqlConnectionString ?? "");

                        // Result
                        IPatientResult patientResult = mainForm;
                        IResultActionView resultActionView = new ResultActionView();
                        IPatientResultRepository patientResultRepository = new PatientRepository(sqlConnectionString ?? "");

                        new PatientPresenter(patientView, patientRepository, addPatientView, patientAnalyticsView, analyticsRepository,
                                              analyticsActionView, patientResult, patientResultRepository, resultActionView);

                        // Initialize User Presenter
                        IUserControlView userControlView = mainForm;
                        IUserActionVIew userActionView = new UserActionView();
                        IUserControlRepository userControlRepository = new UserRepository(sqlConnectionString ?? "");
                        new UserPresenter(userControlView, userControlRepository, userActionView);

                        // Run the application with the main form
                        Application.Run(mainForm);
                    }
                }
                else
                {
                    // If login fails or user closes sign-in form, exit the application
                    Application.Exit();
                }
            }
        }
    }
}