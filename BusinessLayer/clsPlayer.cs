using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
  public class clsPlayer: clsPerson
  {

    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = enMode.AddNew;

    private int _PlayerID;
    public int PlayerID
    {
      get { return _PlayerID; }
      set { _PlayerID = value; }
    }

    public int PersonID { get; set; }
    public bool HasMemberShip { get; set; }
    
    public clsPerson PlayerInfo;

    public clsPlayer()
    {
      this.PlayerID = -1;
      this.PersonID = -1;
      this.HasMemberShip = false;

      _Mode = enMode.AddNew;
    }


    private clsPlayer(int PlayerID,int PersonID, bool HasMemberShip)
    {
      this.PlayerID = PlayerID;
      this.PersonID = PersonID;
      this.HasMemberShip = HasMemberShip;
      this.PlayerInfo = clsPerson.Find(PersonID);
      
      _Mode = enMode.Update;
    }


    private bool _AddNew()
    {
      this.PlayerID = clsPlayersData.AddNewPlayer(this.PersonID,this.HasMemberShip);

      return (this.PlayerID > 0);
    }

    private bool _Update()
    {
      return clsPlayersData.Update(this.PlayerID,this.PersonID, this.HasMemberShip);
    }

    public static clsPlayer Find(int PlayerID)
    {
      int PersonID = -1;
      bool HasMemberShip = false;

      bool IsFound = clsPlayersData.FindPlayerByID(PlayerID, ref PersonID, ref HasMemberShip);

      if (IsFound)
        return new clsPlayer(PlayerID, PersonID, HasMemberShip);
      else
        return null;
    }

    public static clsPlayer Find(string PhoneNumber)
    {
  
      int PlayerID = -1, PersonID = -1;
      bool HasMemberShip = false;

      bool IsFound = clsPlayersData.FindPlayerByPhoneNumber(PhoneNumber, ref PlayerID, ref PersonID, ref HasMemberShip);

      if (IsFound)
        return new clsPlayer(PlayerID, PersonID,HasMemberShip);
      else
        return null;
    }

    public static DataTable GetAllPlayers() => clsPlayersData.GetAllPlayers();

    public static bool IsExist(string PhoneNumber) => clsPlayersData.IsExist(PhoneNumber);

    public bool Delete()
    {
      bool IsPlayerDeleted = false;
      bool IsPersonDeleted = false;

      IsPlayerDeleted = clsPlayersData.DeletePlayer(this.PlayerID);

      // first we check if the Player was deleted
      if (!IsPlayerDeleted)
        return false;

      // then we delete the base which is Person.
      IsPersonDeleted = base.Delete();

      return IsPersonDeleted;
      
    }


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
