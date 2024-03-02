namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for Answer Repository
    /// </summary>
    public class AnswerRepository : IAnswerRepository
    {
        /// <summary>
        /// Field for ApplicationDbContext - our DB Context
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Default Constructor for injection of a DB Context
        /// </summary>
        /// <param name="context">DB Context</param>
        public AnswerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to context
        /// </summary>
        /// <param name="entity">ChemicalElement entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Answer entity)
        {
            await context.Answers.AddAsync(entity);
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
               .Answers
               .FirstOrDefaultAsync(a => a.Id == id)
               ?? throw new ArgumentException("Invalid id!");

            entity.IsActive = false;
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await
                context
                .Answers
                .Include(a => a.Question)
                .Where(ce => ce.IsActive)
                .ToListAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<Answer> GetByIdAsync(int id)
        {
            var entity = await context.Answers
                .Where(ce => ce.IsActive)
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
        public async Task UpdateAsync(int id, Answer entity)
        {
            var entityToUpdate = await context
                .Answers
                .Where(ce => ce.IsActive)
                .FirstOrDefaultAsync(q => q.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.Value = entity.Value;

            await context.SaveChangesAsync();
        }
    }
}
