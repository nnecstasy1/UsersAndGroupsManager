namespace ServiceAccessBL
{
    public class UserGroups
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }
    }
}
