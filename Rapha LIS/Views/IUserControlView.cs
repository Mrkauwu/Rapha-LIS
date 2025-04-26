using Rapha_LIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Views
{
    public interface IUserControlView
    {
        string UserSearchQueryByName { get; set; }

        bool UserIsEdit { get; set; }

        event EventHandler UserSearchRequestedByName;
        event EventHandler UserAddRequested;
        event EventHandler UserActionRequested;
        void BindUserControlList(BindingSource userControlList);
        void Show();
    }
}
