using RepositoryPatternUOW.Core.Models;
using RepositoryPatternUOW.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.EF.Repositories
{
    public class BooksRepository : BaseRepository<Book>, IBooksRepository
    {
        private readonly ApplicationDbContext _context;
        public BooksRepository(ApplicationDbContext context) : base(context)
        {
            
        }
        public IEnumerable<Book> SpeicalMethod()
        {
            throw new NotImplementedException();
        }
    }
}
