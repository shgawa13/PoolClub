using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Pool_Club
{
  public partial class Form1 : Form
  {//Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;

    private bool IsOpened = true;
    public Form1()
    {
      InitializeComponent();
      leftBorderBtn = new Panel();
      leftBorderBtn.Size = new Size(7, 60);
      pnlMenu.Controls.Add(leftBorderBtn);

      //Form
      this.Text = string.Empty;
      //this.ControlBox = false;
     // this.DoubleBuffered = true;
      this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }


    //Structs
    private struct RGBColors
    {
      public static readonly Color color1 = Color.FromArgb(172, 126, 241);
      public static readonly Color color2 = Color.FromArgb(249, 118, 176);
      public static readonly Color color3 = Color.FromArgb(253, 138, 114);
      public static readonly Color color4 = Color.FromArgb(95, 77, 221);
      public static readonly Color color5 = Color.FromArgb(249, 88, 155);
      public static readonly Color color6 = Color.FromArgb(217, 3, 104);
    }
    //Methods
    private void ActivateButton(object senderBtn, Color color)
    {
      if (senderBtn != null)
      {
        DisableButton();
        //Button
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(37, 36, 81);
        currentBtn.ForeColor = color;
        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        currentBtn.IconColor = color;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        //Left border button
        leftBorderBtn.BackColor = color;
        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        leftBorderBtn.Visible = true;
        leftBorderBtn.BringToFront();
        //Current Child Form Icon
        iconCurrentChild.IconChar = currentBtn.IconChar;
        iconCurrentChild.IconColor = color;
      }
    }
    private void DisableButton()
    {
      if (currentBtn != null)
      {
        currentBtn.BackColor = Color.FromArgb(34, 35, 48);
        currentBtn.ForeColor = Color.WhiteSmoke;
        currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        currentBtn.IconColor = Color.WhiteSmoke;
        currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
      }
    }
    private void OpenChildForm(Form childForm)
    {
      //open only form
      if (currentChildForm != null)
      {
        currentChildForm.Close();
        currentChildForm.Dispose();
      }
      currentChildForm = childForm;
      //End
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      //panelDesktop.Controls.Add(childForm);
      //childForm.Size = panelDesktop.Size;
      //panelDesktop.Tag = childForm;
      //childForm.BringToFront();
      //childForm.Show();
      //lblTitleChild.Text = childForm.Text;
    }

    //Events
    //Reset


    private void button1_Click(object sender, EventArgs e)
    {
      HandleLayout();
      ShowAndHideAllText();
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

    private List<IconButton> ListIcons()
    {
      return new List<IconButton>
      {
        btnNewGame,btnTables,btnPlayers,btnVip,btnSettings,btnLogout
      };
    }

    private void ShowAndHideAllText()
    {
     
      foreach (var btn in ListIcons())
      {
        if (!IsOpened)
        {
          btn.Text = string.Empty;
          btn.ImageAlign = ContentAlignment.MiddleCenter;
          btn.IconSize = 43;

        }
        else
        {
          btn.Text = btn.Tag.ToString();
          btn.IconSize = 32;
        }
      }
    }

    private void btnHideText_Click(object sender, EventArgs e)
    {
      //ShowAndHideAllText();
    }

    private void btnNewGame_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color1);
    }

    private void btnTables_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color2);
    }

    private void btnVip_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color3);
    }

    private void btnPlayers_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color4);
    }
  }
}
