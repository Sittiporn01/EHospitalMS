<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Laboratiorian/LaboratorianMaster.Master" AutoEventWireup="true" CodeBehind="LabTest.aspx.cs" Inherits="EHospitalMS.Views.Laboratiorian.LabTest" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
<div class="containner-fluid">
    <div class="row" style="height:50px"></div>
        <div class="row">
            <div class="col-md-4">
                <h1>Laboratory Test Details</h1>
                <form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Name</label>
    <input type="text" class="form-control" id="LabNameTb" runat="server"/>  

  </div>
    <div class="mb-3">
    <label for="TestCostTb" class="form-label">Test Cost</label>
    <input type="text" class="form-control" id="TestCostTb" runat="server"/> 
        </div>
  <div class="row" style="height:150"></div>
  <label runat="server" id="ErrMsg" class="text-danger" ></label><br />
  <asp:Button ID="Edit" runat="server" Text="  Edit  " class="btn btn-warning" OnClick="Edit_Click" />
  <asp:Button ID="AddBtn" runat="server" Text="  Save  " class="btn btn-primary" OnClick="AddBtn_Click"/>
  <asp:Button ID="DeleteBtn" runat="server" Text="  Delete  " class="btn btn-danger" OnClick="DeleteBtn_Click"/>
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
                        <h1>Laboratory Test Details</h1>
                        <asp:GridView ID="LabTestGV" class="table table-hover" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="LabTestGV_SelectedIndexChanged">
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
