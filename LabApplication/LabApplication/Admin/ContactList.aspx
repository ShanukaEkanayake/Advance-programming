﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="LabApplication.Admin.ContactList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover; background-attachment: fixed;">
    <div class="container-fulid pt-4 pb-4">
        <div>
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>

        <h3 class="text-center">Contact Details</h3>

        <div class="row mb-3 pt-sm-3">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-bordered"
                    EmptyDataText="No records to display.." AutoGenerateColumns="False" AllowPaging="True"
                    PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" DataKeyNames="MessageId" 
                    OnRowDeleting="GridView1_RowDeleting" HeaderStyle-HorizontalAlign="Center">
                    <Columns>

                        <asp:BoundField DataField="Sr.No" HeaderText="Sr.No">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="PName" HeaderText="Name">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="PEmail" HeaderText="Email">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="PMessage" HeaderText="Message">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:CommandField CausesValidation="false" HeaderText="Delete" ShowDeleteButton="true" 
                            DeleteImageUrl="../assets/img/icon/trashIcon.png" ButtonType="Image">
                            <ControlStyle Height="25px" Width="25px"/>
                            <ItemStyle HorizontalAlign="Center"/>
                        </asp:CommandField>

                    </Columns>
                    <HeaderStyle  BackColor="darkslateblue" ForeColor="White"/>
                </asp:GridView>
            </div>
        </div>

    </div>
</div>

</asp:Content>
