using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public interface IDrugRepository
    {
        void Add(DrugModel drugModel);
        void Edit(DrugModel drugModel);
        void Delete(int id);
        IEnumerable<DrugModel> GetAll();
        IEnumerable<DrugModel> GetByValue(string value);
    }
}
