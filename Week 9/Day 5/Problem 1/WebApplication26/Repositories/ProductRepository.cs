using Microsoft.EntityFrameworkCore;
using WebApplication26.Models;

namespace WebApplication26.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext ctx;

        public ProductRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await ctx.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await ctx.Products.FindAsync(id);
        }

        public async Task<Product> AddAsync(Product product)
        {
            ctx.Products.Add(product);
            await ctx.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var existing = await ctx.Products.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == product.Id);

            if (existing == null) return null;

            ctx.Products.Update(product);
            await ctx.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await ctx.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null) return false;

            ctx.Products.Remove(item);
            await ctx.SaveChangesAsync();
            return true;
        }
    }
}