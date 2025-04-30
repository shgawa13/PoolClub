using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsSubscription
  {
    public enum enMode {AddNew=0,Update=1 }
    private enMode _Mode = enMode.AddNew;

    private int _SubscriptionID;
    public int SubscriptionID
    {
      get { return _SubscriptionID; }
      set { SubscriptionID = value; }
    }


    private int _PersonID;
    public int PersonID
    {
      get { return _PersonID; }
      set { PersonID = value; }
    }

    private int _MemberShipID;
    public int MemberShipID
    {
      get { return _MemberShipID; }
      set { MemberShipID = value; }
    }

    private DateTime _StartTime;
    public DateTime StartTime
    {
      get { return _StartTime; }
      set { _StartTime = value; }
    }

    private DateTime _EndTime;
    public DateTime EndTime
    {
      get { return _EndTime; }
      set { _EndTime = value; }
    }
    
    public clsSubscription()
    {
      this.SubscriptionID = -1;
      this.PersonID = -1;
      this.MemberShipID = -1;
      this.StartTime = DateTime.Now;
      this.EndTime = DateTime.Now;

      _Mode = enMode.AddNew;
    }


    private clsSubscription(int SubscriptionID,int PersonID,int MemberShipID,DateTime Start,DateTime End)
    {
      this.SubscriptionID = SubscriptionID;
      this.PersonID = PersonID;
      this.MemberShipID = MemberShipID;
      this.StartTime = Start;
      this.EndTime = End;

      _Mode = enMode.Update;
    }


    private bool _AddNew() => false;

    private bool _Update() => false;

    public clsSubscription Find(int SubscriptionID) => null;

    public DataTable GetAllSubscriptions() => null;

    public bool Delete(int SubscriptionID) => false;

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
            return false;

        case enMode.Update:
          return _Update();
      }


      return false;
    }
  }
}
