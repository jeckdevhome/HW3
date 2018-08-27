using Proga.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga.Servies
{
    class BildingServices : IBildingService
    {
        
        public List<Bilding> GetAll()
        {
            var context = new Dbcontext();
            var allBuild = context.Bildings.ToList();
            //var allBuild = context.Bildings.Include("Bildingtype").ToList<Bilding>;

            return allBuild;
        }
    }
}
