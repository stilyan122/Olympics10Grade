namespace ElementFactory.Core.Implementations.Repositories
{
    using ElementFactory.Core.Contracts.Repositories;
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for ChemicalElement Repository
    /// </summary>
    public class ChemicalElementRepository : IChemicalElementRepository
    {
        /// <summary>
        /// Field for ApplicationDbContext - our DB Context
        /// </summary>
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Default Constructor for injection of a DB Context
        /// </summary>
        /// <param name="context">DB Context</param>
        public ChemicalElementRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Asynchronous method for adding an entity to context
        /// </summary>
        /// <param name="entity">ChemicalElement entity</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ChemicalElement entity)
        {
            await context.ChemicalElements.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for deleting an entity by id from context
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(int id)
        {
            var entity = await context
               .ChemicalElements
               .FirstOrDefaultAsync(q => q.Id == id)
               ?? throw new ArgumentException("Invalid id!");

            entity.IsActive = false;
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for loading all entities
        /// </summary>
        /// <returns>Collection with entities</returns>
        public async Task<IEnumerable<ChemicalElement>> GetAllAsync()
        {
            return await
                context
                .ChemicalElements
                .Include(ce => ce.ChemicalType)
                .Where(ce => ce.IsActive)
                .ToListAsync();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>The collected entity</returns>
        public async Task<ChemicalElement> GetByIdAsync(int id)
        {
            var entity = await context.ChemicalElements
                .Where(ce => ce.IsActive)
                .FirstOrDefaultAsync(ce => ce.Id == id);

            return entity ?? throw new ArgumentException("Invalid id!");
        }

        /// <summary>
        /// Asynchronous method for saving changes in repository
        /// </summary>
        /// <returns>(void)</returns>
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method used to update an entity with a given one
        /// </summary>
        /// <param name="id">Id of the entity to update</param>
        /// <param name="entity">Entity which is used for update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(int id, ChemicalElement entity)
        {
            var entityToUpdate = await context
                .ChemicalElements
                .Where(ce => ce.IsActive)
                .FirstOrDefaultAsync(ce => ce.Id == id)
                ?? throw new ArgumentException("Invalid id!");

            entityToUpdate.State = entity.State;
            entityToUpdate.Period = entity.Period;
            entityToUpdate.Density = entity.Density;
            entityToUpdate.IsSynthetic = entity.IsSynthetic;
            entityToUpdate.Id = entity.Id;
            entityToUpdate.EnglishName = entity.EnglishName;
            entityToUpdate.AtomicMass = entity.AtomicMass;
            entityToUpdate.AtomicRadius = entity.AtomicRadius;
            entityToUpdate.AtomicNumber = entity.AtomicNumber;
            entityToUpdate.Name = entity.Name;
            entityToUpdate.ElectronicLayers = entity.ElectronicLayers;
            entityToUpdate.Symbol = entity.Symbol;
            entityToUpdate.Group = entity.Group;
            entityToUpdate.IsRadioactive = entity.IsRadioactive;
            entityToUpdate.BoilingPoint = entity.BoilingPoint;
            entityToUpdate.MeltingPoint = entity.MeltingPoint;
            entityToUpdate.YearFound = entity.YearFound;
            entityToUpdate.BulgarianState = entity.BulgarianState;
            entityToUpdate.Electronegativity = entity.Electronegativity;
            entityToUpdate.ChemicalTypeId = entity.ChemicalTypeId;

            await context.SaveChangesAsync();
        }
    }
}
