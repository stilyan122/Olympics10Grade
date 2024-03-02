namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Data.Models;
    using ElementFactory.Data;
    using Microsoft.EntityFrameworkCore;
    using ElementFactory.Core.Contracts.Repositories;

    /// <summary>
    /// Implementation for Test Repository
    /// </summary>
    public class TestRepository : ITestRepository
    {
        /// <summary>
        /// Field for ApplicationDbContext - our DB Context
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Default Constructor for injection of a DB Context
        /// </summary>
        /// <param name="context">DB Context</param>
        public TestRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to context
        /// </summary>
        /// <param name="entity">Test entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Test entity)
        {
            await context.Tests.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for deleting an entity by id from context
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int id)
        {
            var entity = await context
                .Tests
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entity.IsActive = false;
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await context
                .Tests
                .Where(t => t.IsActive)
                .ToListAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<Test> GetByIdAsync(int id)
        {
            var entity = await context.Tests
                .Where(t => t.IsActive)
                .Include(t => t.QuestionsTests)
                .ThenInclude(qt => qt.Question)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(q => q.Id == id);

            return entity ?? throw new ArgumentException("Invalid id!");
        }

        /// <summary>
        /// Asynchronous method for saving changes in repository
        /// </summary>
        /// <returns>(void)</returns>
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(int id, Test entity)
        {
            var entityToUpdate = await context
                .Tests
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.QuestionsTests = entity.QuestionsTests;
            entityToUpdate.Title = entity.Title;
            entityToUpdate.Category = entity.Category;

            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for loading a test by a given id
        /// </summary>
        /// <param name="id">The id of the test</param>
        /// <returns>Nullable Test entity</returns>
        public async Task<Test?> LoadTestAsync(int id)
        {
            return await context
                .Tests
                .Include(x => x.QuestionsTests)
                .ThenInclude(x => x.Question)
                .ThenInclude(x => x.Answers)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        /// <summary>
        /// Asynchronous method for getting tests by a given grade
        /// </summary>
        /// <param name="grade">The grade of the tests</param>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Test>> GetByGradeAsync(string grade)
        {
            var tests = await context
                .Tests
                .Include(t => t.QuestionsTests)
                .ThenInclude(t => t.Question)
                .ThenInclude(t => t.Answers)
                .Where(t => t.Category.Contains(grade) && t.IsActive)
                .ToListAsync();

            return tests;
        }
    }
}
