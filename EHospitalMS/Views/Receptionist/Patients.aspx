<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="EHospitalMS.Views.Receptionist.Patients" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="containner-fluid">
        <div class="row">
            <div class="col-md-3">
                <h1>Patient Detail</h1>
                <form>
  <div class="mb-3">
    <label for="PatNameTb" class="form-label">Name</label>
    <input type="text" class="form-control" id="PatNameTb" runat="server"/>  

  </div>
    <div class="mb-3">
    <label for="PhoneTb" class="form-label">Phone</label>
    <input type="text" class="form-control" id="PhoneTb" runat="server"/> 
        
  </div>
   <div class="mb-3">
    <label for="GenderCb" class="form-label">Gender</label>
    <asp:DropDownList ID="GenderCB" runat="server" class="form-control">
          <asp:ListItem>Male</asp:ListItem>
          <asp:ListItem>Female</asp:ListItem>
      </asp:DropDownList>
  </div>
 <div class="mb-3">
    <label for="DOBTb" class="form-label">DOB</label>
    <input type="date" class="form-control" id="DOBTb" runat="server"/> 
        
  </div>
   <div class="mb-3">
    <label for="AddressTb" class="form-label">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat="server"/>
  </div>
   
  <div class="mb-3">
    <label for="AllergyTb" class="form-label">Allergies</label>
    <input type="text" class="form-control" id="AllergyTb" runat="server"/>
  </div>
  
  <label runat="server" id="ErrMsg" class="text-danger" ></label><br />
  <asp:Button ID="Edit" runat="server" Text="Edit" class="btn btn-warning" OnClick="Edit_Click"  />
  <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click"  />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click"  />
</form>
            </div>
            <div class="col-md-9">
               
                <div class="row">
                    <div class="col">
                        <h1>Patients Details</h1>
                        <asp:GridView ID="PatientList" class="table table-hover" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="PatientList_SelectedIndexChanged">
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
