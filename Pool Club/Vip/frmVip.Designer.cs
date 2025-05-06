namespace Pool_Club.Vip
{
  partial class frmVip
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
      this.label1 = new System.Windows.Forms.Label();
      this.ctxmVip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
      this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAddPlayer = new Pool_Club.Controls.ctrlExpertBtn();
      this.ctrlExpertBtn1 = new Pool_Club.Controls.ctrlExpertBtn();
      this.txtbSearch = new System.Windows.Forms.TextBox();
      this.cbFindBy = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panelDown = new System.Windows.Forms.Panel();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.ctxmVip.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panelDown.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(323, 200);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "VIP Form";
      // 
      // ctxmVip
      // 
      this.ctxmVip.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctxmVip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
      this.ctxmVip.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
      this.ctxmVip.Name = "ctxmPlayers";
      this.ctxmVip.Size = new System.Drawing.Size(177, 146);
      // 
      // showInfoToolStripMenuItem
      // 
      this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
      this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
      this.showInfoToolStripMenuItem.Text = "Show Info";
      // 
      // updateToolStripMenuItem
      // 
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      this.updateToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
      this.updateToolStripMenuItem.Text = "Update";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
      this.addToolStripMenuItem.Text = "Membership";
      // 
      // statusToolStripMenuItem
      // 
      this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
      this.statusToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
      this.statusToolStripMenuItem.Text = "Status";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
      this.deleteToolStripMenuItem.Text = "Delete";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panel1.Controls.Add(this.btnAddPlayer);
      this.panel1.Controls.Add(this.ctrlExpertBtn1);
      this.panel1.Controls.Add(this.txtbSearch);
      this.panel1.Controls.Add(this.cbFindBy);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 55);
      this.panel1.TabIndex = 2;
      // 
      // btnAddPlayer
      // 
      this.btnAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnAddPlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnAddPlayer.BorderColor = System.Drawing.Color.Gainsboro;
      this.btnAddPlayer.BorderRadius = 5;
      this.btnAddPlayer.BorderSize = 0;
      this.btnAddPlayer.FlatAppearance.BorderSize = 0;
      this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddPlayer.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddPlayer.ForeColor = System.Drawing.Color.Azure;
      this.btnAddPlayer.Location = new System.Drawing.Point(684, 5);
      this.btnAddPlayer.Name = "btnAddPlayer";
      this.btnAddPlayer.Size = new System.Drawing.Size(104, 44);
      this.btnAddPlayer.TabIndex = 4;
      this.btnAddPlayer.Text = "Add New";
      this.btnAddPlayer.TextColor = System.Drawing.Color.Azure;
      this.btnAddPlayer.UseVisualStyleBackColor = false;
      // 
      // ctrlExpertBtn1
      // 
      this.ctrlExpertBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.ctrlExpertBtn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.ctrlExpertBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.ctrlExpertBtn1.BorderRadius = 5;
      this.ctrlExpertBtn1.BorderSize = 0;
      this.ctrlExpertBtn1.FlatAppearance.BorderSize = 0;
      this.ctrlExpertBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ctrlExpertBtn1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctrlExpertBtn1.ForeColor = System.Drawing.Color.Azure;
      this.ctrlExpertBtn1.Location = new System.Drawing.Point(418, 10);
      this.ctrlExpertBtn1.Name = "ctrlExpertBtn1";
      this.ctrlExpertBtn1.Size = new System.Drawing.Size(94, 34);
      this.ctrlExpertBtn1.TabIndex = 3;
      this.ctrlExpertBtn1.Text = "Search";
      this.ctrlExpertBtn1.TextColor = System.Drawing.Color.Azure;
      this.ctrlExpertBtn1.UseVisualStyleBackColor = false;
      // 
      // txtbSearch
      // 
      this.txtbSearch.BackColor = System.Drawing.SystemColors.ControlLight;
      this.txtbSearch.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbSearch.Location = new System.Drawing.Point(239, 11);
      this.txtbSearch.Name = "txtbSearch";
      this.txtbSearch.Size = new System.Drawing.Size(167, 32);
      this.txtbSearch.TabIndex = 2;
      // 
      // cbFindBy
      // 
      this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFindBy.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbFindBy.FormattingEnabled = true;
      this.cbFindBy.Items.AddRange(new object[] {
            "Player ID",
            "Phone Number"});
      this.cbFindBy.Location = new System.Drawing.Point(95, 11);
      this.cbFindBy.Name = "cbFindBy";
      this.cbFindBy.Size = new System.Drawing.Size(132, 33);
      this.cbFindBy.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.GhostWhite;
      this.label2.Location = new System.Drawing.Point(7, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Find By:";
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panelDown.Controls.Add(this.lblPlayersNumber);
      this.panelDown.Controls.Add(this.label3);
      this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelDown.Location = new System.Drawing.Point(0, 395);
      this.panelDown.Name = "panelDown";
      this.panelDown.Size = new System.Drawing.Size(800, 55);
      this.panelDown.TabIndex = 4;
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblPlayersNumber.Location = new System.Drawing.Point(79, 15);
      this.lblPlayersNumber.Name = "lblPlayersNumber";
      this.lblPlayersNumber.Size = new System.Drawing.Size(36, 25);
      this.lblPlayersNumber.TabIndex = 1;
      this.lblPlayersNumber.Text = "???";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.GhostWhite;
      this.label3.Location = new System.Drawing.Point(12, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 25);
      this.label3.TabIndex = 0;
      this.label3.Text = "VIPs :";
      // 
      // frmVip
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panelDown);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Name = "frmVip";
      this.Text = "Vip";
      this.ctxmVip.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx ctxmVip;
    private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private Controls.ctrlExpertBtn btnAddPlayer;
    private Controls.ctrlExpertBtn ctrlExpertBtn1;
    private System.Windows.Forms.TextBox txtbSearch;
    private System.Windows.Forms.ComboBox cbFindBy;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label lblPlayersNumber;
    private System.Windows.Forms.Label label3;
  }
}