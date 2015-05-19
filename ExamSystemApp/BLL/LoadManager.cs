using System.Collections.Generic;
using ExamSystemApp.DAL;
using ExamSystemApp.Model;

namespace ExamSystemApp.BLL
{
    class LoadManager
    {
        readonly LoadGatway _loadGatway = new LoadGatway();
        public List<Subject> LoadAllSubject()
        {
            return _loadGatway.LoadAllSubject();
        }

        public List<QuestionAndAnswer> LoadQuestionList(int sid)
        {
            return _loadGatway.LoadQuestionList(sid);
        }
    }
}
