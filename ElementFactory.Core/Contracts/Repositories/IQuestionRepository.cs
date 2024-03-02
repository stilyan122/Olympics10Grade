namespace ElementFactory.Core.Contracts.Repositories
{
    using ElementFactory.Data.Models;

    /// <summary>
    /// Interface for Question Repository
    /// </summary>
    public interface IQuestionRepository : IRepository<Question>
    {
        /// <summary>
        /// Asynchronous method for getting questions by a given grade
        /// </summary>
        /// <param name="grade">The grade of the questions</param>
        /// <returns>Collection with entities</returns>
        public Task<IEnumerable<Question>> GetByGradeAsync(string grade);
    }
}
