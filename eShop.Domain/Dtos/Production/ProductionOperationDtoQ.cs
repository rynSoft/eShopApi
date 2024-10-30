using System;
using System.Collections.Generic;

namespace eShop.Domain.Dtos
{
  public class ProductionOperationDtoQ
    {
        public bool BeginState { get; set; }
        public string ElapsedTime { get; set; }
        public int? PanelCardCount { get; set; }
        public string DownTime { get; set; }
         
        public string? ElapsedDay { get; set; }
        public string ProductionOrderNo { get; set; }
        public string ProductionStartDate { get; set; }
        public string UserName { get; set; }
        public bool StopState { get; set; }
    }
    
}