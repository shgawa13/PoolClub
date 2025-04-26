using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

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

    private int _PersonID;
    public int PersonID
    {
      get { return _PersonID; }
      set { _PersonID = value; }
    }
    
    private string _UserName;
    public string UserName 
    {
      get { return _UserName; }
      set { _UserName = value; }
    }

    private string _Password;
    public string Password 
    {
      get { return _Password; }
      set { _Password = value; }
    }

    private bool _IsActive;
    public bool IsActive 
    {
      get { return _IsActive; }
      set { IsActive = value; } 
    }

    public clsUsers()
    {
      this.UserID = -1;
      this._PersonID = -1;
      this.UserName = string.Empty;
      this.Password = string.Empty;
      this.IsActive = false;

      this._Mode = enMode.AddNew;
    }


    private clsUsers(int UserID, int PeronID, string UserName, string Password, bool IsActive)
    {
      this.UserID = UserID;
      this._PersonID = PeronID;
      this.UserName = UserName;
      this.Password = Password;
      this.IsActive = IsActive;

      this._Mode = enMode.Update;
    }

    private bool _AddNew()
    {
      this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

      return (this.UserID !=-1);
    }

    private bool _Update() => clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);


    public static clsUsers Find(int UserID)
    {
      int PersonID = -1;
      string UserName = string.Empty, Password = string.Empty;
      bool IsActive = false;

      bool IsFound = clsUserData.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

      if (IsFound)
        return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
      else
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
