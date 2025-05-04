using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogren
{
   double pi = Math.PI;
    long tenThousand = 10000L;
    double tenThousandPi = pi * tenThousand;
    double roundedTenThousandPi = tenThousandPi;
    int integerPartOfTenThousandPi = Convert.ToInt32(tenThousandPi);
    Console.WriteLine(integerPartOfTenThousandPi);
	Console.WriteLine(roundedTenThousandPi);
	Console.ReadLine();

}
