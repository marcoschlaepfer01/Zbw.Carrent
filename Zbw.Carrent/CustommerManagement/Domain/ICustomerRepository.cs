using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.Carrent.CustommerManagement.Domain
{
    public interface ICustomerRepository
    {
        IEnumerable<object> GetAll();
    }
}
