using System;
using System.ComponentModel.DataAnnotations;

namespace MCAP.Nova.LowestRateDisplay.Models
{
    public class SearchCriteria
    {
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime StartDeate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime EndDeate { get; set; }
    }
}
