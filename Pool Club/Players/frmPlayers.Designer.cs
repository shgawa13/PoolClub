namespace Pool_Club.Players
{
  partial class frmPlayers
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.cbFindBy = new System.Windows.Forms.ComboBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panelDown = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panelDown.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.cbFindBy);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 55);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Gainsboro;
      this.label1.Location = new System.Drawing.Point(7, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Find By:";
      // 
      // cbFindBy
      // 
      this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFindBy.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbFindBy.FormattingEnabled = true;
      this.cbFindBy.Items.AddRange(new object[] {
            "Player ID",
            "Phone Number"});
      this.cbFindBy.Location = new System.Drawing.Point(101, 12);
      this.cbFindBy.Name = "cbFindBy";
      this.cbFindBy.Size = new System.Drawing.Size(161, 29);
      this.cbFindBy.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(276, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(167, 34);
      this.textBox1.TabIndex = 2;
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
      this.panelDown.Controls.Add(this.lblPlayersNumber);
      this.panelDown.Controls.Add(this.label2);
      this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelDown.Location = new System.Drawing.Point(0, 395);
      this.panelDown.Name = "panelDown";
      this.panelDown.Size = new System.Drawing.Size(800, 55);
      this.panelDown.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Gainsboro;
      this.label2.Location = new System.Drawing.Point(12, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Players :";
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.Gainsboro;
      this.lblPlayersNumber.Location = new System.Drawing.Point(100, 15);
      this.lblPlayersNumber.Name = "lblPlayersNumber";
      this.lblPlayersNumber.Size = new System.Drawing.Size(36, 25);
      this.lblPlayersNumber.TabIndex = 1;
      this.lblPlayersNumber.Text = "???";
      // 
      // frmPlayers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panelDown);
      this.Controls.Add(this.panel1);
      this.Name = "frmPlayers";
      this.Text = "Players";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ComboBox cbFindBy;
    private System.Windows.Forms.Label lblPlayersNumber;
  }
}