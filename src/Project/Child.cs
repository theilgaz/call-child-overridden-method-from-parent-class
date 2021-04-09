using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Child:Base
    {
        public void CallFoo()
        {
            base.Foo();
        }

        protected override void Bar()
        {
            MessageBox.Show("Called Child.Bar");
        }
    }
}
