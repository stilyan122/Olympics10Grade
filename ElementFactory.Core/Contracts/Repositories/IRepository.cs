namespace ElementFactory.Core.Contracts.Repositories
{
    /// <summary>
    /// Interface for abstract repository
    /// </summary>
    public interface IRepository<T>
    {
        /// <summary>
        /// Asynchronous method for adding an entity
        /// </summary>
        /// <param name="entity">Generic Entity</param>
        /// <returns>(void)</returns>
        public Task AddAsync(T entity);

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
        public Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(int id, T entity);
    }
}
