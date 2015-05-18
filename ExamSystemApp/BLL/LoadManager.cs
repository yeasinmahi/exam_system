using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystemApp.DAL;
using ExamSystemApp.Model;

namespace ExamSystemApp.BLL
{
    class LoadManager
    {
        readonly LoadGatway loadGatway = new LoadGatway();
        public List<Subject> LoadAllSubject()
        {
            return loadGatway.LoadAllSubject();
        }
    }
}
