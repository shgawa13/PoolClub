using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace DataLayer
{
  public class clsSubscriptionData
  {
   
    /// <summary>
    /// Add new Subscription
    /// </summary>
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="StartDate"></param>
    /// <param name="EndDate"></param>
    /// <returns>return New Subscription ID</returns>
    public static int AddNew(int PersonID, int MemberShipID, DateTime StartDate, DateTime EndDate)
    {
      int SubscriptionID = 0;

      string Query = @"Insert Into Subscriptions(PersonID,MemberShipID,StartDate,EndDate)
                     Values(@PersonID,@MemberShipID,@StartDate,@EndDate)
                     SELECT SCOPE_IDENTITY();";

      try
      {
        using(SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

            object result = Command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              SubscriptionID = ID;
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

      return SubscriptionID;
    }

    /// <summary>
    /// Update Subscription
    /// </summary>
    /// <param name="SubscriptionID"></param>
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="StartDate"></param>
    /// <param name="EndDate"></param>
    /// <returns>Boolen</returns>
    public static bool Update(int SubscriptionID, int PersonID, int MemberShipID, DateTime StartDate, DateTime EndDate)
    {
      int rowsAffected = 0;

      string Query = @"Update Subscriptions
                     set PersonID=@PersonID,
                     MemberShipID=@MemberShipID,
                     StartDate=@StartDate,
                     EndDate=@EndDate
                     where SubscriptionID=@SubscriptionID;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using(SqlCommand Command = new SqlCommand(Query, Connection))
          {
            Command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

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

    /// <summary>
    /// Find Subscription by SubscriptionID
    /// </summary>
    /// <param name="SubscriptionID"></param>
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="StartDate"></param>
    /// <param name="EndDate"></param>
    /// <returns>Boolen and fill the praperties</returns>
    public static bool GetSubscriptionByID(int SubscriptionID, ref int PersonID, ref int MemberShipID,
        ref DateTime StartDate, ref DateTime EndDate)
    {
      bool IsFound = false;

      string Query = @"Select * from Subscriptions Where SubscriptionID=@SubscriptionID;";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using(SqlCommand Command = new SqlCommand(Query, Connection))
          {
            Command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

            using (SqlDataReader reader = Command.ExecuteReader())
            {
              if (reader.Read())
              {
                IsFound = true;

                PersonID = (int)reader["PersonID"];
                MemberShipID = (int)reader["MemberShipID"];
                StartDate = (DateTime)reader["StartDate"];
                EndDate = (DateTime)reader["EndDate"];
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

    /// <summary>
    /// Get All Subscriptions  
    /// </summary>
    /// <returns>DataTable</returns>
    public static DataTable GetAllSubscriptions()
    {
      DataTable dtSubscriptions = new DataTable();

      string Query = @"Select * from SubscriptionsView";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();
          using (SqlCommand Command = new SqlCommand(Query, Connection))
          {
            using (SqlDataReader reader = Command.ExecuteReader())
            {

              if (reader.HasRows)
              {
                dtSubscriptions.Load(reader);
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
      return dtSubscriptions;
    }

    /// <summary>
    /// Delete Subscription
    /// </summary>
    /// <param name="SubscriptionID"></param>
    /// <returns>Bool</returns>
    public static bool Delete(int SubscriptionID)
    {
      int rowsAffected = 0;

      string Query = @"Delete from Subscriptions where SubscriptionID=@SubscriptionID";

      try
      {
        using (SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          Connection.Open();

          using (SqlCommand command = new SqlCommand(Query, Connection))
          {

            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

            rowsAffected = command.ExecuteNonQuery();
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

      return (rowsAffected > 0);
    }
  }
}
