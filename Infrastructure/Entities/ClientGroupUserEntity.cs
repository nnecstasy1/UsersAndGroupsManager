using System.Text.Json.Serialization;

namespace Infrastructure
{
    [Index(nameof(UserId), nameof(ClientGroupId))]
    public class ClientGroupUserEntity : TEntity
    {
        [Required]
        public int UserId { get; set; }
        [JsonIgnore]
        public UserEntity UserEntity { get; set; }
        [Required]
        public int ClientGroupId { get; set; }
        [JsonIgnore]
        public ClientGroupEntity ClientGroupEntity { get; set; }
    }
}
