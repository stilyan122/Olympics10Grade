namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static ElementFactory.Data.Constants.FlashCardConstants;

    /// <summary>
    /// Flashcard class
    /// </summary>
    [Comment("Flashcard Class")]
    public class Flashcard
    {
        /// <summary>
        /// Flashcard Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Flashcard identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Flashcard Title
        /// </summary>
        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Flashcard Title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Flashcard Content
        /// </summary>
        [Required]
        [MaxLength(ContentMaxLength)]
        [Comment("Flashcard Content")]
        public string Content { get; set; } = null!;

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// User Id
        /// </summary>
        public string UserId { get; set; } = null!;
    }
}
