<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="Poetry_Site1.Admin_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    

                </div>

                <div class="col-md-6">
                    <h2>Admin Login</h2>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" cssclass="form-control" placeholder="User ID" ></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" cssclass="form-control" placeholder="Password" type="Password"></asp:TextBox>
                  <br />
                    <asp:Button runat="server" Text="Login" cssclass="btn-success" OnClick="Unnamed1_Click"  />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    </div>
                </div>
            </div>
        </form>
</asp:Content>
