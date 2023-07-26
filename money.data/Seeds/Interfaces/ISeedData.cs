using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds.Interfaces
{
    public interface ISeedData<T> where T : class
    {
        public List<T> AddSeedData();
    }
}
