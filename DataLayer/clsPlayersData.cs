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
  public class clsPlayersData
  {
    /// <summary>
    /// Add new Player
    /// </summary>
    /// <param name="PersonID"></param>
    /// <param name="HasMemberShip"></param>
    /// <returns>Int: PlayerID</returns>
    public static int AddNewPlayer(int PersonID,bool HasMemberShip)
    {
      int PlayerID = -1;

      string Query = @"Insert Into Players(PersonID,HasMemberShip)
        Values(@PersonID,@HasMemberShip)
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
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@HasMemberShip", HasMemberShip);
           
            // resiving object from DB
            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PlayerID = ID;
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


      return PlayerID;
    }


    /// <summary>
    /// Update
    /// </summary>
    /// <param name="PlayerID"></param>
    /// <param name="PersonID"></param>
    /// <param name="HasMemberShip"></param>
    /// <returns>Boolen</returns>
    public static bool Update(int PlayerID,int PersonID, bool HasMemberShip)
    {
      int EffectedRow = 0;

      string Query = @"Update Players
        set PersonID=@PersonID,
        HasMemberShip=@HasMemberShip,
        Where PlayerID=@PlayerID";

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
            command.Parameters.AddWithValue("@PlayerID", PlayerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@HasMemberShip", HasMemberShip);
           
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
    /// Find Player by PlayerID
    /// </summary>
    /// <param name="PlayerID"></param>
    /// <param name="PersonID"></param>
    /// <param name="HasMemberShip"></param>
    /// <returns>Boolen</returns>
    public static bool FindPlayerByID(int PlayerID ,ref int PersonID, ref bool HasMemberShip)
    {

      bool IsFound = false;

      string Query = @"Select * from People where PlayerID=@PlayerID";

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
            command.Parameters.AddWithValue("@PlayerID", PlayerID);

            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                PersonID = (int)reader["PersonID"];
                HasMemberShip = (bool)reader["HasMemberShip"];
                
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
    /// Find Player by PhoneNumber.
    /// </summary>
    /// <param name="PhoneNumber"></param>
    /// <param name="PlayerID"></param>
    /// <param name="PersonID"></param>
    /// <param name="HasMemberShip"></param>
    /// <returns>Boolen</returns>
    public static bool FindPlayerByPhoneNumber(string PhoneNumber,ref int PlayerID, ref int PersonID, ref bool HasMemberShip)
    {

      bool IsFound = false;

      string Query = @"Select * from Players
                     inner join People on Players.PersonID=People.PersonID
                     where PhoneNumber=@PhoneNumber";

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
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                PlayerID = (int)reader["PlayerID"];
                PersonID = (int)reader["PersonID"];
                HasMemberShip = (bool)reader["HasMemberShip"];

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
    /// Is Player Phone Number Exist.
    /// </summary>
    /// <param name="PhoneNumber"></param>
    /// <returns>Boolen</returns>
    public static bool IsExist(string PhoneNumber)
    {
      bool IsFound = false;

      string Query = @"Select Found=1 From Players
                     inner join People on Players.PersonID=People.PersonID
                     Where PhoneNumber =@PhoneNumber;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();
          using (SqlCommand command = new SqlCommand(Query, Connection))
          {
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

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


    /// <summary>
    /// GetAllPlayers
    /// </summary>
    /// <returns> DataTable</returns>
    public static DataTable GetAllPlayers()
    {
      DataTable dtPlayers = new DataTable();

      string query = @"Select * from PlayersView;";

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
                dtPlayers.Load(reader);
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

      return dtPlayers;
    }

    /// <summary>
    /// Delete Player:
    ///   it take PlayerID: int.
    /// </summary>
    /// <param name="PlayerID"></param>
    /// <returns>Boolen: if deleted return true other wise false </returns>
    public static bool DeletePlayer(int PlayerID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Players where PlayerID=@PlayerID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PlayerID", PlayerID);

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
        //Console.WriteLine($"Player ID is: {PlayerID}");
      }

      return (IsDeleted > 0);
    }
  }
}
