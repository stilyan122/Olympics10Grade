namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;

    /// <summary>
    /// Implementation for Question Service
    /// </summary>
    public class QuestionService : IQuestionService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly IQuestionRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">Question Repository</param>
        public QuestionService(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">Question entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Question entity)
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
        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        /// <summary>
        /// Asynchronous method for getting questions by a given grade
        /// </summary>
        /// <param name="grade">The grade of the questions</param>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Question>> GetByGradeAsync(string grade)
        {
            return await repository.GetByGradeAsync(grade);
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<Question> GetByIdAsync(int id)
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
        public async Task UpdateAsync(int id, Question entity)
        {
            await repository.UpdateAsync(id, entity);
        }
    }
}
