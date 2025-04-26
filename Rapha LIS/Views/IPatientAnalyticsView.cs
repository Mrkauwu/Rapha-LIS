using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Views
{
     public interface IPatientAnalyticsView
    {
        string SearchQueryByHIR { get; set; }
        event EventHandler? SearchRequestedByHIR;
        event EventHandler? AnalyticsActionRequested;

        void BindPatientAnalyticsList(BindingSource patientAnalyticsList);
        void ShowMessage(string message);
        void Show();
    }
}
