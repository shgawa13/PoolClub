using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Http.Headers;

namespace DataLayer
{
  public class clsMemberShipData
  {
    private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

    public static int AddNew(short Type, string Description, float Price)
    {
      int MemberShipID = 0;

      string Query = @"Insert into MemberShips(Type,Description,Price)
                    Values(@Type,@Description,@Price)
                    SELECT SCOPE_IDENTITY();";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConnectionString))
        {

          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {

            Command.Parameters.AddWithValue("@Type", Type);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Price", Price);

            Connection.Open();

            object result = Command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              MemberShipID = ID;
            }

          }


        }

      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }


      return MemberShipID;
    }


    public static bool Update(int MemberShipID, short Type, string Description, float Price)
    {
      int rowsAffected = 0;

      string Query = @"Update MemberShips
                     set Type=@Type,
                     Description=@Description,
                     Price=@Price
                     where MemberShipID=@MemberShipID";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConnectionString))
        {
            Connection.Open();
          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {
            Command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            Command.Parameters.AddWithValue("@Type", Type);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Price", Price);

            rowsAffected = Command.ExecuteNonQuery();
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }
        return (rowsAffected > 0);
    }


    public static DataTable GetAllMemberShips()
    {
      DataTable dtMemberShips = new DataTable();

      string Query = @"Select * from MemberShipsView";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConnectionString))
        {
          Connection.Open();
          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {
            using (SqlDataReader reader = Command.ExecuteReader())
            {

              if (reader.HasRows)
              {
                dtMemberShips.Load(reader);
              }
            }
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }


        return dtMemberShips;
    }


    public static bool GetMemberShipByID(int MemberShipID,ref short Type,ref string Description, ref float Price)
    {
      bool IsFound = false;

      string Query = @"Select * from MemberShips where MemberShipID=@MemberShipID";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConnectionString))
        {
          Connection.Open();
          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {
            Command.Parameters.AddWithValue("@MemberShipID", MemberShipID);

            using (SqlDataReader reader = Command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                Type = (short)reader["Type"];
                Description = (string)reader["Description"];
                Price = (float)reader["Price"];

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
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }

      return IsFound;
    }

    public static bool Delete(int MemberShipID)
    {
      int rowsAffected = 0;

      string Query = @"Delete from MemberShips where MemberShipID=@MemberShipID";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using (SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@MemberShipID", MemberShipID);

            rowsAffected = command.ExecuteNonQuery();
          }

        }
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex}");
      }
      finally
      {

      }

      return (rowsAffected > 0);
    }
  }
}
