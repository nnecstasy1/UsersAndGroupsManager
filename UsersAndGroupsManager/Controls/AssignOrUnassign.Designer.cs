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
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.Location = new System.Drawing.Point(0, 0);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(150, 29);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "<";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnassign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnassign.Location = new System.Drawing.Point(0, 29);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(150, 29);
            this.btnUnassign.TabIndex = 1;
            this.btnUnassign.Text = ">";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // AssignOrUnassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnAssign);
            this.Name = "AssignOrUnassign";
            this.Load += new System.EventHandler(this.AssignOrUnassign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAssign;
        private Button btnUnassign;
    }
}
