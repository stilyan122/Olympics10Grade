namespace ElementFactory.Models.Question
{
    using ElementFactory.Models.Answer;

    public class QuestionViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; } = null!;

        public List<AnswerViewModel> Answers { get; set; } = 
            new List<AnswerViewModel>();

        public AnswerViewModel CorrectAnswer { get; set; } = null!;
    }
}
