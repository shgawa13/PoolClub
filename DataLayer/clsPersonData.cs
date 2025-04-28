using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace DataLayer
{
  public class clsPersonData
  {
    /// <summary>
    /// AddNewPerson: 
    /// it takes 6 Parameters
    /// </summary>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    /// <param name="PhoneNumber"></param>
    /// <param name="IsActive"></param>
    /// <param name="CreatedByID"></param>
    /// <returns>the New PersonID: int</returns>
    public static int AddNewPerson(string FirstName,string LastName,string PhoneNumber, bool IsActive,int CreatedByID)
    {
      int PersonID = -1;

      string Query = @"Insert Into People(FirstName,LastName,PhoneNumber,IsActive,CreatedByID)
        Values(@FirstName,@LastName,@PhoneNumber,@IsActive,@CreatedByID)
        Select SCOPE_IDENTITY()";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {

          // open connection 
          Connection.Open();
          // create command
          using(SqlCommand command = new SqlCommand(Query, Connection))
          {
            // Adding parameters
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByID", CreatedByID);

            // resiving object from DB
            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PersonID = ID;
            }
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error Adding new Person: {ex}");
      }
      finally
      {

      }


      return PersonID;
    }


    /// <summary>
    /// Update Person
    /// </summary>
    /// <param name="PersonID"></param>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    /// <param name="PhoneNumber"></param>
    /// <param name="IsActive"></param>
    /// <returns>Boolen</returns>
    public static bool Update(int PersonID, string FirstName, string LastName, string PhoneNumber, bool IsActive)
    {
      int EffectedRow = 0;

      string Query = @"Update People
        set FirstName=@FirstName,
        LastName=@LastName,
        PhoneNumber = @PhoneNumber,  
        IsActive=@IsActive;
        Where PersonID=@PersonID";

    try {

        // Create Connection 
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(Query, connection))
          {
            // Adding Paramters
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoenNumber", PhoneNumber);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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



    /// <summary>
    /// FindPersonByPhonNumber:
    ///   It takes 7 parameters
    ///   the first param pass by value and the rest pass by ref.
    /// </summary>
    /// <param name="PersonID"></param>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    /// <param name="PhoneNumber"></param>
    /// <param name="CreatedByID"></param>
    /// <param name="IsActive"></param>
    /// <returns>Boolen also fills  Parameters</returns>
    public static bool FindPersonByID(int PersonID, ref string FirstName,ref string LastName,  ref string PhoneNumber,
        ref bool IsActive ,ref int CreatedByID)
    {

      bool IsFound = false;

      string Query = @"Select * from People where PersonID=@PersonID";

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
            command.Parameters.AddWithValue("@PersonID", PersonID);

            // rows effected  
            using(SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                FirstName = (string)reader["FirstName"];
                LastName = (string)reader["LastName"];
                PhoneNumber = (string)reader["PhoneNumber"];
                IsActive = (bool)reader["IsActive"];
                CreatedByID = (int)reader["CreatedByID"];

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


    /// <summary>
    ///  FindPersonByPhonNumber:
    ///   It takes 7 parameters
    ///   the first param pass by value and the rest pass by ref.
    /// </summary>
    /// <param name="PhoneNumber"></param>
    /// <param name="PersonID"></param>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    /// <param name="CreatedByID"></param>
    /// <param name="IsActive"></param>
    /// <returns>Boolen also fills  Parameters</returns>
    public static bool FindPersonByPhonNumber(string PhoneNumber,ref int PersonID, ref string FirstName, ref string LastName,
         ref bool IsActive, ref int CreatedByID)
    {

      bool IsFound = false;

      string Query = @"Select * from People where PhoneNumber=@PhoneNumber";

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
            command.Parameters.AddWithValue("@PhoenNumber", PhoneNumber);
            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                FirstName = (string)reader["FirstName"];
                LastName = (string)reader["LastName"];
                PhoneNumber = (string)reader["PhoneNumber"];
                IsActive = (bool)reader["IsActive"];
                CreatedByID = (int)reader["CreatedByID"];

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


    /// <summary>
    /// Exist: checks if Person Exist
    /// </summary>
    /// <param name="PhoneNumber"></param>
    /// <returns>Boolen</returns>
    public static bool IsExist(string PhoneNumber)
    {
      bool IsExist = false;

      string Query = @"Select * from People where PhoneNumber=@PhoneNumber";

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
            command.Parameters.AddWithValue("@PhoenNumber", PhoneNumber);
            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsExist= true;

               // PhoneNumber = (string)reader["PhoneNumber"];
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

      return IsExist;
    }



    /// <summary>
    /// GetAllPeople
    /// </summary>
    /// <returns> DataTable</returns>
    public static DataTable GetAllPeople()
    {
      DataTable dtPeople = new DataTable();

      string query = @"Select * from PeopleView;";

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
                dtPeople.Load(reader);
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

      return dtPeople;
    }

    /// <summary>
    /// DeletePerson:
    ///   it take PersonID: int.
    /// </summary>
    /// <param name="PersonID"></param>
    /// <returns>Boolen: if deleted return true other wise false </returns>
    public static bool DeletePerson(int PersonID)
    {
      int IsDeleted = -1;
      string query = @"Delete From People where PersonID=@PersonID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
