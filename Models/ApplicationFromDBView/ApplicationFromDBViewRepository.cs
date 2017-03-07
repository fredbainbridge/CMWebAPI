using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMWebAPI.Models;

namespace CMWebAPI.Models
{
    public class ApplicationFromDBViewRepository : IApplicationFromDBViewRepository
    {
        private CMContext _context;

        public ApplicationFromDBViewRepository (CMContext dataContext)
        {
            _context = dataContext;
        }

        public IList<ApplicationFromDBView> GetAll()
        {
            return _context.ApplicationFromDBView.ToList();
        }
    }
}
