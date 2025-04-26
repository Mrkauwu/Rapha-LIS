using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Views
{
    public interface IPatientControlView
    {
        string SearchQueryByName { get; set; }

        bool IsEdit { get; set; }

        event EventHandler SearchRequestedByName;
        event EventHandler AddRequested;
        event EventHandler ActionRequested;
        void BindPatientControlList(BindingSource patientControlList);
        void Show();
    }
}
