using System;

namespace GetSlabReinfResult.DataCollector.Logic
{
    [Serializable]
    public class SlabNotCalculatedExpetation : Exception
    {
        public SlabNotCalculatedExpetation() { } 
        public SlabNotCalculatedExpetation(string message) : base(message) { }
        public SlabNotCalculatedExpetation(string message, Exception inner) : base(message, inner) { }
        protected SlabNotCalculatedExpetation(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
