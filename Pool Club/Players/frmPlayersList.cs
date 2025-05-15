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
  public partial class frmPlayersList : Form
  {
    private clsPlayer _Player;

    // in case there is no data in the database.
    private static DataTable _dtAllPlayers = clsPlayer.GetAllPeople() ?? new DataTable();
    private DataTable _dtPlayers = _dtAllPlayers.Clone();

    public frmPlayersList()
    {
      InitializeComponent();
    }

    private void frmPlayersList_Load(object sender, EventArgs e)
    {
      _ResetPlayersList();
    


    }


    private void _ResetPlayersList()
    {
      _dtPlayers = clsPlayer.GetAllPlayers() ?? new DataTable();

      // we check if the table is empty or not
      cbFilterBy.SelectedIndex = 0;

      // Hide or Show Controls
      txtFilterValue.Visible = _HandleEmptyTable();
      btnSearch.Visible = txtFilterValue.Visible;
      lblPlayersDataTable.Visible = !txtFilterValue.Visible;


      dgvPlayers.DataSource = _dtPlayers;
      lblPlayersNumber.Text = dgvPlayers.RowCount.ToString();
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
        ctmsPlayers.Enabled = false;
        
      }
        return false;
    }

   

    private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {
      btnSearch.Visible = (cbFilterBy.SelectedIndex != 0);
      txtFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);

      if (txtFilterValue.Visible)
      {
        txtFilterValue.Text = string.Empty;
        txtFilterValue.Focus();
      }

    }

    private void txtFilterValue_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      frmAddUpdatePlayer frm = new frmAddUpdatePlayer();
      frm.ShowDialog();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {

    }
  }
}
