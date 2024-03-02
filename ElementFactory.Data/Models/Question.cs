namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Question class
    /// </summary>
    [Comment("Question Class")]
    public class Question
    {
        /// <summary>
        /// Question Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Question identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Question Description
        /// </summary>
        [Required]
        [MinLength(10), MaxLength(300)]
        [Comment("Question description")]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Collection from question answers
        /// </summary>
        public ICollection<Answer> Answers { get; set; } = null!;

        /// <summary>
        /// Question right answer
        /// </summary>
        [Comment("Question right answer")]
        public string RightAnswer { get; set; } = null!;

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Collection from QuestionsTests
        /// </summary>
        public ICollection<QuestionTestMap> QuestionsTests { get; set; }
         = null!;
    }
}
