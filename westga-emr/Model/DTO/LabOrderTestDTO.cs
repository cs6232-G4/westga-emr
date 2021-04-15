using System;

namespace westga_emr.Model.DTO
{
    public class LabOrderTestDTO
    {
        public int OrderId { get; set; }
        public int VisitId { get; set; }
        public string TestName { get; set; }
        public string TestResult { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime TestDate { get; set; }
        public int TestCode { get; set; }
    }
}
