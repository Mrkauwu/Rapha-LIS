using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Views
{
    public interface IUserActionVIew
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public string Age { get; set; }
        public string? Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Address { get; set; }
        public string? CivilStatus { get; set; }
        public string? Religion { get; set; }
        public string? Contact { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        public DateTime DateCreated { get; }
        public bool DeleteButtonVisible { set; }

        //event EventHandler? PrintRequested;
        event EventHandler? UserSaveRequested;
        event EventHandler? UserDeleteRequested;
    }
}
