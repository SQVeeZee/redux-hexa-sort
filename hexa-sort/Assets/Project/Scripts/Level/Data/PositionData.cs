using Newtonsoft.Json;

namespace Project
{
    public struct PositionData
    {
        public float X { get; }
        public float Z { get; }

        [JsonConstructor]
        public PositionData(float x, float z)
        {
            X = x;
            Z = z;
        }
    }
}