namespace UsersAndGroupsManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.SplitContainer();
            this.ucUserGrid = new UsersAndGroupsManager.Controls.UsersGrid();
            this.ucUserHeader = new UsersAndGroupsManager.Controls.Header();
            this.tabClientGroups = new System.Windows.Forms.TabControl();
            this.tbClientGroup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucUnassigned = new UsersAndGroupsManager.Controls.ClientGroup();
            this.ucAssigned = new UsersAndGroupsManager.Controls.ClientGroup();
            this.ucAssignUnassign = new UsersAndGroupsManager.Controls.AssignOrUnassign();
            this.filterContainer1 = new UsersAndGroupsManager.Controls.FilterContainer();
            this.ucClientGroupHeader = new UsersAndGroupsManager.Controls.Header();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabClientGroups.SuspendLayout();
            this.tbClientGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnlMain.Panel1
            // 
            this.pnlMain.Panel1.Controls.Add(this.ucUserGrid);
            this.pnlMain.Panel1.Controls.Add(this.ucUserHeader);
            // 
            // pnlMain.Panel2
            // 
            this.pnlMain.Panel2.Controls.Add(this.tabClientGroups);
            this.pnlMain.Size = new System.Drawing.Size(819, 576);
            this.pnlMain.SplitterDistance = 340;
            this.pnlMain.TabIndex = 0;
            // 
            // ucUserGrid
            // 
            this.ucUserGrid.BackColor = System.Drawing.SystemColors.Control;
            this.ucUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserGrid.GetGroupsForUserFunc = null;
            this.ucUserGrid.Location = new System.Drawing.Point(0, 30);
            this.ucUserGrid.Name = "ucUserGrid";
            this.ucUserGrid.Size = new System.Drawing.Size(819, 310);
            this.ucUserGrid.TabIndex = 1;
            // 
            // ucUserHeader
            // 
            this.ucUserHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucUserHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.ucUserHeader.Location = new System.Drawing.Point(0, 0);
            this.ucUserHeader.Name = "ucUserHeader";
            this.ucUserHeader.Size = new System.Drawing.Size(819, 30);
            this.ucUserHeader.TabIndex = 0;
            // 
            // tabClientGroups
            // 
            this.tabClientGroups.Controls.Add(this.tbClientGroup);
            this.tabClientGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClientGroups.Location = new System.Drawing.Point(0, 0);
            this.tabClientGroups.Name = "tabClientGroups";
            this.tabClientGroups.SelectedIndex = 0;
            this.tabClientGroups.Size = new System.Drawing.Size(819, 232);
            this.tabClientGroups.TabIndex = 0;
            // 
            // tbClientGroup
            // 
            this.tbClientGroup.Controls.Add(this.tableLayoutPanel1);
            this.tbClientGroup.Controls.Add(this.filterContainer1);
            this.tbClientGroup.Controls.Add(this.ucClientGroupHeader);
            this.tbClientGroup.Location = new System.Drawing.Point(4, 29);
            this.tbClientGroup.Name = "tbClientGroup";
            this.tbClientGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tbClientGroup.Size = new System.Drawing.Size(811, 199);
            this.tbClientGroup.TabIndex = 0;
            this.tbClientGroup.Text = "Assign Client Groups";
            this.tbClientGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.08527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.91473F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel1.Controls.Add(this.ucUnassigned, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucAssigned, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucAssignUnassign, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 125);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ucUnassigned
            // 
            this.ucUnassigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUnassigned.Location = new System.Drawing.Point(490, 3);
            this.ucUnassigned.Name = "ucUnassigned";
            this.ucUnassigned.Size = new System.Drawing.Size(312, 119);
            this.ucUnassigned.TabIndex = 1;
            // 
            // ucAssigned
            // 
            this.ucAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssigned.Location = new System.Drawing.Point(3, 3);
            this.ucAssigned.Name = "ucAssigned";
            this.ucAssigned.Size = new System.Drawing.Size(316, 119);
            this.ucAssigned.TabIndex = 0;
            // 
            // ucAssignUnassign
            // 
            this.ucAssignUnassign.btnAssignFunc = null;
            this.ucAssignUnassign.btnUnassignFunc = null;
            this.ucAssignUnassign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssignUnassign.Location = new System.Drawing.Point(325, 3);
            this.ucAssignUnassign.Name = "ucAssignUnassign";
            this.ucAssignUnassign.Size = new System.Drawing.Size(159, 119);
            this.ucAssignUnassign.TabIndex = 2;
            // 
            // filterContainer1
            // 
            this.filterContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterContainer1.Location = new System.Drawing.Point(3, 33);
            this.filterContainer1.Name = "filterContainer1";
            this.filterContainer1.Size = new System.Drawing.Size(805, 38);
            this.filterContainer1.TabIndex = 1;
            // 
            // ucClientGroupHeader
            // 
            this.ucClientGroupHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucClientGroupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucClientGroupHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.ucClientGroupHeader.Location = new System.Drawing.Point(3, 3);
            this.ucClientGroupHeader.Name = "ucClientGroupHeader";
            this.ucClientGroupHeader.Size = new System.Drawing.Size(805, 30);
            this.ucClientGroupHeader.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 576);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Users And Groups Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabClientGroups.ResumeLayout(false);
            this.tbClientGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer pnlMain;
        private TabControl tabClientGroups;
        private TabPage tbClientGroup;
        private Controls.Header ucUserHeader;
        private Controls.UsersGrid ucUserGrid;
        private Controls.Header ucClientGroupHeader;
        private Controls.FilterContainer filterContainer1;
        private Controls.ClientGroup ucUnassigned;
        private Controls.ClientGroup ucAssigned;
        private Controls.AssignOrUnassign ucAssignUnassign;
        private TableLayoutPanel tableLayoutPanel1;
    }
}