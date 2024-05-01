using Microsoft.Extensions.Configuration;

namespace StudentManage.ConsoleApp.ultis
{
    public static class Connection
    {
        public static string GetConnectString()
        {
            string path = @"E:\Utilities\Download\nhonvtt\Mini-Project-Practice\StudentManage.ConsoleApp\appconfig.json";
            var configBuilder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                       .AddJsonFile(path);                    // nạp config định dạng JSON
            var configurationroot = configBuilder.Build();                // Tạo configurationroot
            return configurationroot["SqlServer:ConnectionString"]!;

        }
    }
}