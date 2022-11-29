﻿using AutoMapper;
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
    internal sealed class PhonesService : IPhonesServices
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public PhonesService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<Phones> GetAllPhones(bool trackChanges)
        {
            try
            {
                var Phones = _repository.Phones.GetAllPhones(trackChanges);
                return Phones;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllPhones)} service method {ex}");
                throw;
            }
        }
    }
}
