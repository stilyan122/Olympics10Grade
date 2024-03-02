namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Class for configuration of Answer Entity
    /// </summary>
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        /// <summary>
        /// Method for configuring the entities
        /// </summary>
        /// <param name="builder">The builder used for configuring</param>
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .OnDelete(DeleteBehavior.Cascade);

            var answers = this.Answers1();
            answers.AddRange(this.Answers2());
            answers.AddRange(this.Answers3());
            answers.AddRange(this.Answers4());
            answers.AddRange(this.Answers6());
            answers.AddRange(this.Answers7());
            answers.AddRange(this.Answers8());

            builder.HasData(answers);
        }

        /// <summary>
        /// Methods for the separate answers
        /// </summary>

        private List<Answer> Answers1()
        {
            // ============================================= //
            // Question 1.1 //

            var answer1_1 = new Answer()
            {
                Id = 1,
                QuestionId = 1,
                Value = "Втора А"
            };

            var answer1_2 = new Answer()
            {
                Id = 2,
                QuestionId = 1,
                Value = "Седма А"
            };

            var answer1_3 = new Answer()
            {
                Id = 3,
                QuestionId = 1,
                Value = "Първа А"
            };

            var answer1_4 = new Answer()
            {
                Id = 4,
                QuestionId = 1,
                Value = "Първа Б"
            };

            // ============================================= //
            // Question 1.2 //

            var answer2_1 = new Answer()
            {
                Id = 5,
                QuestionId = 2,
                Value = "Неметал"
            };

            var answer2_2 = new Answer()
            {
                Id = 6,
                QuestionId = 2,
                Value = "Метал"
            };

            var answer2_3 = new Answer()
            {
                Id = 7,
                QuestionId = 2,
                Value = "Нито едно от изброените"
            };

            var answer2_4 = new Answer()
            {
                Id = 8,
                QuestionId = 2,
                Value = "Алкалоземен метал"
            };

            // ============================================= //
            // Question 1.3 //

            var answer3_1 = new Answer()
            {
                Id = 9,
                QuestionId = 3,
                Value = "Неметали, киселини, вода"
            };

            var answer3_2 = new Answer()
            {
                Id = 10,
                QuestionId = 3,
                Value = "Основни оксиди, киселини, вода"
            };

            var answer3_3 = new Answer()
            {
                Id = 11,
                QuestionId = 3,
                Value = "Основи, киселини, метали"
            };

            var answer3_4 = new Answer()
            {
                Id = 12,
                QuestionId = 3,
                Value = "Киселинни оксиди, основи, соли"
            };

            // ============================================= //
            // Question 1.4 //

            var answer4_1 = new Answer()
            {
                Id = 13,
                QuestionId = 4,
                Value = "Na2O"
            };

            var answer4_2 = new Answer()
            {
                Id = 14,
                QuestionId = 4,
                Value = "Na2O + H2"
            };

            var answer4_3 = new Answer()
            {
                Id = 15,
                QuestionId = 4,
                Value = "NaOH + H2"
            };

            var answer4_4 = new Answer()
            {
                Id = 16,
                QuestionId = 4,
                Value = "NaOH + H2O"
            };

            // ============================================= //
            // Question 1.5 //

            var answer5_1 = new Answer()
            {
                Id = 17,
                QuestionId = 5,
                Value = "За да не взаимодейства с азота от въздуха"
            };

            var answer5_2 = new Answer()
            {
                Id = 18,
                QuestionId = 5,
                Value = "За да не взаимодейства с кислорода от въздуха"
            };

            var answer5_3 = new Answer()
            {
                Id = 19,
                QuestionId = 5,
                Value = "За да не отрови въздуха наоколо"
            };

            var answer5_4 = new Answer()
            {
                Id = 20,
                QuestionId = 5,
                Value = "За да не се изпари"
            };

            // ============================================= //
            // Question 1.6 //

            var answer6_1 = new Answer()
            {
                Id = 21,
                QuestionId = 6,
                Value = "NaCl"
            };

            var answer6_2 = new Answer()
            {
                Id = 22,
                QuestionId = 6,
                Value = "Na2CO3"
            };

            var answer6_3 = new Answer()
            {
                Id = 23,
                QuestionId = 6,
                Value = "Na2O2"
            };

            var answer6_4 = new Answer()
            {
                Id = 24,
                QuestionId = 6,
                Value = "NaOH"
            };

            // ============================================= //
            // Question 1.7 //

            var answer7_1 = new Answer()
            {
                Id = 25,
                QuestionId = 7,
                Value = "Син"
            };

            var answer7_2 = new Answer()
            {
                Id = 26,
                QuestionId = 7,
                Value = "Зелен"
            };

            var answer7_3 = new Answer()
            {
                Id = 27,
                QuestionId = 7,
                Value = "Жълт"
            };

            var answer7_4 = new Answer()
            {
                Id = 28,
                QuestionId = 7,
                Value = "Виолетов"
            };

            // ============================================= //
            // Question 1.8 //

            var answer8_1 = new Answer()
            {
                Id = 29,
                QuestionId = 8,
                Value = "NaOH"
            };

            var answer8_2 = new Answer()
            {
                Id = 30,
                QuestionId = 8,
                Value = "Na2O"
            };

            var answer8_3 = new Answer()
            {
                Id = 31,
                QuestionId = 8,
                Value = "NaCl"
            };

            var answer8_4 = new Answer()
            {
                Id = 32,
                QuestionId = 8,
                Value = "NaNO3"
            };


            // ============================================= //
            // Question 1.9 //

            var answer9_1 = new Answer()
            {
                Id = 33,
                QuestionId = 9,
                Value = "Na+ и OH-"
            };

            var answer9_2 = new Answer()
            {
                Id = 34,
                QuestionId = 9,
                Value = "2Na+ и OH-"
            };

            var answer9_3 = new Answer()
            {
                Id = 35,
                QuestionId = 9,
                Value = "Na+ и 2O-"
            };

            var answer9_4 = new Answer()
            {
                Id = 36,
                QuestionId = 9,
                Value = "Na+ и OH+"
            };

            // ============================================= //
            // Question 1.10 //

            var answer10_1 = new Answer()
            {
                Id = 37,
                QuestionId = 10,
                Value = "1"
            };

            var answer10_2 = new Answer()
            {
                Id = 38,
                QuestionId = 10,
                Value = "2"
            };

            var answer10_3 = new Answer()
            {
                Id = 39,
                QuestionId = 10,
                Value = "3"
            };

            var answer10_4 = new Answer()
            {
                Id = 40,
                QuestionId = 10,
                Value = "4"
            };

            // ============================================= //
            // Question 1.11 //

            var answer11_1 = new Answer()
            {
                Id = 41,
                QuestionId = 11,
                Value = "В червено"
            };

            var answer11_2 = new Answer()
            {
                Id = 42,
                QuestionId = 11,
                Value = "В малиновочервено"
            };

            var answer11_3 = new Answer()
            {
                Id = 43,
                QuestionId = 11,
                Value = "В синьо"
            };

            var answer11_4 = new Answer()
            {
                Id = 44,
                QuestionId = 11,
                Value = "В жълто"
            };

            // ============================================= //
            // Question 1.12 //

            var answer12_1 = new Answer()
            {
                Id = 45,
                QuestionId = 12,
                Value = "K"
            };

            var answer12_2 = new Answer()
            {
                Id = 46,
                QuestionId = 12,
                Value = "Li"
            };

            var answer12_3 = new Answer()
            {
                Id = 47,
                QuestionId = 12,
                Value = "Rb"
            };

            var answer12_4 = new Answer()
            {
                Id = 48,
                QuestionId = 12,
                Value = "Cs"
            };

            // ============================================= //
            // Question 1.13 //

            var answer13_1 = new Answer()
            {
                Id = 49,
                QuestionId = 13,
                Value = "Вярно"
            };

            var answer13_2 = new Answer()
            {
                Id = 50,
                QuestionId = 13,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 1.14 //

            var answer14_1 = new Answer()
            {
                Id = 51,
                QuestionId = 14,
                Value = "Натриев хидрид"
            };

            var answer14_2 = new Answer()
            {
                Id = 52,
                QuestionId = 14,
                Value = "Натриев хидроксид"
            };

            var answer14_3 = new Answer()
            {
                Id = 53,
                QuestionId = 14,
                Value = "Натриев хидрат"
            };

            var answer14_4 = new Answer()
            {
                Id = 54,
                QuestionId = 14,
                Value = "Натриев хемоглобин"
            };

            // ============================================= //
            // Question 1.15 //

            var answer15_1 = new Answer()
            {
                Id = 55,
                QuestionId = 15,
                Value = "Приготвяне на физиологичен разтвор"
            };

            var answer15_2 = new Answer()
            {
                Id = 56,
                QuestionId = 15,
                Value = "Производство на сапуни"
            };

            var answer15_3 = new Answer()
            {
                Id = 57,
                QuestionId = 15,
                Value = "Промивка след изгаряне"
            };

            var answer15_4 = new Answer()
            {
                Id = 58,
                QuestionId = 15,
                Value = "Хранително-вкусова промишленост"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,
                answer6_3,
                answer6_4,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,
                answer9_3,
                answer9_4,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,
                answer12_3,
                answer12_4,

                // Question 1.13
                answer13_1,
                answer13_2,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
                answer15_3,
                answer15_4,
            };
        }

        private List<Answer> Answers2()
        {
            // ============================================= //
            // Question 2.1 //

            var answer1_1 = new Answer()
            {
                Id = 59,
                QuestionId = 16,
                Value = "Червено-кафяв"
            };

            var answer1_2 = new Answer()
            {
                Id = 60,
                QuestionId = 16,
                Value = "Виолетов"
            };

            var answer1_3 = new Answer()
            {
                Id = 61,
                QuestionId = 16,
                Value = "Бледосин"
            };

            var answer1_4 = new Answer()
            {
                Id = 62,
                QuestionId = 16,
                Value = "Жълто-зелен"
            };

            // ============================================= //
            // Question 2.2 //

            var answer2_1 = new Answer()
            {
                Id = 63,
                QuestionId = 17,
                Value = "H2Cl"
            };

            var answer2_2 = new Answer()
            {
                Id = 64,
                QuestionId = 17,
                Value = "HCl2"
            };

            var answer2_3 = new Answer()
            {
                Id = 65,
                QuestionId = 17,
                Value = "H2Cl2"
            };

            var answer2_4 = new Answer()
            {
                Id = 66,
                QuestionId = 17,
                Value = "HCl"
            };

            // ============================================= //
            // Question 2.3 //

            var answer3_1 = new Answer()
            {
                Id = 67,
                QuestionId = 18,
                Value = "HCl и HCl3"
            };

            var answer3_2 = new Answer()
            {
                Id = 68,
                QuestionId = 18,
                Value = "HCl и HClO"
            };

            var answer3_3 = new Answer()
            {
                Id = 69,
                QuestionId = 18,
                Value = "HCl3 и H3Cl2"
            };

            var answer3_4 = new Answer()
            {
                Id = 70,
                QuestionId = 18,
                Value = "HCl2 и HClO"
            };

            // ============================================= //
            // Question 2.4 //

            var answer4_1 = new Answer()
            {
                Id = 71,
                QuestionId = 19,
                Value = "NaCl"
            };

            var answer4_2 = new Answer()
            {
                Id = 72,
                QuestionId = 19,
                Value = "NaOH"
            };

            var answer4_3 = new Answer()
            {
                Id = 73,
                QuestionId = 19,
                Value = "H2O"
            };

            var answer4_4 = new Answer()
            {
                Id = 74,
                QuestionId = 19,
                Value = "H2"
            };

            // ============================================= //
            // Question 2.5 //

            var answer5_1 = new Answer()
            {
                Id = 75,
                QuestionId = 20,
                Value = "Натриев хлорид"
            };

            var answer5_2 = new Answer()
            {
                Id = 76,
                QuestionId = 20,
                Value = "Натриев хлорат"
            };

            var answer5_3 = new Answer()
            {
                Id = 77,
                QuestionId = 20,
                Value = "Натриев хипохлорид"
            };

            var answer5_4 = new Answer()
            {
                Id = 78,
                QuestionId = 20,
                Value = "Натриев хипохлорит"
            };

            // ============================================= //
            // Question 2.6 //

            var answer6_1 = new Answer()
            {
                Id = 79,
                QuestionId = 21,
                Value = "Осма А"
            };

            var answer6_2 = new Answer()
            {
                Id = 80,
                QuestionId = 21,
                Value = "Шеста А"
            };

            var answer6_3 = new Answer()
            {
                Id = 81,
                QuestionId = 21,
                Value = "Седма А"
            };

            var answer6_4 = new Answer()
            {
                Id = 82,
                QuestionId = 21,
                Value = "Пета А"
            };

            // ============================================= //
            // Question 2.7 //

            var answer7_1 = new Answer()
            {
                Id = 83,
                QuestionId = 22,
                Value = "Не се променя"
            };

            var answer7_2 = new Answer()
            {
                Id = 84,
                QuestionId = 22,
                Value = "Малиновочервен"
            };

            var answer7_3 = new Answer()
            {
                Id = 85,
                QuestionId = 22,
                Value = "Виолетов"
            };

            var answer7_4 = new Answer()
            {
                Id = 86,
                QuestionId = 22,
                Value = "Син"
            };

            // ============================================= //
            // Question 2.8 //

            var answer8_1 = new Answer()
            {
                Id = 87,
                QuestionId = 23,
                Value = "Сода каустик"
            };

            var answer8_2 = new Answer()
            {
                Id = 88,
                QuestionId = 23,
                Value = "Бертолетова сол"
            };

            var answer8_3 = new Answer()
            {
                Id = 89,
                QuestionId = 23,
                Value = "Готварска сол"
            };

            var answer8_4 = new Answer()
            {
                Id = 90,
                QuestionId = 23,
                Value = "Белина"
            };

            // ============================================= //
            // Question 2.9 //

            var answer9_1 = new Answer()
            {
                Id = 91,
                QuestionId = 24,
                Value = "1"
            };

            var answer9_2 = new Answer()
            {
                Id = 92,
                QuestionId = 24,
                Value = "2"
            };

            var answer9_3 = new Answer()
            {
                Id = 93,
                QuestionId = 24,
                Value = "3"
            };

            var answer9_4 = new Answer()
            {
                Id = 94,
                QuestionId = 24,
                Value = "4"
            };

            // ============================================= //
            // Question 2.10 //

            var answer10_1 = new Answer()
            {
                Id = 95,
                QuestionId = 25,
                Value = "Отрицателен със заряд 1-"
            };

            var answer10_2 = new Answer()
            {
                Id = 96,
                QuestionId = 25,
                Value = "Отрицателен със заряд 2-"
            };

            var answer10_3 = new Answer()
            {
                Id = 97,
                QuestionId = 25,
                Value = "Положителен със заряд 1+"
            };

            var answer10_4 = new Answer()
            {
                Id = 98,
                QuestionId = 25,
                Value = "Положителен със заряд 2+"
            };

            // ============================================= //
            // Question 2.11 //

            var answer11_1 = new Answer()
            {
                Id = 99,
                QuestionId = 26,
                Value = "Перхлорати"
            };

            var answer11_2 = new Answer()
            {
                Id = 100,
                QuestionId = 26,
                Value = "Хлорати"
            };

            var answer11_3 = new Answer()
            {
                Id = 101,
                QuestionId = 26,
                Value = "Хлорити"
            };

            var answer11_4 = new Answer()
            {
                Id = 102,
                QuestionId = 26,
                Value = "Хлориди"
            };

            // ============================================= //
            // Question 2.12 //

            var answer12_1 = new Answer()
            {
                Id = 103,
                QuestionId = 27,
                Value = "1"
            };

            var answer12_2 = new Answer()
            {
                Id = 104,
                QuestionId = 27,
                Value = "2"
            };

            var answer12_3 = new Answer()
            {
                Id = 105,
                QuestionId = 27,
                Value = "3"
            };

            var answer12_4 = new Answer()
            {
                Id = 106,
                QuestionId = 27,
                Value = "4"
            };

            // ============================================= //
            // Question 2.13 //

            var answer13_1 = new Answer()
            {
                Id = 107,
                QuestionId = 28,
                Value = "H + Cl"
            };

            var answer13_2 = new Answer()
            {
                Id = 108,
                QuestionId = 28,
                Value = "H2O + Cl2"
            };

            var answer13_3 = new Answer()
            {
                Id = 109,
                QuestionId = 28,
                Value = "Cl + OH"
            };

            var answer13_4 = new Answer()
            {
                Id = 110,
                QuestionId = 28,
                Value = "HCl + O"
            };

            // ============================================= //
            // Question 2.14 //

            var answer14_1 = new Answer()
            {
                Id = 111,
                QuestionId = 29,
                Value = "Вярно"
            };

            var answer14_2 = new Answer()
            {
                Id = 112,
                QuestionId = 29,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 2.15 //

            var answer15_1 = new Answer()
            {
                Id = 113,
                QuestionId = 30,
                Value = "Производство на фойерверки"
            };

            var answer15_2 = new Answer()
            {
                Id = 114,
                QuestionId = 30,
                Value = "Дезинфекция на водите"
            };

            var answer15_3 = new Answer()
            {
                Id = 115,
                QuestionId = 30,
                Value = "Хранително-вкусовата промишленост"
            };

            var answer15_4 = new Answer()
            {
                Id = 116,
                QuestionId = 30,
                Value = "Производство на мебели"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,
                answer6_3,
                answer6_4,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,
                answer9_3,
                answer9_4,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,
                answer12_3,
                answer12_4,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                
                // Question 1.15
                answer15_1,
                answer15_2,
                answer15_3,
                answer15_4,
            };
        }

        private List<Answer> Answers3()
        {
            // ============================================= //
            // Question 3.1 //

            var answer1_1 = new Answer()
            {
                Id = 117,
                QuestionId = 31,
                Value = "Алкален метал"
            };

            var answer1_2 = new Answer()
            {
                Id = 118,
                QuestionId = 31,
                Value = "Алкалоземен метал"
            };

            var answer1_3 = new Answer()
            {
                Id = 119,
                QuestionId = 31,
                Value = "Халоген"
            };

            var answer1_4 = new Answer()
            {
                Id = 120,
                QuestionId = 31,
                Value = "Преходен метал"
            };

            // ============================================= //
            // Question 3.2 //

            var answer2_1 = new Answer()
            {
                Id = 121,
                QuestionId = 32,
                Value = "Молекулен"
            };

            var answer2_2 = new Answer()
            {
                Id = 122,
                QuestionId = 32,
                Value = "Йонен"
            };

            var answer2_3 = new Answer()
            {
                Id = 123,
                QuestionId = 32,
                Value = "Кристален"
            };

            var answer2_4 = new Answer()
            {
                Id = 124,
                QuestionId = 32,
                Value = "Атомен"
            };

            // ============================================= //
            // Question 3.3 //

            var answer3_1 = new Answer()
            {
                Id = 125,
                QuestionId = 33,
                Value = "1"
            };

            var answer3_2 = new Answer()
            {
                Id = 126,
                QuestionId = 33,
                Value = "2"
            };

            var answer3_3 = new Answer()
            {
                Id = 127,
                QuestionId = 33,
                Value = "3"
            };

            var answer3_4 = new Answer()
            {
                Id = 128,
                QuestionId = 33,
                Value = "4"
            };

            // ============================================= //
            // Question 3.4 //

            var answer4_1 = new Answer()
            {
                Id = 129,
                QuestionId = 34,
                Value = "Гасена вар"
            };

            var answer4_2 = new Answer()
            {
                Id = 130,
                QuestionId = 34,
                Value = "Негасена вар"
            };

            var answer4_3 = new Answer()
            {
                Id = 131,
                QuestionId = 34,
                Value = "Бистра варна вода (БВВ)"
            };

            var answer4_4 = new Answer()
            {
                Id = 132,
                QuestionId = 34,
                Value = "Син камък"
            };

            // ============================================= //
            // Question 3.5 //

            var answer5_1 = new Answer()
            {
                Id = 133,
                QuestionId = 35,
                Value = "Втора А"
            };

            var answer5_2 = new Answer()
            {
                Id = 134,
                QuestionId = 35,
                Value = "Първа Б"
            };

            var answer5_3 = new Answer()
            {
                Id = 135,
                QuestionId = 35,
                Value = "Седма А"
            };

            var answer5_4 = new Answer()
            {
                Id = 136,
                QuestionId = 35,
                Value = "Втора Б"
            };

            // ============================================= //
            // Question 3.6 //

            var answer6_1 = new Answer()
            {
                Id = 137,
                QuestionId = 36,
                Value = "CaH2"
            };

            var answer6_2 = new Answer()
            {
                Id = 138,
                QuestionId = 36,
                Value = "CaO2"
            };

            var answer6_3 = new Answer()
            {
                Id = 139,
                QuestionId = 36,
                Value = "Ca(OH)2"
            };

            var answer6_4 = new Answer()
            {
                Id = 140,
                QuestionId = 36,
                Value = "CaO"
            };

            // ============================================= //
            // Question 3.7 //

            var answer7_1 = new Answer()
            {
                Id = 141,
                QuestionId = 37,
                Value = "Ca(OH)2"
            };

            var answer7_2 = new Answer()
            {
                Id = 142,
                QuestionId = 37,
                Value = "Ca(OH)2 и H2"
            };

            var answer7_3 = new Answer()
            {
                Id = 143,
                QuestionId = 37,
                Value = "CaOH и H2"
            };

            var answer7_4 = new Answer()
            {
                Id = 144,
                QuestionId = 37,
                Value = "CaOH"
            };

            // ============================================= //
            // Question 3.8 //

            var answer8_1 = new Answer()
            {
                Id = 145,
                QuestionId = 38,
                Value = "Основа"
            };

            var answer8_2 = new Answer()
            {
                Id = 146,
                QuestionId = 38,
                Value = "Калция не взаимодейства с киселини"
            };

            var answer8_3 = new Answer()
            {
                Id = 147,
                QuestionId = 38,
                Value = "Киселина"
            };

            var answer8_4 = new Answer()
            {
                Id = 148,
                QuestionId = 38,
                Value = "Сол"
            };

            // ============================================= //
            // Question 3.9 //

            var answer9_1 = new Answer()
            {
                Id = 149,
                QuestionId = 39,
                Value = "Вярно"
            };

            var answer9_2 = new Answer()
            {
                Id = 150,
                QuestionId = 39,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 3.10 //

            var answer10_1 = new Answer()
            {
                Id = 151,
                QuestionId = 40,
                Value = "Киселинен"
            };

            var answer10_2 = new Answer()
            {
                Id = 152,
                QuestionId = 40,
                Value = "Основен"
            };

            var answer10_3 = new Answer()
            {
                Id = 153,
                QuestionId = 40,
                Value = "Неутрален"
            };

            var answer10_4 = new Answer()
            {
                Id = 154,
                QuestionId = 40,
                Value = "Смесен"
            };

            // ============================================= //
            // Question 3.11 //

            var answer11_1 = new Answer()
            {
                Id = 155,
                QuestionId = 41,
                Value = "CaO + H2O => CaOH + H2"
            };

            var answer11_2 = new Answer()
            {
                Id = 156,
                QuestionId = 41,
                Value = "Ca + 2HCl => CaCl + 2H"
            };

            var answer11_3 = new Answer()
            {
                Id = 157,
                QuestionId = 41,
                Value = "Ca + H2 => 2CaH"
            };

            var answer11_4 = new Answer()
            {
                Id = 158,
                QuestionId = 41,
                Value = "Ca + 2H2O => Ca(OH)2+H2"
            };

            // ============================================= //
            // Question 3.12 //

            var answer12_1 = new Answer()
            {
                Id = 159,
                QuestionId = 42,
                Value = "Вярно"
            };

            var answer12_2 = new Answer()
            {
                Id = 160,
                QuestionId = 42,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 3.13 //

            var answer13_1 = new Answer()
            {
                Id = 161,
                QuestionId = 43,
                Value = "Бял"
            };

            var answer13_2 = new Answer()
            {
                Id = 162,
                QuestionId = 43,
                Value = "Керемиденочервен"
            };

            var answer13_3 = new Answer()
            {
                Id = 163,
                QuestionId = 43,
                Value = "Син"
            };

            var answer13_4 = new Answer()
            {
                Id = 164,
                QuestionId = 43,
                Value = "Зелен"
            };

            // ============================================= //
            // Question 3.14 //

            var answer14_1 = new Answer()
            {
                Id = 165,
                QuestionId = 44,
                Value = "Ca(OH)2 с вода"
            };

            var answer14_2 = new Answer()
            {
                Id = 166,
                QuestionId = 44,
                Value = "Ca с киселина"
            };

            var answer14_3 = new Answer()
            {
                Id = 167,
                QuestionId = 44,
                Value = "CaCO3 с киселина"
            };

            var answer14_4 = new Answer()
            {
                Id = 168,
                QuestionId = 44,
                Value = "Ca с киселинен оксид"
            };

            // ============================================= //
            // Question 3.15 //

            var answer15_1 = new Answer()
            {
                Id = 169,
                QuestionId = 45,
                Value = "4"
            };

            var answer15_2 = new Answer()
            {
                Id = 170,
                QuestionId = 45,
                Value = "7"
            };

            var answer15_3 = new Answer()
            {
                Id = 171,
                QuestionId = 45,
                Value = "2"
            };

            var answer15_4 = new Answer()
            {
                Id = 172,
                QuestionId = 45,
                Value = "11"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,
                answer6_3,
                answer6_4,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
                answer15_3,
                answer15_4,
            };
        }

        private List<Answer> Answers4()
        {
            // ============================================= //
            // Question 4.1 //

            var answer1_1 = new Answer()
            {
                Id = 173,
                QuestionId = 46,
                Value = "C6H6, C6H5OH, CO3"
            };

            var answer1_2 = new Answer()
            {
                Id = 174,
                QuestionId = 46,
                Value = "CO2, C6H12O6, C3H5(OH)3"
            };

            var answer1_3 = new Answer()
            {
                Id = 175,
                QuestionId = 46,
                Value = "CO, CO2, H2CO3, Na2CO3"
            };

            var answer1_4 = new Answer()
            {
                Id = 176,
                QuestionId = 46,
                Value = "CO, H2CO3, C2H4(ONa)2"
            };

            // ============================================= //
            // Question 4.2 //

            var answer2_1 = new Answer()
            {
                Id = 177,
                QuestionId = 47,
                Value = "1"
            };

            var answer2_2 = new Answer()
            {
                Id = 178,
                QuestionId = 47,
                Value = "2"
            };

            var answer2_3 = new Answer()
            {
                Id = 179,
                QuestionId = 47,
                Value = "3"
            };

            var answer2_4 = new Answer()
            {
                Id = 180,
                QuestionId = 47,
                Value = "4"
            };

            // ============================================= //
            // Question 4.3 //

            var answer3_1 = new Answer()
            {
                Id = 181,
                QuestionId = 48,
                Value = "ВВ, които съдържат само прости връзки"
            };

            var answer3_2 = new Answer()
            {
                Id = 182,
                QuestionId = 48,
                Value = "ВВ, които съдържат поне една сложна връзка"
            };

            var answer3_3 = new Answer()
            {
                Id = 183,
                QuestionId = 48,
                Value = "ВВ с по-сложен строеж, които са циклични"
            };

            var answer3_4 = new Answer()
            {
                Id = 184,
                QuestionId = 48,
                Value = "ВВ, които съдържат само сложни връзки"
            };

            // ============================================= //
            // Question 4.4 //

            var answer4_1 = new Answer()
            {
                Id = 185,
                QuestionId = 49,
                Value = "CH4"
            };

            var answer4_2 = new Answer()
            {
                Id = 186,
                QuestionId = 49,
                Value = "CO2"
            };

            var answer4_3 = new Answer()
            {
                Id = 187,
                QuestionId = 49,
                Value = "CO"
            };

            var answer4_4 = new Answer()
            {
                Id = 188,
                QuestionId = 49,
                Value = "C2H2"
            };

            // ============================================= //
            // Question 4.5 //

            var answer5_1 = new Answer()
            {
                Id = 189,
                QuestionId = 50,
                Value = "Вярно"
            };

            var answer5_2 = new Answer()
            {
                Id = 190,
                QuestionId = 50,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 4.6 //

            var answer6_1 = new Answer()
            {
                Id = 191,
                QuestionId = 51,
                Value = "Вярно"
            };

            var answer6_2 = new Answer()
            {
                Id = 192,
                QuestionId = 51,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 4.7 //

            var answer7_1 = new Answer()
            {
                Id = 193,
                QuestionId = 52,
                Value = "C10H22"
            };

            var answer7_2 = new Answer()
            {
                Id = 194,
                QuestionId = 52,
                Value = "C9H18"
            };

            var answer7_3 = new Answer()
            {
                Id = 195,
                QuestionId = 52,
                Value = "C9H16"
            };

            var answer7_4 = new Answer()
            {
                Id = 196,
                QuestionId = 52,
                Value = "C9H20"
            };

            // ============================================= //
            // Question 4.8 //

            var answer8_1 = new Answer()
            {
                Id = 197,
                QuestionId = 53,
                Value = "CnH2n"
            };

            var answer8_2 = new Answer()
            {
                Id = 198,
                QuestionId = 53,
                Value = "CnH2n+2"
            };

            var answer8_3 = new Answer()
            {
                Id = 199,
                QuestionId = 53,
                Value = "CnH2n-2"
            };

            var answer8_4 = new Answer()
            {
                Id = 200,
                QuestionId = 53,
                Value = "CnHn"
            };

            // ============================================= //
            // Question 4.9 //

            var answer9_1 = new Answer()
            {
                Id = 201,
                QuestionId = 54,
                Value = "Вярно"
            };

            var answer9_2 = new Answer()
            {
                Id = 202,
                QuestionId = 54,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 4.10 //

            var answer10_1 = new Answer()
            {
                Id = 203,
                QuestionId = 55,
                Value = "Висока температура"
            };

            var answer10_2 = new Answer()
            {
                Id = 204,
                QuestionId = 55,
                Value = "Високо налягане"
            };

            var answer10_3 = new Answer()
            {
                Id = 205,
                QuestionId = 55,
                Value = "Катализатор (Ni)"
            };

            var answer10_4 = new Answer()
            {
                Id = 206,
                QuestionId = 55,
                Value = "И трите изброени"
            };

            // ============================================= //
            // Question 4.11 //

            var answer11_1 = new Answer()
            {
                Id = 207,
                QuestionId = 56,
                Value = "Прости връзки"
            };

            var answer11_2 = new Answer()
            {
                Id = 208,
                QuestionId = 56,
                Value = "Въглеродни атоми"
            };

            var answer11_3 = new Answer()
            {
                Id = 209,
                QuestionId = 56,
                Value = "Водородни атоми"
            };

            var answer11_4 = new Answer()
            {
                Id = 210,
                QuestionId = 56,
                Value = "Сложни връзки"
            };

            // ============================================= //
            // Question 4.12 //

            var answer12_1 = new Answer()
            {
                Id = 211,
                QuestionId = 57,
                Value = "Бойл Мариот"
            };

            var answer12_2 = new Answer()
            {
                Id = 212,
                QuestionId = 57,
                Value = "Марковников"
            };

            var answer12_3 = new Answer()
            {
                Id = 213,
                QuestionId = 57,
                Value = "Аристотел"
            };

            var answer12_4 = new Answer()
            {
                Id = 214,
                QuestionId = 57,
                Value = "Менделеев"
            };

            // ============================================= //
            // Question 4.13 //

            var answer13_1 = new Answer()
            {
                Id = 215,
                QuestionId = 58,
                Value = "Ni"
            };

            var answer13_2 = new Answer()
            {
                Id = 216,
                QuestionId = 58,
                Value = "Hg2+"
            };

            var answer13_3 = new Answer()
            {
                Id = 217,
                QuestionId = 58,
                Value = "CCl4"
            };

            var answer13_4 = new Answer()
            {
                Id = 218,
                QuestionId = 58,
                Value = "Pb(CH3COO)2"
            };

            // ============================================= //
            // Question 4.14 //

            var answer14_1 = new Answer()
            {
                Id = 219,
                QuestionId = 59,
                Value = "Толуен и HNO3 в излишък"
            };

            var answer14_2 = new Answer()
            {
                Id = 220,
                QuestionId = 59,
                Value = "Фенол и HNO3"
            };

            var answer14_3 = new Answer()
            {
                Id = 221,
                QuestionId = 59,
                Value = "Бензен и HNO3"
            };

            var answer14_4 = new Answer()
            {
                Id = 222,
                QuestionId = 59,
                Value = "Бензен и нитратни соли"
            };

            // ============================================= //
            // Question 4.15 //

            var answer15_1 = new Answer()
            {
                Id = 223,
                QuestionId = 60,
                Value = "Ацеталдехид"
            };

            var answer15_2 = new Answer()
            {
                Id = 224,
                QuestionId = 60,
                Value = "Бензен и 2Na"
            };

            var answer15_3 = new Answer()
            {
                Id = 225,
                QuestionId = 60,
                Value = "Феноксиден анион и водороден катион"
            };

            var answer15_4 = new Answer()
            {
                Id = 226,
                QuestionId = 60,
                Value = "Натриев феноксид и 1/2 H2"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,

                // Question 1.6
                answer6_1,
                answer6_2,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,
                answer12_3,
                answer12_4,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
                answer15_3,
                answer15_4,
            };
        }

        private List<Answer> Answers6()
        {
            // ============================================= //
            // Question 6.1 //

            var answer1_1 = new Answer()
            {
                Id = 227,
                QuestionId = 71,
                Value = "Вода и разтварящо се вещество"
            };

            var answer1_2 = new Answer()
            {
                Id = 228,
                QuestionId = 71,
                Value = "Течен разтворител и захар"
            };

            var answer1_3 = new Answer()
            {
                Id = 229,
                QuestionId = 71,
                Value = "Разтворител и разтварящо се вещество"
            };

            var answer1_4 = new Answer()
            {
                Id = 230,
                QuestionId = 71,
                Value = "Нито едно от изброените"
            };

            // ============================================= //
            // Question 6.2 //

            var answer2_1 = new Answer()
            {
                Id = 231,
                QuestionId = 72,
                Value = "\"Йони се разтварят в йони\""
            };

            var answer2_2 = new Answer()
            {
                Id = 232,
                QuestionId = 72,
                Value = "\"В разтвор с ниска концентрация се разтваря вещество с висока концентрация\""
            };

            var answer2_3 = new Answer()
            {
                Id = 233,
                QuestionId = 72,
                Value = "\"Подобни се разтварят в подобни\""
            };

            var answer2_4 = new Answer()
            {
                Id = 234,
                QuestionId = 72,
                Value = "\"Всеки разтвор е смес от вода и друго вещество с по-висока концентрация\""
            };

            // ============================================= //
            // Question 6.3 //

            var answer3_1 = new Answer()
            {
                Id = 235,
                QuestionId = 73,
                Value = "Молекулни и йонни"
            };

            var answer3_2 = new Answer()
            {
                Id = 236,
                QuestionId = 73,
                Value = "Течни и твърди"
            };

            var answer3_3 = new Answer()
            {
                Id = 237,
                QuestionId = 73,
                Value = "Соли, основи и киселини"
            };

            var answer3_4 = new Answer()
            {
                Id = 238,
                QuestionId = 73,
                Value = "Според частиците на разтвореното вещество не се разглеждат различни по видове разтвори"
            };

            // ============================================= //
            // Question 6.4 //

            var answer4_1 = new Answer()
            {
                Id = 239,
                QuestionId = 74,
                Value = "Солватация, дифузия, разграждане на кристалната решетка (ако има такава)"
            };

            var answer4_2 = new Answer()
            {
                Id = 240,
                QuestionId = 74,
                Value = "Разграждане на кристалната решетка (ако има такава), солватация, дифузия"
            };

            var answer4_3 = new Answer()
            {
                Id = 241,
                QuestionId = 74,
                Value = "Дифузия, разграждане на кристалната решетка (ако има такава), солватация"
            };

            var answer4_4 = new Answer()
            {
                Id = 242,
                QuestionId = 74,
                Value = "Разграждане на кристалната решетка (ако има такава), дифузия, солватация"
            };

            // ============================================= //
            // Question 6.5 //

            var answer5_1 = new Answer()
            {
                Id = 243,
                QuestionId = 75,
                Value = "Йонизация"
            };

            var answer5_2 = new Answer()
            {
                Id = 244,
                QuestionId = 75,
                Value = "Солватация"
            };

            var answer5_3 = new Answer()
            {
                Id = 245,
                QuestionId = 75,
                Value = "Дифузия"
            };

            var answer5_4 = new Answer()
            {
                Id = 246,
                QuestionId = 75,
                Value = "Кристализация"
            };

            // ============================================= //
            // Question 6.6 //

            var answer6_1 = new Answer()
            {
                Id = 247,
                QuestionId = 76,
                Value = "Вярно"
            };

            var answer6_2 = new Answer()
            {
                Id = 248,
                QuestionId = 76,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 6.7 //

            var answer7_1 = new Answer()
            {
                Id = 249,
                QuestionId = 77,
                Value = "m(р-р) = M(А) * n(р-р)"
            };

            var answer7_2 = new Answer()
            {
                Id = 250,
                QuestionId = 77,
                Value = "S(А) = m(А) / 100g(р-р)"
            };

            var answer7_3 = new Answer()
            {
                Id = 251,
                QuestionId = 77,
                Value = "W(А) = m(А) / m(р-р)"
            };

            var answer7_4 = new Answer()
            {
                Id = 252,
                QuestionId = 77,
                Value = "C(А) = n(А) / V"
            };

            // ============================================= //
            // Question 6.8 //

            var answer8_1 = new Answer()
            {
                Id = 253,
                QuestionId = 78,
                Value = "1 милиметър"
            };

            var answer8_2 = new Answer()
            {
                Id = 254,
                QuestionId = 78,
                Value = "1 нанометър"
            };

            var answer8_3 = new Answer()
            {
                Id = 255,
                QuestionId = 78,
                Value = "1 микрон"
            };

            var answer8_4 = new Answer()
            {
                Id = 256,
                QuestionId = 78,
                Value = "1 метър"
            };

            // ============================================= //
            // Question 6.9 //

            var answer9_1 = new Answer()
            {
                Id = 257,
                QuestionId = 79,
                Value = "Вярно"
            };

            var answer9_2 = new Answer()
            {
                Id = 258,
                QuestionId = 79,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 6.10 //

            var answer10_1 = new Answer()
            {
                Id = 259,
                QuestionId = 80,
                Value = "Дифузия, понижаване на парното налягане, осмоза"
            };

            var answer10_2 = new Answer()
            {
                Id = 260,
                QuestionId = 80,
                Value = "Повишаването на температурата на замръзване, понижаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза"
            };

            var answer10_3 = new Answer()
            {
                Id = 261,
                QuestionId = 80,
                Value = "Понижаването на температурата на замръзване, повишаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза"
            };

            var answer10_4 = new Answer()
            {
                Id = 262,
                QuestionId = 80,
                Value = "Дифузия, повишаване на парното налягане, осмоза"
            };

            // ============================================= //
            // Question 6.11 //

            var answer11_1 = new Answer()
            {
                Id = 263,
                QuestionId = 81,
                Value = "π = 3*i*c*R"
            };

            var answer11_2 = new Answer()
            {
                Id = 264,
                QuestionId = 81,
                Value = "π = i*c*R*T"
            };

            var answer11_3 = new Answer()
            {
                Id = 265,
                QuestionId = 81,
                Value = "2*π = i*c*R*T"
            };

            var answer11_4 = new Answer()
            {
                Id = 266,
                QuestionId = 81,
                Value = "π^2 = i*c*R*T"
            };

            // ============================================= //
            // Question 6.12 //

            var answer12_1 = new Answer()
            {
                Id = 267,
                QuestionId = 82,
                Value = "Хипертоничен"
            };

            var answer12_2 = new Answer()
            {
                Id = 268,
                QuestionId = 82,
                Value = "Хипотоничен"
            };

            var answer12_3 = new Answer()
            {
                Id = 269,
                QuestionId = 82,
                Value = "Изотоничен"
            };

            var answer12_4 = new Answer()
            {
                Id = 270,
                QuestionId = 82,
                Value = "Разтвор на електролит"
            };

            // ============================================= //
            // Question 6.13 //

            var answer13_1 = new Answer()
            {
                Id = 271,
                QuestionId = 83,
                Value = "C6H12O6, Cl2, Al(OH)3, Na2CO3"
            };

            var answer13_2 = new Answer()
            {
                Id = 272,
                QuestionId = 83,
                Value = "AlCl3, захар, Sr(OH)2, NaCl"
            };

            var answer13_3 = new Answer()
            {
                Id = 273,
                QuestionId = 83,
                Value = "C6H6, S, KOH, CaCO3"
            };

            var answer13_4 = new Answer()
            {
                Id = 274,
                QuestionId = 83,
                Value = "CuSO4, NaOH, H2O, Ca(OH)2"
            };

            // ============================================= //
            // Question 6.14 //

            var answer14_1 = new Answer()
            {
                Id = 275,
                QuestionId = 84,
                Value = "Наситени, преситени, ненаситени"
            };

            var answer14_2 = new Answer()
            {
                Id = 276,
                QuestionId = 84,
                Value = "Силни и слаби"
            };

            var answer14_3 = new Answer()
            {
                Id = 277,
                QuestionId = 84,
                Value = "Средни, слаби, силни"
            };

            var answer14_4 = new Answer()
            {
                Id = 278,
                QuestionId = 84,
                Value = "Електролитни и неелектролитни"
            };

            // ============================================= //
            // Question 6.15 //

            var answer15_1 = new Answer()
            {
                Id = 279,
                QuestionId = 85,
                Value = "Вярно"
            };

            var answer15_2 = new Answer()
            {
                Id = 280,
                QuestionId = 85,
                Value = "Грешно"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,
                answer12_3,
                answer12_4,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
            };
        }

        private List<Answer> Answers7()
        {
            // ============================================= //
            // Question 7.1 //

            var answer1_1 = new Answer()
            {
                Id = 281,
                QuestionId = 86,
                Value = "Na+"
            };

            var answer1_2 = new Answer()
            {
                Id = 282,
                QuestionId = 86,
                Value = "Ne"
            };

            var answer1_3 = new Answer()
            {
                Id = 283,
                QuestionId = 86,
                Value = "Al3+"
            };

            var answer1_4 = new Answer()
            {
                Id = 284,
                QuestionId = 86,
                Value = "F-"
            };

            // ============================================= //
            // Question 7.2 //

            var answer2_1 = new Answer()
            {
                Id = 285,
                QuestionId = 87,
                Value = "Състояние, което се определя от стойностите на квантовите числа n, l и m"
            };

            var answer2_2 = new Answer()
            {
                Id = 286,
                QuestionId = 87,
                Value = "Функция, която описва електроните в една атомна система"
            };

            var answer2_3 = new Answer()
            {
                Id = 287,
                QuestionId = 87,
                Value = "Вероятността за намиране на електрона в пространството около ядрото"
            };

            var answer2_4 = new Answer()
            {
                Id = 288,
                QuestionId = 87,
                Value = "Част от пространството, което е около самото ядро, в която шансът за намиране на електрона е приблизително 90%"
            };

            // ============================================= //
            // Question 7.3 //

            var answer3_1 = new Answer()
            {
                Id = 289,
                QuestionId = 88,
                Value = "Вярно"
            };

            var answer3_2 = new Answer()
            {
                Id = 290,
                QuestionId = 88,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 7.4 //

            var answer4_1 = new Answer()
            {
                Id = 291,
                QuestionId = 89,
                Value = "CO2, BeH2, N2"
            };

            var answer4_2 = new Answer()
            {
                Id = 292,
                QuestionId = 89,
                Value = "HBr, CO2, N2"
            };

            var answer4_3 = new Answer()
            {
                Id = 293,
                QuestionId = 89,
                Value = "NH3, H2О, N2"
            };

            var answer4_4 = new Answer()
            {
                Id = 294,
                QuestionId = 89,
                Value = "H2О, CH4, O2"
            };

            // ============================================= //
            // Question 7.5 //

            var answer5_1 = new Answer()
            {
                Id = 295,
                QuestionId = 90,
                Value = "То е сумата от броя на елементарните частици"
            };

            var answer5_2 = new Answer()
            {
                Id = 296,
                QuestionId = 90,
                Value = "То е равно на сумата от броя на електроните и неутроните"
            };

            var answer5_3 = new Answer()
            {
                Id = 297,
                QuestionId = 90,
                Value = "То е равно на сумата от броя на протоните и неутроните"
            };

            var answer5_4 = new Answer()
            {
                Id = 298,
                QuestionId = 90,
                Value = "Според него химичният елемент е смес от изотопи"
            };

            // ============================================= //
            // Question 7.6 //

            var answer6_1 = new Answer()
            {
                Id = 299,
                QuestionId = 91,
                Value = "Вярно"
            };

            var answer6_2 = new Answer()
            {
                Id = 300,
                QuestionId = 91,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 7.7 //

            var answer7_1 = new Answer()
            {
                Id = 301,
                QuestionId = 92,
                Value = "CO2, N2, H2O"
            };

            var answer7_2 = new Answer()
            {
                Id = 302,
                QuestionId = 92,
                Value = "H2O, CO2, N2"
            };

            var answer7_3 = new Answer()
            {
                Id = 303,
                QuestionId = 92,
                Value = "PCl3, H2O, C2H6"
            };

            var answer7_4 = new Answer()
            {
                Id = 304,
                QuestionId = 92,
                Value = "C2H2, N2, CO2"
            };

            // ============================================= //
            // Question 7.8 //

            var answer8_1 = new Answer()
            {
                Id = 305,
                QuestionId = 93,
                Value = "CaH2, PCl5, H2S"
            };

            var answer8_2 = new Answer()
            {
                Id = 306,
                QuestionId = 93,
                Value = "NH3, AgCl, CH4"
            };

            var answer8_3 = new Answer()
            {
                Id = 307,
                QuestionId = 93,
                Value = "NaH, K2O, BaCl2"
            };

            var answer8_4 = new Answer()
            {
                Id = 308,
                QuestionId = 93,
                Value = "H2O, H2SO4, HCl"
            };

            // ============================================= //
            // Question 7.9 //

            var answer9_1 = new Answer()
            {
                Id = 309,
                QuestionId = 94,
                Value = "Вярно"
            };

            var answer9_2 = new Answer()
            {
                Id = 310,
                QuestionId = 94,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 7.10 //

            var answer10_1 = new Answer()
            {
                Id = 311,
                QuestionId = 95,
                Value = "sp"
            };

            var answer10_2 = new Answer()
            {
                Id = 312,
                QuestionId = 95,
                Value = "sp^3d"
            };

            var answer10_3 = new Answer()
            {
                Id = 313,
                QuestionId = 95,
                Value = "sp3"
            };

            var answer10_4 = new Answer()
            {
                Id = 314,
                QuestionId = 95,
                Value = "sp^3d^2"
            };

            // ============================================= //
            // Question 7.11 //

            var answer11_1 = new Answer()
            {
                Id = 315,
                QuestionId = 96,
                Value = "F и Li"
            };

            var answer11_2 = new Answer()
            {
                Id = 316,
                QuestionId = 96,
                Value = "Na и F"
            };

            var answer11_3 = new Answer()
            {
                Id = 317,
                QuestionId = 96,
                Value = "H и Ca"
            };

            var answer11_4 = new Answer()
            {
                Id = 318,
                QuestionId = 96,
                Value = "F и O"
            };

            // ============================================= //
            // Question 7.12 //

            var answer12_1 = new Answer()
            {
                Id = 319,
                QuestionId = 97,
                Value = "Вярно"
            };

            var answer12_2 = new Answer()
            {
                Id = 320,
                QuestionId = 97,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 7.13 //

            var answer13_1 = new Answer()
            {
                Id = 321,
                QuestionId = 98,
                Value = "Метална"
            };

            var answer13_2 = new Answer()
            {
                Id = 322,
                QuestionId = 98,
                Value = "Атомна"
            };

            var answer13_3 = new Answer()
            {
                Id = 323,
                QuestionId = 98,
                Value = "Молекулна"
            };

            var answer13_4 = new Answer()
            {
                Id = 324,
                QuestionId = 98,
                Value = "Йонна"
            };

            // ============================================= //
            // Question 7.14 //

            var answer14_1 = new Answer()
            {
                Id = 325,
                QuestionId = 99,
                Value = "PCl5"
            };

            var answer14_2 = new Answer()
            {
                Id = 326,
                QuestionId = 99,
                Value = "CO2"
            };

            var answer14_3 = new Answer()
            {
                Id = 327,
                QuestionId = 99,
                Value = "SF6"
            };

            var answer14_4 = new Answer()
            {
                Id = 328,
                QuestionId = 99,
                Value = "H2O"
            };

            // ============================================= //
            // Question 7.15 //

            var answer15_1 = new Answer()
            {
                Id = 329,
                QuestionId = 100,
                Value = "Вярно"
            };

            var answer15_2 = new Answer()
            {
                Id = 330,
                QuestionId = 100,
                Value = "Грешно"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,
                answer5_3,
                answer5_4,

                // Question 1.6
                answer6_1,
                answer6_2,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,
                answer8_3,
                answer8_4,

                // Question 1.9
                answer9_1,
                answer9_2,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
            };
        }

        private List<Answer> Answers8()
        {
            // ============================================= //
            // Question 8.1 //

            var answer1_1 = new Answer()
            {
                Id = 331,
                QuestionId = 101,
                Value = "0.8 mol"
            };

            var answer1_2 = new Answer()
            {
                Id = 332,
                QuestionId = 101,
                Value = "0.2 mol"
            };

            var answer1_3 = new Answer()
            {
                Id = 333,
                QuestionId = 101,
                Value = "6.0 mol"
            };

            var answer1_4 = new Answer()
            {
                Id = 334,
                QuestionId = 101,
                Value = "2.0 mol"
            };

            // ============================================= //
            // Question 8.2 //

            var answer2_1 = new Answer()
            {
                Id = 335,
                QuestionId = 102,
                Value = "се поглъща топлина, ΔH < 0 и продуктите са по-стабилни"
            };

            var answer2_2 = new Answer()
            {
                Id = 336,
                QuestionId = 102,
                Value = "се отделя топлина, ΔH < 0 и продуктите са по-стабилни"
            };

            var answer2_3 = new Answer()
            {
                Id = 337,
                QuestionId = 102,
                Value = "се отделя топлина, ΔH > 0 и реагентите са по-стабилни"
            };

            var answer2_4 = new Answer()
            {
                Id = 338,
                QuestionId = 102,
                Value = "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни"
            };

            // ============================================= //
            // Question 8.3 //

            var answer3_1 = new Answer()
            {
                Id = 339,
                QuestionId = 103,
                Value = "-1374 kJ/mol"
            };

            var answer3_2 = new Answer()
            {
                Id = 340,
                QuestionId = 103,
                Value = "837 kJ/mol"
            };

            var answer3_3 = new Answer()
            {
                Id = 341,
                QuestionId = 103,
                Value = "-837 kJ/mol"
            };

            var answer3_4 = new Answer()
            {
                Id = 342,
                QuestionId = 103,
                Value = "1374 kJ/mol"
            };

            // ============================================= //
            // Question 8.4 //

            var answer4_1 = new Answer()
            {
                Id = 343,
                QuestionId = 104,
                Value = "F = U - T*S"
            };

            var answer4_2 = new Answer()
            {
                Id = 344,
                QuestionId = 104,
                Value = "H = U + p*V"
            };

            var answer4_3 = new Answer()
            {
                Id = 345,
                QuestionId = 104,
                Value = "S = R * lnW"
            };

            var answer4_4 = new Answer()
            {
                Id = 346,
                QuestionId = 104,
                Value = "G = H - T*S"
            };

            // ============================================= //
            // Question 8.5 //

            var answer5_1 = new Answer()
            {
                Id = 347,
                QuestionId = 105,
                Value = "Вярно"
            };

            var answer5_2 = new Answer()
            {
                Id = 348,
                QuestionId = 105,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 8.6 //

            var answer6_1 = new Answer()
            {
                Id = 349,
                QuestionId = 106,
                Value = "v = k * c(S) * c(O2)"
            };

            var answer6_2 = new Answer()
            {
                Id = 350,
                QuestionId = 106,
                Value = "v = k * c^2(O2)"
            };

            var answer6_3 = new Answer()
            {
                Id = 351,
                QuestionId = 106,
                Value = "v = k * c(O2)"
            };

            var answer6_4 = new Answer()
            {
                Id = 352,
                QuestionId = 106,
                Value = "v = k * c(S)"
            };

            // ============================================= //
            // Question 8.7 //

            var answer7_1 = new Answer()
            {
                Id = 353,
                QuestionId = 107,
                Value = "Ще се понижи два пъти"
            };

            var answer7_2 = new Answer()
            {
                Id = 354,
                QuestionId = 107,
                Value = "Ще се понижи шест пъти"
            };

            var answer7_3 = new Answer()
            {
                Id = 355,
                QuestionId = 107,
                Value = "Ще се понижи четири пъти"
            };

            var answer7_4 = new Answer()
            {
                Id = 356,
                QuestionId = 107,
                Value = "Ще се понижи осем пъти"
            };

            // ============================================= //
            // Question 8.8 //

            var answer8_1 = new Answer()
            {
                Id = 357,
                QuestionId = 108,
                Value = "Вярно"
            };

            var answer8_2 = new Answer()
            {
                Id = 358,
                QuestionId = 108,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 8.9 //

            var answer9_1 = new Answer()
            {
                Id = 359,
                QuestionId = 109,
                Value = "Ензимите се отличават от химичните катализатори по своята чувствителност и специфичност"
            };

            var answer9_2 = new Answer()
            {
                Id = 360,
                QuestionId = 109,
                Value = "Скоростта на ензимно-каталитичните процеси не зависи от концентрацията на ензима"
            };

            var answer9_3 = new Answer()
            {
                Id = 361,
                QuestionId = 109,
                Value = "Ензимите притежават общите свойства на катализаторите"
            };

            var answer9_4 = new Answer()
            {
                Id = 362,
                QuestionId = 109,
                Value = "Върху ензимната активност оказва влияние температурата"
            };

            // ============================================= //
            // Question 8.10 //

            var answer10_1 = new Answer()
            {
                Id = 363,
                QuestionId = 110,
                Value = "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/z*F"
            };

            var answer10_2 = new Answer()
            {
                Id = 364,
                QuestionId = 110,
                Value = "Масата на веществото m, което се отделя на електродите, е правопропорционална на големината на тока, протекъл през електролита, и времето, за което протича: m = k*I*t"
            };

            var answer10_3 = new Answer()
            {
                Id = 365,
                QuestionId = 110,
                Value = "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/F"
            };

            var answer10_4 = new Answer()
            {
                Id = 366,
                QuestionId = 110,
                Value = "Нито едно от изброените"
            };

            // ============================================= //
            // Question 8.11 //

            var answer11_1 = new Answer()
            {
                Id = 367,
                QuestionId = 111,
                Value = "Готварска сол"
            };

            var answer11_2 = new Answer()
            {
                Id = 368,
                QuestionId = 111,
                Value = "Етанол"
            };

            var answer11_3 = new Answer()
            {
                Id = 369,
                QuestionId = 111,
                Value = "Калиева основа"
            };

            var answer11_4 = new Answer()
            {
                Id = 370,
                QuestionId = 111,
                Value = "Сярна киселина"
            };

            // ============================================= //
            // Question 8.12 //

            var answer12_1 = new Answer()
            {
                Id = 371,
                QuestionId = 112,
                Value = "Вярно"
            };

            var answer12_2 = new Answer()
            {
                Id = 372,
                QuestionId = 112,
                Value = "Грешно"
            };

            // ============================================= //
            // Question 8.13 //

            var answer13_1 = new Answer()
            {
                Id = 373,
                QuestionId = 113,
                Value = "Ca2+"
            };

            var answer13_2 = new Answer()
            {
                Id = 374,
                QuestionId = 113,
                Value = "S2-"
            };

            var answer13_3 = new Answer()
            {
                Id = 375,
                QuestionId = 113,
                Value = "Na+"
            };

            var answer13_4 = new Answer()
            {
                Id = 376,
                QuestionId = 113,
                Value = "Al3+"
            };

            // ============================================= //
            // Question 8.14 //

            var answer14_1 = new Answer()
            {
                Id = 377,
                QuestionId = 114,
                Value = "CH3COOK, Na2S, C2H5OH"
            };

            var answer14_2 = new Answer()
            {
                Id = 378,
                QuestionId = 114,
                Value = "AlCl3, C6H5OH, H2SO4"
            };

            var answer14_3 = new Answer()
            {
                Id = 379,
                QuestionId = 114,
                Value = "KOH, K2CO3, K2SO4"
            };

            var answer14_4 = new Answer()
            {
                Id = 380,
                QuestionId = 114,
                Value = "Ca(OH)2, NH4OH, NaHCO3"
            };

            // ============================================= //
            // Question 8.15 //

            var answer15_1 = new Answer()
            {
                Id = 381,
                QuestionId = 115,
                Value = "Вярно"
            };

            var answer15_2 = new Answer()
            {
                Id = 382,
                QuestionId = 115,
                Value = "Грешно"
            };

            return new List<Answer>()
            {
                // Question 1.1
                answer1_1,
                answer1_2,
                answer1_3,
                answer1_4,

                // Question 1.2
                answer2_1,
                answer2_2,
                answer2_3,
                answer2_4,

                // Question 1.3
                answer3_1,
                answer3_2,
                answer3_3,
                answer3_4,

                // Question 1.4
                answer4_1,
                answer4_2,
                answer4_3,
                answer4_4,

                // Question 1.5
                answer5_1,
                answer5_2,

                // Question 1.6
                answer6_1,
                answer6_2,
                answer6_3,
                answer6_4,

                // Question 1.7
                answer7_1,
                answer7_2,
                answer7_3,
                answer7_4,

                // Question 1.8
                answer8_1,
                answer8_2,

                // Question 1.9
                answer9_1,
                answer9_2,
                answer9_3,
                answer9_4,

                // Question 1.10
                answer10_1,
                answer10_2,
                answer10_3,
                answer10_4,

                // Question 1.11
                answer11_1,
                answer11_2,
                answer11_3,
                answer11_4,

                // Question 1.12
                answer12_1,
                answer12_2,

                // Question 1.13
                answer13_1,
                answer13_2,
                answer13_3,
                answer13_4,

                // Question 1.14
                answer14_1,
                answer14_2,
                answer14_3,
                answer14_4,
                
                // Question 1.15
                answer15_1,
                answer15_2,
            };
        }
    }
}
