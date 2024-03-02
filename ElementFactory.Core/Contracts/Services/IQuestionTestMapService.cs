using ElementFactory.Data.Models;

namespace ElementFactory.Core.Contracts.Service
{
    public interface IQuestionTestMapService
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">QuestionTestMap entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(QuestionTestMap entity);

        /// <summary>
        /// Asynchronous method for saving changes in repository
        /// </summary>
        /// <returns>(void)</returns>
        public Task SaveChangesAsync();

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<QuestionTestMap>> GetAllAsync();

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public Task<QuestionTestMap> GetByIdAsync(int id);

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(int id, QuestionTestMap entity);

        /// <summary>
        /// Asynchronous method used to delete an entity with given ids
        /// </summary>
        /// <param name="testId">Test Id</param>
        /// <param name="questionId">Question Id</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(int testId, int questionId);
    }
}
