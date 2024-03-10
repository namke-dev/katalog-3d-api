using katalog_3d_api.data;

namespace katalog_3d_api.Repository
{
    public class Repository<TEntity>(KatalogContext context) : IRepository<TEntity> where TEntity : class
    {
        private readonly KatalogContext _context = context;

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity?> UpdateAsync(int id, TEntity entity)
        {
            var existingEntity = await _context.Set<TEntity>().FindAsync(id);

            if (existingEntity == null)
            {
                return null;
            }

            // Use reflection to get the properties of TEntity and update them
            var properties = typeof(TEntity).GetProperties();

            foreach (var property in properties)
            {
                // Exclude the property if it's an identifier
                if (property.Name == "Id")
                {
                    continue;
                }
                var newValue = property.GetValue(entity);
                property.SetValue(existingEntity, newValue);
            }

            await _context.SaveChangesAsync();

            return existingEntity;
        }

        public async Task<TEntity?> DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}