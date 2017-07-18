using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM phone = new GSM("A1000", "Lenovo");

            List<Call> calls = new List<Call>();

            phone.AddCall(new Call("0888123456", DateTime.Now, 35));
            phone.AddCall(new Call("0876996633", DateTime.Now, 120));
            phone.AddCall(new Call("0845784512", DateTime.Now, 65));

            Console.WriteLine(phone.CallHistory.ToString());
            Console.WriteLine(phone.CallPrice(0.37));

            var longestDuration = phone.CallHistory.Max(x => x.Duration);
            var longestCall = phone.CallHistory.First(x => x.Duration == longestDuration);

            phone.DeleteCall(longestCall);

            Console.WriteLine(phone.CallPrice(0.37));

            phone.ClearHistory();

            Console.WriteLine(phone.CallHistory);
        }
    }
}
