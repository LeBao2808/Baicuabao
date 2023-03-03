using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baicuabao
{
    public class canho
    {
        CH chh = new CH();
        khudat kdd = new khudat();  
        public void nhap() {
            Console.WriteLine("ma can ho : ");
            chh.macanho = Console.ReadLine();
            Console.WriteLine("dia chi : ");
            chh.diachicanho = Console.ReadLine();
            Console.WriteLine("Khu dat : ");
            kdd.nhap();
            
        }
        public void xuat()
        {
            Console.WriteLine("ma can ho " + chh.macanho);
            Console.WriteLine("dia chi can ho " + chh.diachicanho);
            Console.WriteLine("thuoc Khu Dat");
            kdd.xuat();
           
        }
    }
}
