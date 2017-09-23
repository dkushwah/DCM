using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CultivationDetails
    {
        public int SerialNumber { get; set; }

        public int StateId { get; set; }

        public string Year { get; set; }

        public int CultivationArea { get; set; }

        public string CropName { get; set; }

        public Decimal QuantityOfCultivation { get; set; }

        public int Demand { get; set; }

        public int Supply { get; set; }
    }
}