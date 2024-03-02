namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for Answer Service
    /// </summary>
    public class AnswerService : IAnswerService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly IAnswerRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">Answer Repository</param>
        public AnswerService(IAnswerRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">Question entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Answer entity)
        {
            await repository.AddAsync(entity);
        }

        /// <summary>
        /// Asynchronous method for deleting an entity by id from repository
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<Answer> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        /// <summary>
        /// Asynchronous method for saving changes in repository
        /// </summary>
        /// <returns>(void)</returns>
        public async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(int id, Answer entity)
        {
            await repository.UpdateAsync(id, entity);
        }
    }
}
