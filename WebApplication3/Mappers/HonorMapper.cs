using AutoMapper;
using Entities.DTO;
using Entities.Entities;
using Entities.Params;

namespace WebApplication3.Mappers
{
    public class HonorMapper : Profile
    {
        public HonorMapper() {
            CreateMap<Honor, HonorDTO>()
                .ForMember(x => x.KodeDaerah, src => src.MapFrom(x => x.KdDaerah))
                .ForMember(x => x.TahunBerjalan, src => src.MapFrom(x => x.Tahun + 1));
            CreateMap<HonorParam, Honor>();
        }
    }
}
