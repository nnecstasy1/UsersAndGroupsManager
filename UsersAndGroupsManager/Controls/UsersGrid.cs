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

            grdUsers.Columns.Add(nameof(User.UserId), "ID");
            grdUsers.Columns.Add(nameof(User.Name), "User Name(s)");
            grdUsers.Columns.Add(nameof(User.IsGlobalUser), "Global User");
            grdUsers.Columns.Add("UserType", "User Type");
            grdUsers.Columns[0].Visible = false;
            grdUsers.Columns[3].Visible = false;

            UpdateUsersDataSource(new List<User>());
            grdUsers.SelectionChanged += GrdUsers_SelectionChanged;
        }

        public void UpdateUsersDataSource(List<User> users)
        {
            grdUsers.DataSource = new BindingList<User>(users);
            RepaintUserTypeCells();
        }

        private void GrdUsers_SelectionChanged(object? sender, EventArgs e)
        {
            int selectedRowIndex = grdUsers.CurrentRow.Index;
            var selectedUser = (User)grdUsers.Rows[selectedRowIndex].DataBoundItem;
            SelectedUserId = selectedUser.UserId;
            if (selectedUser != null) GetGroupsForUserFunc.Invoke(SelectedUserId);
        }

        private void RepaintUserTypeCells()
        {
            foreach (DataGridViewRow row in grdUsers.Rows)
            {
                //row.Cells[4].Value = (bool)row.Cells[3].Value ? "Global User" : "Client User";
            }
        }
    }
}
