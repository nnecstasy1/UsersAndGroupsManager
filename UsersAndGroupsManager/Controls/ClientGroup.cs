using ServiceAccessBL;
using System.ComponentModel;

namespace UsersAndGroupsManager.Controls
{
    public partial class ClientGroup : UserControl
    {
        public Func<int?> UpdateListDataFunc { get; internal set; }
        public BindingList<UserGroups> userGroups = new BindingList<UserGroups>();
        public ClientGroup()
        {
            InitializeComponent();
            UpdateListDataFunc = UpdateDisplayData;
        }

        private int? UpdateDisplayData(/*BindingList<UserGroups> arg*/)
        {
            userGroups.Clear();
            lstGroups.DataSource = null;
            lstGroups.DataSource = userGroups;
            lstGroups.DisplayMember = nameof(UserGroups.Name);
            lstGroups.ValueMember = nameof(UserGroups.Id);
            //userGroups = arg;
            //lstGroups.DataSource = userGroups;
            return null;
        }

        private void ClientGroup_Load(object sender, EventArgs e)
        {
            lstGroups.DisplayMember = nameof(UserGroups.Name);
            lstGroups.ValueMember = nameof(UserGroups.Id);
            lstGroups.DataSource = userGroups;
            userGroups.Add(new UserGroups() { Id = 1, Name = "mkanjdiujsdiuoeijise"});
            
        }
    }
}
