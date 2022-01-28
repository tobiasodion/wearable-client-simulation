using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WearableClientSimulation
{
    public class Wearable
    {
        public int deviceId { set; get; }
        public bool paired { set; get; }
        public bool activated { set; get; }
        public int interval { set; get; }
        public WearableData data { set; get; }

        public Wearable(int deviceId){
            this.deviceId = deviceId;
            this.paired = false;
            this.activated = false;
            this.interval = 3600;
        }

        public string transmit()
        {
            string transmitResult = WearableService.TransmitService(data);

            if (transmitResult == "00")
            {
                paired = true;
                return $"Device: {deviceId} data transmission successful";
            }

            if (transmitResult == "01")
            {
                return $"Device: {deviceId} data transmission not successful";
            }

            if (transmitResult == "10")
            {
                return $"Device: {deviceId} data not transmitted. Client error";
            }

            return $"Device: {deviceId} data not transmitted. System error";
        }

        public string pair()
        {
            string pairResult = WearableService.PairService(deviceId);

            if (pairResult == "00")
            {
                paired = true;
                return $"Device: {deviceId} paired successfully";
            }

            if (pairResult == "01")
            {
                return $"Device: {deviceId} not paired. Device not assigned to pet";
            }

            if (pairResult == "10")
            {
                return $"Device: {deviceId} not paired. Client error";
            }

            return $"Device: {deviceId} not paired. System error";
        }

        public string activate()
        {
            activated = true;
            return $"Device: {deviceId} Activated";
        }

        public string deactivate()
        {
            activated = false;
            return $"Device: {deviceId} deactivated";
        }

        public override string ToString()
        {
            string properties = @deviceId + "\n" + paired.ToString() + "\n" + activated.ToString() + "\n" +
                                interval + "\n" + data.ToString();

            return base.ToString() + ": " + properties;
        }

    }
}
