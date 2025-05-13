using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsMemberShip
  {
    public enum enType {None=0, Daimond =1,Gold=2,Silver=3};
    public enType MembershipType = enType.None;

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


    private bool _AddNew() 
    {
      this.MemberShipID = clsMemberShipData.AddNew(this.Type, this.Description, this.Price);
      return (this.MemberShipID > 0);
    }


    private bool _Update() => clsMemberShipData.Update(this.MemberShipID,this.Type,this.Description,this.Price);


    public static clsMemberShip Find(int MemberShipID)
    {
      short Type = 0;
      string Description = string.Empty;
      float Price = 0;

      bool IsFound = clsMemberShipData.GetMemberShipByID(MemberShipID, ref Type, ref Description, ref Price);

      if (IsFound)
        return new clsMemberShip(MemberShipID, Type, Description, Price);
      else
        return null;
      
    }


    public bool Delete(int MemeberShipID) => clsMemberShipData.Delete(MemeberShipID);
    

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
