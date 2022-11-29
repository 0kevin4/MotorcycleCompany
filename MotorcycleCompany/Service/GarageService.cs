﻿using Contracts;
using Entities.Models;
using Service.Contract;
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

        public GarageService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public IEnumerable<Garage>GetAllGarages(bool trackChanges)
        {
            try
            {
                var Garages = _repository.Garage.GetAllGarages(trackChanges);
                return Garages;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllGarages)} service method {ex}");
                throw;
            }
        }
    }
}
