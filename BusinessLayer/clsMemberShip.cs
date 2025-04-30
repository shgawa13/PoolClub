using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsMemberShip
  {
    public enum enType { Daimond =1,Gold=2,Silver=3};

    public enum enMode { AddNew=0, Update=1 }
    private enMode _Mode = enMode.AddNew;

    private int _MemberShipID;
    public int MemberShipID
    {
      get { return _MemberShipID; }
      set { _MemberShipID = value; }  
    }

    private short _Type;
    public short Type
    {
      get { return _Type; }
      set { _Type = value; }
    }

    private string _Description;
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }

    private float _Price;
    public float Price
    {
      get { return _Price; }
      set { _Price = value; }
    }


    public clsMemberShip()
    {
      this.MemberShipID = -1;
      this.Type = -1;
      this.Description = string.Empty;
      this.Price = -1;

      _Mode = enMode.AddNew;
    }

    private clsMemberShip(int MemberShipID, short Type, string Description,float Price)
    {
      this.MemberShipID = MemberShipID;
      this.Type = Type;
      this.Description = Description;
      this.Price = Price;

      _Mode = enMode.Update;
    }


    private bool _AddNew() => false;


    private bool _Update() => false;


    public clsMemberShip Find() => null;


    public bool Delete(int MemeberShipID) => false;
    

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
