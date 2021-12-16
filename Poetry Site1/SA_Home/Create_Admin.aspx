<%@ Page Title="" Language="C#" MasterPageFile="~/SA_Home/Site2.Master" AutoEventWireup="true" CodeBehind="Create_Admin.aspx.cs" Inherits="Poetry_Site1.SA_Home.Create_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    

                </div>

                <div class="col-md-6">
                    <h2>Create Admin</h2>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Email Id"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Contact" ></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Department"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" placeholder="Date of Joining"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" placeholder="Create Admin User ID" ></asp:TextBox>
                    <br />
                     <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" placeholder="Create Password" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Create Admin" CssClass="btn-danger" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    
                </div>
            </div>

        </div>

    </form>

</asp:Content>
