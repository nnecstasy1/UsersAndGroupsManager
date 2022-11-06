namespace UsersAndGroupsManager.Controls
{
    partial class AssignOrUnassign
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.Location = new System.Drawing.Point(53, 29);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(48, 61);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "<";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnassign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnassign.Location = new System.Drawing.Point(53, 96);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(48, 39);
            this.btnUnassign.TabIndex = 1;
            this.btnUnassign.Text = ">";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.btnAssign, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUnassign, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AssignOrUnassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssignOrUnassign";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAssign;
        private Button btnUnassign;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
