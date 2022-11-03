namespace ServiceAccessBL
{
    public class ClientGroups
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("clientGroupId")]
        public int ClientGroupId { get; set; }
    }
}
