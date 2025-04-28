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
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="CreatedByID"></param>
    /// <param name="Total"></param>
    /// <param name="PaymentDate"></param>
    /// <returns>PaymentID: int</returns>
    public static int AddNewPayment(int PersonID, int MemberShipID, int CreatedByID, float Total, DateTime PaymentDate)
    {
      int PaymentID = -1;

      string Query = @"Insert into Payments(PersonID,MemberShipID,CreatedByID,Total,PaymentDate)
         Values(@PersonID,@MemberShipID,@CreatedByID,@Total,@PaymentDate)
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
            command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
            command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
           

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
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="CreatedByID"></param>
    /// <param name="Total"></param>
    /// <param name="PaymentDate"></param>
    /// <returns>Boolen</returns>
    public static bool Update(int PaymentID, int PersonID, int MemberShipID, int CreatedByID, float Total,DateTime PaymentDate)
    {
      int EffectedRow = 0;

      string Query = @"Update Payments
        set PersonID=@PersonID,
        MemberShipID=@MemberShipID,
        CreatedByID = @CreatedByID,
        Total=@Total,
        PaymentDate=@PaymentDate
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
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@MemberShipID", MemberShipID);
            command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);


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
    /// <param name="PersonID"></param>
    /// <param name="MemberShipID"></param>
    /// <param name="CreatedByID"></param>
    /// <param name="Total"></param>
    /// <param name="PaymentDate"></param>
    /// <returns>Fill Properties and return Boolen</returns>
    public static bool FindPaymentByID(int PaymentID,ref int PersonID,ref int MemberShipID, ref int CreatedByID, 
      ref float Total,ref DateTime PaymentDate)
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
                PersonID = (int)reader["PersonID"];
                MemberShipID = (int)reader["MemberShipID"];
                CreatedByID = (int)reader["CreatedByID"];
                Total = (float)reader["Total"];
                PaymentDate = (DateTime)reader["PaymentDate"];

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
