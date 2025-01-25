using AlphaFarha.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.Core.Interfaces
{
    public interface IMRFRepository
    {
        Task<IEnumerable<MRF>?> GetAllMRFAsync();
        Task<IEnumerable<MRF>> GetFilteredAsync(DateTime fromDate, DateTime toDate, string type, string requestedBy, string project, string mrfNo);
        Task AddMRFAsync(MRF mrf);
        Task UpdateMRFAsync(MRF mrf);
        Task DeleteMRFAsync(MRF mrf);
    }

  
}
