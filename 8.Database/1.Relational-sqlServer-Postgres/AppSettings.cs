namespace _1.Relational_sqlServer_Postgres
{
    public class AppSettings
    {
        public string SqlServerConnectionStrings { get; set; }
        public string PostgreSqlConnectionStrings { get; set; }
        public bool SqlServer { get; set; }
        public bool PostgreSql { get; set; }
    }
}