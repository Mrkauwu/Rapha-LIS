
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MVP_LEARNING.Repositories;
using Rapha_LIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapha_LIS.Repositories
{
    public class PatientRepository : BaseRepository, IPatientControlRepository, IAnalyticsRepository, IPatientResultRepository
    {
        public PatientRepository(string ConnectionString)
        {
            this.connectionString = ConnectionString;
        }



        //Analytics

        public void UpdateExaminer(string barcodeID, string examinerName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Patients2 SET MedTech = @MedTech WHERE BarcodeID = @BarcodeID";
                    command.Parameters.AddWithValue("@MedTech", examinerName);
                    command.Parameters.AddWithValue("@BarcodeID", barcodeID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Patient record updated. MedTech: {examinerName}");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient record.");
                    }
                }
            }
        }

        public PatientModel? GetPatientByHRI(string id)
        {
            PatientModel? patientList = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Patients2 WHERE BarcodeID = @BarcodeID";
                    command.Parameters.Add("@BarcodeID", SqlDbType.NVarChar).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patientList = new PatientModel()
                            {

                                Id = Convert.ToInt32(reader["Id"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                MiddleInitial = reader["MiddleInitial"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Sex = reader["Sex"].ToString(),
                                Birthdate = Convert.ToDateTime(reader["Birthdate"]),
                                Address = reader["Address"].ToString(),
                                CivilStatus = reader["CivilStatus"].ToString(),
                                Religion = reader["Religion"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                                Test = reader["Test"].ToString(),
                                TestDescription = reader["TestDescription"].ToString(),
                                Result = reader["Result"].ToString()
                            };
                        }

                    }

                }
            }
            MessageBox.Show(patientList != null ? $"User Found: {patientList.FirstName}" : "User not found in GetUserById!");

            return patientList;
        }

        public void AddPatientAnalytics(PatientModel patientModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = command.CommandText = @"INSERT INTO AnalyticsPatients2 (Id, FirstName, LastName, MiddleInitial, Age, Sex, Birthdate, " +
                        "Address, CivilStatus, Religion, Contact, Test, Result) VALUES (@Id, @FirstName, @LastName, @MiddleInitial, @Age, " +
                        "@Sex, @Birthdate, @Address, @CivilStatus, @Religion, @Contact, @Test, @Result)";
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = patientModel.Id;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patientModel.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patientModel.LastName;
                    command.Parameters.Add("@MiddleInitial", SqlDbType.NVarChar).Value = patientModel.MiddleInitial;
                    command.Parameters.Add("@Age", SqlDbType.Int).Value = patientModel.Age;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = patientModel.Sex;
                    command.Parameters.Add("@Birthdate", SqlDbType.Date).Value = patientModel.Birthdate;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patientModel.Address;
                    command.Parameters.Add("@CivilStatus", SqlDbType.NVarChar).Value = patientModel.CivilStatus;
                    command.Parameters.Add("@Religion", SqlDbType.NVarChar).Value = patientModel.Religion;
                    command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = patientModel.Contact;
                    command.Parameters.Add("@Test", SqlDbType.NVarChar).Value = patientModel.Test;
                    command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = patientModel.Result;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<PatientModel> GetPatientHRI(string examinerName)
        {
            var patientHRI = new List<PatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Patients2 WHERE MedTech = @MedTech";
                command.Parameters.AddWithValue("@MedTech", examinerName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patientModel = new PatientModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleInitial = reader["MiddleInitial"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Sex = reader["Sex"].ToString(),
                            Birthdate = Convert.ToDateTime(reader["Birthdate"]),
                            Address = reader["Address"].ToString(),
                            CivilStatus = reader["CivilStatus"].ToString(),
                            Religion = reader["Religion"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                            Test = reader["Test"].ToString(),
                            TestDescription = reader["TestDescription"].ToString(),
                            Result = reader["Result"].ToString()
                        };

                        patientHRI.Add(patientModel); // FIX: Now actually adding to the list
                    }
                }
            }
            return patientHRI;
        }

        public void EditPatientAnalytics(PatientModel patientModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            UPDATE AnalyticsPatients2 
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                MiddleInitial = @MiddleInitial,
                Age = @Age,
                Sex = @Sex,
                Birthdate = @Birthdate,
                Address = @Address,
                CivilStatus = @CivilStatus,
                Religion = @Religion,
                Contact = @Contact,
                Test = @Test,
                Result = @Result
            WHERE Id = @Id";
                
                command.Parameters.Add("@Id", SqlDbType.Int).Value = patientModel.Id;
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patientModel.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patientModel.LastName;
                command.Parameters.Add("@MiddleInitial", SqlDbType.NVarChar).Value = patientModel.MiddleInitial;
                command.Parameters.Add("@Age", SqlDbType.Int).Value = patientModel.Age;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = patientModel.Sex;
                command.Parameters.Add("@Birthdate", SqlDbType.Date).Value = patientModel.Birthdate;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patientModel.Address;
                command.Parameters.Add("@CivilStatus", SqlDbType.NVarChar).Value = patientModel.CivilStatus;
                command.Parameters.Add("@Religion", SqlDbType.NVarChar).Value = patientModel.Religion;
                command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = patientModel.Contact;
                command.Parameters.Add("@Test", SqlDbType.NVarChar).Value = patientModel.Test;
                command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = patientModel.Result;
                command.ExecuteNonQuery();
            }
        }

        //PatientControl
        
        public void AddPatient(PatientModel patientModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Patients2 (FirstName, LastName, MiddleInitial, Age, Sex, Birthdate, " +
                        "Address, CivilStatus, Religion, Contact, Test) VALUES (@FirstName, @LastName, @MiddleInitial, @Age, " +
                        "@Sex, @Birthdate, @Address, @CivilStatus, @Religion, @Contact, @Test)";

                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patientModel.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patientModel.LastName;
                    command.Parameters.Add("@MiddleInitial", SqlDbType.NVarChar).Value = patientModel.MiddleInitial;
                    command.Parameters.Add("@Age", SqlDbType.Int).Value = patientModel.Age;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = patientModel.Sex;
                    command.Parameters.Add("@Birthdate", SqlDbType.Date).Value = patientModel.Birthdate;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patientModel.Address;
                    command.Parameters.Add("@CivilStatus", SqlDbType.NVarChar).Value = patientModel.CivilStatus;
                    command.Parameters.Add("@Religion", SqlDbType.NVarChar).Value = patientModel.Religion;
                    command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = patientModel.Contact;
                    command.Parameters.Add("@Test", SqlDbType.NVarChar).Value = patientModel.Test;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatient(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Patients2 where Id=@Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.ExecuteNonQuery();
            }

        }

        public void EditPatient(PatientModel patient)
        {
            using (var connection = new SqlConnection(connectionString))    
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            UPDATE Patients2
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                MiddleInitial = @MiddleInitial,
                Age = @Age,
                Sex = @Sex,
                Birthdate = @Birthdate,
                Address = @Address,
                CivilStatus = @CivilStatus,
                Religion = @Religion,
                Contact = @Contact,
                Test = @Test
            WHERE Id = @Id";

                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patient.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patient.LastName;
                command.Parameters.Add("@MiddleInitial", SqlDbType.NVarChar).Value = patient.MiddleInitial;
                command.Parameters.Add("@Age", SqlDbType.Int).Value = patient.Age;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = patient.Sex;
                command.Parameters.Add("@Birthdate", SqlDbType.Date).Value = patient.Birthdate;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patient.Address;
                command.Parameters.Add("@CivilStatus", SqlDbType.NVarChar).Value = patient.CivilStatus;
                command.Parameters.Add("@Religion", SqlDbType.NVarChar).Value = patient.Religion;
                command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = patient.Contact;
                command.Parameters.Add("@Test", SqlDbType.NVarChar).Value = patient.Test;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = patient.Id;
                command.ExecuteNonQuery();

               
                
            }
        }

        public List<FilteredPatientModel> GetFilteredName()
        {
            var filteredPatientList = new List<FilteredPatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Patients2 ORDER BY DateCreated DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new FilteredPatientModel();

                        userModel.Id = Convert.ToInt32(reader["Id"]);
                        userModel.FirstName = reader["FirstName"].ToString();
                        userModel.LastName = reader["LastName"].ToString();
                        userModel.MiddleInitial = reader["MiddleInitial"].ToString();
                        userModel.Age = Convert.ToInt32(reader["Age"]);
                        userModel.Sex = reader["Sex"].ToString();
                        userModel.MedTech = reader["MedTech"].ToString();
                        userModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        userModel.Test = reader["Test"].ToString();
                        userModel.TestDescription = reader["TestDescription"].ToString();
                        userModel.Result = reader["Result"].ToString();
                        filteredPatientList.Add(userModel);
                    }
                }
            }
            return filteredPatientList;
        }

        public List<FilteredPatientModel> GetByFilteredName(string value)
        {
            var filteredPatientList = new List<FilteredPatientModel>();
            string userName = value;
            int Id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"    
                                        SELECT * FROM Patients2
                                        WHERE Id = @Id or LastName LIKE @LastName + '%'
                                        ORDER BY DateCreated DESC";
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = userName;
                command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new FilteredPatientModel();
                        userModel.Id = Convert.ToInt32(reader["Id"]);
                        userModel.FirstName = reader["FirstName"].ToString();
                        userModel.LastName = reader["LastName"].ToString();
                        userModel.MiddleInitial = reader["MiddleInitial"].ToString();
                        userModel.Age = Convert.ToInt32(reader["Age"]);
                        userModel.Sex = reader["Sex"].ToString();
                        userModel.MedTech = reader["MedTech"].ToString();
                        userModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        userModel.Test = reader["Test"].ToString();
                        userModel.TestDescription = reader["TestDescription"].ToString();
                        userModel.Result = reader["Result"].ToString();
                        filteredPatientList.Add(userModel);
                    }
                }
            }
            return filteredPatientList;
        }

        public List<PatientModel> GetAll()
        {
            var patientList = new List<PatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *FROM Patients2 Order by DateCreated desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                            var patientModel = new PatientModel();

                            //patientModel.Number = Convert.ToInt32(reader["Number"]);
                            patientModel.Id = Convert.ToInt32(reader["Id"]);
                            patientModel.FirstName = reader["FirstName"].ToString();
                            patientModel.LastName = reader["LastName"].ToString();
                            patientModel.MiddleInitial = reader["MiddleInitial"].ToString();
                            patientModel.Age = Convert.ToInt32(reader["Age"]);
                            patientModel.Sex = reader["Sex"].ToString();
                            patientModel.Birthdate = Convert.ToDateTime(reader["Birthdate"]);
                            patientModel.Address = reader["Address"].ToString();
                            patientModel.CivilStatus = reader["CivilStatus"].ToString();
                            patientModel.Religion = reader["Religion"].ToString();
                            patientModel.Contact = reader["Contact"].ToString();
                            patientModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                            patientModel.Test = reader["Test"].ToString();
                            patientModel.TestDescription = reader["TestDescription"].ToString();
                            patientModel.Result = reader["Result"].ToString();
                            patientList.Add(patientModel);
                    }
                }
            }
            return patientList;
        }

        //Result

        public List<PatientModel> GetAllPatientResult()
        {
            var resultList = new List<PatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Patients2  WHERE Result <> 'Pending'  ORDER BY DateCreated DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patientModel = new PatientModel();

                        //patientModel.Number = Convert.ToInt32(reader["Number"]);
                        patientModel.Id = Convert.ToInt32(reader["Id"]);
                        patientModel.FirstName = reader["FirstName"].ToString();
                        patientModel.LastName = reader["LastName"].ToString();
                        patientModel.MiddleInitial = reader["MiddleInitial"].ToString();
                        patientModel.Age = Convert.ToInt32(reader["Age"]);
                        patientModel.Sex = reader["Sex"].ToString();
                        patientModel.Birthdate = Convert.ToDateTime(reader["Birthdate"]);
                        patientModel.Address = reader["Address"].ToString();
                        patientModel.CivilStatus = reader["CivilStatus"].ToString();
                        patientModel.Religion = reader["Religion"].ToString();
                        patientModel.Contact = reader["Contact"].ToString();
                        patientModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        patientModel.Test = reader["Test"].ToString();
                        patientModel.TestDescription = reader["TestDescription"].ToString();
                        patientModel.Result = reader["Result"].ToString();
                        resultList.Add(patientModel);
                    }
                }
            }
            return resultList;
        }

        public List<FilteredPatientModel> GetResultFilteredName()
        {
            var filteredPatientList = new List<FilteredPatientModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Patients2  WHERE Result <> 'Pending'  ORDER BY DateCreated DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new FilteredPatientModel();

                        userModel.Id = Convert.ToInt32(reader["Id"]);
                        userModel.FirstName = reader["FirstName"].ToString();
                        userModel.LastName = reader["LastName"].ToString();
                        userModel.MiddleInitial = reader["MiddleInitial"].ToString();
                        userModel.Age = Convert.ToInt32(reader["Age"]);
                        userModel.Sex = reader["Sex"].ToString();
                        userModel.MedTech = reader["MedTech"].ToString();
                        userModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        userModel.Test = reader["Test"].ToString();
                        userModel.TestDescription = reader["TestDescription"].ToString();
                        userModel.Result = reader["Result"].ToString();
                        filteredPatientList.Add(userModel);
                    }
                }
            }
            return filteredPatientList;
        }

        public List<FilteredPatientModel> GetResultByFilteredName(string value)
        {
            var filteredPatientList = new List<FilteredPatientModel>();
            string userName = value;
            int Id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Patients2 WHERE LastName LIKE @LastName + '%'
                                        AND Result <> 'Pending' ORDER BY DateCreated DESC";
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = userName;
                command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new FilteredPatientModel();
                        userModel.Id = Convert.ToInt32(reader["Id"]);
                        userModel.FirstName = reader["FirstName"].ToString();
                        userModel.LastName = reader["LastName"].ToString();
                        userModel.MiddleInitial = reader["MiddleInitial"].ToString();
                        userModel.Age = Convert.ToInt32(reader["Age"]);
                        userModel.Sex = reader["Sex"].ToString();
                        userModel.MedTech = reader["MedTech"].ToString();
                        userModel.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        userModel.Test = reader["Test"].ToString();
                        userModel.TestDescription = reader["TestDescription"].ToString();
                        userModel.Result = reader["Result"].ToString();
                        filteredPatientList.Add(userModel);
                    }
                }
            }
            return filteredPatientList;
        }

        public void EditResult(PatientModel patientModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            UPDATE Patients2
            SET Result = @Result
            WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = patientModel.Id;
                command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = patientModel.Result;
                command.ExecuteNonQuery();
            }
        }

        
    }
}
