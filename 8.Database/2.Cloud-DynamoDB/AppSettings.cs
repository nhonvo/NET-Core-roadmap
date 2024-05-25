namespace _2.Cloud_DynamoDB
{
    public class AppSettings
    {
        public DynamoDb AwsSettings { get; set; }
        public class DynamoDb
        {
            public string Table_Name { get; set; }
            public bool UseHttp { get; set; }
            public string ServiceUrl { get; set; }
        }
    }
}