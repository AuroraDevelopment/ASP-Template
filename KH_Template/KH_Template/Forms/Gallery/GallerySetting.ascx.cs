using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KH_Template.Forms.Gallery
{
    public partial class GallerySetting : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Getting Post Types */
            drpTypes.DataSource = PostTypesOperation.GetAllPostTypes();
            drpTypes.DataTextField = "type";
            drpTypes.DataBind();
            /* Get Post list to Delete */
            rptGallery.DataSource = PostOperation.GetAllPost();
            rptGallery.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                /* Get Image to Delete */
                Post p = PostOperation.GetAllPost("ID = " + btn.CommandName).First();
                /* Delete Image from Disk */
                Paths.DeleteImage(p.URL);
                /* Delete Image from Database */
                PostOperation.DeletePost("ID = " + btn.CommandName);
                // Stop Caching in IE
                Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                // Stop Caching in Firefox
                Response.Cache.SetNoStore();
                // Reload
                Response.Redirect(Page.Request.RawUrl, false);
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /* Prepare path to save image to disk */
                string path = Server.MapPath(Paths.Gallery + fileUpload.FileName);
                string fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                /* Add Post to Disk */
                if (Paths.UploadImage(path, fileUpload))
                {
                    Post post = new Post(0, txtTitle.Value, 
                                            txtTitle.Value, 
                                            txtDesc.Value, 
                                            path, 
                                            drpTypes.Value,
                                            DateTime.Now,
                                            Utilities.GetCurrentUser(),
                                            DateTime.Now,
                                            Utilities.GetCurrentUser());

                    List<Post> posts = new List<Post>();
                    posts.Add(post);
                    /* Add Post to Database */
                    PostOperation.InsertPost(posts);
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
            catch(Exception ex)
            {

            }
            
        }

    }
}