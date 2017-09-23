using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.DAL.Entities
{
    public class CultivationDetail : Base
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
