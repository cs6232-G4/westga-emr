using System;

namespace westga_emr.Model
{
    public class Report
    {
        public int LabCode { get; }
        public string LabName { get; }
        public int NumberOfTests { get; }
        public int TotalTests { get; }
        public decimal PercentageOfTotal { get; }
        public int NumberOfNormalResults { get; }
        public int NumberOfAbnormalResults { get; }
        public decimal PercentageDoneOnTwentyYearOldsDuringThisTime { get; }
        public decimal PercentageDoneOnThirtyYearOldsDuringThisTime { get; }
        public decimal PercentageDoneOnOtherAgesOldsDuringThisTime { get; }

        public Report(int LabCode_, string LabName_, int NumberOfTests_, int TotalTests_, decimal PercentageOfTotal_,
            int NumberOfNormalResults_, int NumberOfAbnormalResults_, decimal PercentageDoneOnTwentyYearOldsDuringThisTime_,
            decimal PercentageDoneOnThirtyYearOldsDuringThisTime_, decimal PercentageDoneOnOtherAgesOldsDuringThisTime_)
        {
            if (LabCode_ < 1)
            {
                throw new ArgumentException("code must be greater than zero");
            }
            if (string.IsNullOrWhiteSpace(LabName_))
            {
                throw new ArgumentException("name cannot be null, empty, or consist only of white space");
            }
            if (NumberOfTests_ < 0 || NumberOfNormalResults_ < 0 || NumberOfAbnormalResults_ < 0)
            {
                throw new ArgumentException("cannot have negative value for number of tests, normal results, or abnormal results");
            }
            if (PercentageOfTotal_ < 0 || PercentageDoneOnTwentyYearOldsDuringThisTime_ < 0 || 
                PercentageDoneOnThirtyYearOldsDuringThisTime_ < 0 || PercentageDoneOnOtherAgesOldsDuringThisTime_ < 0)
            {
                throw new ArgumentException("cannot have negative value for percentages");
            }
            this.LabCode = LabCode_;
            this.LabName = LabName_;
            this.NumberOfTests = NumberOfTests_;
            this.TotalTests = TotalTests_;
            this.PercentageOfTotal = PercentageOfTotal_;
            this.NumberOfNormalResults = NumberOfNormalResults_;
            this.NumberOfAbnormalResults = NumberOfAbnormalResults_;
            this.PercentageDoneOnTwentyYearOldsDuringThisTime = PercentageDoneOnTwentyYearOldsDuringThisTime_;
            this.PercentageDoneOnThirtyYearOldsDuringThisTime = PercentageDoneOnThirtyYearOldsDuringThisTime_;
            this.PercentageDoneOnOtherAgesOldsDuringThisTime = PercentageDoneOnOtherAgesOldsDuringThisTime_;
        }
    }
}
