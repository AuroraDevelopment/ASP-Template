using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KH_Template.Code
{
    public partial class AjaxOperations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod(EnableSession = true)]
        public static object GetObjects(int jtStartIndex = 0, int jtPageSize = 0)
        {
            try
            {
                //Get data from database
                List<Event> events = EventOperation.GetAllEvent();

                //Return result to jTable
                return new { Result = "OK", Records = events, TotalRecordCount = events.Count };
            }
            catch (Exception ex)
            {
                return new { Result = "ERROR", Message = ex.Message };
            }
        }

        [WebMethod(EnableSession = true)]
        public static void CreateObject(Event record)
        {
            List<Event> events = new List<Event>();
            events.Add(record);
            EventOperation.InsertEvent(events);
        }

      
        [WebMethod(EnableSession = true)]
        public static void DeleteStudent(int StudentId)
        {
            EventOperation.DeleteEvent("ID = " + StudentId);
        }

    }
}