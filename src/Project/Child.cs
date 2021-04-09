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
        public void ExecuteOrder666()
        {
            base.Call();
        }

        protected override void Foo()
        {
            MessageBox.Show("Called Child.Foo");
        }
    }
}
