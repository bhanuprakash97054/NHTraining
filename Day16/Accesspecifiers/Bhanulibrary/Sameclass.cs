using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhanulibrary
{
    /***************************************
     * author:bhanu ram krishna prakash jakkamsetti
     * purpose:know use of access specifiers
     * **************************************/
    public class Sameclass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        internal protected int e;

        public  void Sameclassmethod()
        {
            a = 5;
            b = 6;  
            c = 7;
            d = 8;
            e = 9;
        }

    }
    class DerivedclassinSameAssembly : Sameclass    
    {
        public void DerivedclassinSameAssemblymethod()
        {
           
            a = 5;
            b = 6;
            c = 7;
            d = 8;
            e = 9;
            
        }
    }
    class OtherclassinSameAssembly
    {
        public void OtherclassinSameAssemblymethod()
        {
           Sameclass s=new Sameclass();
            
           s. a = 5;
           s. b = 6;
           s. c = 7;
           s. d = 8;
           s. e = 9; 
            
        }
    }
}
