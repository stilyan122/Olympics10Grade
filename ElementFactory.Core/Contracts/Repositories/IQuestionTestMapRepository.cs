namespace ElementFactory.Core.Contracts.Repositories
{
    using ElementFactory.Data.Models;

    public interface IQuestionTestMapRepository : IRepository<QuestionTestMap>
    {
        /// <summary>
        /// Asynchronous method used to delete an entity with given ids
        /// </summary>
        /// <param name="testId">Test Id</param>
        /// <param name="questionId">Question Id</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(int testId, int questionId);
    }
}
