using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KH_Template
{
    public partial class GalleryForm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptGallery.DataSource = PostOperation.GetAllPost();
            rptGallery.DataBind();
        }
    }
}