namespace ElementFactory.Data.Configuration
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Class for configuration of Question Entity
    /// </summary>
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        /// <summary>
        /// Method for configuring the entities
        /// </summary>
        /// <param name="builder">The builder used for configuring</param>
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasMany(q => q.QuestionsTests)
                   .WithOne(qtm => qtm.Question)
                   .HasForeignKey(qtm => qtm.QuestionId);

            var questions = this.Questions1();
            questions.AddRange(this.Questions2());
            questions.AddRange(this.Questions3());
            questions.AddRange(this.Questions4());
            questions.AddRange(this.Questions5());
            questions.AddRange(this.Questions6());
            questions.AddRange(this.Questions7());
            questions.AddRange(this.Questions8());

            builder.HasData(questions);
        }

        /// <summary>
        /// Methods for the separate questions
        /// </summary>
        /// 
        private List<Question> Questions1()
        {
            // ============================================= //
            // Test 1 //
            var question1_1 = new Question()
            {
                Id = 1,
                Description = "В коя група е химичният елемент Na?",
                RightAnswer = "Първа А",
                Answers = new List<Answer>()
            };

            var question1_2 = new Question()
            {
                Id = 2,
                Description = "Какво по характер е простото вещество на Na?",
                RightAnswer = "Метал",
                Answers = new List<Answer>()
            };

            var question1_3 = new Question()
            {
                Id = 3,
                Description = "Натрият взаимодейства със: ",
                RightAnswer = "Неметали, киселини, вода",
                Answers = new List<Answer>()
            };

            var question1_4 = new Question()
            {
                Id = 4,
                Description = "При взаимодействие на Na с вода се получава:",
                RightAnswer = "NaOH + H2",
                Answers = new List<Answer>()
            };

            var question1_5 = new Question()
            {
                Id = 5,
                Description = "Защо простото вещество Na се държи под петрол?",
                RightAnswer = "За да не взаимодейства с кислорода от въздуха",
                Answers = new List<Answer>()
            };

            var question1_6 = new Question()
            {
                Id = 6,
                Description = "Кое от химичните съединения на натрия е " +
                "по-познато в практиката като сода каустик?",
                RightAnswer = "NaOH",
                Answers = new List<Answer>()
            };

            var question1_7 = new Question()
            {
                Id = 7,
                Description = "С какъв пламък изгаря Na?",
                RightAnswer = "Жълт",
                Answers = new List<Answer>()
            };

            var question1_8 = new Question()
            {
                Id = 8,
                Description = "Кое от химичните съединения на Na се получава от реакция с" +
                " реактива AgNO3?",
                RightAnswer = "NaNO3",
                Answers = new List<Answer>()
            };

            var question1_9 = new Question()
            {
                Id = 9,
                Description = "При електролитна дисоциация на NaOH се получават: ",
                RightAnswer = "Na+ и OH-",
                Answers = new List<Answer>()
            };

            var question1_10 = new Question()
            {
                Id = 10,
                Description = "От коя валентност е Na?",
                RightAnswer = "1",
                Answers = new List<Answer>()
            };

            var question1_11 = new Question()
            {
                Id = 11,
                Description = "Ако в разтвор от NaOH внесем лакмус, то той се оцветява: ",
                RightAnswer = "В синьо",
                Answers = new List<Answer>()
            };

            var question1_12 = new Question()
            {
                Id = 12,
                Description = "Кое от следните прости вещества има " +
                "по-ниска реактивоспособност от натрия?",
                RightAnswer = "Li",
                Answers = new List<Answer>()
            };

            var question1_13 = new Question()
            {
                Id = 13,
                Description = "Водният разтвор на NaOH провежда електричен ток.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question1_14 = new Question()
            {
                Id = 14,
                Description = "Според UPAC химичното съединение \"NaH\" се нарича:",
                RightAnswer = "Натриев хидрид",
                Answers = new List<Answer>()
            };

            var question1_15 = new Question()
            {
                Id = 15,
                Description = "Кое е ГРЕШНОТО твърдение? Натрият / неговите съединения " +
                "се използват за:",
                RightAnswer = "Промивка след изгаряне",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question1_1,
                question1_2,
                question1_3,
                question1_4,
                question1_5,
                question1_6,
                question1_7,
                question1_8,
                question1_9,
                question1_10,
                question1_11,
                question1_12,
                question1_13,
                question1_14,
                question1_15
            };
        }

        private List<Question> Questions2()
        {
            // ============================================= //
            // Test 2 //
            var question2_1 = new Question()
            {
                Id = 16,
                Description = "Какъв цвят е простото вещество на Cl?",
                RightAnswer = "Жълто-зелен",
                Answers = new List<Answer>()
            };

            var question2_2 = new Question()
            {
                Id = 17,
                Description = "Какво се получава при взаимодействието на хлор с водород?",
                RightAnswer = "HCl",
                Answers = new List<Answer>()
            };

            var question2_3 = new Question()
            {
                Id = 18,
                Description = "Кои киселини се получават при директно " +
                "взаимодействие на хлор с вода?",
                RightAnswer = "HCl и HClO",
                Answers = new List<Answer>()
            };

            var question2_4 = new Question()
            {
                Id = 19,
                Description = "С кое от веществата хлорът НЕ взаимодейства?",
                RightAnswer = "NaCl",
                Answers = new List<Answer>()
            };

            var question2_5 = new Question()
            {
                Id = 20,
                Description = "Съединението NaClO се нарича:",
                RightAnswer = "Натриев хипохлорит",
                Answers = new List<Answer>()
            };

            var question2_6 = new Question()
            {
                Id = 21,
                Description = "От коя група е елементът хлор?",
                RightAnswer = "Седма А",
                Answers = new List<Answer>()
            };

            var question2_7 = new Question()
            {
                Id = 22,
                Description = "В какъв цвят се оцветява фенолфталеина при контакт с" +
                " водния разтвор на HCl?",
                RightAnswer = "Не се променя",
                Answers = new List<Answer>()
            };

            var question2_8 = new Question()
            {
                Id = 23,
                Description = "С какво име в практиката е известен NaClO?",
                RightAnswer = "Белина",
                Answers = new List<Answer>()
            };

            var question2_9 = new Question()
            {
                Id = 24,
                Description = "От колко атома се състои молекулата на хлора?",
                RightAnswer = "2",
                Answers = new List<Answer>()
            };

            var question2_10 = new Question()
            {
                Id = 25,
                Description = "В какъв йон се превръща атомът на хлора при реакция?",
                RightAnswer = "Отрицателен със заряд 1-",
                Answers = new List<Answer>()
            };

            var question2_11 = new Question()
            {
                Id = 26,
                Description = "Как се наричат солите на хлора?",
                RightAnswer = "Хлориди",
                Answers = new List<Answer>()
            };

            var question2_12 = new Question()
            {
                Id = 27,
                Description = "От коя валентност е хлорът в съединението си с водорода?",
                RightAnswer = "1",
                Answers = new List<Answer>()
            };

            var question2_13 = new Question()
            {
                Id = 28,
                Description = "Хипохлористата киселина се разлага до:",
                RightAnswer = "HCl + O",
                Answers = new List<Answer>()
            };

            var question2_14 = new Question()
            {
                Id = 29,
                Description = "Газът хлор има силен, приятен мирис.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question2_15 = new Question()
            {
                Id = 30,
                Description = "За какво се използва хлорът в практиката?",
                RightAnswer = "Дезинфекция на водите",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question2_1,
                question2_2,
                question2_3,
                question2_4,
                question2_5,
                question2_6,
                question2_7,
                question2_8,
                question2_9,
                question2_10,
                question2_11,
                question2_12,
                question2_13,
                question2_14,
                question2_15
            };
        }

        private List<Question> Questions3()
        {
            // ============================================= //
            // Test 3 //
            var question3_1 = new Question()
            {
                Id = 31,
                Description = "Простото вещество Ca е:",
                RightAnswer = "Алкалоземен метал",
                Answers = new List<Answer>()
            };

            var question3_2 = new Question()
            {
                Id = 32,
                Description = "С какъв строеж е простото вещество Ca?",
                RightAnswer = "Кристален",
                Answers = new List<Answer>()
            };

            var question3_3 = new Question()
            {
                Id = 33,
                Description = "С каква валентност участва в съединенията си Ca?",
                RightAnswer = "2",
                Answers = new List<Answer>()
            };

            var question3_4 = new Question()
            {
                Id = 34,
                Description = "Под какво име е известно съединението CaO?",
                RightAnswer = "Негасена вар",
                Answers = new List<Answer>()
            };

            var question3_5 = new Question()
            {
                Id = 35,
                Description = "В коя група е Ca?",
                RightAnswer = "Втора А",
                Answers = new List<Answer>()
            };

            var question3_6 = new Question()
            {
                Id = 36,
                Description = "При взаимодействието на Ca с кислород се получава:",
                RightAnswer = "CaO",
                Answers = new List<Answer>()
            };

            var question3_7 = new Question()
            {
                Id = 37,
                Description = "Реакцията \"Гасене на вар\" е реакция на CaO с вода, при която се получава/т:",
                RightAnswer = "Ca(OH)2",
                Answers = new List<Answer>()
            };

            var question3_8 = new Question()
            {
                Id = 38,
                Description = "При взаимодействие на Ca с халогеноводородна киселина се получава:",
                RightAnswer = "Сол",
                Answers = new List<Answer>()
            };

            var question3_9 = new Question()
            {
                Id = 39,
                Description = "Простото вещество Ca е газ с метален блясък и висока електропроводимост.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question3_10 = new Question()
            {
                Id = 40,
                Description = "Какъв характер проявява водният разтвор на калциевия дихидроксид?",
                RightAnswer = "Основен",
                Answers = new List<Answer>()
            };

            var question3_11 = new Question()
            {
                Id = 41,
                Description = "Кое от следните уравнения за Ca и неговите съединения е изравнено вярно?",
                RightAnswer = "Ca + 2H2O => Ca(OH)2+H2",
                Answers = new List<Answer>()
            };

            var question3_12 = new Question()
            {
                Id = 42,
                Description = "Ca се съхранява по петрол или инертен газ.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question3_13 = new Question()
            {
                Id = 43,
                Description = "Какъв е цветът на пламъка при горенето на Ca?",
                RightAnswer = "Керемиденочервен",
                Answers = new List<Answer>()
            };

            var question3_14 = new Question()
            {
                Id = 44,
                Description = "Реакцията \"Шумяща проба\" се наблюдава при взаимодействието на:",
                RightAnswer = "CaCO3 с киселина",
                Answers = new List<Answer>()
            };

            var question3_15 = new Question()
            {
                Id = 45,
                Description = "Разтворът на Ca(OH)2 е с pH:",
                RightAnswer = "11",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question3_1,
                question3_2,
                question3_3,
                question3_4,
                question3_5,
                question3_6,
                question3_7,
                question3_8,
                question3_9,
                question3_10,
                question3_11,
                question3_12,
                question3_13,
                question3_14,
                question3_15
            };
        }

        private List<Question> Questions4()
        {
            // ============================================= //
            // Test 4 //
            var question4_1 = new Question()
            {
                Id = 46,
                Description = "В кой от редовете са посочени само неорганични съединения:",
                RightAnswer = "CO, CO2, H2CO3, Na2CO3",
                Answers = new List<Answer>()
            };

            var question4_2 = new Question()
            {
                Id = 47,
                Description = "Каква валентност проявява C в неговите ОС?",
                RightAnswer = "4",
                Answers = new List<Answer>()
            };

            var question4_3 = new Question()
            {
                Id = 48,
                Description = "Кое е най-точното определение за ароматните ВВ?",
                RightAnswer = "ВВ с по-сложен строеж, които са циклични",
                Answers = new List<Answer>()
            };

            var question4_4 = new Question()
            {
                Id = 49,
                Description = "Кое от посочените съединения е известно под името \"Газ гризу\":",
                RightAnswer = "CH4",
                Answers = new List<Answer>()
            };

            var question4_5 = new Question()
            {
                Id = 50,
                Description = "\"Халогенирането\" на метан е заместителна реакция.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question4_6 = new Question()
            {
                Id = 51,
                Description = "Всяко ОС при взаимодействие с кислород (горене) се разлага до въглероден диоксид и вода",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question4_7 = new Question()
            {
                Id = 52,
                Description = "Кое от от следните съединения е нонан:",
                RightAnswer = "C9H20",
                Answers = new List<Answer>()
            };

            var question4_8 = new Question()
            {
                Id = 53,
                Description = "Каква е общата молекулна формула на алкените?",
                RightAnswer = "CnH2n",
                Answers = new List<Answer>()
            };

            var question4_9 = new Question()
            {
                Id = 54,
                Description = "Характерни за алкените са заместителните реакции, поради наличието на сложната двойна връзка.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question4_10 = new Question()
            {
                Id = 55,
                Description = "\"Хидрирането\" на алкени протича при наличието на:",
                RightAnswer = "И трите изброени",
                Answers = new List<Answer>()
            };

            var question4_11 = new Question()
            {
                Id = 56,
                Description = "Наличието на какво се доказва с разтвор на KMnO4?",
                RightAnswer = "Сложни връзки",
                Answers = new List<Answer>()
            };

            var question4_12 = new Question()
            {
                Id = 57,
                Description = "При присъединяването на полярни H-съдържащи " +
                "молекули към молекули на несиметрични алкени се спазва правилото на:",
                RightAnswer = "Марковников",
                Answers = new List<Answer>()
            };

            var question4_13 = new Question()
            {
                Id = 58,
                Description = "За да се спре реакцията на \"Хидриране\" на алкините, така че от алкин да се получи алкен, се използва катализатор:",
                RightAnswer = "Pb(CH3COO)2",
                Answers = new List<Answer>()
            };

            var question4_14 = new Question()
            {
                Id = 59,
                Description = "2,4,6-тринитротолуен (TNT) се получава при взаимодействието на:",
                RightAnswer = "Толуен и HNO3 в излишък",
                Answers = new List<Answer>()
            };

            var question4_15 = new Question()
            {
                Id = 60,
                Description = "При взаимодействието на фенол и натрий се получава:",
                RightAnswer = "Натриев феноксид и 1/2 H2",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question4_1,
                question4_2,
                question4_3,
                question4_4,
                question4_5,
                question4_6,
                question4_7,
                question4_8,
                question4_9,
                question4_10,
                question4_11,
                question4_12,
                question4_13,
                question4_14,
                question4_15
            };
        }

        private List<Question> Questions5()
        {
            // ============================================= //
            // Test 5 //
            var question5_1 = new Question()
            {
                Id = 61,
                Description = "Топлината на образуване на 1 мол хлороводород е 92.5kJ. " +
                "Какъв е топлинният ефект на реакцията: " +
                "H + Cl => HCl (Уравнението не е изравнено!) в kJ?",
                RightAnswer = "185",
                Answers = new List<Answer>()
            };

            var question5_2 = new Question()
            {
                Id = 62,
                Description = "Колко е температурата на образуване на ромбичната сяра в kJ?",
                RightAnswer = "0",
                Answers = new List<Answer>()
            };

            var question5_3 = new Question()
            {
                Id = 63,
                Description = "Изчислете топлината на образуване на NH3 според уравнението" +
                " в kJ, закръглено до първия знак след запетаята: N2 + 3H2 => 2NH3 + 92,4 kJ",
                RightAnswer = "46.2",
                Answers = new List<Answer>()
            };

            var question5_4 = new Question()
            {
                Id = 64,
                Description = "Ако температурата на образуване на водните пари е 242.5kJ," +
                " то тогава колко е температурата им на изгаряне, изчислена в" +
                " kJ и закръглена до първия знак след запетаята?",
                RightAnswer = "-242.5",
                Answers = new List<Answer>()
            };

            var question5_5 = new Question()
            {
                Id = 65,
                Description = "Ако температурата на образуване на " +
                "графита е 394.8kJ/mol, а на диаманта е 396.6kJ/mol, " +
                "то тогава колко ще бъде топлинният ефект при реакция " +
                "от вида \"графит => диамант\", измерена в kJ и закръглена" +
                " до първия знак след запетаята?",
                RightAnswer = "-1.8",
                Answers = new List<Answer>()
            };

            var question5_6 = new Question()
            {
                Id = 66,
                Description = @"Дадено:
                C6H6 + 15/2 O2 => 6CO2 + 3H20 + Q
                Q=3271kJ,
                Qобразуване(CO2) = 394kJ/mol,
                Qобразуване(H20) = 285.8kJ/mol
                Търсим:
                Qобразуване(C6H6) = ?kJ, закръглено до първия знак след запетаята.",
                RightAnswer = "-49.6",
                Answers = new List<Answer>()
            };

            var question5_7 = new Question()
            {
                Id = 67,
                Description = "Ако в хомогенния едностадиен процес " +
                "2CO + O2 => 2CO2 концентрацията на CO се увеличи " +
                "3 пъти при t = const, то с колко пъти новата скорост " +
                "ще е по-голяма от старата?",
                RightAnswer = "9",
                Answers = new List<Answer>()
            };

            var question5_8 = new Question()
            {
                Id = 68,
                Description = "2SO2(г) + O2(г) => 2SO3(г) + Q." +
                " Ако увеличим налягането на системата три пъти, " +
                "то с колко новата средна скорост на уравнението ще " +
                "бъде по-голяма от тази на началното уравнение?",
                RightAnswer = "27",
                Answers = new List<Answer>()
            };

            var question5_9 = new Question()
            {
                Id = 69,
                Description = "S(тв) + H2(г) => H2S(г) + 4.8kJ. " +
                "Изчислете количеството обменена топлина в kJ," +
                " закръглено до първия знак след запетаята, " +
                "ако 8 грама сяра реагират по даденото химично " +
                "уравнение (счита се, че M(S) = 32.0).",
                RightAnswer = "1.2",
                Answers = new List<Answer>()
            };

            var question5_10 = new Question()
            {
                Id = 70,
                Description = "Колко е температурата на изгаряне на SO3 в kJ/mol?",
                RightAnswer = "0",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question5_1,
                question5_2,
                question5_3,
                question5_4,
                question5_5,
                question5_6,
                question5_7,
                question5_8,
                question5_9,
                question5_10
            };
        }

        private List<Question> Questions6()
        {
            // ============================================= //
            // Test 6 //
            var question6_1 = new Question()
            {
                Id = 71,
                Description = "Кои са задължителните компоненти на истинските разтвори?",
                RightAnswer = "Разтворител и разтварящо се вещество",
                Answers = new List<Answer>()
            };

            var question6_2 = new Question()
            {
                Id = 72,
                Description = "По кое правило/закон се образуват разтворите?",
                RightAnswer = "\"Подобни се разтварят в подобни\"",
                Answers = new List<Answer>()
            };

            var question6_3 = new Question()
            {
                Id = 73,
                Description = "Според частиците на разтвореното вещество, разтворите биват:",
                RightAnswer = "Молекулни и йонни",
                Answers = new List<Answer>()
            };

            var question6_4 = new Question()
            {
                Id = 74,
                Description = "Коя е правилната последователност на процесите, през които минава механизмът на разтварянето?",
                RightAnswer = "Разграждане на кристалната решетка (ако има такава), солватация, дифузия",
                Answers = new List<Answer>()
            };

            var question6_5 = new Question()
            {
                Id = 75,
                Description = "Как се нарича обратната реакция на разтварянето, ако е погледнато като обратим проес?",
                RightAnswer = "Кристализация",
                Answers = new List<Answer>()
            };

            var question6_6 = new Question()
            {
                Id = 76,
                Description = "Видовете разтвори според състоянието им от състоянието на равновесие са само наситен и ненаситен.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question6_7 = new Question()
            {
                Id = 77,
                Description = "По коя от формулите НЕ можем да определим концентрацията на даден разтвор?",
                RightAnswer = "m(р-р) = M(А) * n(р-р)",
                Answers = new List<Answer>()
            };

            var question6_8 = new Question()
            {
                Id = 78,
                Description = "Разтворите са устойчиви системи, чиито размери на частиците НЕ надвишават:",
                RightAnswer = "1 нанометър",
                Answers = new List<Answer>()
            };

            var question6_9 = new Question()
            {
                Id = 79,
                Description = "Процесът на кристализация е съпроводен с положителен топлинен ефект (+Q1).",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question6_10 = new Question()
            {
                Id = 80,
                Description = "На кой ред са изброени всички общи свойства на разтворите?",
                RightAnswer = "Понижаването на температурата на замръзване, повишаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза",
                Answers = new List<Answer>()
            };

            var question6_11 = new Question()
            {
                Id = 81,
                Description = "Коя е най-точната формула за определяне на осмотичното налягане?",
                RightAnswer = "π = i*c*R*T",
                Answers = new List<Answer>()
            };

            var question6_12 = new Question()
            {
                Id = 82,
                Description = "Ако имаме една кръвна клетка, на която цитозолът е с концентрация 0.9%, а кръвта около нея е с концентрация," +
                " по-висока от 1.2%, то спрямо клетката разтворът в околната среда (кръвта) ще бъде:",
                RightAnswer = "Хипертоничен",
                Answers = new List<Answer>()
            };

            var question6_13 = new Question()
            {
                Id = 83,
                Description = "На кой ред всички изброени вещества са електролити?",
                RightAnswer = "CuSO4, NaOH, H2O, Ca(OH)2",
                Answers = new List<Answer>()
            };

            var question6_14 = new Question()
            {
                Id = 84,
                Description = "Какви видове разтвори има според степента на електролитна дисоциация?",
                RightAnswer = "Средни, слаби, силни",
                Answers = new List<Answer>()
            };

            var question6_15 = new Question()
            {
                Id = 85,
                Description = "Водата е електролит.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question6_1,
                question6_2,
                question6_3,
                question6_4,
                question6_5,
                question6_6,
                question6_7,
                question6_8,
                question6_9,
                question6_10,
                question6_11,
                question6_12,
                question6_13,
                question6_14,
                question6_15
            };
        }

        private List<Question> Questions7()
        {
            // ============================================= //
            // Test 7 //
            var question7_1 = new Question()
            {
                Id = 86,
                Description = "Коя от частиците е с най-малък атомен радиус?",
                RightAnswer = "Al3+",
                Answers = new List<Answer>()
            };

            var question7_2 = new Question()
            {
                Id = 87,
                Description = "Кое е най-точното определение на \"Електронен облак\"?",
                RightAnswer = "Част от пространството, което е около самото ядро, в която шансът за намиране на електрона е приблизително 90%",
                Answers = new List<Answer>()
            };

            var question7_3 = new Question()
            {
                Id = 88,
                Description = "Атомните орбитали с едно и също главно и орбитално квантово число образуват електронен слой.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question7_4 = new Question()
            {
                Id = 89,
                Description = "В коя група всички означени вещества са с неполярни молекули?",
                RightAnswer = "CO2, BeH2, N2",
                Answers = new List<Answer>()
            };

            var question7_5 = new Question()
            {
                Id = 90,
                Description = "Кое от следните твърдения е вярно за масовото число?",
                RightAnswer = "То е равно на сумата от броя на протоните и неутроните",
                Answers = new List<Answer>()
            };

            var question7_6 = new Question()
            {
                Id = 91,
                Description = "Здравината на ковалентната връзка нараства с увеличаване на нейната кратност.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question7_7 = new Question()
            {
                Id = 92,
                Description = "В кой от редовете са изброени само вещества, в които има кратна ковалентна връзка?",
                RightAnswer = "C2H2, N2, CO2",
                Answers = new List<Answer>()
            };

            var question7_8 = new Question()
            {
                Id = 93,
                Description = "В кой от редовете са изброени само вещества с йонна химична връзка?",
                RightAnswer = "NaH, K2O, BaCl2",
                Answers = new List<Answer>()
            };

            var question7_9 = new Question()
            {
                Id = 94,
                Description = "π-връзка може да се образува между еднакви по вид атоми.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question7_10 = new Question()
            {
                Id = 95,
                Description = "В молекулата на CS2 каква е хибридизацията на централния атом?",
                RightAnswer = "sp",
                Answers = new List<Answer>()
            };

            var question7_11 = new Question()
            {
                Id = 96,
                Description = "Коя от двойките елементи не се свързва с йонна връзка?",
                RightAnswer = "F и O",
                Answers = new List<Answer>()
            };

            var question7_12 = new Question()
            {
                Id = 97,
                Description = "Еквивалентните атомни орбитали се заемат първоначално от двойни електрони с паралелни спинове.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question7_13 = new Question()
            {
                Id = 98,
                Description = "За веществото X е известно, че има висока температура на топене, ковко е и не се разтваря във вода. Какъв е видът на кристалната решетка на това вещество?",
                RightAnswer = "Метална",
                Answers = new List<Answer>()
            };

            var question7_14 = new Question()
            {
                Id = 99,
                Description = "На кое от изброените вещества хибридизацията на централния атом е sp^3d^2?",
                RightAnswer = "SF6",
                Answers = new List<Answer>()
            };

            var question7_15 = new Question()
            {
                Id = 100,
                Description = "Йонизационната енергия характеризира редукционната активност на атомите.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question7_1,
                question7_2,
                question7_3,
                question7_4,
                question7_5,
                question7_6,
                question7_7,
                question7_8,
                question7_9,
                question7_10,
                question7_11,
                question7_12,
                question7_13,
                question7_14,
                question7_15
            };
        }

        private List<Question> Questions8()
        {
            // ============================================= //
            // Test 8 //
            var question8_1 = new Question()
            {
                Id = 101,
                Description = "Количеството вещество, което съответства на 5.6г азот, е:",
                RightAnswer = "0.2 mol",
                Answers = new List<Answer>()
            };

            var question8_2 = new Question()
            {
                Id = 102,
                Description = "Кое от твърденията за ендотермични реакции е вярно? При ендотермични реакции:",
                RightAnswer = "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни",
                Answers = new List<Answer>()
            };
            
            var question8_3 = new Question()
            {
                Id = 103,
                Description = "При изгарянето на 9 грама алуминий, като знаете че M(Al) = 27g/mol, в кислородна среда се отделят 229kJ топлина. Това означава, че стандартната енталпия на образуване на диалуминиевия триоксид е равна на:",
                RightAnswer = "-1374 kJ/mol",
                Answers = new List<Answer>()
            };

            var question8_4 = new Question()
            {
                Id = 104,
                Description = "Термохимичната функция \"Енергия на Гибс\" се дефинира чрез:",
                RightAnswer = "G = H - T*S",
                Answers = new List<Answer>()
            };

            var question8_5 = new Question()
            {
                Id = 105,
                Description = "Ентропията расте, когато се преминава от едно по-неподредено към по-подредено състояние.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question8_6 = new Question()
            {
                Id = 106,
                Description = "Ако приемем, че реакцията протича по уравнението: S(тв.) + O2(г.) => SO2(г.), то кинетичното уравнение за процеса е:",
                RightAnswer = "v = k * c(O2)",
                Answers = new List<Answer>()
            };

            var question8_7 = new Question()
            {
                Id = 107,
                Description = "Кинетичното уравнение на химичен процес е v = k * c(A) * c^2(B). Как ще се промени скоростта на процеса при понижаване на налягането два пъти?",
                RightAnswer = "Ще се понижи осем пъти",
                Answers = new List<Answer>()
            };

            var question8_8 = new Question()
            {
                Id = 108,
                Description = "Ендотермичните процеси не могат да протичат спонтанно.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            var question8_9 = new Question()
            {
                Id = 109,
                Description = "Кое от твърденията НЕ е вярно?",
                RightAnswer = "Ензимите притежават общите свойства на катализаторите",
                Answers = new List<Answer>()
            };

            var question8_10 = new Question()
            {
                Id = 110,
                Description = "Кое от следните определения описва \"Вторият закон на Фарадей\"",
                RightAnswer = "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/z*F",
                Answers = new List<Answer>()
            };

            var question8_11 = new Question()
            {
                Id = 111,
                Description = "При еднаква молна концентрация и температура = const, най-високото осмотично налягане от посочените по-долу има разтворът на:",
                RightAnswer = "Сярна киселина",
                Answers = new List<Answer>()
            };

            var question8_12 = new Question()
            {
                Id = 112,
                Description = "При ΔG < 0 реакцията протича спонтанно, а при ΔG = 0 системата се намира в динамично равновесие.",
                RightAnswer = "Вярно",
                Answers = new List<Answer>()
            };

            var question8_13 = new Question()
            {
                Id = 113,
                Description = "При взаимодействие на 1cm^3 1M разтвор на калиев хлорид и 1cm^3 0.1M разтвор на сребърен нитрат е получен зол. Най-бързата коагулация на колоидния разтвор могат да предизвикат:",
                RightAnswer = "Al3+",
                Answers = new List<Answer>()
            };

            var question8_14 = new Question()
            {
                Id = 114,
                Description = "В коя от групите всички означени вещества оцветяват лакмуса в синьо?",
                RightAnswer = "Ca(OH)2, NH4OH, NaHCO3",
                Answers = new List<Answer>()
            };

            var question8_15 = new Question()
            {
                Id = 115,
                Description = "Адсорбтив е вещество, което задържа на повърхността си други вещества.",
                RightAnswer = "Грешно",
                Answers = new List<Answer>()
            };

            return new List<Question>()
            {
                question8_1,
                question8_2,
                question8_3,
                question8_4,
                question8_5,
                question8_6,
                question8_7,
                question8_8,
                question8_9,
                question8_10,
                question8_11,
                question8_12,
                question8_13,
                question8_14,
                question8_15
            };
        }
    }
}
