using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Consts
{
    public static class DemoConst
    {
        private enum RequestStatus
        {
            Exp,
            Exam,
            Interview,
            JobOffer,
        }


        private static readonly Dictionary<int, string> Statuses = new Dictionary<int, string>
        {
                    { (int)RequestStatus.Exp, "يحتاج تقييم خبرات" },
                    { (int)RequestStatus.Exam, "يحتاج جدولة اختبار" },
                    { (int)RequestStatus.Interview, "يحتاج جدولة مقابلة شخصية" },
                    { (int)RequestStatus.JobOffer, "تقديم عرض وظيف" }

        };
        //private static string[] Status = {"يحتاج تقييم خبرات", "يحتاج جدولة اختبار", "يحتاج جدولة مقابلة شخصية", "تقديم عرض وظيف" };
        public static string GetCandidateStatus(int statusNumber)
        {
            return Statuses[statusNumber];
        }

    }
}
