namespace UsersAndGroupsManager.Controls
{
    partial class ClientGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.lblListBoxHeaderPlaceHolder = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroups
            // 
            this.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.ItemHeight = 20;
            this.lstGroups.Location = new System.Drawing.Point(3, 30);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGroups.Size = new System.Drawing.Size(144, 117);
            this.lstGroups.TabIndex = 0;
            // 
            // lblListBoxHeaderPlaceHolder
            // 
            this.lblListBoxHeaderPlaceHolder.AutoSize = true;
            this.lblListBoxHeaderPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListBoxHeaderPlaceHolder.Location = new System.Drawing.Point(3, 0);
            this.lblListBoxHeaderPlaceHolder.Name = "lblListBoxHeaderPlaceHolder";
            this.lblListBoxHeaderPlaceHolder.Size = new System.Drawing.Size(144, 27);
            this.lblListBoxHeaderPlaceHolder.TabIndex = 1;
            this.lblListBoxHeaderPlaceHolder.Text = "lblListBoxHeader";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblListBoxHeaderPlaceHolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstGroups, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ClientGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientGroup";
            this.Load += new System.EventHandler(this.ClientGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstGroups;
        private Label lblListBoxHeaderPlaceHolder;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
