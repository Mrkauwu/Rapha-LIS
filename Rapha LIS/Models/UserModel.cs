using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Address { get; set; }
        public string? CivilStatus { get; set; }
        public string? Religion { get; set; }
        public string? Contact { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
