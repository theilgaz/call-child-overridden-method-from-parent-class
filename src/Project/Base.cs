using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Base
    {
        protected virtual void Foo()
        {

        }

        protected void Call()
        {
            Foo();
        }
    }
}
