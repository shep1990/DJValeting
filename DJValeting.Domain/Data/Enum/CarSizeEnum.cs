using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DJValeting.Domain.Data.Enum
{
    public enum CarSizeEnum
    {
        [Display(Name = "Small")]
        Small = 0,
        [Display(Name = "Medium")]
        Medium = 1,
        [Display(Name = "Large")]
        Large = 2,
        [Display(Name = "Van")]
        Van = 3
    }
}
