using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Honor
    {
        public int Id { get; set; }
        public string KdDaerah { get; set; } = string.Empty;
        public string Tahun { get; set; }
        [NotMapped]
        public int Dinas { get; set; }

        [NotMapped]
        public string? NamaProvinsi { get
            {
                return KdDaerah.StartsWith("3") ? "Jakarta" : "";
            } }

        [NotMapped]
        public int CreatedBy { get; set; } = 0;
    }
}
