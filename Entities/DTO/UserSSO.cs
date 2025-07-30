using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class UserSSO
    {
        public int IdPegawai {  get; set; }
        public string KodeOrganisasi { get; set; } = string.Empty;
        public string NamaOrganisasi { get; set; } = string.Empty;
        public string Nip {  get; set; } = string.Empty;
        public string Nama {  get; set; } = string.Empty;
    }
}
