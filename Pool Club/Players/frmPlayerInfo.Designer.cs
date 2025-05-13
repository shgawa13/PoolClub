namespace Pool_Club.Players
{
  partial class frmPlayerInfo
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
      this.ctrlPlayerCard1 = new Pool_Club.ctrlPlayerCard();
      this.SuspendLayout();
      // 
      // ctrlPlayerCard1
      // 
      this.ctrlPlayerCard1.BackColor = System.Drawing.SystemColors.Control;
      this.ctrlPlayerCard1.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctrlPlayerCard1.Location = new System.Drawing.Point(0, 0);
      this.ctrlPlayerCard1.Name = "ctrlPlayerCard1";
      this.ctrlPlayerCard1.Size = new System.Drawing.Size(955, 271);
      this.ctrlPlayerCard1.TabIndex = 0;
      // 
      // frmPlayerInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(955, 271);
      this.Controls.Add(this.ctrlPlayerCard1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPlayerInfo";
      this.Text = "Player Information";
      this.Load += new System.EventHandler(this.frmPlayerInfo_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private ctrlPlayerCard ctrlPlayerCard1;
  }
}