using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contract;
using Shared;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ClientService : IClientService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public ClientService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<ClientDto> GetAllClients(bool trackChanges)
        {
            var Clients = _repository.Client.GetAllClients(trackChanges);

            var ClientsDto  = _mapper.Map<IEnumerable<ClientDto>>(Clients);

            return ClientsDto;
            
        }
    }
}
