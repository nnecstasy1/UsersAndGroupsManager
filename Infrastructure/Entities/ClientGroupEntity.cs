namespace Infrastructure
{
    public class ClientGroupEntity: TEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public bool IsHidden { get; set; }

        public virtual ICollection<ClientGroupUserEntity> ClientGroupUsers { get; set; }
    }
}
