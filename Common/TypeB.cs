using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB // can only be access throught it's project
    {
        public TypeB() { 
            TypeA a=new TypeA();
            //a.x = 5; //error because it is private so it only be accessed inside it's class
            a.y = 0;
            a.z = 0;
        }
    }
}
