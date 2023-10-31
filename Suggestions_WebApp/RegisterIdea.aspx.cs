using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Suggestions_WebApp.SuggestionService;

namespace Suggestions_WebApp
{
    public partial class RegisterIdea : System.Web.UI.Page
    {
        SuggestionService.ServiceClient objServiceClientobjService = new SuggestionService.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Idea ideainfo = new Idea();
            ideainfo.Title = TextBoxTitle.Text;
            ideainfo.Title = TextBoxDescription.Text;
            ideainfo.Expected_Dureation = Calendar1.SelectedDates.ToString();
            ideainfo.Docs = FileUpload1.ToString();
            ideainfo.Current_Status = "Submitted";
            ideainfo.Createdat = DateTime.Now;
            ideainfo.Createdby = "Dummy User";
            string result = objServiceClientobjService.InsertIdea(ideainfo);
            LabelMessage.Text = result;
        }
    }
}