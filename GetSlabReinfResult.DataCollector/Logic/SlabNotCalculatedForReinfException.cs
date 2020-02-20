using System;

namespace GetSlabReinfResult.DataCollector.Logic
{
    [Serializable]
    public class SlabNotCalculatedForReinfException : Exception
    {
        public SlabNotCalculatedForReinfException() { }
        public SlabNotCalculatedForReinfException(string message) : base(message) { }
        public SlabNotCalculatedForReinfException(string message, Exception inner) : base(message, inner) { }
        protected SlabNotCalculatedForReinfException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
