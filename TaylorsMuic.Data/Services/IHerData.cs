using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaylorsMuic.Data.Models;

namespace TaylorsMuic.Data.Services
{
    public  interface IHerData
    {
        IEnumerable<Her> GetAll();

    }
}
