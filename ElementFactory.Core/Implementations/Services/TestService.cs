namespace ElementFactory.Core.Implementations.Services
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for Test Service
    /// </summary>
    public class TestService : ITestService
    {
        /// <summary>
        /// Field for repository
        /// </summary>
        private readonly ITestRepository repository;

        /// <summary>
        /// Default Constructor for injection of a repository
        /// </summary>
        /// <param name="repository">Test Repository</param>
        public TestService(ITestRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to repository
        /// </summary>
        /// <param name="entity">Test entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(Test entity)
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
        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<Test> GetByIdAsync(int id)
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
        public async Task UpdateAsync(int id, Test entity)
        {
            await repository.UpdateAsync(id, entity);
        }

        /// <summary>
        /// Asynchronous method for loading a test by a given id
        /// </summary>
        /// <param name="id">The id of the test</param>
        /// <returns>Nullable Test entity</returns>
        /// <exception cref="ArgumentException">
        /// An exception to throw in case of an error
        /// </exception>
        public async Task<Test?> LoadTestAsync(int id)
        {
            var test = await repository.LoadTestAsync(id);

            return test ?? throw new ArgumentException("Invalid test!");
        }

        /// <summary>
        /// Asynchronous method for getting tests by a given grade
        /// </summary>
        /// <param name="grade">The grade of the tests</param>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<Test>> GetByGradeAsync(string grade)
        {
            return await repository.GetByGradeAsync(grade);
        }
    }
}
