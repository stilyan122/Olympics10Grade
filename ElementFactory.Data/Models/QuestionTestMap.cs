namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    public class QuestionTestMap
    {
        /// <summary>
        /// Question Id corresponding to the Question => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Question))]
        [Comment("Question identificator")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Property for the Question
        /// </summary>
        public virtual Question Question { get; set; } = null!;

        /// <summary> 
        /// Test ID corresponding to the Test => Foreign Key
        /// </summary>
        [ForeignKey(nameof(Test))]
        [Comment("Test identificator")]
        public int TestId { get; set; }

        /// <summary>
        /// Property for the Test
        /// </summary>
        public virtual Test Test { get; set; }
        = null!;

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}
