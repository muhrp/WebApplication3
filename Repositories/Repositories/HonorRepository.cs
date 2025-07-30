using Entities;
using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class HonorRepository(
        RepositoryContext repositoryContext
        ) : IHonorRepository
    {
        public RepositoryContext Repository { get { return repositoryContext; } }
        
        public IQueryable<Honor> GetAll()
        {
            return Repository.Honor.AsQueryable();
        }

        public void Create(Honor honor)
        {
            Repository.Honor.Add(honor);
            Repository.SaveChanges();
        }

        public IQueryable<Honor> GetByTahun(string tahun)
        {
            return Repository.Honor.Where(x => x.Tahun == tahun).AsQueryable();
        }

        //public IQueryable<Honor> GetByTahun(string kddaerah)
        //{
        //    return Repository.Honor.Where(x => x.KdDaerah == kddaerah).AsQueryable();
        //}
    }
}
