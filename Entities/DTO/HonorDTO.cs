﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class HonorDTO
    {
        public int Id { get; set; }
        public string KodeDaerah { get; set; } = string.Empty;
        public int TahunBerjalan { get; set; }
    }
}
