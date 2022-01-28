using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WearableClientSimulation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            try
            {
                Wearable device1 = new Wearable(1234);
                Wearable device2 = new Wearable(2345);
                Wearable device3 = new Wearable(3456);
                Wearable device4 = new Wearable(4567);
                Wearable device5 = new Wearable(5678);

                device1.pair();
                device2.pair();
                device3.pair();
                device4.pair();
                device5.pair();

                for (var i = 0; i<50; i++)
                {
                    device1.data = new WearableData(device1.deviceId);
                    var transmitResult1 = device1.transmit();
                    Console.WriteLine(transmitResult1);

                    device2.data = new WearableData(device2.deviceId);
                    var transmitResult2 = device2.transmit();
                    Console.WriteLine(transmitResult2);

                    device3.data = new WearableData(device3.deviceId);
                    var transmitResult3 = device3.transmit();
                    Console.WriteLine(transmitResult3);

                    device4.data = new WearableData(device4.deviceId);
                    var transmitResult4 = device4.transmit();
                    Console.WriteLine(transmitResult4);

                    device5.data = new WearableData(device5.deviceId);
                    var transmitResult5 = device5.transmit();
                    Console.WriteLine(transmitResult5);

                    Thread.Sleep(60000);
                }

                /*Wearable device1 = new Wearable(1234);
                device1.data = new WearableData(device1.deviceId);

                Console.WriteLine(device1.ToString());

                var pairResult = device1.pair();
                var transmitResult = device1.transmit();

                Console.WriteLine(pairResult);
                Console.WriteLine(transmitResult);

                Console.WriteLine(device1.ToString());

                Console.ReadLine();*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
