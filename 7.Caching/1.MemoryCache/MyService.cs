using Microsoft.Extensions.Caching.Memory;

namespace _1.MemoryCache;

public class MyService
{
    private readonly IMemoryCache _memoryCache;
    public MyService(IMemoryCache memoryCache)
    {
        _ = _memoryCache.Set("test", "data for cache test");
        _memoryCache = memoryCache;
    }
    public string GetData(string key)
    {
        // Try to get the data from the cache
        if (_memoryCache.TryGetValue(key, out string cachedData))
        {
            // If data is found in the cache, return it
            return cachedData;
        }

        // If data is not found in the cache, fetch it from the source
        string data = FetchDataFromSource(key);

        // Cache the data for future use
        _memoryCache.Set(key, data, TimeSpan.FromMinutes(10));

        return data;
    }

    private static string FetchDataFromSource(string key)
    {
        // Simulate fetching data from a source (e.g., database)
        return $"Data for {key}";
    }
}
