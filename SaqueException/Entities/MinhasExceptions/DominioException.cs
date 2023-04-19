using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueException.Entities.MinhasExceptions
{
    internal class DominioException:ApplicationException
    {
        public DominioException(string messagem): base(messagem)
        {
            
        }
    }
}
