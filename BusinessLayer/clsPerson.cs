using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class clsPerson
  {
    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

    private int _ID;
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public clsPerson()
    {
      this.ID = -1;
      this.FirstName = string.Empty;
      this.LastName = string.Empty;
      this.PhoneNumber = string.Empty;

      _Mode = enMode.AddNew;
    }


    private clsPerson(int ID, string FirstName, string LastName, string PhoneNumber)
    {
      this.ID = ID;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.PhoneNumber = PhoneNumber;

      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      //this.ID = 

      return false;
    }

    private bool _Update() => false;

    public static clsPerson Find(int ID)
    {
      return null;
    }

    public static clsPerson Find(string PhoneNumber) => null;


    public static bool IsExist(string PhoneNumber) => false;

    public static bool Delete(int ID) => false;


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
