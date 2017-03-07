using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMWebAPI.Models;

namespace CMWebAPI.Models
{
    public interface IApplicationFromDBViewRepository
    {
        IList<ApplicationFromDBView> GetAll();
    }
}
