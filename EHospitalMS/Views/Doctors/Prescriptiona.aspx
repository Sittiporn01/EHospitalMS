<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctors/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="Prescriptiona.aspx.cs" Inherits="EHospitalMS.Views.Doctors.Prescriptiona" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="containner-fluid">
        <div class="row">
            <div class="col-md-4">
                <h1>Prescription Detail</h1>
                <br />
                <form>
  <div class="mb-3">
    <label for="PatientCb" class="form-label">Patient</label>
    <asp:DropDownList ID="PatientCb" runat="server" class="form-control">
          
      </asp:DropDownList> 

  </div>
    <div class="mb-3">
    <label for="MedicientTb" class="form-label">Mediciens</label>
    <input type="text" class="form-control" id="MedicientTb" runat="server"/> 
        
  </div>
 <div class="mb-3">
    <label for="TestCb" class="form-label">Lab Test</label>
    <asp:DropDownList ID="TestCb" runat="server" class="form-control">
          
      </asp:DropDownList> 
        
  </div>

   <div class="mb-3">
    <label for="CostTB" class="form-label">Cost</label>
    <input type="text" class="form-control" id="CostTB" runat="server"/>
  </div>

<div class="d-grid">
   <label runat="server" id="ErrMsg" class="text-danger" ></label><br />
  
  <asp:Button ID="AddBtn" runat="server" Text="Save Prescription" class="btn btn-warning btn-block text-white" OnClick="AddBtn_Click"  />
  
</div>
  
</form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Laboratorian.jpg" height="200px" width="95%" class="rounded-3"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h1>Prescription Details</h1>
                        <asp:GridView ID="PrescriptionGV" class="table table-hover" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="PrescriptionGV_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
