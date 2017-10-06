using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KH_Template.Forms.Calendar
{
    public partial class CalendarSetting : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            drpTypes.DataSource = EventTypesOperation.GetAllEventTypes();
            drpTypes.DataTextField = "type";
            drpTypes.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Server.MapPath(Paths.Calendar + fileUpload.FileName);
                string fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                if (Paths.UploadImage(path, fileUpload))
                {
                    Event eve = new Event(0, txtTitle.Value, txtTitle.Value, txtDesc.Value, path, drpTypes.Value, DateTime.Now, Utilities.GetCurrentUser(), DateTime.Now, Utilities.GetCurrentUser(), DateTime.Parse(dateStart.Value), DateTime.Parse(dateEnd.Value), 0);
                    List<Event> events = new List<Event>();
                    events.Add(eve);
                    EventOperation.InsertEvent(events);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(typeof(Page), "successfull", "alert('Please upload only jpeg, jpg,png,tif,tiff'); window.location = 'ParivarRegistration.aspx';", true);
                }
                Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);

                // Stop Caching in Firefox
                Response.Cache.SetNoStore();
                Response.Redirect(Page.Request.RawUrl, false);
            }
            catch (Exception ex)
            {

            }

        }
    }
}