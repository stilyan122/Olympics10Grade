namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class QuestionTestMapRepository : IQuestionTestMapRepository
    {
        /// <summary>
        /// Field for ApplicationDbContext - our DB Context
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Default Constructor for injection of a DB Context
        /// </summary>
        /// <param name="context">DB Context</param>
        public QuestionTestMapRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to context
        /// </summary>
        /// <param name="entity">ChemicalElement entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(QuestionTestMap entity)
        {
            await context.QuestionsTests.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int testId, int questionId)
        {
            var entity = await this.context
                .QuestionsTests
                .FirstOrDefaultAsync(qt => qt.TestId == testId &&  qt.QuestionId == questionId)
                ?? throw new ArgumentException("Invalid id!");

            entity.IsActive = false;
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotSupportedException("Invalid method for such case!");
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<QuestionTestMap>> GetAllAsync()
        {
            return await
                context
                .QuestionsTests
                .Include(qt => qt.Question)
                .Include(qt => qt.Test)
                .Where(ce => ce.IsActive)
                .ToListAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<QuestionTestMap> GetByIdAsync(int id)
        {
            var entity = await context.QuestionsTests
                .Where(qt => qt.IsActive)
                .FirstOrDefaultAsync(qt => qt.TestId + "" + qt.QuestionId == id.ToString());

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
        public async Task UpdateAsync(int id, QuestionTestMap entity)
        {
            var entityToUpdate = await context
                .QuestionsTests
                .Where(ce => ce.IsActive)
                .FirstOrDefaultAsync(qt => qt.TestId + "" + qt.QuestionId == id.ToString())
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.QuestionId = entity.QuestionId;
            entityToUpdate.TestId = entity.TestId;

            await context.SaveChangesAsync();
        }
    }
}
