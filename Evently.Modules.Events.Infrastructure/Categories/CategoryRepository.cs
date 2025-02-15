using Evently.Modules.Events.Domain.Categories;
using Evently.Modules.Events.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Evently.Modules.Events.Infrastructure.Categories;
internal sealed class CategoryRepository(EventsDbContext context) : ICategoryRepository
{
    public void Insert(Category category)
    {
        context.Categories.Add(category);
    }

    public Task<Category?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return context.Categories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
