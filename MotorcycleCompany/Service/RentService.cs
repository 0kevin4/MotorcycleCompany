using Contracts;
using Entities.Models;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class RentService : IRentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public RentService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public IEnumerable<Rent> GetAllRents(bool trackChanges)
        {
            try
            {
                var Rents = _repository.Rent.GetAllRents(trackChanges);
                return Rents;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllRents)} service method {ex}");
                throw;
            }
        }
    }
}
