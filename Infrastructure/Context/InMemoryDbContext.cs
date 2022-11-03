namespace Infrastructure
{
    /// <summary>
    /// In Memory Database Context. Includes default data loading through using a singleton.
    /// </summary>
    public class InMemoryDbContext : DbContext
    {
        private DefaultDataSingleton _dataSingleton;
        public InMemoryDbContext(DbContextOptions options)
            : base(options)
        {
             _dataSingleton = DefaultDataSingleton.GetDefaultDataSingleton();
            LoadDefaultData();
        }

        #region Entities
        DbSet<UserEntity> Users { get; set; }
        DbSet<ClientGroupEntity> ClientGroups { get; set; }
        DbSet<ClientGroupUserEntity> ClientGroupUsers { get; set; }
        #endregion

        private void LoadDefaultData()
        {
            if (!_dataSingleton.IsLoaded())
            {
                CreateDefaultData();
                SaveChanges();
                _dataSingleton.IsLoaded(true);
            }
        }
        private void CreateDefaultData()
        {
            Users.AddRange(new UserEntity[]
            {
               new UserEntity(){Id = 1, Name = "Alena", IsGlobalUser = false},
               new UserEntity(){Id = 2, Name = "Sergiy", IsGlobalUser = true},
               new UserEntity(){Id = 3, Name = "Andrii", IsGlobalUser = true},
            });
            
            ClientGroups.AddRange(new ClientGroupEntity[]
            {
                new ClientGroupEntity(){Id = 1, Name = "Client Group 1", IsHidden = false},
                new ClientGroupEntity(){Id = 2, Name = "Client Group 2", IsHidden = false},
                new ClientGroupEntity(){Id = 3, Name = "Client Group 3", IsHidden = false},
                new ClientGroupEntity(){Id = 4, Name = "Client Group 4", IsHidden = false},
                new ClientGroupEntity(){Id = 5, Name = "Client Group 5", IsHidden = false},
                new ClientGroupEntity(){Id = 6, Name = "Client Group 6", IsHidden = false},
                new ClientGroupEntity(){Id = 7, Name = "Client Group 7", IsHidden = false},
                new ClientGroupEntity(){Id = 8, Name = "Client Group 8", IsHidden = false},
                new ClientGroupEntity(){Id = 9, Name = "Client Group 9", IsHidden = false},
                new ClientGroupEntity(){Id = 10, Name = "Client Group 10", IsHidden = false},
            });

            ClientGroupUsers.AddRange(new ClientGroupUserEntity[]
            {
                new ClientGroupUserEntity(){Id = 1, UserId = 1 , ClientGroupId = 1},
                new ClientGroupUserEntity(){Id = 2, UserId = 1 , ClientGroupId = 2},
                new ClientGroupUserEntity(){Id = 3, UserId = 1 , ClientGroupId = 3},
                new ClientGroupUserEntity(){Id = 4, UserId = 1 , ClientGroupId = 4},
                new ClientGroupUserEntity(){Id = 5, UserId = 2 , ClientGroupId = 1},
                new ClientGroupUserEntity(){Id = 6, UserId = 2 , ClientGroupId = 5},
                new ClientGroupUserEntity(){Id = 7, UserId = 2 , ClientGroupId = 6},
            });
        }
    }
}
