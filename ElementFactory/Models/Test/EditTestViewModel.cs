namespace ElementFactory.Models.Test
{
    using ElementFactory.Models.Answer;
    using ElementFactory.Models.Question;
    using System.ComponentModel.DataAnnotations;

    public class EditTestViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето за заглавие е задължително!")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Дължината за полето на заглавието" +
            " трябва да е между" +
            " {2} and {1} символа!")]
        public string Title { get; set; } = null!;

        public string Category { get; set; } = null!;

        public List<QuestionViewModel> Questions { get; set; } =
            new List<QuestionViewModel>();
    }
}
