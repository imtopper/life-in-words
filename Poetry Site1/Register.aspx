<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Poetry_Site1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    

                </div>

                <div class="col-md-6">
                    <h2>Register Yourself</h2>
                    <p>What Are You Waiting For. Register Yourself And Share Your Stories.</p>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Enter Your Name"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Enter Your Email ID"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Create Password" type="Password"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Confirm Password" type="Password"></asp:TextBox>
                    <br />
                    <asp:Image ID="captchaImage" runat="server" Height="40px" Width="150px" ImageUrl="~/MyCaptcha.aspx" />
                    <asp:TextBox ID="captchaCode" runat="server" CssClass="form-control" placeholder="Enter Captcha Code"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn-success" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    
                </div>
            </div>

        </div>

    </form>
</asp:Content>
