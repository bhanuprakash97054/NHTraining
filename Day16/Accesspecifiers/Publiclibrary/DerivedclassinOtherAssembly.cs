using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bhanulibrary;

namespace Publiclibrary
{
    public class DerivedclassinOtherAssembly : Sameclass
    {
        public void DerivedclassinOtherAssemblymethod()
        {
            a = 5;
            b = 6;
            c = 7;
            d = 8;
            e = 9;
        }
    }
    class OtherclassinOtherAssembly
    {
        public void OtherclassinOtherAssemblymethod()
        {
            Sameclass s = new Sameclass();
            s.a = 5;
            s.b = 6;
            s.c = 7;
            s.d = 8;
            s.e = 9;
        }

    }
}
