using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Models
{
    public interface IUserControlRepository
    {
        void AddUser(UserModel userModel);
        void EditUser(UserModel userModel);
        void DeleteUser(int Id);
        List<UserModel> GetAll();
        List<FilteredUserModel> GetFilteredName();
        List<FilteredUserModel> GetByFilteredName(string value);
    }
}
