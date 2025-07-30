using AutoMapper;
using Azure.Core;
using Entities.DTO;
using Entities.Entities;
using Entities.Params;
using Repositories.IRepositories;

namespace WebApplication3.Services
{
    public class HonorService(
        IHonorRepository honorRepository,
        IMapper mapper
        )
    {
        public List<HonorDTO> GetAll(IQueryCollection query, UserSSO user)
        {
            var allHonor = honorRepository.GetAll().ToList();

            if (query.Count != 0)
            {
                int limit = int.TryParse(query["limit"], out limit) ? limit : 0;
                allHonor = allHonor.Take(limit).ToList();
            }

            foreach (var item in allHonor)
            {
                item.CreatedBy = user.IdPegawai;
            }

            var honorDTO = mapper.Map<List<HonorDTO>>(allHonor);

            return honorDTO;
        }

        public void CreateHonor(HonorParam param)
        {
            if (param.KdDaerah.StartsWith("0")) throw new Exception("Tidak Diizinkan");
            var honor = mapper.Map<Honor>(param);

            honorRepository.Create(honor);
        }

        public async Task<Honor?> GetHonorAsync()
        {
            var honor = new Honor();
            return honor;
        }
    }
}
