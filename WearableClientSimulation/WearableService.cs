using Newtonsoft.Json;

namespace WearableClientSimulation
{
    public static class WearableService
    {
            public static string PairService(int deviceId) {
            string requestData = JsonConvert.SerializeObject(new { id = deviceId });
            string response = Integration.Pair(requestData);
            return response;
        }

        public static string TransmitService(WearableData data)
        {
            string requestData = JsonConvert.SerializeObject(data);
            string response = Integration.Transmit(requestData);
            return response;
        }
    }
}