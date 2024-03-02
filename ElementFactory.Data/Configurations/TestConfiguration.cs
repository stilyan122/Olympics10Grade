namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Class for configuration of Test Entity
    /// </summary>
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        /// <summary>
        /// Method for configuring the entities
        /// </summary>
        /// <param name="builder">The builder used for configuring</param>
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            var tests = this.Tests7Grade();
            tests.AddRange(this.Tests8_9Grade());
            tests.AddRange(this.Tests10Grade());
            tests.AddRange(this.Tests11_12Grade());

            builder.HasMany(t => t.QuestionsTests)
              .WithOne(qtm => qtm.Test)
              .HasForeignKey(qtm => qtm.TestId);

            builder.HasData(tests);
        }

        /// <summary>
        /// Methods for the separate tests
        /// </summary>

        private List<Test> Tests7Grade()
        {
            var test1 = new Test()
            {
                Id = 1,
                Title = "Метали. Натрий и неговите съединения",
                Category = "7 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            var test2 = new Test()
            {
                Id = 2,
                Title = "Неметали. Хлор и неговите съединения",
                Category = "7 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

        private List<Test> Tests8_9Grade()
        {
            var test1 = new Test()
            {
                Id = 3,
                Title = "Алкалоземни метали. Калций и неговите съединения",
                Category = "8-9 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            var test2 = new Test()
            {
                Id = 4,
                Title = "Органична химия. Въглерод и неговите органични съединения",
                Category = "8-9 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

        private List<Test> Tests10Grade()
        {
            var test1 = new Test()
            {
                Id = 5,
                Title = "Характеристики на химичните процеси",
                Category = "10 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            var test2 = new Test()
            {
                Id = 6,
                Title = "Разтвори и химични процеси във водни разтвори",
                Category = "10 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

        private List<Test> Tests11_12Grade()
        {
            var test1 = new Test()
            {
                Id = 7,
                Title = "Строеж и свойства на веществата",
                Category = "11-12 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            var test2 = new Test()
            {
                Id = 8,
                Title = "11-12 клас. Обобщителен тест",
                Category = "11-12 клас",
                QuestionsTests = new List<QuestionTestMap>()
            };

            return new List<Test>()
            {
                test1,
                test2
            };
        }

    }
}
