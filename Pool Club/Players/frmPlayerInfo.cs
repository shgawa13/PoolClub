using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club.Players
{
  public partial class frmPlayerInfo : Form
  {
    private int _PlayerID;

    public frmPlayerInfo(int ID)
    {
      InitializeComponent();
      _PlayerID = ID;
    }

    private void frmPlayerInfo_Load(object sender, EventArgs e)
    {
      ctrlPlayerCard1.LoadPlayerData(_PlayerID);
    }
  }
}
