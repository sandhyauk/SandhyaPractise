using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMS
{
    [TestClass]
    public class ForLoop
    {
        [TestMethod]
        public void Loop()
        {
            for (int i = 20; i >= 2; i =i-2 )
            {

                
                    Console.WriteLine(i);
                
            }


            string a = "abcsdefghi";

            for(int i =9; i>=0; i-- ) 
            
            {
                Console.WriteLine(a[i]);
            }


        }
    }
}
