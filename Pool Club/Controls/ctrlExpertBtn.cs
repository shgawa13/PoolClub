﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pool_Club.Controls
{
  public partial class ctrlExpertBtn : Button
  {

    //Fields
    private int borderSize = 0;
    private int borderRadius = 10;
    private Color borderColor = Color.PaleVioletRed;
    private bool isChanging = false; // Flag to prevent infinite loop

    //Properties
    [Category("Expert Btn")]
    public int BorderSize
    {
      get { return borderSize; }
      set
      {
        if (borderSize != value) // Check if the value has actually changed
        {
          borderSize = value;
          if (!isChanging) // Avoid calling Invalidate if it's already in progress
          {
            isChanging = true;
            this.Invalidate();
            isChanging = false;
          }
        }
      }
    }

    [Category("Expert Btn")]
    public int BorderRadius
    {
      get { return borderRadius; }
      set
      {
        if (borderRadius != value)
        {
          borderRadius = value;
          if (!isChanging)
          {
            isChanging = true;
            this.Invalidate();
            isChanging = false;
          }
        }
      }
    }

    [Category("Expert Btn")]
    public Color BorderColor
    {
      get { return borderColor; }
      set
      {
        if (borderColor != value)
        {
          borderColor = value;
          if (!isChanging)
          {
            isChanging = true;
            this.Invalidate();
            isChanging = false;
          }
        }
      }
    }
    [Category("Expert Btn")]
    public Color BackgroundColor
    {
      get { return this.BackColor; }
      set { this.BackColor = value; }
    }

    [Category("Expert Btn")]
    public Color TextColor
    {
      get { return this.ForeColor; }
      set { this.ForeColor = value; }
    }

    //Constructor
    public ctrlExpertBtn()
    {
      InitializeComponent();
      this.FlatStyle = FlatStyle.Flat;
      this.FlatAppearance.BorderSize = 0;
      this.Size = new Size(150, 40);
      this.BackColor = Color.MediumSlateBlue;
      this.ForeColor = Color.White;
      this.Resize += new EventHandler(Button_Resize);
    }
   

    private void Button_Resize(object sender, EventArgs e)
    {
      if (borderRadius > this.Height)
        borderRadius = this.Height;
    }

    //Methods
    private GraphicsPath GetFigurePath(Rectangle rect, float radius)
    {
      GraphicsPath path = new GraphicsPath();
      float curveSize = radius * 2F;

      path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
      path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
      path.CloseFigure();
      return path;
    }
    
    protected override void OnPaint(PaintEventArgs pevent)
    {
     
      base.OnPaint(pevent);

      Rectangle rectSurface = this.ClientRectangle;
      Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
      int smoothSize = 2;
      if (borderSize > 0)
        smoothSize = borderSize;

      if (borderRadius > 2) //Rounded button
      {
        using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
        using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(borderColor, borderSize))
        {
          pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
          //Button surface
          this.Region = new Region(pathSurface);
          //Draw surface border for HD result
          pevent.Graphics.DrawPath(penSurface, pathSurface);

          //Button border                    
          if (borderSize >= 1)
            //Draw control border
            pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
      }
      else //Normal button
      {
        pevent.Graphics.SmoothingMode = SmoothingMode.None;
        //Button surface
        this.Region = new Region(rectSurface);
        //Button border
        if (borderSize >= 1)
        {
          using (Pen penBorder = new Pen(borderColor, borderSize))
          {
            penBorder.Alignment = PenAlignment.Inset;
            pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
          }
        }
      }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
      base.OnHandleCreated(e);
      if (this.Parent != null)
      {
        this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
      }
    }

    // Also need to handle when the control is added to a parent later
    protected override void OnParentChanged(EventArgs e)
    {
      base.OnParentChanged(e);
      if (this.Parent != null)
      {
        this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
      }

    }

    private void Container_BackColorChanged(object sender, EventArgs e)
    {
      this.Invalidate();
    }
  }
}
