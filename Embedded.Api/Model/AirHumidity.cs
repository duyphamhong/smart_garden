using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Embedded.Api.Model
{
    public class AirHumidity : BaseModel
    {
        public decimal Value { get; set; }
        public int CustomerId { get; set; }
    }
}
