<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
     CodeBehind="StudentsForm.aspx.cs" ViewStateMode="Disabled" EnableViewState="false" Inherits="WebFormClient.StudentsForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        
        <div class="col-md-6">
            <h2>Daftar Mahasiswa</h2>
            <asp:GridView runat="server" ID="gvStudents" CssClass="table table-striped">
            </asp:GridView>
            <asp:Label ID="lblKet" runat="server" />
        </div>
        <div class="col-md-6">
            <h2>Insert Edit Student</h2>
            <div class="form-group">
                <label for="txtID">ID :</label>
                <asp:TextBox runat="server" ID="txtID" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtFirstName">First Name :</label>
                <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtLastName">Last Name :</label>
                <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtAddress">Address :</label>
                <asp:TextBox runat="server" ID="txtAddress" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtEnrollment">Enrollment Date :</label>
                <asp:TextBox runat="server" ID="txtEnrollment" TextMode="Date" 
                    CssClass="form-control" />
            </div>
            <asp:Button Text="Submit" ID="btnSubmit" 
                CssClass="btn btn-default" runat="server" OnClick="btnSubmit_Click" />
            <asp:Button Text="Edit" ID="btnEdit" CssClass="btn btn-primary" runat="server" OnClick="btnEdit_Click" />
            <asp:Button Text="Delete" CssClass="btn btn-danger" runat="server" ID="btnDelete" OnClick="btnDelete_Click" />
        </div>
    </div>
</asp:Content>
