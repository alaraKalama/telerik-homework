using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefiningClassesPart_1;


namespace DefiningClassesPart_1
{
    class MainGSM
    {
        static void Main()
        {

           GSM Samsung = new GSM("GalaxyS5",
              ManufacturerCo.Samsung, 310.75,
              new Battery(BatteryType.Li_Ion, 2600, 360),
              new Display(5.1, 16));
           GSM Android = new GSM("Nexus5",
              ManufacturerCo.Google, 495,
              new Battery(BatteryType.Li_Ion, 2600, 360),
              new Display(5, 16));

           GSM Nokia = new GSM("3310", ManufacturerCo.Nokia);

            Test newtest = new Test();
            //this is odd, first the method was working fine, then it didn't work (VS said it doesn't exist in the current context)
            //I looked up in stackoverflow and saw I should add this^^ (Test newtest = new Test();), and then it worked, but I don't know
            //why exactly. Your comment will be really helpful if you tell me something about this :)
            GSM[] testArray = new GSM[] { Samsung, Android, Nokia, GSM.iPhone4S };
            Console.WriteLine(newtest.Testing(testArray));

            Call call = new Call(DateTime.Now, "0987654321", 450);
            call.DisplayCallInfo(call);

            CallTest calls = new CallTest();
            calls.HistoryTest(Samsung);
            
            
        }
    }
}
