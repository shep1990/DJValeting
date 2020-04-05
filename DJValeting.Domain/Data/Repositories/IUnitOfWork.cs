using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DJValeting.Domain.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        int Commit();

        Task<int> CommitAsync();
    }
}
