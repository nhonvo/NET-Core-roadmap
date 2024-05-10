using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Distributed_Cache_redis
{
   public class CacheService
    {
        IDatabase _cacheDb;
        public CacheService(AppConfiguration configuration)
        {
            if (configuration.UseRedisCache)
            {
                var redis = ConnectionMultiplexer.Connect("redis:6379");
                _cacheDb = redis.GetDatabase();
            }
        }

        public async Task<T> Get<T>(string key)
        {
            var value = await _cacheDb.StringGetAsync(key);
            return value.HasValue ? JsonSerializer.Deserialize<T>(value) : default;
        }

        public async Task<bool> Remove(string key)
            => await _cacheDb.KeyDeleteAsync(key);

        public async Task<bool> Set<T>(string key, T value, DateTimeOffset expirationTime)
        {
            var expiryTime = expirationTime - DateTimeOffset.Now;
            return await _cacheDb.StringSetAsync(key, JsonSerializer.Serialize(value), expiryTime);
        }
    }
}