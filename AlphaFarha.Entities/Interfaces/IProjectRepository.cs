using AlphaFarha.Core.Models;
using AlphaFarha.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.Core.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>?> GetAllProjectAsync();
         Task AddProjectAsync(Project project);
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(string projectCode);
    }
}
