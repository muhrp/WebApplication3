using Entities.Entities;
using Entities.Params;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class HonorController(
        IHonorRepository _honorRepository,
        HonorService _honorService
        ) : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            //var allHonor = _honorRepository.GetAll();
            var allHonor = _honorService.GetAll(Request.Query, _userSSO);

            return Ok(allHonor, allHonor.Count());
        }

        [HttpPost]
        public IActionResult CreateHonor(HonorParam honorParam)
        {
            try
            {
                _honorService.CreateHonor(honorParam);

                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("ByTahun/{tahun}")]
        public IActionResult GetByTahun(string tahun)
        {
            var allHonorByTahun = _honorRepository.GetByTahun(tahun);

            return Ok(allHonorByTahun);
        }

        [HttpGet("OneByTahun/{tahun}")]
        public IActionResult GetOneByTahun(string tahun)
        {
            var allHonorByTahun = _honorRepository.GetByTahun(tahun).FirstOrDefault();

            return Ok(allHonorByTahun);
        }
    }
}
