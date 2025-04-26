using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
  public class clsUserData
  {
    // Get User by UserID

    public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
    {
      bool IsFound = false;

     
      string Query = @"Select * From Users Where UserID =@UserID;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // open Connection 

          Connection.Open();
          // create command
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("UserID", UserID);

            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                // User Found
                IsFound = true;

                PersonID = (int)reader["PersonID"];
                UserName = (string)reader["UserName"];
                Password = (string)reader["Password"];
                IsActive = (bool)reader["IsActive"];
              }

            }

          }
        }
      }
      catch (Exception ex)
      {
        IsFound = false;
      }
      finally
      {

      }

      return IsFound;
    }

    // Get User by PersonID
    public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
                 ref string Password, ref bool IsActive)
    {
      bool IsFound = false;
      string Query = @"Select * From Users Where PersonID =@PersonID;";

      try { 
      using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
      {
          // open Connection 

          Connection.Open();
        using (SqlCommand command = new SqlCommand(Query, Connection))
        {
          command.Parameters.AddWithValue("@PersonID", PersonID);


          using (SqlDataReader reader = command.ExecuteReader())
          {

            if (reader.Read())
            {
              IsFound = true;


              UserID = (int)reader["UserID"];
              UserName = (string)reader["UserName"];
              Password = (string)reader["Password"];
              IsActive = (bool)reader["IsActive"];
            }
          }

        
        }

      }
      }
      catch (Exception ex)
      {
        IsFound = false;
      }
      finally
      {
        
      }

      return IsFound;
    }


    // Get User by UserName and Password
    public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
          ref int UserID, ref int PersonID, ref bool IsActive)
    {
      bool IsFound = false;

      string Query = @"Select * From Users Where UserName =@UserName and Password=@Password;";

     
      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"])) { 
          Connection.Open();
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                UserID = (int)reader["UserID"];
                PersonID = (int)reader["PersonID"];
                IsActive = (bool)reader["IsActive"];

              }
              else
              {
                IsFound = false;
              }
            }


          }
        }
      }
      catch (Exception ex)
      {
        IsFound = false;
      }
      finally
      {
      
      }

      return IsFound;
    }

    // Add new User
    public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
    {
      int UserID = -1;

        string Query = @"Insert into Users (PersonID,UserName,Password,IsActive)
                         values(@PersonID,@UserName,@Password,@IsActive);
                         SELECT SCOPE_IDENTITY();";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"])) 
        { 
          using(SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
              
            Connection.Open();
            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              UserID = ID;
            }
          }

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
       
      }

      return UserID;
    }

    // Update User
    public static bool UpdateUser(int UserID, int PersonID, string UserName,
           string Password, bool IsActive)
    {
      int rowsAffected = 0;

      
      string Query = @"Update Users
                         set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";

      try
      {
        using(SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"])) 
        { 
          Connection.Open();
          using(SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

            rowsAffected = command.ExecuteNonQuery();
          }


        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        
      }

      return (rowsAffected > 0);
    }

    // Get All Users
    public static DataTable GetAllUsers()
    {
      DataTable dtUsers = new DataTable();

      string Query = @"Select Users.UserID, Users.PersonID, People.FirstName + ' ' + People.SecondName + ' '+
                        IsNull(People.ThirdName,'')+ ' '+ People.LastName as FullName, Users.UserName,
                        Users.IsActive from Users inner join People on Users.PersonID = People.PersonID; ";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using(SqlCommand command = new SqlCommand(Query, Connection))
          {

            using(SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.HasRows)
              {
                dtUsers.Load(reader);
              }
            }

          }


        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }

      finally
      {
       
      }


      return dtUsers;
    }

    // Delete User
    public static bool DeleteUser(int UserID)
    {
      int rowsAffected = 0;

      string Query = @"Delete From Users Where UserID = @UserID;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using(SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@UserID", UserID);

            rowsAffected = command.ExecuteNonQuery();
          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        
      }

      return (rowsAffected > 0);
    }

    // Is UserID Exist
    public static bool IsUserExist(int UserID)
    {
      bool IsFound = false;
      string Query = @"Select Found=1 From Users Where UserID =@UserID;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {

          Connection.Open();
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@UserID", UserID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
               IsFound = reader.HasRows;

            }

          }

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        
      }

      return IsFound;
    }

    // Is UserName Exist
    public static bool IsUserExist(string UserName)
    {
      bool IsFound = false;

      string Query = @"Select Found=1 From Users Where UserName =@UserName;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@UserName", UserName);

            SqlDataReader reader = command.ExecuteReader();
            IsFound = reader.HasRows;
          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
       
      }

      return IsFound;
    }

    // Is User Exist for PeronsID
    public static bool IsUserExistForPersonID(int PersonID)
    {
      bool IsFound = false;
      string Query = @"Select Found=1 From Users Where PersonID =@PersonID;";

      try
      {
        using(SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using (SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@PersonID", PersonID);
            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;
          }

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
       
      }

      return IsFound;
    }


    public static bool DoesPersonHaveUser(int PersonID)
    {
      bool IsFound = false;
      string Query = @"Select Found=1 From Users Where PersonID =@PersonID;";


      try
      {
        using(SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();
      
          using(SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;

          }

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        
      }

      return IsFound;
    }

    public static bool ChangePassword(int UserID, string NewPassword)
    {
      int rowsAffected = 0;

      string Query = @"Update Users
                        set Password=@NewPassword
                        Where UserID=@UserID;";
      try
      {
        using(SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@NewPassword", NewPassword);
            command.Parameters.AddWithValue("@UserID", UserID);

            rowsAffected = command.ExecuteNonQuery();

          }

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
       
      }

      return (rowsAffected > 0);
    }

  }
}
