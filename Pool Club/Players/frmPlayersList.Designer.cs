﻿namespace Pool_Club.Players
{
  partial class frmPlayersList
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
      this.btnAddPlayer = new Pool_Club.Controls.ctrlExpertBtn();
      this.btnSearch = new Pool_Club.Controls.ctrlExpertBtn();
      this.txtFilterValue = new System.Windows.Forms.TextBox();
      this.cbFilterBy = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panelDown = new System.Windows.Forms.Panel();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dgvPlayers = new System.Windows.Forms.DataGridView();
      this.ctxPlayers = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
      this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.panelDown.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
      this.ctxPlayers.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panel1.Controls.Add(this.btnAddPlayer);
      this.panel1.Controls.Add(this.btnSearch);
      this.panel1.Controls.Add(this.txtFilterValue);
      this.panel1.Controls.Add(this.cbFilterBy);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 55);
      this.panel1.TabIndex = 0;
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
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnSearch.BorderRadius = 5;
      this.btnSearch.BorderSize = 0;
      this.btnSearch.FlatAppearance.BorderSize = 0;
      this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSearch.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.ForeColor = System.Drawing.Color.Azure;
      this.btnSearch.Location = new System.Drawing.Point(446, 10);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(94, 34);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "Search";
      this.btnSearch.TextColor = System.Drawing.Color.Azure;
      this.btnSearch.UseVisualStyleBackColor = false;
      // 
      // txtFilterValue
      // 
      this.txtFilterValue.BackColor = System.Drawing.SystemColors.ControlLight;
      this.txtFilterValue.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFilterValue.Location = new System.Drawing.Point(269, 11);
      this.txtFilterValue.Name = "txtFilterValue";
      this.txtFilterValue.Size = new System.Drawing.Size(167, 32);
      this.txtFilterValue.TabIndex = 2;
      this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
      // 
      // cbFilterBy
      // 
      this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFilterBy.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbFilterBy.FormattingEnabled = true;
      this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Player ID",
            "Phone Number"});
      this.cbFilterBy.Location = new System.Drawing.Point(96, 11);
      this.cbFilterBy.Name = "cbFilterBy";
      this.cbFilterBy.Size = new System.Drawing.Size(162, 33);
      this.cbFilterBy.TabIndex = 1;
      this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
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
      // dgvPlayers
      // 
      this.dgvPlayers.AllowUserToAddRows = false;
      this.dgvPlayers.AllowUserToDeleteRows = false;
      this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPlayers.ContextMenuStrip = this.ctxPlayers;
      this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvPlayers.Location = new System.Drawing.Point(0, 55);
      this.dgvPlayers.Name = "dgvPlayers";
      this.dgvPlayers.ReadOnly = true;
      this.dgvPlayers.Size = new System.Drawing.Size(800, 340);
      this.dgvPlayers.TabIndex = 4;
      // 
      // ctxPlayers
      // 
      this.ctxPlayers.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctxPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
      this.ctxPlayers.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
      this.ctxPlayers.Name = "ctxPlayers";
      this.ctxPlayers.Size = new System.Drawing.Size(177, 146);
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
      this.ctxPlayers.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFilterValue;
    private System.Windows.Forms.ComboBox cbFilterBy;
    private System.Windows.Forms.Label lblPlayersNumber;
    private Controls.ctrlExpertBtn btnSearch;
    private System.Windows.Forms.DataGridView dgvPlayers;
    private Controls.ctrlExpertBtn btnAddPlayer;
    private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx ctxPlayers;
    private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
  }
}