using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHospitalMS.Views.Laboratiorian
{
    public partial class LabTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowTest();
        }
        Models.Functions Con;
        private void ShowTest()
        {
            string Query = "Select * from LabTestTbl";
            LabTestGV.DataSource = Con.GetDatas(Query);
            LabTestGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string User = Session["uid"] as string;
                string TestName = LabNameTb.Value;
                string TestCost = TestCostTb.Value;
                string Query = "insert into LabTestTbl values('{0}','{1}',{2})";
                Query = string.Format(Query, TestName, TestCost, User);
                Con.SetDatas(Query);
                ShowTest();
                ErrMsg.InnerText = "Test Added!!";
                LabNameTb.Value = "";
                TestCostTb.Value = "";

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void LabTestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LabTestGV.SelectedRow.Cells[2].Text;
            TestCostTb.Value = LabTestGV.SelectedRow.Cells[3].Text;

            if (LabNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabTestGV.SelectedRow.Cells[1].Text);
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
                    string Query = "delete from LabTestTbl where TestId={0}";
                    Query = string.Format(Query, LabTestGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowTest();
                    ErrMsg.InnerText = "Test Deleted!!";
                    Key = 0;
                    LabNameTb.Value = "";
                    TestCostTb.Value = "";
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
                string TestName = LabNameTb.Value;
                string TestCost = TestCostTb.Value;
                string Query = "update LabTestTbl set TestName ='{0}',TestCost={1} where TestId ={2}";
                Query = string.Format(Query, TestName, TestCost, LabTestGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowTest();
                ErrMsg.InnerText = "Test Update!!";
                LabNameTb.Value = "";
                TestCostTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}