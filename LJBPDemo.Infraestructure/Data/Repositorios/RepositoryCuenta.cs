﻿using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Infraestructure.Data.Repositorios
{
    public class RepositoryCuenta:RepositoryBase<Cuenta>, IRepositoryCuenta
    {
        private readonly SqlContext sqlContext;
        public RepositoryCuenta(SqlContext sqlContext): base(sqlContext)
        {
            this.sqlContext = sqlContext;   
        }
    }
}
