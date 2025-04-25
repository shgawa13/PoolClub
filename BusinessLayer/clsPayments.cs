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

    private int _PersonID;
    public int PersonID
    {
      get { return _PersonID; }
      set { _PersonID = value; }
    }

    private int _MemberShipID;
    public int MemberShipID
    {
      get { return _MemberShipID; }
      set { value = _MemberShipID; }
    }

    private int _CreatedByID;
    public int CreatedByID
    {
      get { return _CreatedByID; }
      set { value = _CreatedByID; }
    }

    private float _Totla;
    public float Total;

    public clsPayments()
    {
      this.PaymentID = -1;
      this.PersonID = -1;
      this.MemberShipID = -1;
      this.CreatedByID = -1;
      this.Total = 0;

      _Mode = enMode.AddNew;
    }

    private clsPayments(int PaymentID, int PersonID, int MemberShipID, int CreatedByID, float Total)
    {
      this.PaymentID = PaymentID;
      this.PersonID = PersonID;
      this.MemberShipID = MemberShipID;
      this.CreatedByID = CreatedByID;
      this.Total = Total;

      _Mode = enMode.Update;
    }

    private bool _AddNew() 
    {
      this.PaymentID = clsPaymentData.AddNewPayment(this.PersonID, this.MemberShipID, this.CreatedByID, 
        this.Total);

      return (this.PaymentID != -1);
    
    }

    private bool _Update()
    {
      return clsPaymentData.Update(this.PaymentID, this.PersonID, this.MemberShipID, this.CreatedByID,
        this.Total);
    }

    public clsPayments Find(int PaymentID)
    {
      int PersonID = -1, MemberShipID = -1, CreatedByID = -1;
      float Total = 0;

      bool IsFound = clsPaymentData.FindPaymentByID(PaymentID, ref PersonID, ref MemberShipID, ref CreatedByID,
        ref Total);

      if (IsFound)
        return new clsPayments(PaymentID, PersonID, MemberShipID, CreatedByID, Total);
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
