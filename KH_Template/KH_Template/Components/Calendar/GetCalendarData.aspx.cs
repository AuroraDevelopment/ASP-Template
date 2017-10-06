using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

public partial class GetCalendarData : System.Web.UI.Page
{
}

namespace KH_Template
{
    public static class Util
    {
        public static string GetData()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/Components/Calendar/data.xml";
            DataTable dt = DatabaseModel.ExecuteQuery("Select ID, Title, Detail, StartDate, EndDate, AllDay, Color from Event join EventTypes on Event.Type = EventTypes.Type");
            XDocument doc = XDocument.Load(path);

            foreach (DataRow dr in dt.Rows)
            {
                string start = DateTime.Parse(dr[3].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string end = DateTime.Parse(dr[4].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                XElement xelem = new XElement("EventItem",
                     new XAttribute("ows_ID", dr[0].ToString()),
                     new XAttribute("ows_Title", dr[1].ToString()),
                     new XAttribute("ows_EventDate", start),
                     new XAttribute("ows_EndDate", end),
                     new XAttribute("ows_fAllDayEvent", dr[5].ToString()),
                     new XAttribute("ows_EventCategory", "#" + dr[6].ToString())
                     );
                doc.Root.Add(xelem);
              
            }
            string data = doc.Root.ToString();
            return data;
        }
    }   
}