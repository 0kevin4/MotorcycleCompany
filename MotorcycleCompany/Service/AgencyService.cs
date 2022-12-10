using AutoMapper;
using Contracts;
using Entities.Exceptions;
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
    internal sealed class AgencyService : IAgencyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public AgencyService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public AgencyDto GetAgencias(int Id, bool trackChanges)
        {
            var agency = _repository.Agency.GetAgencias(Id, trackChanges);
            if(agency is null)
                throw new AgencyNotFoundException(Id);

            var agencyDto= _mapper.Map<AgencyDto>(agency);
            return agencyDto;
        }

        public IEnumerable<AgencyDto> GetAllAgencias(bool trackChanges)
        {
            var agencias = _repository.Agency.GetAllAgencias(trackChanges);

            //var agenciasDto = agencias.Select(a=>new AgencyDto(a.Name,a.Direction,a.Poblation ?? ""))
            //    .ToList();

            var agenciasDto = _mapper.Map<IEnumerable<AgencyDto>>(agencias);
            return agenciasDto;

            
        }
    }
}
