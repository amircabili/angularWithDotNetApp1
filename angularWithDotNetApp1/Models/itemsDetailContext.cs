using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angularWithDotNetApp1.Controllers
{
    public class itemsDetailContext:DbContext
    {
        public itemsDetailContext(DbContextOptions<itemsDetailContext> options) : base(options)
        {

        }

    }
}
