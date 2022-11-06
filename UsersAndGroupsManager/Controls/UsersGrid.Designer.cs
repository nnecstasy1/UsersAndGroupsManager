namespace UsersAndGroupsManager.Controls
{
    partial class UsersGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.AllowUserToDeleteRows = false;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUsers.Location = new System.Drawing.Point(0, 0);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowHeadersWidth = 51;
            this.grdUsers.RowTemplate.Height = 29;
            this.grdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsers.Size = new System.Drawing.Size(150, 150);
            this.grdUsers.TabIndex = 0;
            // 
            // UsersGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grdUsers);
            this.Name = "UsersGrid";
            this.Load += new System.EventHandler(this.UsersGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdUsers;
    }
}
