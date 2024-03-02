namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Test class
    /// </summary>
    [Comment("Test Class")]
    public class Test
    {
        /// <summary>
        /// Test Id => Primary Key
        /// 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Test identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Test Title
        /// </summary>
        [MinLength(3), MaxLength(150)]
        [Comment("Test title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Test Category
        /// </summary>
        [MinLength(3), MaxLength(100)]
        [Comment("Test category")]
        public string Category { get; set; } = null!;

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Collection from QuestionsTests
        /// </summary>
        public ICollection<QuestionTestMap> QuestionsTests { get; set; }
        = new List<QuestionTestMap>();
    }
}
