using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsPerson
  {
    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

    private int _PersonID;
    public int PersonID
    {
      get { return _PersonID; }
      set { _PersonID = value; }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public int MemberShipPersonID { get; set; }
    public bool IsActive { get; set; }
    public int CreatedByPersonID { get; set; }

    public clsPerson()
    {
      this.PersonID = -1;
      this.FirstName = string.Empty;
      this.LastName = string.Empty;
      this.PhoneNumber = string.Empty;
      this.MemberShipPersonID = -1;
      this.IsActive = false;
      this.CreatedByPersonID = -1;

      _Mode = enMode.AddNew;
    }


    private clsPerson(int PersonID, string FirstName, string LastName, string PhoneNumber,int MemberShipPersonID,
      bool IsActive,int CreatedByPersonID)
    {
      this.PersonID = PersonID;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.PhoneNumber = PhoneNumber;
      this.MemberShipPersonID = MemberShipPersonID;
      this.IsActive = IsActive;
      this.CreatedByPersonID = CreatedByPersonID;

      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      this.PersonID = clsPersonData.AddNewPerson(this.FirstName,this.LastName,this.PhoneNumber,this.MemberShipPersonID,
        this.IsActive,this.CreatedByPersonID);

      return (this.PersonID > 0);
    }

    private bool _Update() => false;

    public static clsPerson Find(int PersonID)
    {
      return null;
    }

    public static clsPerson Find(string PhoneNumber) => null;


    public static bool IsExist(string PhoneNumber) => false;

    public static bool Delete(int PersonID) => false;


    public  bool Save()
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
