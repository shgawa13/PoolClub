using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club
{
  public partial class PoolTable : UserControl
  {
    

    public PoolTable()
    {
      InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      base.OnPaint(pe);
    }


    // Table Event
    public class PoolTableEvent : EventArgs
    {
      public string TimeText { get; }
      public int TimeInSeconds { get; }
      public float TotolFees { get; }
      public float RatePerHour { get; } 
    }


  }
}
