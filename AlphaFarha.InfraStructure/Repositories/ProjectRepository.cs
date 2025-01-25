using AlphaFarha.Core.Interfaces;
using AlphaFarha.Core.Models;
using AlphaFarha.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AlphaFarha.InfraStructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;
        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddProjectAsync(Project project)
        {
            await _context.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public Task DeleteProjectAsync(string mrfNo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Project>> GetAllProjectAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public Task UpdateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
