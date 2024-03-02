namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class QuestionTestMapService : IQuestionTestMapService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly IQuestionTestMapRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">QuestionTestMap Repository</param>
        public QuestionTestMapService(IQuestionTestMapRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">QuestionTestMap entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(QuestionTestMap entity)
        {
            await repository.AddAsync(entity);
        }

        /// <summary>
        /// Asynchronous method used to delete an entity with given ids
        /// </summary>
        /// <param name="testId">Test Id</param>
        /// <param name="questionId">Question Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int testId, int questionId)
        {
            await repository.DeleteAsync(testId, questionId);
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<QuestionTestMap>> GetAllAsync()
        {
             return await repository.GetAllAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<QuestionTestMap> GetByIdAsync(int id)
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
        public async Task UpdateAsync(int id, QuestionTestMap entity)
        {
            await repository.UpdateAsync(id, entity);
        }
    }
}
