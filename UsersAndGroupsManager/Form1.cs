using ServiceAccessBL;

namespace UsersAndGroupsManager
{
    public partial class Form1 : Form
    {
        private List<User> usersList;
        private readonly IServiceProvider serviceProvider;
        UserBL userBL;
        UserGroupsBL userGroupsBL;
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

            UpdateGroupsListItems();
        }

        private void UpdateGroupsListItems()
        {
            //List<UserGroups> bList = new List<UserGroups>();
            //bList.Add(new UserGroups() { Id = 1, Name = "item one", IsHidden=false });
            foreach (var item in assigned)
            {
                ucAssigned.userGroups.Add(item);
            }
            //TODO: pass through the data and update controls
            ucAssigned.UpdateListDataFunc.Invoke();
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
        }
    }
}