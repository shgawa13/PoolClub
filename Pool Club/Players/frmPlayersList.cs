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
  public partial class frmPlayers : Form
  {
    private clsPlayer _Player;

    // in case there is no data in the database.
    private static DataTable _dtAllPlayers = clsPlayer.GetAllPeople() ?? new DataTable();
    private DataTable _dtPlayers = _dtAllPlayers.Clone();

    public frmPlayers()
    {
      InitializeComponent();
      _Reset();
    }

    private void _Reset()
    {
      cbFilterBy.SelectedIndex = 0;
      btnSearch.Visible = false;
      txtFilterValue.Visible = false;
    }

    private void _RefreshPlayersList()
    {
      _dtPlayers = clsPlayer.GetAllPeople() ?? new DataTable();
      
     // cbFilterBy.Enabled =
    }

    private bool _HandleEmptyTable()
    {
      if(_dtAllPlayers.Rows.Count > 0)
      {
        _dtPlayers.DefaultView.ToTable(false, "PlayerID",
          "PersonID", "FirstName", "LastName", "PhoneNumber", "HasMemberShip");
        return true;
      }
      else
      {
        _dtPlayers.Clear();
        _Reset();
      }
        return false;
    }

   

    private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnSearch.Visible = (cbFilterBy.SelectedIndex != 0);
        txtFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);

    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
