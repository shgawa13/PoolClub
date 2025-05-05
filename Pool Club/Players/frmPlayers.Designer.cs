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
      this.txtbSearch = new System.Windows.Forms.TextBox();
      this.panelDown = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.dgvPlayers = new System.Windows.Forms.DataGridView();
      this.btnAddPlayer = new Pool_Club.Controls.ctrlExpertBtn();
      this.ctrlExpertBtn1 = new Pool_Club.Controls.ctrlExpertBtn();
      this.ctxmPlayers = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.panelDown.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
      this.ctxmPlayers.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panel1.Controls.Add(this.btnAddPlayer);
      this.panel1.Controls.Add(this.ctrlExpertBtn1);
      this.panel1.Controls.Add(this.txtbSearch);
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
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.GhostWhite;
      this.label1.Location = new System.Drawing.Point(7, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Find By:";
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
      this.cbFindBy.SelectedIndexChanged += new System.EventHandler(this.cbFindBy_SelectedIndexChanged);
      // 
      // txtbSearch
      // 
      this.txtbSearch.BackColor = System.Drawing.SystemColors.ControlLight;
      this.txtbSearch.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtbSearch.Location = new System.Drawing.Point(239, 11);
      this.txtbSearch.Name = "txtbSearch";
      this.txtbSearch.Size = new System.Drawing.Size(167, 32);
      this.txtbSearch.TabIndex = 2;
      this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
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
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.GhostWhite;
      this.label2.Location = new System.Drawing.Point(12, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Players :";
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblPlayersNumber.Location = new System.Drawing.Point(100, 15);
      this.lblPlayersNumber.Name = "lblPlayersNumber";
      this.lblPlayersNumber.Size = new System.Drawing.Size(36, 25);
      this.lblPlayersNumber.TabIndex = 1;
      this.lblPlayersNumber.Text = "???";
      // 
      // dgvPlayers
      // 
      this.dgvPlayers.AllowUserToAddRows = false;
      this.dgvPlayers.AllowUserToDeleteRows = false;
      this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvPlayers.Location = new System.Drawing.Point(0, 55);
      this.dgvPlayers.Name = "dgvPlayers";
      this.dgvPlayers.ReadOnly = true;
      this.dgvPlayers.Size = new System.Drawing.Size(800, 340);
      this.dgvPlayers.TabIndex = 4;
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
      // ctxmPlayers
      // 
      this.ctxmPlayers.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctxmPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
      this.ctxmPlayers.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
      this.ctxmPlayers.Name = "ctxmPlayers";
      this.ctxmPlayers.Size = new System.Drawing.Size(181, 168);
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.addToolStripMenuItem.Text = "Membership";
      // 
      // updateToolStripMenuItem
      // 
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.updateToolStripMenuItem.Text = "Update";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
      // 
      // showInfoToolStripMenuItem
      // 
      this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
      this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.showInfoToolStripMenuItem.Text = "Show Info";
      // 
      // statusToolStripMenuItem
      // 
      this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
      this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.statusToolStripMenuItem.Text = "Status";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.deleteToolStripMenuItem.Text = "Delete";
      // 
      // frmPlayers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dgvPlayers);
      this.Controls.Add(this.panelDown);
      this.Controls.Add(this.panel1);
      this.Name = "frmPlayers";
      this.Text = "Players";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
      this.ctxmPlayers.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtbSearch;
    private System.Windows.Forms.ComboBox cbFindBy;
    private System.Windows.Forms.Label lblPlayersNumber;
    private Controls.ctrlExpertBtn ctrlExpertBtn1;
    private System.Windows.Forms.DataGridView dgvPlayers;
    private Controls.ctrlExpertBtn btnAddPlayer;
    private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx ctxmPlayers;
    private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
  }
}