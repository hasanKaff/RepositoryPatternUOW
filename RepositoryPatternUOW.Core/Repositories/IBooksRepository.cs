using RepositoryPatternUOW.Core.Consts;
using RepositoryPatternUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core.Repositories
{
    public interface IBooksRepository : IBaseRepository<Book>
    {
        IEnumerable<Book> SpeicalMethod();
    }
}
