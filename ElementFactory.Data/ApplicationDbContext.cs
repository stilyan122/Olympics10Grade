namespace ElementFactory.Data
{
    using ElementFactory.Data.Configuration;
    using ElementFactory.Data.Configurations;
    using ElementFactory.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Database Application Context
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Database Application Context Constructor
        /// </summary>
        /// <param name="options">Options for the DbContext</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        /// <summary>
        /// Database Application Context User DbSet
        /// </summary>
        public override DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// Database Application Context ChemicalElement DbSet
        /// </summary>
        public DbSet<ChemicalElement> ChemicalElements { get; set; } = null!;

        /// <summary>
        /// Database Application Context ChemicalType DbSet
        /// </summary>
        public DbSet<ChemicalType> ChemicalTypes { get; set; } = null!;

        /// <summary>
        /// Database Application Context Founder DbSet
        /// </summary>
        public DbSet<Founder> Founders { get; set; } = null!;

        /// <summary>
        /// Database Application Context FounderChemicalElement DbSet
        /// </summary>
        public DbSet<FounderChemicalElementMap> FoundersChemicalElements { get; set; } = null!;

        /// <summary>
        /// Database Application Context Test DbSet
        /// </summary>
        public DbSet<Test> Tests { get; set; } = null!;

        /// <summary>
        /// Database Application Context Question DbSet
        /// </summary>
        public DbSet<Question> Questions { get; set; } = null!;

        /// <summary>
        /// Database Application Context QuestionsTest DbSet
        /// </summary>
        public DbSet<QuestionTestMap> QuestionsTests { get; set; } = null!;

        /// <summary>
        /// Database Application Context Answer DbSet
        /// </summary>
        public DbSet<Answer> Answers { get; set; } = null!;

        /// <summary>
        /// Database Application Context Flashcard DbSet
        /// </summary>
        public DbSet<Flashcard> Flashcards { get; set; } = null!;

        /// <summary>
        /// Database Application Context OnModelCreating method
        /// </summary>
        /// <param name="builder">ModelBuilder</param>
        protected override void OnModelCreating(ModelBuilder 
            builder)
        {
            base.OnModelCreating(builder);

            // Setting Composite Primary Key For
            // FounderChemicalElement
            builder
                .Entity<FounderChemicalElementMap>()
                .HasKey(fce => new
                {
                    fce.FounderId,
                    fce.ChemicalElementSymbol
                });

            builder.ApplyConfiguration<ChemicalType>(new ChemicalTypeConfiguration());

            builder.ApplyConfiguration<ChemicalElement>(new ChemicalElementConfiguration());

            builder.ApplyConfiguration<Test>(new TestConfiguration());

            builder.ApplyConfiguration<Question>(new QuestionConfiguration());  

            builder.ApplyConfiguration<QuestionTestMap>(new
                    QuestionTestConfiguration());

            builder.ApplyConfiguration<Answer>(new AnswerConfiguration());
        }
    }
}