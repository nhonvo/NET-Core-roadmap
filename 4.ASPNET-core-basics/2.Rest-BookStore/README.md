# Rest api

## Middleware

- Authentication middleware
- Performance middleware
- Routing middleware

## Filter and Attribute

- Exception filter
- Validation filter
![The request is processed through Authorization Filters, Resource Filters, Model Binding, Action Filters, Action Execution and Action Result Conversion, Exception Filters, Result Filters, and Result Execution. On the way out, the request is only processed by Result Filters and Resource Filters before becoming a response sent to the client.](README.assets/filter-pipeline-2.pngview=aspnetcore-7.png)

## App Settings and Config

- settings are typically stored in configuration files, such as appsettings.json, appsettings.development.json, or appsettings.production.json, and can be accessed using the IConfiguration interface.
- Configurations refer to the process of loading and managing the app settings and typically loads configuration data from various sources, such as JSON files, environment variables, or command-line arguments.