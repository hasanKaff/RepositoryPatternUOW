using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        public Author Author { get; set; }
        
        // Author Id
        public int AuthorId { get; set; }
    }
}
