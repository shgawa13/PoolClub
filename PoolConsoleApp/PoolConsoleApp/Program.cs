using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace PoolConsoleApp
{
  internal class Program
  {
   

    public static void AddNewPerson()
    {
      clsPerson  p1= new clsPerson();
      p1.FirstName = "Nano";
      p1.LastName = "AlKamies";
      p1.PhoneNumber = "0548748374";
      p1.MemberShipID = 1;
      p1.CreatedByID = 2;
      p1.IsActive = true;

      if (p1.Save())
        Console.WriteLine("new person had been added");
      else
        Console.WriteLine("Faild");
    }


    public static void find(int id)
    {
      clsPerson p = clsPerson.Find(id);

      if(p != null)
      {
        Console.WriteLine($"Person ID: {p.PersonID}");
        Console.WriteLine($"FirstName: {p.FirstName}");
        Console.WriteLine($"LastName: {p.LastName}");
        Console.WriteLine($"PhoneNumber:  {p.PhoneNumber}");
        Console.WriteLine($"MemberShip :{p.MemberShipID}");
        Console.WriteLine($"CreatedBy  : {p.CreatedByID}");
        Console.WriteLine($"Is Active  :{p.IsActive}");

      }
      else
      {
        Console.WriteLine($"person with {id} was not found");
      }
    }



    public static void Delete(int ID)
    {

      if (clsPerson.Delete(ID))
        Console.WriteLine($"Person with id: {ID} has been deleted");
      else
        Console.WriteLine("couldn't delted");

    }



    static void Main(string[] args)
    {

      //AddNewPerson();
      Delete(6);
      Console.ReadKey();

    }
  }
}
