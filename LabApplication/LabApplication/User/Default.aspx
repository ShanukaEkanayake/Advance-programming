<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LabApplication.User.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main>

        <!-- slider Area Start-->
        <div class="slider-area ">
            <!-- Mobile Menu -->
            <div class="slider-active">
                <div class="single-slider slider-height d-flex align-items-center" data-background="../assets/img/hero/h2_hero.jpg">
                    <div class="container">
                        <div class="row">
                            <div class="col-xl-6 col-lg-9 col-md-10">
                                <div class="hero__caption">
                                    <h1 style="color:#ffffff;">Healthcare at its finest</h1>
                                </div>
                            </div>
                        </div>
                        <!-- Search Box -->
                        <div class="row">
                            <div class="col-xl-8">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- slider Area End-->

         <!-- Testimonial Start -->
 <div class="testimonial-area testimonial-padding">
     <div class="container">
         <!-- Testimonial contents -->
         <div class="row d-flex justify-content-center">
             <div class="col-xl-8 col-lg-8 col-md-10">
                 <div class="h1-testimonial-active dot-style">
                     <!-- Single Testimonial -->
                     <div class="single-testimonial text-center">
                         <!-- Testimonial Content -->
                         <div class="testimonial-caption ">
                             <!-- founder -->
                             <div class="testimonial-founder  ">
                                 <div class="founder-img mb-30">
                                     <img src="../assets/img/testmonial/16320.jpg" alt="">
                                     <span>Ralph Waldo Emerson</span>
                                     <p>Creative Director</p>
                                 </div>
                             </div>
                             <div class="testimonial-top-cap">
                                 <p>“To know even one life has breathed easier because you have lived. This is to have succeeded.”</p>
                             </div>
                         </div>
                     </div>
                 </div>
             </div>
         </div>
     </div>
 </div>
 <!-- Testimonial End -->

        <!-- Online Reports Area Start -->
        <div class="online-cv cv-bg section-overly pt-90 pb-120" data-background="../assets/img/gallery/pa1_bg.jpg">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-xl-10">
                        <div class="cv-caption text-center">
                            <p class="pera2">Upload your labs Reports</p>
                            <a href="Profile.aspx" class="border-btn2 border-btn4" style="background-color:#4cd3e3">Add Here</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Online Reports Area End-->
      
       
    </main>

</asp:Content>
