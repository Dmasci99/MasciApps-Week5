using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Required for connecting to Entity Framework db
using MasciApps_Week5.Models;
using System.Web.ModelBinding;

namespace MasciApps_Week5
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if lading the page for the first time
            if (!IsPostBack)
            {
                //Get students from Entity Framework db
                this.GetStudents();
            }
        }


        protected void GetStudents()
        {
            //connect to Entity Framework
            using (DefaultConnection db = new DefaultConnection())
            {
                //query the Students table using EF and Linq
                var Students = (from allStudents in db.Students
                                select allStudents);

                //bind the result to the gridview
                StudentsGridView.DataSource = Students.ToList();
                StudentsGridView.DataBind();
            }

        }
    }
}