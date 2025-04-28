using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataLayer
{
  
  public class clsPaymentData
  {
    /// <summary>
    /// Add New payment
    /// </summary>
    /// <param name="SubscriptionID"></param>
    /// <param name="PaymentDate"></param>
    /// <param name="Total"></param>
    /// <param name="CreatedByID"></param>
    /// <returns>PaymentID: int</returns>
    public static int AddNewPayment( int SubscriptionID, DateTime PaymentDate, float Total, int CreatedByID)
    {
      int PaymentID = -1;

      string Query = @"Insert into Payments(SubscriptionID,PaymentDate,Total,CreatedByID)
         Values(@SubscriptionID,@PaymentDate,@Total,@CreatedByID)
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
            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
           

            // resiving object from DB
            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int ID))
            {
              PaymentID = ID;
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


      return PaymentID;

    }

    /// <summary>
    /// Update payment
    /// </summary>
    /// <param name="PaymentID"></param>
    /// <param name="SubscriptionID"></param>
    /// <param name="PaymentDate"></param>
    /// <param name="Total"></param>
    /// <param name="CreatedByID"></param>
    /// <returns>Boolen</returns>
    public static bool Update(int PaymentID, int SubscriptionID, DateTime PaymentDate, float Total, int CreatedByID)
    {
      int EffectedRow = 0;

      string Query = @"Update Payments
        set SubscriptionID=@SubscriptionID,
        PaymentDate=@PaymentDate
        Total=@Total,
        CreatedByID = @CreatedByID,
        Where PaymentID=@PaymentID";
        

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
            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@CreatedByID", CreatedByID);


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
    /// Find Payment by ID
    /// </summary>
    /// <param name="PaymentID"></param>
    /// <param name="SubscriptionID"></param>
    /// <param name="PaymentDate"></param>
    /// <param name="Total"></param>
    /// <param name="CreatedByID"></param>
    /// <returns>Fill Properties and return Boolen</returns>
    public static bool FindPaymentByID(int PaymentID,ref int SubscriptionID, ref DateTime PaymentDate, 
        ref float Total, ref int CreatedByID)
    {

      bool IsFound = false;

      string Query = @"Select * from Payments where PaymentID=@PaymentID";

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
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            // rows effected  
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                IsFound = true;
                // here we will fill the props
                PaymentID = (int)reader["PaymentID"];
                SubscriptionID = (int)reader["SubscriptionID"];
                PaymentDate = (DateTime)reader["PaymentDate"];
                Total = (float)reader["Total"];
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
    /// Get all payments
    /// </summary>
    /// <returns>DataTable</returns>
    public static DataTable GetAllPayments()
    {
      DataTable dtPayments = new DataTable();

      string query = @"Select * from PaymentsView;";

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
                dtPayments.Load(reader);
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

      return dtPayments;
    }

    /// <summary>
    /// Delete payment
    /// </summary>
    /// <param name="PaymentID"></param>
    /// <returns>Boolen</returns>
    public static bool DeletePayment(int PaymentID)
    {
      int IsDeleted = -1;
      string query = @"Delete From Payments where PaymentID=@PaymentID;";
      try
      {

        using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
        {
          // Open the connection 
          connection.Open();
          // Create Command 
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
