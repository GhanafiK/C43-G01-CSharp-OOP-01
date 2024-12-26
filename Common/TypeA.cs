using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA // can be access throught it's project or other projects but must be imported
    {
        private int x; // can only access inside it's class
        internal int y; // can be accessed throught it's project
        public int z; // can be accessed inside it's project or other proljects but must be imported

        public TypeA()
        {
            TypeB b=new TypeB();
        }
    }
}
