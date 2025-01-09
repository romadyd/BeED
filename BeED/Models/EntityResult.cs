namespace BeED.Models
{
    public class EntityResult<T>
    {
        public IEnumerable<T> Value { get; set; }
        public int TotalRows { get; set; }
        public string? Message { get; set; }
    }
}
