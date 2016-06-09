using MasciApps_Week5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasciApps_Week5
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContactCancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Students.aspx");
        }

        protected void ContactSaveButton_Click(object sender, EventArgs e)
        {
            //use EF to connect to the Server
            using (DefaultConnection db = new DefaultConnection())
            {
                //use the student model to save a new record
                Student newStudent = new Student()
                {
                    LastName = LastNameTextBox.Text,
                    FirstMidName = FirstNameTextBox.Text,
                    EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text)
                };

                //adding the new student to the collection
                db.Students.Add(newStudent);

                //run at insert command
                db.SaveChanges();

                Response.Redirect("~/Students.aspx");
            }
        }
    }
}