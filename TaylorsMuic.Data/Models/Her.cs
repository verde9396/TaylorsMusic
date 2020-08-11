using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsMuic.Data.Models
{
  public  class Her
    {
        public int Id { get; set; }
        public Albums Album { get; set; }
        public string Name { get; set; }

        public MusicGenres Genre { get; set; }
    }
}
