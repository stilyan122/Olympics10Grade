namespace ElementFactory.Data.Configurations
{
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Text.Json;


    /// <summary>
    /// Class for configuration of ChemicalType Entity
    /// </summary>
    public class ChemicalTypeConfiguration : IEntityTypeConfiguration<ChemicalType>
    {
        /// <summary>
        /// Method for configuring the entities
        /// </summary>
        /// <param name="builder">The builder used for configuring</param>
        public void Configure(EntityTypeBuilder<ChemicalType> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            string json = @"[{""Id"":1,""Name"":""Non-Metal"",""BulgarianName"":""Неметал""},{""Id"":2,""Name"":""Alkali Metal"",""BulgarianName"":""Алкален метал""},{""Id"":3,""Name"":""Alkaline Earth Metal"",""BulgarianName"":""Алкалоземен метал""},{""Id"":4,""Name"":""Transition Metal"",""BulgarianName"":""Преходен метал""},{""Id"":5,""Name"":""PostTransition Metal"",""BulgarianName"":""Други метали""},{""Id"":6,""Name"":""Halogen"",""BulgarianName"":""Халоген""},{""Id"":7,""Name"":""Noble gas"",""BulgarianName"":""Благороден газ""},{""Id"":8,""Name"":""Lanthanide"",""BulgarianName"":""Лантанид""},{""Id"":9,""Name"":""Actinide"",""BulgarianName"":""Актинид""},{""Id"":10,""Name"":""Metaloid"",""BulgarianName"":""Металоид""}]";

            ChemicalType?[] entities = JsonSerializer.Deserialize<ChemicalType?[]>(json);

            builder.HasData(entities);
        }
    }
}
