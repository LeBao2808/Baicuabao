using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baicuabao
{
    public class chungcu
    {
       CC ccc = new CC();
       
        public canho ch = new canho();
        public void nhap()
        {
            Console.WriteLine("nhap ma chung cu : " );
            ccc.machungcu = Console.ReadLine();
            Console.WriteLine("nhap dia chi : ");
            ccc.diachichungcu = Console.ReadLine();
            ch.nhap();
          
        }
        public void xuat()
        {
            Console.WriteLine("ma chung cu " + ccc.machungcu);
            Console.WriteLine("dia chi chung cu " + ccc.diachichungcu);
            Console.WriteLine("Chung cu thuoc can ho ");
            ch.xuat();
           
        }
    }
}
