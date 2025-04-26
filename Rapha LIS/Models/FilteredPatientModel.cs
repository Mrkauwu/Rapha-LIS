using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Models
{
    public class FilteredPatientModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? MedTech { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Test { get; set; }
        public string? TestDescription { get; set; }
        public string? Result { get; set; }
    }
}
