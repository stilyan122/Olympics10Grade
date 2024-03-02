namespace ElementFactory.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static ElementFactory.Data.Constants.ChemicalElementConstants;

    /// <summary>
    /// Chemical Element Class
    /// </summary>
    [Comment("Chemical Element Class")]
    public class ChemicalElement
    {
        /// <summary>
        /// Element Symbol => Primary Key
        /// </summary>
        [Key]
        [Required]
        [MinLength(ChemicalElementSymbolMinLength), 
            MaxLength(ChemicalElementSymbolMaxLength)]
        [Comment("Chemical element symbol => PK")]
        public string Symbol { get; set; } = null!;

        /// <summary>
        /// Helpful Identificator
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Element Name
        /// </summary>
        [MinLength(ChemicalElementNameMinLength), 
            MaxLength(ChemicalElementNameMaxLength)]
        [Comment("Chemical element name *bulgarian*")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Element English Name
        /// </summary>
        [Required]
        [MinLength(ChemicalElementNameMinLength), 
            MaxLength(ChemicalElementNameMaxLength)]
        [Comment("Chemical element name *english*")]
        public string EnglishName { get; set; } = null!;

        /// <summary>
        /// Element Atomic Number
        /// </summary>
        [Required]
        [Range(ChemicalElementAtomicNumberMinValue,
            ChemicalElementAtomicNumberMaxValue)]
        [Comment("Chemical element atomic number")]
        public int AtomicNumber { get; set; }

        /// <summary>
        /// Element Atomic Mass
        /// </summary>
        [Required]
        [Comment("Chemical element atomic mass")]
        public decimal AtomicMass { get; set; }

        /// <summary>
        /// Group from the Periodic Table for the Element
        /// </summary>
        [Required]
        [Range(ChemicalElementGroupMinValue, ChemicalElementGroupMaxValue)]
        [Comment("Chemical element group")]
        public int Group { get; set; }

        /// <summary>
        /// Period from the Periodic Table for the Element
        /// </summary>
        [Required]
        [Range(ChemicalElementPeriodMinValue, ChemicalElementPeriodMaxValue)]
        [Comment("Chemical element period")]
        public int Period { get; set; }

        /// <summary>
        /// Number of Element Electronic Layers
        /// </summary>
        [Required]
        [Range(ChemicalElementElLayersMinValue, ChemicalElementElLayersMaxValue)]
        [Comment("Chemical element electronic layers")]
        public int ElectronicLayers { get; set; }

        /// <summary>
        /// Flag for radioactivity for an Element
        /// </summary>
        [Required]
        [Comment("Is chemical element radioactive - flag")]
        public bool IsRadioactive { get; set; }

        /// <summary>
        /// Flag for syntheticity for an Element
        /// </summary>
        [Required]
        [Comment("Is chemical element synthetic - flag")]
        public bool IsSynthetic { get; set; }

        /// <summary>
        /// Id corresponding to the Chemical Type => Foreign Key
        /// </summary>
        [ForeignKey(nameof(ChemicalType))]
        [Required]
        [Comment("Chemical element id for type")]
        public int ChemicalTypeId { get; set; }

        /// <summary>
        /// Boiling point for the Element
        /// </summary>
        [Required]
        [Comment("Chemical element boiling point")]
        public decimal BoilingPoint { get; set; }

        /// <summary>
        /// Melting point for the Element
        /// </summary>
        [Required]
        [Comment("Chemical element melting point")]
        public decimal MeltingPoint { get; set; }

        /// <summary>
        /// Year when the Element was found
        /// </summary>
        [Required]
        [Comment("Chemical element year when found")]
        public int YearFound { get; set; }

        /// <summary>
        /// Physical state for the Element
        /// </summary>
        [Required]
        [MinLength(ChemicalElementStateMinLength), 
            MaxLength(ChemicalElementStateMaxLength)]
        [Comment("Chemical element state *english*")]
        public string State { get; set; } = null!;

        /// <summary>
        /// Physical state for the Element in Bulgarian
        /// </summary>
        [Required]
        [MinLength(ChemicalElementStateMinLength), 
            MaxLength(ChemicalElementStateMaxLength)]
        [Comment("Chemical element state *bulgarian*")]
        public string BulgarianState { get; set; } = null!;

        /// <summary>
        /// Electronegativity for the Element
        /// </summary>
        [Required]
        [Comment("Chemical element electronegativity")]
        public decimal Electronegativity { get; set; }

        /// <summary>
        /// Atomic Radius for the Element
        /// </summary>
        [Required]
        [Comment("Chemical element atomic radius")]
        public decimal AtomicRadius { get; set; }

        /// <summary>
        /// Density of the Element
        /// </summary>
        [Required]
        [Comment("Chemical element density")]
        public decimal Density { get; set; }

        /// <summary>
        /// Flag for activity => used in DB
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Property for the Chemical Type
        /// </summary>
        public virtual ChemicalType ChemicalType { get; set; } 
            = null!;

        /// <summary>
        /// Collection from FoundersChemicalElements
        /// </summary>
        public ICollection<FounderChemicalElementMap>
           FoundersChemicalElements { get; set; } = null!;
    }
}
