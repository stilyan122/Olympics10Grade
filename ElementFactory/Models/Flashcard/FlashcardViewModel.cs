using System.ComponentModel.DataAnnotations;
using static ElementFactory.Data.Constants.FlashCardConstants;
namespace ElementFactory.Models.Flashcard
{
    public class FlashcardViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето за въпрос е задължително")]
        [StringLength(TitleMaxLength,MinimumLength = TitleMinLength,
             ErrorMessage = "Невалиден въпрос! Дължината на въпроса трябва да е между {2} и {1} символа.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage ="Полето за отговор е задължително")]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength,
             ErrorMessage = "Невалиден отговор! Дължината на отговора трябва да е между {2} и {1} символа.")]
        public string Content { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
