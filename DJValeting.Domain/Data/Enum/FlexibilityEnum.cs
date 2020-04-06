using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DJValeting.Domain.Data.Enum
{
    public enum FlexibilityEnum 
    {
        [Display(Name = "+/- 1 Day")]
        OneDay = 0,
        [Display(Name = "+/- 2 Days")]
        TwoDays = 1,
        [Display(Name = "+/- 3 Days")]
        ThreeDays = 2
    }
}
