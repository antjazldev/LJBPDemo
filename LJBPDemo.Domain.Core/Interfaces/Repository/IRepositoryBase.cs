﻿using System.Collections.Generic;

namespace LJBPDemo.Domain.Core.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}