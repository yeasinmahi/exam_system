using ExamSystemApp.DAL;
using ExamSystemApp.Model;

namespace ExamSystemApp.BLL
{
    class TeacherManager
    {
        readonly TeacherGatway _teacherGatway = new TeacherGatway();
        
        public string Insert(QuestionAndAnswer questionAndAnswer)
        {
            string message;
            int isInsert = _teacherGatway.Insert(questionAndAnswer);
            if (isInsert>0)
            {
                message = "Inserted Successfully";
            }
            else if( isInsert==-1)
            {
                message = "Database Connection Error";
            }
            else
            {
                message = "Cannot Saved Your Question!!!";
            }
            return message;
        }
    }
}
