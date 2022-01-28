using System;

namespace WearableClientSimulation
{
    public class WearableData
    {
        public int deviceId { set; get; }
        public string date { set; get; }
        public string time { set; get; }
        public float temperature { set; get; }
        public float heartRate { set; get; }
        public float oxygenSaturation { set; get; }
        public string snoringDetection { set; get; }
        public float accelerometerData { set; get; }

        Random random = new Random();

        public WearableData(int deviceId)
        {
            DateTime today = DateTime.Now;
            this.deviceId = deviceId;
            this.date = today.Year.ToString() + '-' + today.Month.ToString() + '-' + today.Day.ToString();
            this.time = today.Hour.ToString() + ":" + today.Minute.ToString() + ":" + today.Second.ToString();
            this.temperature = randomFloat(38, 40);
            this.heartRate = randomFloat(60, 140);
            this.oxygenSaturation = randomFloat(87, 100);
            this.snoringDetection = (randomInt(0, 1) == 1) ? "yes" : "no";
            this.accelerometerData = randomFloat(0, 100);
        }

        private int randomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, (max+1));    
        }

        private float randomFloat(int min, int max)
        {
            double val = (random.NextDouble() * (max - min) + min);
            return (float)Math.Round(val,2);
        }

        public override string ToString()
        {
            string properties = @deviceId + "\n" + 
                                date + "\n" + time + "\n" + temperature + "\n" + heartRate + "\n" + 
                                oxygenSaturation + "\n" + snoringDetection + "\n" + accelerometerData;

            return base.ToString() + ": " + properties;
        }
    }

}