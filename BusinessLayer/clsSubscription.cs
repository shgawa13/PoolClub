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


    private int _PlayerID;
    public int PlayerID
    {
      get { return _PlayerID; }
      set { PlayerID = value; }
    }

    private int _MemberShipID;
    public int MemberShipID
    {
      get { return _MemberShipID; }
      set { MemberShipID = value; }
    }

    private DateTime _StartDate;
    public DateTime StartDate
    {
      get { return _StartDate; }
      set { _StartDate = value; }
    }

    private DateTime _EndDate;
    public DateTime EndDate
    {
      get { return _EndDate; }
      set { _EndDate = value; }
    }

    public clsMemberShip _MemberShipInfo;

    public clsSubscription()
    {
      this.SubscriptionID = -1;
      this.PlayerID = -1;
      this.MemberShipID = -1;
      this.StartDate = DateTime.Now;
      this.EndDate = DateTime.Now;

      _Mode = enMode.AddNew;
    }


    private clsSubscription(int SubscriptionID,int PlayerID,int MemberShipID,DateTime Start,DateTime End)
    {
      this.SubscriptionID = SubscriptionID;
      this.PlayerID = PlayerID;
      this.MemberShipID = MemberShipID;
      this.StartDate = Start;
      this.EndDate = End;
      this._MemberShipInfo = clsMemberShip.Find(MemberShipID);

      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      this.SubscriptionID = clsSubscriptionData.AddNew(this.PlayerID, this.MemberShipID, this.StartDate, this.EndDate);
      return (this.SubscriptionID > 0);
    }

    private bool _Update()
    {
     return clsSubscriptionData.Update(this.SubscriptionID,this.PlayerID,this.MemberShipID,this.StartDate,this.EndDate);

    }

     public static clsSubscription Find(int SubscriptionID)
    {
      int PlayerID =-1, MemberShipID =-1;
      DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;

      bool IsFound = clsSubscriptionData.GetSubscriptionByID(SubscriptionID, ref PlayerID, ref MemberShipID, ref StartDate,
        ref EndDate);

      if (IsFound)
        return new clsSubscription(SubscriptionID, PlayerID, MemberShipID, StartDate, EndDate);
      else
        return null;

    }

    public DataTable GetAllSubscriptions() => clsSubscriptionData.GetAllSubscriptions();

    public bool Delete(int SubscriptionID) => clsSubscriptionData.Delete(SubscriptionID);

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
