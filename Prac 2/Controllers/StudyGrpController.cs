using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac_2.Controllers
{
    public class StudyGrpController : Controller
    {
        // GET: StudyGrp
        public ActionResult Index()
        {
            List<Models.myStudyGroupClass> MyGroup = new List<Models.myStudyGroupClass>();

            MyGroup.Add(new Models.myStudyGroupClass { StudentNumber = "21496073", Name = "Jonny", Surname = "Cyns", EmailAddress = "u21496073@tuks.co.za" });
            MyGroup.Add(new Models.myStudyGroupClass { StudentNumber = "21496088", Name = "Manny", Surname = "Paqman", EmailAddress = "u21496088@tuks.co.za" });
            MyGroup.Add(new Models.myStudyGroupClass { StudentNumber = "21494473", Name = "Mthembza", Surname = "Goat", EmailAddress = "u21494473@tuks.co.za" });
            MyGroup.Add(new Models.myStudyGroupClass { StudentNumber = "22496073", Name = "Malcolm", Surname = "Extra", EmailAddress = "u22496073@tuks.co.za" });
            MyGroup.Add(new Models.myStudyGroupClass { StudentNumber = "20496073", Name = "Lungelo", Surname = "Mpanza", EmailAddress = "u20496073@tuks.co.za" });
            

            return View(MyGroup);
        }

       
    }
}