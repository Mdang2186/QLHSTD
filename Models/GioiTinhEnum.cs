﻿using System.ComponentModel.DataAnnotations;

namespace Nhom6_QLHoSoTuyenDung.Models
{
    public enum GioiTinhEnum
    {
        [Display(Name = "Nam")]
        Nam = 0,

        [Display(Name = "Nữ")]
        Nu = 1,

        [Display(Name = "Khác")]
        Khac = 2
    }
}
