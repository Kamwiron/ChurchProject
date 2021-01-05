using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;


namespace ChurchProject.Repository
{
    public class TitleRepository
    {
        private ChurchProjectEntities _context;
        public TitleRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<Title> GetTitles()
        {
            var title = _context.Titles.ToList();
            return title;
        }
    }
}
