namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static ElementFactory.Data.Constants.ChemicalTypeConstants;

    /// <summary>
    /// Chemical Type class
    /// </summary>
    [Comment("Chemical Type Class")]
    public class ChemicalType
    {
        /// <summary>
        /// Chemical Type Id => Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Chemical Type identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Chemical Type Name
        /// </summary>
        [Required]
        [MinLength(ChemicalTypeNameMinLength), 
            MaxLength(ChemicalTypeNameMaxLength)]
        [Comment("Chemical type name english")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Chemical Type Name in Bulgarian
        /// </summary>
        [Required]
        [MinLength(ChemicalTypeNameMinLength), 
            MaxLength(ChemicalTypeNameMaxLength)]
        [Comment("Chemical type name bulgarian")]
        public string BulgarianName { get; set; } = null!;

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Collection from Chemical Elements
        /// </summary>
        public ICollection<ChemicalElement> ChemicalElements 
        { get; set; } = null!;
    }
}
