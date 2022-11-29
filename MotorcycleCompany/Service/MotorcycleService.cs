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
    internal sealed class MotorcycleService : IMotorcycleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public MotorcycleService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges)
        {
            try
            {
                var Motorcycles = _repository.Motorcycle.GetAllMotorcycles(trackChanges);
                return Motorcycles;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllMotorcycles)} service method {ex}");
                throw;
            }
        }
    }
}
