using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Pagination
{
    public interface IPageable<TItem>
    {
        Task<TItem[]> GetAll();
        Task<PagedResult<TItem>> GetPage(int page, int pageSize);
    }
    
    public record PagedResult<TItem>(int Page, int PageSize, TItem[] Items);
    
    public class QueryPaging<TItem> : IPageable<TItem>
    {
        private readonly IQueryable<TItem> _dataSource;
    
        public QueryPaging(IQueryable<TItem> dataSource) 
            => _dataSource = dataSource;
        
        public Task<TItem[]> GetAll() 
            =>  _dataSource.ToArrayAsync();
        
        public async Task<PagedResult<TItem>> GetPage(int page, int pageSize)
            => new(page, pageSize, await _dataSource.Skip(page * pageSize).Take(pageSize).ToArrayAsync());
    }
    
    public static class QueryableExtensions
    {
        public static IPageable<TItem> AsPageable<TItem>(this IQueryable<TItem> dataSource)
            => new QueryPaging<TItem>(dataSource);
    }
}