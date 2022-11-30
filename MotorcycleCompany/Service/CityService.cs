using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contract;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CityService : ICityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public CityService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<CityDto> GetAllAgencias(bool trackChanges)
        {

            var cities = _repository.City.GetAllCities(trackChanges);

            var citiesDto = _mapper.Map<IEnumerable<CityDto>>(cities);
            return citiesDto;
        }
    }
}
