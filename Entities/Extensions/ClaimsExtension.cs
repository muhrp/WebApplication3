using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Extensions
{
    public static class ClaimsExtension
    {
        private static string GetNamaPegawai(this IEnumerable<Claim> claim)
        {
            return claim.FirstOrDefault(x => x.Type == "name")?.Value ?? "";
        }

        private static int GetIdPegawai(this IEnumerable<Claim> claim)
        {
            return Convert.ToInt32(claim.FirstOrDefault(x => x.Type == "id")?.Value ?? "");
        }

        public static UserSSO GetUserLogin(this IEnumerable<Claim> claim)
        {
            return new UserSSO() { 
                Nama = claim.GetNamaPegawai(),
                IdPegawai = claim.GetIdPegawai()
            };
        }
    }
}
