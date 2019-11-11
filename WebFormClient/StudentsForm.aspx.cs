using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebFormClient.Models;
using RestSharp;

namespace WebFormClient
{
    public partial class StudentsForm : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest("/api/Students", Method.GET);
            var response = client.Execute<List<Student>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                gvStudents.DataSource = response.Data;
                gvStudents.DataBind();
            }
            else
            {
                lblKet.Text = "Gagal request data";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest("/api/Students", Method.POST){
                RequestFormat=DataFormat.Json };

            var newStudent = new Student
            {
                FirstMidName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                EnrollmentDate = Convert.ToDateTime(txtEnrollment.Text)
            };

            request.AddJsonBody(newStudent);
            try
            {
                var response = client.Execute(request);
                gvStudents.DataBind();
                lblKet.Text = $"Data berhasil ditambah";
            }
            catch (Exception ex)
            {
                lblKet.Text = $"Data gagal ditambah {ex.Message}";
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest($"/api/Students/{id}", Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };

            var editStudent = new Student
            {
                ID=Convert.ToInt32(txtID.Text),
                FirstMidName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                EnrollmentDate = Convert.ToDateTime(txtEnrollment.Text)
            };
            request.AddJsonBody(editStudent);

            try
            {
                var response = client.Execute(request);
                gvStudents.DataBind();
                lblKet.Text = $"Data berhasil diedit";
            }
            catch (Exception ex)
            {
                lblKet.Text = $"Data gagal diedit {ex.Message}";
            }
        }
    }
}