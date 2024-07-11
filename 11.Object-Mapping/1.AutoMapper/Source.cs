namespace _1.AutoMapper
{
    public class Source
    {
        public string Name { get; set; }
        public InnerSource InnerSource { get; set; }
        public OtherInnerSource OtherInnerSource { get; set; }
    }
    public class InnerSource
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class OtherInnerSource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
    public class Destination
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }

}