namespace ElementFactory.Models.Others
{
    using ElementFactory.Data.Models;

    public class AddQuestionsChooseModel
    {
        public string Description { get; set; } = string.Empty;

        public int NumberOfQ { get; set; }

        public string TestTitle { get; set; } = string.Empty;

        public string TestCategory { get; set; } = string.Empty;

        public IList<Question> Questions { get; set; } =
            new List<Question>();

        public IList<string> QuestionsForDBJSON { get; set; } =
            new List<string>();
    }
}
