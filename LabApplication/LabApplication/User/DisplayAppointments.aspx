<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="DisplayAppointments.aspx.cs" Inherits="LabApplication.User.DisplayAppointments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
    .gridview {
        font-family: Arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        .gridview th, .gridview td {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        .gridview tr:nth-child(even) {
            background-color: #f2f2f2;
        }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main>
    <div>
        <div class="text-center">
            <h2>Appointment Details</h2>
        </div>
        <div class="m-5">
            <asp:GridView ID="GridView1" runat="server" CssClass="gridview" AutoGenerateColumns="false" PageSize="5">
                <Columns>
                    <asp:TemplateField HeaderText="Company Image">
                        <ItemTemplate>
                            <img width="80" src="<%# GetImageUrl( Eval("SLogo")) %>" alt="">
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Report">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0000ff" 
                                NavigateUrl='<%# DataBinder.Eval(Container,"DataItem.UserReport","../{0}") %>'>
                                <i class="fas fa-download"></i>Download
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Headding" HeaderText="Service Title" />
                    <asp:BoundField DataField="DName" HeaderText="Doctor Name" />
                    <asp:BoundField DataField="SFee" HeaderText="Fee" />
                </Columns>
            </asp:GridView>
        </div>

    </div>
</main>

</asp:Content>
