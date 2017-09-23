using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.DTO
{

    [DataContract]
    public class CultivationDetailDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int SerialNumber { get; set; }

        [DataMember]
        public int StateId { get; set; }

        [DataMember]
        public string Year { get; set; }

        [DataMember]
        public int CultivationArea { get; set; }

        [DataMember]
        public string CropName { get; set; }

        [DataMember]
        public Decimal QuantityOfCultivation { get; set; }

        [DataMember]
        public int Demand { get; set; }

        [DataMember]
        public int Supply { get; set; }
    }
}
