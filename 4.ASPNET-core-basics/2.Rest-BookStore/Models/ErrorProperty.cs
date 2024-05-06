namespace _2.Rest_BookStore.Models
{
    public class ErrorProperty(string property, string value)
    {
        public string Property { get; set; } = property;
        public string Value { get; set; } = value;
    }
}