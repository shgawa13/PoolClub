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

    private int _PersonID;
    public int PersonID
    {
      get { return _PersonID; }
      set { _PersonID = value; }
    }

    public clsUsers()
    {
      this.UserID = -1;
      this.UserName = string.Empty;
      this.Password = string.Empty;
      this.IsActive = false;
      this._PersonID = -1;

      this._Mode = enMode.AddNew;
    }


    private clsUsers(int UserID, string UserName, string Password, bool IsActive, int PeronID)
    {
      this.UserID = UserID;
      this.UserName = UserName;
      this.Password = Password;
      this.IsActive = IsActive;
      this.PersonID = PeronID;

      this._Mode = enMode.Update;
     
    }

    private bool _AddNew()
    {
      this.UserID = clsUserData.AddNewUser(this.UserName, this.Password, this.IsActive, this.PersonID);

      return (this.UserID !=-1);
    }

    private bool _Update() => clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive);


    public static clsUsers Find(int UserID)
    {
      int PersonID = -1;
      string UserName = string.Empty, Password = string.Empty;
      bool IsActive = false;

      bool IsFound = clsUserData.GetUserByID(UserID, ref UserName, ref Password, ref IsActive,ref PersonID);

      if (IsFound)
        return new clsUsers(UserID, UserName, Password, IsActive,PersonID);
      else
        return null;
    }

    public static clsUsers Find(string PhoneNumber) => clsUsers.Find(PhoneNumber);

    public static bool IsExist(string UserName) => clsUserData.IsUserExist(UserName);

    public static bool Delete(int UserID) => clsUserData.DeleteUser(UserID);

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
