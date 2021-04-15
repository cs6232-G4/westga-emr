using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace westga_emr.Model.DTO
{
    public class LabOrderDTO
    {
        public long? ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime TestPerformed { get; set; }
        public string Results { get; set; }
    }
}
