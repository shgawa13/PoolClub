namespace Pool_Club
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pnlDashBoard = new System.Windows.Forms.Panel();
      this.pnlLogo = new System.Windows.Forms.Panel();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.pnlDashBoard.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlDashBoard
      // 
      this.pnlDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.pnlDashBoard.Controls.Add(this.pnlLogo);
      this.pnlDashBoard.Controls.Add(this.button2);
      this.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlDashBoard.Location = new System.Drawing.Point(0, 0);
      this.pnlDashBoard.MaximumSize = new System.Drawing.Size(200, 0);
      this.pnlDashBoard.Name = "pnlDashBoard";
      this.pnlDashBoard.Size = new System.Drawing.Size(200, 584);
      this.pnlDashBoard.TabIndex = 0;
      // 
      // pnlLogo
      // 
      this.pnlLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
      this.pnlLogo.BackgroundImage = global::Pool_Club.Properties.Resources.gzexperts_logo;
      this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlLogo.Location = new System.Drawing.Point(0, 0);
      this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
      this.pnlLogo.Name = "pnlLogo";
      this.pnlLogo.Size = new System.Drawing.Size(200, 94);
      this.pnlLogo.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.flowLayoutPanel1.Controls.Add(this.button1);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 69);
      this.flowLayoutPanel1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(91, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Black;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(200, 69);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(777, 2);
      this.panel1.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Black;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(200, 71);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(2, 513);
      this.panel2.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(45, 130);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(94, 30);
      this.button2.TabIndex = 1;
      this.button2.Tag = "0";
      this.button2.Text = "English";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(977, 584);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.pnlDashBoard);
      this.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.MinimumSize = new System.Drawing.Size(993, 623);
      this.Name = "Form1";
      this.RightToLeftLayout = true;
      this.Text = "Form1";
      this.pnlDashBoard.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDashBoard;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel pnlLogo;
    private System.Windows.Forms.Button button2;
  }
}

