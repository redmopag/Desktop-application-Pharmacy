using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Repositories.SupplierRepository
{
    public interface ISupplierRepository
    {
        void Add(SupplierModel supplierModel);
        void Edit(SupplierModel supplierModel);
        void Delete(int id);
        IEnumerable<SupplierModel> GetAll();
        IEnumerable<SupplierModel> GetByValue(string value);
    }
}
