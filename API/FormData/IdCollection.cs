namespace API
{
    /// <summary>
    /// Accept collection of ID's from an API request.
    /// </summary>
    public class IdCollection
    {
        public Id[] Ids { get; set; }
    }
    public class Id
    {
        public int id { get; set; }
    }
}
