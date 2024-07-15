# Đáp án tham khảo

```csharp
using Dumpify;

IEnumerable<int> numbers = Enumerable.Range(0, 100);

LearnPaging<int> learnPaging = new LearnPaging<int>(numbers);

learnPaging.Paging(10, 5).Dump();

public class LearnPaging<T>
{
    private IEnumerable<T> _data;

    public LearnPaging(IEnumerable<T> data)
    {
        _data = data;
    }

    public Page<IEnumerable<T>> Paging(int pageIndex = 0, int pageSize = 10)
    {
        int totalItems = _data.Count();
        int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var pagedData = _data.Skip(pageIndex * pageSize).Take(pageSize);

        bool hasNextPage = pageIndex < totalPages - 1;
        bool hasPreviousPage = pageIndex > 0;

        return new Page<IEnumerable<T>>
        {
            PageIndex = pageIndex,
            PageSize = pageSize,
            TotalPage = totalPages,
            Data = pagedData,
            HasNextPage = hasNextPage,
            HasPreviousPage = hasPreviousPage
        };
    }
}

public class Page<T>
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int TotalPage { get; set; }
    public T Data { get; set; }
    public bool HasNextPage { get; set; }
    public bool HasPreviousPage { get; set; }
}
```