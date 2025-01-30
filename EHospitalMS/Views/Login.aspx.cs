﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHospitalMS.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }
        Models.Functions Con;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            if(RoleCb.SelectedIndex == 0)
            {
                ErrMsg.InnerText = "Select a Role!!";
            }
            else if(RoleCb.SelectedIndex == 1)
            {
                if(EmailTb.Value =="Amin@gmail.com" && PasswordTb.Value == "Admin")
                {
                    string role = "Admin";
                    Session["uid"] = 1;
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Doctors.aspx";
                    r_url = string.Format(r_url, role);

                    Response.Redirect(r_url); 
                }
                else
                {
                    ErrMsg.InnerText = "Invalin Admin!!";
                }
            }
            else if (RoleCb.SelectedIndex == 2)
            {
                //ErrMsg.InnerText = "Select a Doctor!!";
                string Query = "select * from DoctorTbl where DocEmail = '{0}' and DocPass = '{1}'";
                Query = string.Format(Query, EmailTb.Value ,PasswordTb.Value);
                DataTable dt = Con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Doctor";
                }
                else
                {
                    string role = "Doctors";
                    Session["uid"]= dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Prescriptiona.aspx";
                    r_url = string.Format(r_url, role);

                    Response.Redirect(r_url);
                }
            }
            else if (RoleCb.SelectedIndex == 3)
            {
                //ErrMsg.InnerText = "Select a Receptionist!!";
                string Query = "select * from ReceptionistTbl where RecEmail = '{0}' and RecPassword = '{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Doctor";
                }
                else
                {
                    string role = "Receptionist";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Patients.aspx";
                    r_url = string.Format(r_url, role);

                    Response.Redirect(r_url);
                }
            }
            else if (RoleCb.SelectedIndex == 4)
            {
                //ErrMsg.InnerText = "Select a Laboratorian!!";
                string Query = "select * from LaboratorianTbl where LabEmail = '{0}' and LabPass = '{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Laboratorian";
                }
                else
                {
                    string role = "Laboratiorian";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/LabTest.aspx";
                    r_url = string.Format(r_url, role);

                    Response.Redirect(r_url);
                }
            }
        }
    }
}