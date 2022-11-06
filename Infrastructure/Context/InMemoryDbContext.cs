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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientGroupUserEntity>()
            .HasOne(u => u.UserEntity)
            .WithMany(g => g.ClientGroupUsers)
            .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<ClientGroupUserEntity>()
            .HasOne(u => u.ClientGroupEntity)
            .WithMany(g => g.ClientGroupUsers)
            .HasForeignKey(s => s.ClientGroupId);
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
               new UserEntity(){ Name = "Alena", IsGlobalUser = false},
               new UserEntity(){ Name = "Sergiy", IsGlobalUser = true},
               new UserEntity(){ Name = "Andrii", IsGlobalUser = true},
            });

            ClientGroups.AddRange(new ClientGroupEntity[]
            {
                new ClientGroupEntity(){ Name = "Client Group 1", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 2", IsHidden = true},
                new ClientGroupEntity(){ Name = "Client Group 3", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 4", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 5", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 6", IsHidden = true},
                new ClientGroupEntity(){ Name = "Client Group 7", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 8", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 9", IsHidden = false},
                new ClientGroupEntity(){ Name = "Client Group 10", IsHidden = true},
            });

            ClientGroupUsers.AddRange(new ClientGroupUserEntity[]
            {
                new ClientGroupUserEntity(){ UserId = 1 , ClientGroupId = 1},
                new ClientGroupUserEntity(){ UserId = 1 , ClientGroupId = 2},
                new ClientGroupUserEntity(){ UserId = 1 , ClientGroupId = 3},
                new ClientGroupUserEntity(){ UserId = 1 , ClientGroupId = 4},
                new ClientGroupUserEntity(){ UserId = 2 , ClientGroupId = 1},
                new ClientGroupUserEntity(){ UserId = 2 , ClientGroupId = 5},
                new ClientGroupUserEntity(){ UserId = 2 , ClientGroupId = 6},
            });
        }
    }
}
