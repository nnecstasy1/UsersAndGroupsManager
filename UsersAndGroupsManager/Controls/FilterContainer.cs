namespace UsersAndGroupsManager.Controls
{
    public partial class FilterContainer : UserControl
    {
        public Action<string> SearchFunc;
        public FilterContainer()
        {
            InitializeComponent();
        }

        private void EnterKeyToSearch(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchFunc.Invoke(txtFilter.Text);
            }
        }
    }
}
