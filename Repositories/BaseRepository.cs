using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Repositories
{
    // This class is needed for conection with database and working with it
    // Можно было обойтись и без абстрактного класса, но это делается в целях соблюдения DIP 
    public abstract class BaseRepository
    {
        protected string connection;
    }
}
