using ServiceAccessBL;
using System.ComponentModel;

namespace UsersAndGroupsManager.Controls
{
    public partial class ClientGroup : UserControl
    {
        public List<UserGroups> selectedUserGroupsList{get; private set;}

        public BindingList<UserGroups> userGroups = new BindingList<UserGroups>();
        public ClientGroup()
        {
            InitializeComponent();
        }

        public void SelectedUserGroups()
        {
            selectedUserGroupsList = new List<UserGroups>();
            foreach (var item in lstGroups.SelectedItems)
            {
                selectedUserGroupsList.Add(item as UserGroups);
            }
        }

        private void ClientGroup_Load(object sender, EventArgs e)
        {
            lstGroups.DisplayMember = nameof(UserGroups.Name);
            lstGroups.ValueMember = nameof(UserGroups.Id);
        }

        public void ManageListBoxItems()
        {
            lstGroups.Invoke(new MethodInvoker(delegate 
            {
                lstGroups.DataSource = userGroups;
                lstGroups.ClearSelected();
            }));
        }

        internal void UpdateLabel(string listBoxTitle)
        {
            lblListBoxHeaderPlaceHolder.Text = listBoxTitle;
        }
    }
}
