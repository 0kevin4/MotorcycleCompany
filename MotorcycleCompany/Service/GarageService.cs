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
    internal sealed class GarageService : IGarageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public GarageService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<GarageDto>GetAllGarages(bool trackChanges)
        {
            var Garages = _repository.Garage.GetAllGarages(trackChanges);


            var GaragesDto = _mapper.Map<IEnumerable<GarageDto>>(Garages);
            return GaragesDto;
        }
    }
}
