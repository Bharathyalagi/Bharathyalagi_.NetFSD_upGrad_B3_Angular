using ContactCachingApi.Models;
using ContactCachingApi.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace ContactCachingApi.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository repo;
    private readonly IMemoryCache cache;

    public ContactService(IContactRepository repo, IMemoryCache cache)
    {
        this.repo = repo;
        this.cache = cache;
    }

    public List<Contact> FetchAll()
    {
        var key = "all_contacts";

        if (!cache.TryGetValue(key, out List<Contact> data))
        {
            data = repo.GetAll();

            var opt = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(60));

            cache.Set(key, data, opt);
        }

        return data;
    }

    public Contact FetchById(int id)
    {
        var key = $"contact_{id}";

        if (!cache.TryGetValue(key, out Contact data))
        {
            data = repo.GetById(id);

            var opt = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(60));

            cache.Set(key, data, opt);
        }

        return data;
    }
}