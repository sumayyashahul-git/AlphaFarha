using AlphaFarha.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.Core.Interfaces
{
    public interface IMRFItemRepository
    {
        Task<IEnumerable<MRFItem>> GetMRFItemsByMRFNoAsync(string mrfNo);
        Task AddMRFItemAsync(MRFItem mrfItem);
        Task UpdateMRFItemAsync(MRFItem mrfItem);
        Task DeleteMRFItemAsync(string itemCode);
    }
}
