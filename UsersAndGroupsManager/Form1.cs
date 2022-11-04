using ServiceAccessBL;

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
            ucUserHeader.Controls["lblHeaderText"].Text = "Users";
            ucClientGroupHeader.Controls["lblHeaderText"].Text = "Assign User to Client Group";

            ucUserGrid.GetGroupsForUserFunc = InvocableLoadAssignedAndUnassigedGroups;
        }
        public int InvocableLoadAssignedAndUnassigedGroups(int userId)
        {
            Task.Run(() => GetAssignedAndUnassignedGroups(userId));
            return userId;
        }
        public async void GetAssignedAndUnassignedGroups(int userId)
        {
            (assigned, unassigned) = userGroupsBL.GetAssignedUsersGroupsAsync(userId);
            ucAssigned.userGroups = assigned;
            ucUnassigned.userGroups = unassigned;
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

            ucAssignUnassign.btnAssignFunc = AssignUser;
            ucAssignUnassign.btnUnassignFunc = UnassignUser;
        }
        private int AssignUser()
        {
            ucAssigned.SelectedUserGroups();
            clientGroupBL.AssignUserOrUnAssignToGroup(true, ucUserGrid.SelectedUserId, ucAssigned.selectedUserGroupsList);
            //fetch updated list of assigned groups
            InvocableLoadAssignedAndUnassigedGroups(ucUserGrid.SelectedUserId);
            return 1;
        }

        private int UnassignUser()
        {
            ucUnassigned.SelectedUserGroups();
            clientGroupBL.AssignUserOrUnAssignToGroup(false, ucUserGrid.SelectedUserId, ucUnassigned.selectedUserGroupsList);
            //fetch updated list of unassigned groups
            InvocableLoadAssignedAndUnassigedGroups(ucUserGrid.SelectedUserId);
            return 1;
        }

        
    }
}