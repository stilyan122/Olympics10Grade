namespace ElementFactory.Core.Contracts.Repositories
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for Test Repository
    /// </summary>
    public interface ITestRepository : IRepository<Test>
    {
        /// <summary>
        /// Asynchronous method for getting tests by a given grade
        /// </summary>
        /// <param name="grade">The grade of the tests</param>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<Test>> GetByGradeAsync(string grade);

        /// <summary>
        /// Asynchronous method for loading a test by a given id
        /// </summary>
        /// <param name="id">The id of the test</param>
        /// <returns>Nullable Test entity</returns>
        public Task<Test?> LoadTestAsync(int id);
    }
}
