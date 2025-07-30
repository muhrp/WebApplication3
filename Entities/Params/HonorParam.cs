using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Params
{
    public class HonorParam
    {
        public int Id { get; set; }
        public string KdDaerah { get; set; } = string.Empty;
        public string Tahun { get; set; }
        public int Dinas
        {
            get
            {
                return KdDaerah.StartsWith("3") ? 10000 : 0;
            }
        }
    }
}
