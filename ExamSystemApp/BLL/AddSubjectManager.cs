using ExamSystemApp.DAL;
using ExamSystemApp.Model;

namespace ExamSystemApp.BLL
{
    class AddSubjectManager
    {
        readonly AddSubjectGatway _addSubjectGatway = new AddSubjectGatway();
        
        public string Insert(Subject subject)
        {
            int codeUnique=_addSubjectGatway.IsCodeUnique(subject);
            string message;
            if (codeUnique==0)
            {
                int isInsert = _addSubjectGatway.Insert(subject);
                if (isInsert > 0)
                {
                    message = "Insert Seccessfully";
                }
                else
                {
                    message = "Cannot Insert";
                }
            }
            else if (codeUnique==-1)
            {
                message = "DataBase Connection Problem";
            }
            else if (codeUnique==1)
            {
                message = "You Already Have This Code Before";
            }
            else
            {
                message = "Unknown Problem Occured";
            }
            return message;
        }
    }
}
