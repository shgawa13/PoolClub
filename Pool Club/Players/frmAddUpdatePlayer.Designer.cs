namespace Pool_Club.Players
{
  partial class frmAddUpdatePlayer
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelDown = new System.Windows.Forms.Panel();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelDown.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblTitle.Location = new System.Drawing.Point(374, 141);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(94, 25);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Add New";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Pool_Club.Properties.Resources.Players;
      this.pictureBox1.Location = new System.Drawing.Point(320, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(195, 125);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panelDown.Controls.Add(this.pictureBox1);
      this.panelDown.Controls.Add(this.lblTitle);
      this.panelDown.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelDown.Location = new System.Drawing.Point(0, 0);
      this.panelDown.Name = "panelDown";
      this.panelDown.Size = new System.Drawing.Size(800, 174);
      this.panelDown.TabIndex = 4;
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblPlayersNumber.Location = new System.Drawing.Point(95, 266);
      this.lblPlayersNumber.Name = "lblPlayersNumber";
      this.lblPlayersNumber.Size = new System.Drawing.Size(36, 25);
      this.lblPlayersNumber.TabIndex = 1;
      this.lblPlayersNumber.Text = "???";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.GhostWhite;
      this.label2.Location = new System.Drawing.Point(12, 265);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Players :";
      // 
      // frmAddUpdatePlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panelDown);
      this.Controls.Add(this.lblPlayersNumber);
      this.Controls.Add(this.label2);
      this.Name = "frmAddUpdatePlayer";
      this.Text = "Add New Player";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label lblPlayersNumber;
    private System.Windows.Forms.Label label2;
  }
}