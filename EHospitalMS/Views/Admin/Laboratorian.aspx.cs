using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHospitalMS.Views.Admin
{
    public partial class Laboratiorian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowLaboratorian();
        }
        Models.Functions Con;
        private void ShowLaboratorian()
        {
            string Query = "Select * from LaboratorianTbl";
            LabGV.DataSource = Con.GetDatas(Query);
            LabGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = LabNameTb.Value;
                string LabEmail = EmailTb.Value;
                string LabPass = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAdd = LabAddressTb.Value;
                string LabGen = GenderCB.SelectedItem.Value;
                string Query = "insert into LaboratorianTbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                Query = string.Format(Query, LabName, LabEmail, LabPass, LabPhone, LabAdd, LabGen);
                Con.SetDatas(Query);
                ShowLaboratorian();
                ErrMsg.InnerText = "Laboratorian Added!!";
                LabNameTb.Value = "";
                EmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                LabAddressTb.Value = "";
                GenderCB.SelectedIndex = -1;
               
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void LabGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LabGV.SelectedRow.Cells[2].Text;
            EmailTb.Value = LabGV.SelectedRow.Cells[3].Text;
            PasswordTb.Value = LabGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = LabGV.SelectedRow.Cells[5].Text;
            LabAddressTb.Value = LabGV.SelectedRow.Cells[6].Text;
            GenderCB.SelectedItem.Value = LabGV.SelectedRow.Cells[7].Text;

            if (LabNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Select a Laboratorian!!";

                }
                else
                {
                    string Query = "delete from LaboratorianTbl where LabId={0}";
                    Query = string.Format(Query, LabGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowLaboratorian();
                    ErrMsg.InnerText = "Laboratorian Deleted!!";
                    Key = 0;
                    LabNameTb.Value = "";
                    EmailTb.Value = "";
                    PasswordTb.Value = "";
                    PhoneTb.Value = "";
                    LabAddressTb.Value = "";
                    GenderCB.SelectedIndex = -1;
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
                string LabName = LabNameTb.Value;
                string LabEmail = EmailTb.Value;
                string LabPass = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAdd = LabAddressTb.Value;
                string LabGen = GenderCB.SelectedItem.Value;
                string Query = "update LaboratorianTbl set LabName ='{0}',LabEmail='{1}',LabPass='{2}',LabPhone='{3}',LabAddress='{4}',LabGen='{5}' where LabId ={6}";
                Query = string.Format(Query, LabName, LabEmail, LabPass, LabPhone, LabAdd, LabGen, LabGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowLaboratorian();
                ErrMsg.InnerText = "Laboratorian Update!!";
                LabNameTb.Value = "";
                EmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                LabAddressTb.Value = "";
                GenderCB.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}