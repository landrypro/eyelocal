using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.manageapp
{
    interface Connectable
    {
        public int connect();
        public int close();
    }
}
