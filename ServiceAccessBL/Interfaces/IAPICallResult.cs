namespace ServiceAccessBL
{
    public interface IAPICallResult<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether the API call was successful or not.
        /// </summary>
        bool IsSuccessStatusCode { get; set; }

        /// <summary>
        /// Gets or sets this field.
        /// </summary>
        HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// Gets or sets this field.
        /// </summary>
        List<string> LocationSegments { get; set; }

        /// <summary>
        /// Gets or sets this field.
        /// </summary>
        T ResultObject { get; set; }

        /// <summary>
        /// Gets or sets this field.
        /// </summary>
        string Message { get; set; }
    }
}
