using System;

namespace Embedded.Api.Model
{
    public class GroundHumidity : BaseModel
    {
        /// <summary>
        /// Index number of the box which contain the ground humidity sensor
        /// </summary>
        public int OrderOfBox { get; set; }
        public decimal Value { get; set; }
        public int CustomerId { get; set; }
    }
}
