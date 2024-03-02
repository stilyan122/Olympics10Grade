namespace ElementFactory.Core.Contracts.Service
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for Test Service
    /// </summary>
    public interface ITestService
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">Test entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(Test entity);

        /// <summary>
        /// Asynchronous method for saving changes in repository
        /// </summary>
        /// <returns>(void)</returns>
        public Task SaveChangesAsync();

        /// <summary>
        /// Asynchronous method for deleting an entity by id
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(int id);

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<Test>> GetAllAsync();

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public Task<Test> GetByIdAsync(int id);

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(int id, Test entity);

        /// <summary>
        /// Asynchronous method for loading a test by a given id
        /// </summary>
        /// <param name="id">The id of the test</param>
        /// <returns>Nullable Test entity</returns>
        public Task<Test?> LoadTestAsync(int id);

        /// <summary>
        /// Asynchronous method for getting tests by a given grade
        /// </summary>
        /// <param name="grade">The grade of the tests</param>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<Test>> GetByGradeAsync(string grade);
    }
}
