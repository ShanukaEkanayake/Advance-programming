﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="ServiceDetails.aspx.cs" Inherits="LabApplication.User.ServiceDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main>

    <!-- Hero Area Start-->
    <div class="slider-area ">
    <div class="single-slider section-overly slider-height2 d-flex align-items-center" data-background="../assets/img/hero/about1.jpg">
        <div class="container">
            <div class="row">
                <div class="col-xl-12">
                    <div class="hero-cap text-center">
                        <h2><%# serviceTitle %></h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    <!-- Hero Area End -->

        <div>
            <asp:Label ID="lblMsg" runat="server" Visible="false"></asp:Label>
        </div>

    <!-- Service post company Start -->
    <div class="job-post-company pt-120 pb-120">
        <div class="container">
            <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound">

                <ItemTemplate>

            <div class="row justify-content-between">
                <!-- Left Content -->
                <div class="col-xl-7 col-lg-8">
                    <!-- Service single -->
                    <div class="single-job-items mb-50">
                        <div class="job-items">
                            <div class="company-img company-img-details mb-3">
                                <a href="#">
                                    <img width="80" src="<%# GetImageUrl(Eval("SLogo")) %>"" alt=""></a>
                            </div>
                            <div class="job-tittle">
                                <a href="#">
                                    <h4><%# Eval("Headding") %></h4>
                                </a>
                                <ul>
                                    <li><%# Eval("DName") %></li>
                                    <li><i class="fas fa-map-marker-alt"></i><%# Eval("State") %>, <%# Eval("SContact") %></li>
                                    <li><%# Eval("SFee") %></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                      <!-- Service single End -->
                   
                    <div class="job-post-details">
                        <div class="post-details1 mb-50">
                            <!-- Small Section Tittle -->
                            <div class="small-section-tittle">
                                <h4>Service Description</h4>
                            </div>
                            <p><%# Eval("SDescription") %></p>
                        </div>
                        <div class="post-details2  mb-50">
                             <!-- Small Section Tittle -->
                            <div class="small-section-tittle">
                                <h4>Qualification</h4>
                            </div>
                           <ul>
                               <li><%# Eval("Qualification") %></li>
                           </ul>
                        </div>
                    </div>

                </div>
                <!-- Right Content -->
                <div class="col-xl-4 col-lg-4">
                    <div class="post-details3  mb-50">
                        <!-- Small Section Tittle -->
                       <div class="small-section-tittle">
                           <h4>Service Overview</h4>
                       </div>
                      <ul>
                          <li>Posted date : <span><%# DataBinder.Eval(Container.DataItem,"AddDate", "{0:dd MMMM yyyy}") %></span></li>
                          <li>Location : <span><%# Eval("State") %></span></li>
                          <li>Avilable for : <span><%# Eval("SCount") %></span></li>
                          <li>Service nature : <span><%# Eval("SType") %></span></li>
                          <li>Channel Fee :  <span><%# Eval("SFee") %></span></li>
                          <li>AVailable Untill : <span><%# DataBinder.Eval(Container.DataItem,"ApplyBefore", "{0:dd MMMM yyyy}") %></span></li>
                      </ul>
                     <div class="apply-btn2">
                         <asp:LinkButton ID="lbApplyService" runat="server" CssClass="btn" Text="Apply Now" CommandName="ApplyService" BackColor="#4cd3e3" OnClick="lbApplyService_Click"></asp:LinkButton>
                     </div>
                   </div>
                    <div class="post-details4  mb-50">
                        <!-- Small Section Tittle -->
                       <div class="small-section-tittle">
                           <h4>Company Information</h4>
                       </div>
                          <span>ABC LABORATORIES</span>
                          <p>Address:</b><%# Eval("SAddress") %></p>
                        <ul>
                            <li>Name: <span>ABC LABS </span></li>
                        </ul>
                   </div>
                </div>
            </div>


                </ItemTemplate>

            </asp:DataList>
        </div>
    </div>
    <!-- Service post company End -->

</main>

</asp:Content>
