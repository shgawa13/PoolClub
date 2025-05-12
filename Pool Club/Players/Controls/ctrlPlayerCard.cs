using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Pool_Club
{
  public partial class ctrlPlayerCard : UserControl
  {
    private int _PlayerID =-1;
    private clsPlayer _Player;
    private clsSubscription _Subscription;

    public ctrlPlayerCard()
    {
      InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      base.OnPaint(pe);
    }

    private void ctrlPlayerCard_Load(object sender, EventArgs e)
    {

    }

    public void LoadPlayerData(int PlayerID)
    {
      _Player = clsPlayer.Find(PlayerID);

      if(_Player == null)
      {
        MessageBox.Show($"Couldn't find Player ID: {PlayerID}");
        return;
      }

      _LoadData();
    }

    public void LoadPlayerData(string PhoneNumber)
    {

    }


    private void _LoadData()
    {
      lblPlayerID.Text = _Player.PlayerID.ToString();
      lblFullName.Text = _Player.PlayerInfo.FullName;
      lblPhone.Text = _Player.PlayerInfo.PhoneNumber;
      lblHasSubscription.Text = (_Player.HasMemberShip)? "Yes":"No";



    }

    private void _LoadSubscriptionData()
    {
      _Subscription = clsSubscription.Find(_PlayerID);
      if (_Subscription == null) { }
    }

  }
}
