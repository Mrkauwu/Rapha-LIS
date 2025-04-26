using Rapha_LIS.Models;
using Rapha_LIS.Repositories;
using Rapha_LIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Presenters
{
    public class UserPresenter
    {
        private readonly IUserActionVIew userActionVIew;
        private readonly IUserControlRepository userRepository;
        private readonly IUserControlView userControlView;
        private readonly BindingSource UserControlBindingSource;
        private List<UserModel>? userList;
        private List<FilteredUserModel>? filteredUserList;

        public UserPresenter(IUserControlView userControlView, IUserControlRepository userRepository, IUserActionVIew userActionVIew) 
        {
            //PatientControlView
            this.userControlView = userControlView ?? throw new ArgumentNullException(nameof(userControlView));
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));

            //PatientActionView
            this.userActionVIew = userActionVIew ?? throw new ArgumentNullException(nameof(userActionVIew));

            //PatientControlView
            this.userControlView.UserSearchRequestedByName += UserControlView_UserSearchRequestedByName;
            this.userControlView.UserAddRequested += UserControlView_UserAddRequested;
            this.userControlView.UserActionRequested += UserControlView_UserActionRequested;
            this.UserControlBindingSource = new BindingSource();  // ✅ Initialize first
            this.userControlView.BindUserControlList(UserControlBindingSource);

            //PatientActionView
            this.userActionVIew.UserSaveRequested += UserActionVIew_UserSaveRequested;
            this.userActionVIew.UserDeleteRequested += UserActionVIew_UserDeleteRequested;

            LoadAllUserList();
            this.userControlView.Show();
        }

        private void LoadAllUserList()
        {
            userActionVIew.DeleteButtonVisible = userActionVIew.IsEdit;
            filteredUserList = userRepository.GetFilteredName();
            UserControlBindingSource.DataSource = filteredUserList;
        }

        private void CleanviewFields()
        {
            userActionVIew.FirstName = "";
            userActionVIew.LastName = "";
            userActionVIew.MiddleInitial = "";
            userActionVIew.Age = "";
            userActionVIew.Address = "";
            userActionVIew.CivilStatus = "";
            userActionVIew.Religion = "";
            userActionVIew.Contact = "";
        }

        //User Control

        private void UserControlView_UserActionRequested(object? sender, EventArgs e)
        {
            //Using both models much faster 
            var selectedRow = (FilteredUserModel)UserControlBindingSource.Current;
            if (selectedRow == null) return;

            var userModel = userRepository.GetAll().FirstOrDefault(user => user.Id == selectedRow.Id);
            if (userModel == null) return;


            userActionVIew.Id = userModel.Id;
            userActionVIew.FirstName = userModel.FirstName;
            userActionVIew.LastName = userModel.LastName;
            userActionVIew.MiddleInitial = userModel.MiddleInitial;
            userActionVIew.Age = userModel.Age.ToString();
            userActionVIew.Sex = userModel.Sex;
            userActionVIew.Birthdate = userModel.Birthdate;
            userActionVIew.Address = userModel.Address;
            userActionVIew.CivilStatus = userModel.CivilStatus;
            userActionVIew.Religion = userModel.Religion;
            userActionVIew.Contact = userModel.Contact;

            userActionVIew.IsEdit = true;

            userActionVIew.UserSaveRequested -= UserActionVIew_UserSaveRequested;
            userActionVIew.UserSaveRequested += UserActionVIew_UserSaveRequested;


            ((Form)userActionVIew).ShowDialog();
            CleanviewFields();
        }

        private void UserControlView_UserAddRequested(object? sender, EventArgs e)
        {
            userActionVIew.IsEdit = false;
            ((Form)userActionVIew).ShowDialog();
        }

        private void UserControlView_UserSearchRequestedByName(object? sender, EventArgs e)
        {
                bool emptyValue = string.IsNullOrWhiteSpace(this.userControlView.UserSearchQueryByName);
                if (emptyValue == false)
                filteredUserList = userRepository.GetByFilteredName(this.userControlView.UserSearchQueryByName); 
            else filteredUserList = userRepository.GetFilteredName();
            UserControlBindingSource.DataSource = filteredUserList;
        }

        //User Action
        private void UserActionVIew_UserSaveRequested(object? sender, EventArgs e)
        {
            var userModel = new UserModel()
            {
                Id = userActionVIew.Id,
                FirstName = userActionVIew.FirstName,
                LastName = userActionVIew.LastName,
                MiddleInitial = userActionVIew.MiddleInitial,
                Age = int.TryParse(userActionVIew.Age, out int age) ? age : 0,
                Sex = userActionVIew.Sex,
                Birthdate = userActionVIew.Birthdate < new DateTime(1753, 1, 1)
                ? DateTime.Now
                : userActionVIew.Birthdate,
                Address = userActionVIew.Address,
                CivilStatus = userActionVIew.CivilStatus,
                Religion = userActionVIew.Religion,
                Contact = userActionVIew.Contact,
                DateCreated = DateTime.Now,
            };

            try
            {
                new Common.ModelDataValidation().Validate(userModel);

                if (userActionVIew.IsEdit) // Use IsEdit to check if it's an edit operation
                {
                    MessageBox.Show($"Patient ID: {userModel.Id}");

                    userRepository.EditUser(userModel);
                    userActionVIew.Message = "Patient updated successfully.";
                }
                else // Add new patient
                {
                    // Generate Username and Password
                    userModel.Username = GenerateUsername(userModel.FirstName, userModel.LastName, userModel.Age);
                    userModel.Password = GeneratePassword(userModel.LastName, userModel.Age);

                    // Save the new user
                    userRepository.AddUser(userModel);
                    userActionVIew.Message = "Patient added successfully. Username: " + userModel.Username;
                }

                userActionVIew.IsSuccessful = true;
                LoadAllUserList(); // Refresh the list
                CleanviewFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Debugging step
                userActionVIew.IsSuccessful = false;
                userActionVIew.Message = ex.Message;
            }
        }

        private string GenerateUsername(string? firstName, string? lastName, int Age)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return "user" + Age; // Default if missing values

            char firstLetter = firstName[0]; // Get first letter of first name
            return $"{firstLetter}{lastName}{Age}".ToLower(); // Example: JDoe123
        }


        private string GeneratePassword(string? lastName, int age)
        {
            if (string.IsNullOrEmpty(lastName)) return "default" + age;
            return lastName.Trim().ToLower() + age;  // Normalize before hashing
        }

        private string HashPassword(string password)
        {
            password = password.Trim();  // Remove unwanted spaces
            password = password.ToLower(); // Ensure consistent case
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    

        private void UserActionVIew_UserDeleteRequested(object? sender, EventArgs e)
        {
            var user = (UserModel)UserControlBindingSource.Current;
            userRepository.DeleteUser(user.Id);
            userActionVIew.IsSuccessful = true;
            userActionVIew.Message = "User Deleted Successfuly";
            LoadAllUserList();
        }
    }
}
