using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace techiz.Domain.Entities
{
    public class Viewsa
    {

        public string Dates { get; set; }
        public string OrderNo { get; set; }
        public int Ids { get; set; }
        //public int LineIds { get; set; }
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public string Break { get; set; }
        public string SumStartWorkNoCountable { get; set; }

        public string SumStartWork { get; set; }
        public string SumStopWork { get; set; }
        public string UseAbleTime { get; set; }
        public double? UseAbleMinute { get; set; }
        public double? LoadingLevel { get; set; }
        public double? TheoricSpeed { get; set; }
        public int? ShiftTarget { get; set; }
        public int? ProductionTarget { get; set; }
        public double? PerformanceLevel { get; set; }
        public int? SolidCardCount { get; set; }
        public int? QualityLevel { get; set; }
        public double Oee { get; set; }




    }
}
