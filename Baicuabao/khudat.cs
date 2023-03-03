using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baicuabao
{
    public class khudat
    {
      KD k = new KD();
        public void nhap()
        {
            Console.WriteLine(" nhap ma khu dat : ");
            k.makhudat= Console.ReadLine();
            Console.WriteLine("nhap dia chi : ");
            k.diachi= Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("ma khu dat : " + k.makhudat);
            Console.WriteLine("dia chi khu dat : " + k.diachi);
        }
    }
    
}
