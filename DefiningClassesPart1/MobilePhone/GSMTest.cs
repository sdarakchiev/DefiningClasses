using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMTest
    {
        static void Main(string[] args)
        {
            GSM SamsungGalaxyS8 = new GSM("Galaxy S8", "Samsung", 999, new Battery("3000 mAh", 67, 20, BatteryType.LiIon), new Display(5.8, 16000000));
            GSM HuaweiP10 = new GSM("P10", "Huawei", 679, new Battery("3200 mAh"), new Display(5.1, 16000000));
            GSM Lumia950 = new GSM("Lumia 950", "Microsoft", 619, new Battery("3000 mAh", 23, 288, BatteryType.LiIon), new Display(5.2, 16000000));

            GSM[] phones = new GSM[3] { SamsungGalaxyS8, HuaweiP10, Lumia950 };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine(GSM.IPhone4S.ToString());

            //GSMCallHistoryTest.Test();
        }
    }
}
