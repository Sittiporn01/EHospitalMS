using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHospitalMS.Views.Admin
{
    public partial class Doctors : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowDocttors();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowDocttors()
        {
            string Query = "Select * from DoctorTbl";
            DoctorsGV.DataSource = Con.GetDatas(Query);
            DoctorsGV.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string DocName = DocNameTb.Value;
                string DocPhone = DocPhoneTb.Value;
                string DocExp = DocExTb.Value;
                string DocSpec = SpecialisationTb.Value;
                string DocGen = GenderCB.SelectedItem.ToString();
                string DocAdd = AddressTb.Value;
                string DOB = DOBTb.Value;
                string DocPass = PasswordTb.Value;
                string DocEmail = EmailTb.Value;
                string Query = "insert into DoctorTbl values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')";
                Query = string.Format(Query, DocName, DocPhone, DocExp, DocSpec, DocGen, DocAdd, DOB, DocPass,DocEmail);
                Con.SetDatas(Query);
                ShowDocttors();
                ErrMsg.InnerText = "Doctor Added!!";
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExTb.Value = "";
                SpecialisationTb.Value = "";
                GenderCB.SelectedIndex = -1;
                AddressTb.Value = "";
                DOBTb.Value = "";
                PasswordTb.Value = "";
                EmailTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void DoctorsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocNameTb.Value = DoctorsGV.SelectedRow.Cells[2].Text;
            DocPhoneTb.Value = DoctorsGV.SelectedRow.Cells[3].Text;
            DocExTb.Value = DoctorsGV.SelectedRow.Cells[4].Text;
            SpecialisationTb.Value = DoctorsGV.SelectedRow.Cells[5].Text;
            GenderCB.SelectedItem.Value = DoctorsGV.SelectedRow.Cells[6].Text;
            AddressTb.Value = DoctorsGV.SelectedRow.Cells[7].Text;
            DOBTb.Value = DoctorsGV.SelectedRow.Cells[8].Text;
            PasswordTb.Value = DoctorsGV.SelectedRow.Cells[9].Text;
            EmailTb.Value = DoctorsGV.SelectedRow.Cells[10].Text;
            if (DocNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorsGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DocNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Select a Doctor!!";

                }
                else
                {
                    string Query = "delete from DoctorTbl where DocId={0}";
                    Query = string.Format(Query, DoctorsGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowDocttors();
                    ErrMsg.InnerText = "Doctor Deleted!!";
                    Key = 0;
                    DocNameTb.Value = "";
                    DocPhoneTb.Value = "";
                    DocExTb.Value = "";
                    SpecialisationTb.Value = "";
                    GenderCB.SelectedIndex = -1;
                    AddressTb.Value = "";
                    DOBTb.Value = "";
                    PasswordTb.Value = "";
                    EmailTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string DocName = DocNameTb.Value;
                string DocPhone = DocPhoneTb.Value;
                string DocExp = DocExTb.Value;
                string DocSpec = SpecialisationTb.Value;
                string DocGen = GenderCB.SelectedItem.ToString();
                string DocAdd = AddressTb.Value;
                string DOB = DOBTb.Value;
                string DocPass = PasswordTb.Value;
                string DocEmail = EmailTb.Value;
                string Query = "update DoctorTbl set DocName ='{0}',DocPhone='{1}',DocExp={2},DocSpec='{3}',DocGen='{4}',DocAdd='{5}',DocDOB='{6}',DocPass='{7}',DocEmail='{8}' where DocId ={9}";
                Query = string.Format(Query, DocName, DocPhone, DocExp, DocSpec, DocGen, DocAdd, DOB, DocPass, DocEmail, DoctorsGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowDocttors();
                ErrMsg.InnerText = "Doctor Update!!";
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExTb.Value = "";
                SpecialisationTb.Value = "";
                GenderCB.SelectedIndex = -1;
                AddressTb.Value = "";
                DOBTb.Value = "";
                PasswordTb.Value = "";
                EmailTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}