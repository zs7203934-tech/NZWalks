using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;

        public IMapper Mapper { get; }

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.Mapper = mapper;
        }

        

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            // Map domain models to DTOs
            //var regionsDTO = new List<Models.DTO.Region>();

          //  regions.ToList().ForEach(region =>
           // {
              //  var dto = new Models.DTO.Region
              //  {
               //     Id = region.Id,
                //    Name = region.Name,
               //     Code = region.Code,
               //     Area = region.Area,
               //     Lat = region.Lat,
               //     Long = region.Long,
               //     Population = region.Population
               // };

             //   regionsDTO.Add(dto);
            //});

            var regionsDTO = Mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
    }
}
