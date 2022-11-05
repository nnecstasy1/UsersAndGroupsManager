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
        }
        public int LoadAssignedAndUnassigedGroupsTask(int userId)
        {
            Task.Run(() => GetAssignedAndUnassignedGroups(userId));
            return userId;
        }
        public async void GetAssignedAndUnassignedGroups(int userId)
        {
            (assigned, unassigned) = userGroupsBL.GetAssignedUsersGroupsAsync(userId);
            ucAssigned.userGroups = new BindingList<UserGroups>(assigned);
            ucUnassigned.userGroups = new BindingList<UserGroups>(unassigned);

            ucAssigned.ManageListBoxItems();
            ucUnassigned.ManageListBoxItems();
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
            await FetchUsers();

            userGroupsBL = new UserGroupsBL(serviceProvider);
            ucUserGrid.UpdateUsersGrid(usersList);

            clientGroupBL = new ClientGroupBL(serviceProvider);
        }
        private void AssignUser()
        {
            ucUnassigned.SelectedUserGroups();
            clientGroupBL.AssignUserOrUnAssignToGroup(true, ucUserGrid.SelectedUserId, ucUnassigned.selectedUserGroupsList);
            LoadAssignedAndUnassigedGroupsTask(ucUserGrid.SelectedUserId);
        }

        private void UnassignUser()
        {
            ucAssigned.SelectedUserGroups();
            clientGroupBL.AssignUserOrUnAssignToGroup(false, ucUserGrid.SelectedUserId, ucAssigned.selectedUserGroupsList);
            LoadAssignedAndUnassigedGroupsTask(ucUserGrid.SelectedUserId);
        }

        
    }
}