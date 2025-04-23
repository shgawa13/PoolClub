using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class clsUsers
  {
    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

    private int _UserID;
    public int UserID
    {
      get { return _UserID; }
      set { _UserID = value; }
    }

    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    
    public clsUsers()
    {
      this.UserID = -1;
      this.UserName = string.Empty;
      this.Password = string.Empty;
      this.IsActive = false;

      this._Mode = enMode.AddNew;
    }


    private clsUsers(int UserID, string UserName, string Password, bool IsActive)
    {
      this.UserID = UserID;
      this.UserName = UserName;
      this.Password = Password;
      this.IsActive = IsActive;

      this._Mode = enMode.Update;
    }

    private bool _AddNew()
    {
      //this.UserID = 

      return false;
    }

    private bool _Update() => false;

    public static clsUsers Find(int UserID)
    {
      return null;
    }

    public static clsUsers Find(string PhoneNumber) => null;


    public static bool IsExist(string PhoneNumber) => false;

    public static bool Delete(int UserID) => false;


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
