using System.Text.Json.Serialization;

namespace Infrastructure
{
    [Index(nameof(UserId))]
    public class ClientGroupUserEntity : TEntity
    {
        //TODO: referential integrity constraint fix between entities.
        public int UserId { get; set; }
        [ForeignKey("Id")]
        //public UserEntity User { get; set; }
        public int ClientGroupId { get; set; }
        //[ForeignKey("Id")]
        //public ClientGroupEntity ClientGroup { get; set; }
        
    }
}
