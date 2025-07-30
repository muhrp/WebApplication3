using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IHonorRepository
    {
        IQueryable<Honor> GetAll();
        void Create(Honor honor);
        IQueryable<Honor> GetByTahun(string tahun);
        //IQueryable<Honor> GetByTahun(string kddaerah);
    }
}
