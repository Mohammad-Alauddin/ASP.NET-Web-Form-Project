using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Project.WorkingFolder
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {

           FileUpload fu =  (FileUpload)DetailsView1.FindControl("FileUpload1");
            if(fu.HasFile)
            {
                fu.SaveAs( Server.MapPath("~/Image/") + fu.FileName);
                SqlDataSource2.InsertParameters["ImageUrl"].DefaultValue = "~/Image/" + fu.FileName;
            }
            
        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            FileUpload fu = (FileUpload)DetailsView1.FindControl("FileUpload1");
            if (fu.HasFile)
            {
                fu.SaveAs(Server.MapPath("~/Image/") + fu.FileName);
                SqlDataSource2.UpdateParameters["ImageUrl"].DefaultValue = "~/Image/" + fu.FileName;
            }
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {

            GridView1.DataBind();

        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }
    }
}