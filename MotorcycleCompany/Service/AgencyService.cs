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
    internal sealed class AgencyService : IAgencyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public AgencyService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public IEnumerable<AgencyDto> GetAllAgencias(bool trackChanges)
        {
            try
            {
                var agencias = _repository.Agency.GetAllAgencias(trackChanges);
                
                var agenciasDto = agencias.Select(a=>new AgencyDto(a.Name,a.Direction,a.Poblation ?? ""))
                    .ToList();
                return agenciasDto;

            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllAgencias)} service method {ex}");
                throw;
            }
        }
    }
}
