using RepositoryPatternUOW.Core.Models;
using RepositoryPatternUOW.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Author> Authors { get;  }
        IBooksRepository Books { get; }
        int Complete(); // return number of affected rows
    }
}
