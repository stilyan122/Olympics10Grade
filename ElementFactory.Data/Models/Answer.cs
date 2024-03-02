namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static ElementFactory.Data.Constants.AnswerConstants;

    /// <summary>
    /// Answer class
    /// </summary>
    [Comment("Answer Class")]
    public class Answer
    {
        /// <summary>
        /// Answer Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Answer identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Answer value
        /// </summary>
        [MinLength(AnswerValueMinLength),
            MaxLength(AnswerValueMaxLength)]
        [Comment("Answer value")]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Question property
        /// </summary>
        public virtual Question Question { get; set; } = null!;

        /// <summary>
        /// Question Id => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Question))]
        [Comment("Answer question Id")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}
