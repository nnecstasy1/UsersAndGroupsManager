using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndGroupsManager.Controls
{
    public partial class AssignOrUnassign : UserControl
    {
        public AssignOrUnassign()
        {
            InitializeComponent();
        }

        public Action btnAssignFunc { get; set; }
        public Action btnUnassignFunc { get; set; }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            btnAssignFunc.Invoke();
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            btnUnassignFunc.Invoke();
        }
    }
}
