namespace UsersAndGroupsManager.Controls
{
    public partial class UsersGrid : UserControl
    {
        public Func<int,int> GetGroupsForUserFunc { get; set; }
        public int SelectedUserId { get; private set; }
        public UsersGrid()
        {
            InitializeComponent();
        }

        private void UsersGrid_Load(object sender, EventArgs e)
        {
            grdUsers.AutoGenerateColumns = true;
            grdUsers.AllowUserToAddRows = false;

            grdUsers.Columns.Add("UserId", "ID");
            grdUsers.Columns.Add("Name", "Name(s)");
            grdUsers.Columns.Add("IsGlobalUser", "Global User");

            grdUsers.SelectionChanged += GrdUsers_SelectionChanged;
        }

        public void UpdateUsersDataSource(List<User> users)
        {
            grdUsers.DataSource = new BindingList<User>(users);
        }

        private void GrdUsers_SelectionChanged(object? sender, EventArgs e)
        {
            int selectedRowIndex = grdUsers.CurrentRow.Index;
            var selectedUser = (User)grdUsers.Rows[selectedRowIndex].DataBoundItem;
            SelectedUserId = selectedUser.UserId;
            if (selectedUser != null) GetGroupsForUserFunc.Invoke(SelectedUserId);
        }
    }
}
