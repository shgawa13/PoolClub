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
  public partial class Form1 : Form
  {
    public bool IsOpened = true;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      HandleLayout();
    }

    private void HandleLayout()
    {
      if (IsOpened)
        pnlMenu.Width = 100;
      else
        pnlMenu.Width = 200;

      IsOpened = !IsOpened;

    }

    private void button2_Click(object sender, EventArgs e)
    {
      SwitshLayout();
    }
    private void SwitshLayout()
    {
      this.RightToLeft = RightToLeft.Yes;
    }

    
  }
}
