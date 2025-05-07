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
    private clsPerson _Person;

    // in case there is no data in the database.
    private static DataTable _dtAllPlayers = clsPerson.GetAllPeople() ?? new DataTable();
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
      txtbSearch.Visible = false;
    }

    private void _RefreshPlayersList()
    {
      _dtPlayers = clsPerson.GetAllPeople() ?? new DataTable();
      
     // cbFilterBy.Enabled =
    }

    private bool _HandleEmptyTable()
    {
      if(_dtAllPlayers.Rows.Count > 0)
      {
        //_dtPlayers.DefaultView.ToTable(false,)
      }
      return false;
    }

    private void txtbSearch_TextChanged(object sender, EventArgs e)
    {

    }

    private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {

        btnSearch.Visible = (cbFilterBy.SelectedIndex != 0);
        txtbSearch.Visible = (cbFilterBy.SelectedIndex != 0);

    }
  }
}
