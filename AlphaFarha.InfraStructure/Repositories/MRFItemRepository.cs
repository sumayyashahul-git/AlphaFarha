using AlphaFarha.Core.Interfaces;
using AlphaFarha.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.InfraStructure.Repositories
{
    public class MRFItemRepository : IMRFItemRepository
    {
        public Task AddMRFItemAsync(MRFItem mrfItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMRFItemAsync(string itemCode)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MRFItem>> GetMRFItemsByMRFNoAsync(string mrfNo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMRFItemAsync(MRFItem mrfItem)
        {
            throw new NotImplementedException();
        }
    }
}
