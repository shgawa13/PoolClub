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
    public static int AddNewUser(string UserName,string Password,bool IsActive,int PersonID)
    {
      int UserID = -1;

      string Query = @"Insert into Users(UserName,Password,IsActive,PersonID)
         Values(@UserName,@Password,@IsActive,@PersonID)
         Select SCOPE_IDENTITY()";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {

          // open connection 
          Connection.Open();
          // create command
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            // Adding parameters
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            // resiving object from DB
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
        Console.WriteLine($"Error Adding new Person: {ex}");
      }
      finally
      {

      }


      return UserID;

    }

    public static bool Update(int UserID,string UserName, string Password, bool IsActive, int PersonID)
    {
      int EffectedRow = 0;

      string Query = @"Update Users
        set UserName=@UserName,
        Password=@Password,
        IsActive = @IsActive,
        PersonID=@PersonID,
        Where UserID=@UserID";

      try
      {

        // Create Connection 
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // Adding Paramters
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);


            // rows effected  
            EffectedRow = command.ExecuteNonQuery();

          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        // Console.WriteLine($"");
      }

      return (EffectedRow > 0);

    }

    public static bool FindUserByID(int UserID,ref string UserName,ref string Password,ref bool IsActive, ref int PersonID)
    {

      bool IsFound = false;

      string Query = @"Select * from Users where UserID=@UserID";

      try
      {

        // Create Connection 
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // Adding Paramters
            command.Parameters.AddWithValue("@UserID", UserID);

            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                UserID = (int)reader["UserID"];
                UserName = (string)reader["UserName"];
                Password = (string)reader["Password"];
                IsActive = (bool)reader["IsActive"];
                PersonID = (int)reader["PersonID"];

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
        // Console.WriteLine($"");
      }

      return IsFound;
    }


    public static DataTable GetAllUsers()
    {
      DataTable dtUsers = new DataTable();

      string query = @"Select * from UsersView;";

      try
      {

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
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


    public static bool IsActive(int UserID)
    {
      bool IsActive = false;

      return IsActive;
    }

    public static bool DeleteUser(int UserID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Users where UserID=@UserID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@UserID", UserID);

            IsDeleted = command.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }
      finally
      {
        //Console.WriteLine($"Person ID is: {PersonID}");
      }

      return (IsDeleted > 0);
    }

  }
}
