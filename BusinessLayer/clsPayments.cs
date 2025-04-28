using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsPayments
  {
    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

    private int _PaymentID;
    public int PaymentID
    {
      get { return _PaymentID; }
      set { _PaymentID = value; }
    }

    private int _SubscriptionID;
    public int SubscriptionID
    {
      get { return _SubscriptionID; }
      set { value = _SubscriptionID; }
    }

    private DateTime _PaymentDate;
    public DateTime PaymentDate
    {
      get { return _PaymentDate; }
      set { value = _PaymentDate; }
    }

    private float _Total;
    public float Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private int _CreatedByID;
    public int CreatedByID
    {
      get { return _CreatedByID; }
      set { value = _CreatedByID; }
    }


    public clsPayments()
    {
      this.PaymentID = -1;
      this.SubscriptionID = -1;
      this.PaymentDate = DateTime.Now;
      this.Total = 0;
      this.CreatedByID = -1;

      _Mode = enMode.AddNew;
    }

    private clsPayments(int PaymentID, int SubscriptionID, DateTime PaymentDate, float Total, int CreatedByID)
    {
      this.PaymentID = PaymentID;
      this.SubscriptionID = SubscriptionID;
      this.PaymentDate = PaymentDate;
      this.Total = Total;
      this.CreatedByID = CreatedByID;

      _Mode = enMode.Update;
    }

    private bool _AddNew() 
    {
      this.PaymentID = clsPaymentData.AddNewPayment(this.SubscriptionID, this.PaymentDate, this.Total, this.CreatedByID);

      return (this.PaymentID != -1);
    
    }

    private bool _Update()
    {
      return clsPaymentData.Update(this.PaymentID, this.SubscriptionID, this.PaymentDate,this.Total, this.CreatedByID);
    }

    public clsPayments Find(int PaymentID)
    {
      int PersonID = -1, SubscriptionID = -1, CreatedByID = -1;
      float Total = 0;
      DateTime PaymentDate = DateTime.Now;

      bool IsFound = clsPaymentData.FindPaymentByID(PaymentID, ref SubscriptionID, ref PaymentDate,
        ref Total, ref CreatedByID);

      if (IsFound)
        return new clsPayments(PaymentID, SubscriptionID, PaymentDate, Total, CreatedByID);
      else
        return null;
    }

    public bool Delete(int PaymentID) => clsPaymentData.DeletePayment(PaymentID);

    public bool Save()
    {
      switch (_Mode)
      {
        case enMode.AddNew:
          if (_AddNew())
          {
            _Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }

        case enMode.Update:
          return _Update();


      }
      return false;
    }
  }
}
