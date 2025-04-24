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
    public int MemberShipID { get; set; }
    public bool IsActive { get; set; }
    public int CreatedByID { get; set; }

    public clsPerson()
    {
      this.PersonID = -1;
      this.FirstName = string.Empty;
      this.LastName = string.Empty;
      this.PhoneNumber = string.Empty;
      this.MemberShipID = -1;
      this.CreatedByID = -1;
      this.IsActive = false;

      _Mode = enMode.AddNew;
    }


    private clsPerson(int PersonID, string FirstName, string LastName, string PhoneNumber,int MemberShipID,
      int CreatedByID, bool IsActive)
    {
      this.PersonID = PersonID;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.PhoneNumber = PhoneNumber;
      this.MemberShipID = MemberShipID;
      this.CreatedByID = CreatedByID;
      this.IsActive = IsActive;

      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      this.PersonID = clsPersonData.AddNewPerson(this.FirstName,this.LastName,this.PhoneNumber,this.MemberShipID,
        this.IsActive,this.CreatedByID);

      return (this.PersonID > 0);
    }

    private bool _Update()
    { 
     return clsPersonData.Update(this.PersonID,this.FirstName, this.LastName, this.PhoneNumber, this.MemberShipID, 
        this.IsActive);
    }

    public static clsPerson Find(int PersonID)
    {
      string FirstName = string.Empty, LastName = string.Empty, PhoneNumber = string.Empty;
      int CreatedByID = -1, MemberShipID = -1;
      bool IsActive = false;

      bool IsFound = clsPersonData.FindPersonByID(PersonID, ref FirstName, ref LastName, ref PhoneNumber, ref MemberShipID,
        ref CreatedByID, ref IsActive);

      if (IsFound)
        return new clsPerson(PersonID, FirstName, LastName, PhoneNumber, MemberShipID, CreatedByID, IsActive);
      else
        return null;
    }

    public static clsPerson Find(string PhoneNumber) 
    {
      string FirstName = string.Empty, LastName = string.Empty;
      int PersonID = -1, CreatedByID = -1, MemberShipID = -1;
      bool IsActive = false;

      bool IsFound = clsPersonData.FindPersonByPhonNumber(PhoneNumber, ref PersonID, ref FirstName, ref LastName, ref MemberShipID,
        ref CreatedByID, ref IsActive);

      if (IsFound)
        return new clsPerson(PersonID, FirstName, LastName, PhoneNumber, MemberShipID, CreatedByID, IsActive);
      else
        return null;
    }


    public static bool IsExist(string PhoneNumber) => clsPersonData.IsExist(PhoneNumber);

    public static bool Delete(int PersonID) => clsPersonData.DeletePerson(PersonID);


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
