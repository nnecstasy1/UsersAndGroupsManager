namespace UsersAndGroupsManager
{
    public partial class Form1 : Form
    {
        private List<User> usersList;
        private readonly IServiceProvider serviceProvider;
        UserBL userBL;
        UserGroupsBL userGroupsBL;
        ClientGroupBL clientGroupBL;
        List<UserGroups> assigned;
        List<UserGroups> unassigned;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeUpdateUserControlComponents();
            this.serviceProvider = serviceProvider;
        }

        private void InitializeUpdateUserControlComponents()
        {
            ucUserHeader.UpdateLabel("Users");
            ucClientGroupHeader.UpdateLabel("Assign User to Client Group"); 
            ucAssigned.UpdateLabel("Assigned Client Groups");
            ucUnassigned.UpdateLabel("Unassigned Client Groups");

            ucUserGrid.GetGroupsForUserFunc = LoadAssignedAndUnassigedGroupsTask;
            ucAssignUnassign.btnAssignFunc = AssignUser;
            ucAssignUnassign.btnUnassignFunc = UnassignUser;
            filterContainer1.SearchFunc = SearchGroup;
        }
        public int LoadAssignedAndUnassigedGroupsTask(int userId)
        {
            Task.Run(() => GetAssignedAndUnassignedGroups(userId));
            return userId;
        }
        public void GetAssignedAndUnassignedGroups(int userId)
        {
            (assigned, unassigned) = userGroupsBL.GetAssignedUsersGroupsAsync(userId);
            ucAssigned.userGroups = new BindingList<UserGroups>(assigned);
            ucUnassigned.userGroups = new BindingList<UserGroups>(unassigned);

            UpdateListBoxItems();
        }

        private async Task FetchUsers()
        {
            usersList = await userBL.GetUsers();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            usersList = new List<User>();
            assigned = new List<UserGroups>();
            unassigned = new List<UserGroups>();

            userBL = new UserBL(serviceProvider);
            userGroupsBL = new UserGroupsBL(serviceProvider);
            clientGroupBL = new ClientGroupBL(serviceProvider);
            
            await FetchUsers();            
            ucUserGrid.UpdateUsersDataSource(usersList);
        }

        private async void AssignUser()
        {
            ucUnassigned.SelectedUserGroups();
            await clientGroupBL.AssignUserOrUnAssignToGroup(true, ucUserGrid.SelectedUserId, ucUnassigned.selectedUserGroupsList);
            LoadAssignedAndUnassigedGroupsTask(ucUserGrid.SelectedUserId);
        }

        private async void UnassignUser()
        {
            ucAssigned.SelectedUserGroups();
            await clientGroupBL.AssignUserOrUnAssignToGroup(false, ucUserGrid.SelectedUserId, ucAssigned.selectedUserGroupsList);
            LoadAssignedAndUnassigedGroupsTask(ucUserGrid.SelectedUserId);
        }

        private void SearchGroup(string groupName)
        {
            //should the search be an exact string match(=) or a contains(like)??
            ucAssigned.userGroups = new BindingList<UserGroups>(assigned.Where(x => x.Name == groupName).ToList());
            ucUnassigned.userGroups = new BindingList<UserGroups>(unassigned.Where(x => x.Name == groupName).ToList());

            UpdateListBoxItems();
        }

        private void UpdateListBoxItems()
        {
            ucAssigned.ManageListBoxItems();
            ucUnassigned.ManageListBoxItems();
        }
    }
}