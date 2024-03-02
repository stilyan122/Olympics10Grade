namespace ElementFactory.Core.Extensions
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Core.Implementations.Repositories;
    using ElementFactory.Core.Implementations.Services;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Static class which seeds the correct services to the IoC container
    /// </summary>
    public static class WebApplicationBuilderExtensions
    {
        /// <summary>
        /// Method which seeds the services
        /// </summary>
        /// <param name="services">Services Container</param>
        public static void AddApplicationServices(this IServiceCollection 
            services)
        {
            services
                .AddScoped<IQuestionRepository, QuestionRepository>();

            services
                .AddScoped<ITestRepository, TestRepository>();

            services
                .AddScoped<IChemicalElementRepository, ChemicalElementRepository>();

            services
                .AddScoped<IQuestionTestMapRepository, QuestionTestMapRepository>();

            services
                .AddScoped<IAnswerRepository, AnswerRepository>();

            services
                .AddScoped<IQuestionService, QuestionService>();

            services
                .AddScoped<ITestService, TestService>();

            services
                .AddScoped<IChemicalElementService, ChemicalElementService>();

            services
                .AddScoped<IQuestionTestMapService, QuestionTestMapService>();

            services
                .AddScoped<IAnswerService, AnswerService>();
        }
    }
}
