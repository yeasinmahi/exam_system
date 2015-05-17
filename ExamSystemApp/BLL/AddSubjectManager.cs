using ExamSystemApp.DAL;
using ExamSystemApp.Model;

namespace ExamSystemApp.BLL
{
    class AddSubjectManager
    {
        AddSubjectGatway addSubjectGatway = new AddSubjectGatway();
        
        public string Insert(Subject subject)
        {
            int codeUnique=addSubjectGatway.IsCodeUnique(subject);
            string message;
            if (codeUnique==0)
            {
                int IsInsert = addSubjectGatway.Insert(subject);
                if (IsInsert > 0)
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
