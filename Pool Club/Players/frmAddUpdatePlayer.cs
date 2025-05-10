using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Pool_Club.Players
{
  public partial class frmAddUpdatePlayer : Form
  {
    public enum enMode { AddNew=0, Update=1 }
    private enMode _Mode = enMode.AddNew;

    private int _PlayerID = -1;
    private clsPlayer _Player;
    private clsPerson _Person;

    public frmAddUpdatePlayer()
    {
      InitializeComponent();
      _Mode = enMode.AddNew;
     
    }

    public frmAddUpdatePlayer(int ID)
    {
      InitializeComponent();
      _PlayerID = ID;

      _Mode = enMode.Update;
    }


    // this function will rest the form to Defualt.
    private void _ResetDefualtValues()
    {
      if (_Mode == enMode.AddNew) 
      {
        this.Text = "Add New";
        lblTitle.Text = "Add New";
        lblPlayerID.Text = "???";
      }

        txbFirstName.Text = string.Empty;
      txbLastName.Text = string.Empty;
      txbPhone.Text = string.Empty;
    }

    private void _LoadData()
    {
      _Player = clsPlayer.Find(_PlayerID);

      // if null we will return.
      if (_Player == null)
      {
        MessageBox.Show($"Error: couldn't find PlayerID: {_PlayerID}.",
          "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        this.Close();
        return;
      }

      // if not null we will fill the form with data.
      lblPlayerID.Text = _Player.PlayerID.ToString();
      txbFirstName.Text = _Player.PlayerInfo.FirstName;
      txbLastName.Text = _Player.PlayerInfo.LastName;
      txbPhone.Text = _Player.PlayerInfo.PhoneNumber;
    }

    private void frmAddUpdatePlayer_Load(object sender, EventArgs e)
    {
      if (_Mode == enMode.Update)
        _LoadData();
    }

    // Now we Fill both Person and Player Obj.
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      _Person.FirstName = txbFirstName.Text.Trim();
      _Person.LastName = txbLastName.Text.Trim();
      _Person.PhoneNumber = txbPhone.Text.Trim();

      if (_Person.Save())
      {
        // now we create player
        _Player.PersonID = _Person.PersonID;
        if (_Player.Save())
        {
          lblPlayerID.Text = _Player.PlayerID.ToString();
          MessageBox.Show("Data Has been Save Successfully");
        }
        else
        {
          MessageBox.Show("Error: Something went worng couldn't Save Player.");
        }
      }
    }
  }
}
