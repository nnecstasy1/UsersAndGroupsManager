namespace Infrastructure
{
    public class UserEntity : TEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public bool IsGlobalUser { get; set; }

        public virtual ICollection<ClientGroupUserEntity>  ClientGroupUsers { get; set; }
    }
}
