namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Class for configuration of QuestionTest Entity
    /// </summary>
    public class QuestionTestConfiguration :
        IEntityTypeConfiguration<QuestionTestMap>
    {
        /// <summary>
        /// Method for configuring the entities
        /// </summary>
        /// <param name="builder">The builder used for configuring</param>
        public void Configure(EntityTypeBuilder<QuestionTestMap> builder)
        {
            var questionsTestsMap = this.QuestionsTests1();
            questionsTestsMap.AddRange(this.QuestionsTests2());
            questionsTestsMap.AddRange(this.QuestionsTests3());
            questionsTestsMap.AddRange(this.QuestionsTests4());
            questionsTestsMap.AddRange(this.QuestionsTests5());
            questionsTestsMap.AddRange(this.QuestionsTests6());
            questionsTestsMap.AddRange(this.QuestionsTests7());
            questionsTestsMap.AddRange(this.QuestionsTests8());

            builder.HasOne(qtm => qtm.Question)
                   .WithMany(q => q.QuestionsTests)
                   .HasForeignKey(qtm => qtm.QuestionId);

            builder.HasOne(qtm => qtm.Test)
                .WithMany(t => t.QuestionsTests)
                .HasForeignKey(qtm => qtm.TestId);

            builder.HasKey(qt => new
                {
                    qt.QuestionId,
                    qt.TestId
                });

            builder.HasData(questionsTestsMap);
        }

        /// <summary>
        /// Methods for the separate questionsTestsMap
        /// </summary>
   
        private List<QuestionTestMap> QuestionsTests1()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 1,
                TestId = 1
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 2,
                TestId = 1
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 3,
                TestId = 1
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 4,
                TestId = 1
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 5,
                TestId = 1
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 6,
                TestId = 1
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 7,
                TestId = 1
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 8,
                TestId = 1
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 9,
                TestId = 1
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 10,
                TestId = 1
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 11,
                TestId = 1
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 12,
                TestId = 1
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 13,
                TestId = 1
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 14,
                TestId = 1
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 15,
                TestId = 1
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests2()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 16,
                TestId = 2
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 17,
                TestId = 2
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 18,
                TestId = 2
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 19,
                TestId = 2
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 20,
                TestId = 2
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 21,
                TestId = 2
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 22,
                TestId = 2
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 23,
                TestId = 2
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 24,
                TestId = 2
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 25,
                TestId = 2
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 26,
                TestId = 2
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 27,
                TestId = 2
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 28,
                TestId = 2
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 29,
                TestId = 2
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 30,
                TestId = 2
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests3()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 31,
                TestId = 3
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 32,
                TestId = 3
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 33,
                TestId = 3
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 34,
                TestId = 3
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 35,
                TestId = 3
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 36,
                TestId = 3
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 37,
                TestId = 3
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 38,
                TestId = 3
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 39,
                TestId = 3
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 40,
                TestId = 3
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 41,
                TestId = 3
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 42,
                TestId = 3
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 43,
                TestId = 3
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 44,
                TestId = 3
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 45,
                TestId = 3
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests4()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 46,
                TestId = 4
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 47,
                TestId = 4
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 48,
                TestId = 4
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 49,
                TestId = 4
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 50,
                TestId = 4
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 51,
                TestId = 4
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 52,
                TestId = 4
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 53,
                TestId = 4
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 54,
                TestId = 4
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 55,
                TestId = 4
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 56,
                TestId = 4
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 57,
                TestId = 4
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 58,
                TestId = 4
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 59,
                TestId = 4
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 60,
                TestId = 4
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests5()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 61,
                TestId = 5
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 62,
                TestId = 5
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 63,
                TestId = 5
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 64,
                TestId = 5
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 65,
                TestId = 5
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 66,
                TestId = 5
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 67,
                TestId = 5
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 68,
                TestId = 5
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 69,
                TestId = 5
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 70,
                TestId = 5
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10
            };
        }

        private List<QuestionTestMap> QuestionsTests6()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 71,
                TestId = 6
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 72,
                TestId = 6
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 73,
                TestId = 6
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 74,
                TestId = 6
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 75,
                TestId = 6
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 76,
                TestId = 6
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 77,
                TestId = 6
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 78,
                TestId = 6
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 79,
                TestId = 6
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 80,
                TestId = 6
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 81,
                TestId = 6
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 82,
                TestId = 6
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 83,
                TestId = 6
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 84,
                TestId = 6
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 85,
                TestId = 6
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests7()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 86,
                TestId = 7
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 87,
                TestId = 7
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 88,
                TestId = 7
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 89,
                TestId = 7
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 90,
                TestId = 7
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 91,
                TestId = 7
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 92,
                TestId = 7
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 93,
                TestId = 7
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 94,
                TestId = 7
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 95,
                TestId = 7
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 96,
                TestId = 7
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 97,
                TestId = 7
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 98,
                TestId = 7
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 99,
                TestId = 7
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 100,
                TestId = 7
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }

        private List<QuestionTestMap> QuestionsTests8()
        {
            var questionTestMap1 = new QuestionTestMap()
            {
                QuestionId = 101,
                TestId = 8
            };

            var questionTestMap2 = new QuestionTestMap()
            {
                QuestionId = 102,
                TestId = 8
            };

            var questionTestMap3 = new QuestionTestMap()
            {
                QuestionId = 103,
                TestId = 8
            };

            var questionTestMap4 = new QuestionTestMap()
            {
                QuestionId = 104,
                TestId = 8
            };

            var questionTestMap5 = new QuestionTestMap()
            {
                QuestionId = 105,
                TestId = 8
            };

            var questionTestMap6 = new QuestionTestMap()
            {
                QuestionId = 106,
                TestId = 8
            };

            var questionTestMap7 = new QuestionTestMap()
            {
                QuestionId = 107,
                TestId = 8
            };

            var questionTestMap8 = new QuestionTestMap()
            {
                QuestionId = 108,
                TestId = 8
            };

            var questionTestMap9 = new QuestionTestMap()
            {
                QuestionId = 109,
                TestId = 8
            };

            var questionTestMap10 = new QuestionTestMap()
            {
                QuestionId = 110,
                TestId = 8
            };

            var questionTestMap11 = new QuestionTestMap()
            {
                QuestionId = 111,
                TestId = 8
            };

            var questionTestMap12 = new QuestionTestMap()
            {
                QuestionId = 112,
                TestId = 8
            };

            var questionTestMap13 = new QuestionTestMap()
            {
                QuestionId = 113,
                TestId = 8
            };

            var questionTestMap14 = new QuestionTestMap()
            {
                QuestionId = 114,
                TestId = 8
            };

            var questionTestMap15 = new QuestionTestMap()
            {
                QuestionId = 115,
                TestId = 8
            };


            return new List<QuestionTestMap>()
            {
                questionTestMap1,
                questionTestMap2,
                questionTestMap3,
                questionTestMap4,
                questionTestMap5,
                questionTestMap6,
                questionTestMap7,
                questionTestMap8,
                questionTestMap9,
                questionTestMap10,
                questionTestMap11,
                questionTestMap12,
                questionTestMap13,
                questionTestMap14,
                questionTestMap15
            };
        }
    }
}
