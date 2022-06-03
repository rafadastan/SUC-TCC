﻿using Microsoft.EntityFrameworkCore.Storage;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._3._Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlContext _sqlContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void BeginTransaction()
        {
            _transaction = _sqlContext
                .Database
                .BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Save()
        {
            _sqlContext.SaveChanges();
        }

        public IUsuarioRepository UsuarioRepository => new UsuarioRepository(_sqlContext);
        public IPerfilRepository PerfilRepository => new PerfilRepository(_sqlContext);

        public void Dispose()
        {
            _transaction.Dispose();
        }
    }
}
