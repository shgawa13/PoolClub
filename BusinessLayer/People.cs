using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class People
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

    public People()
    {
      this.ID = -1;
      this.FirstName = string.Empty;
      this.LastName = string.Empty;
      this.PhoneNumber = string.Empty;

      _Mode = enMode.AddNew;
    }


    private People(int ID, string FirstName, string LastName, string PhoneNumber)
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



  }
}
