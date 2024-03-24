<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="LabApplication.User.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .post-btn{
            background-color:#4cd3e3;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main>

    <!-- Hero Area Start-->
    <div class="slider-area ">
    <div class="single-slider section-overly slider-height2 d-flex align-items-center" data-background="../assets/img/hero/about2.jpg">
        <div class="container">
            <div class="row">
                <div class="col-xl-12">
                    <div class="hero-cap text-center">
                        <h2>About us</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    <!-- Hero Area End -->
    <!-- Support Company Start-->
    <div class="support-company-area fix section-padding2">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-xl-6 col-lg-6">
                    <div class="right-caption">
                        <!-- Section Tittle -->
                        <div class="section-tittle section-tittle2">
                            <span>What About us</span>
                        </div>
                        <div class="support-caption">
                            <p class="pera-top">The saga of the ABC LABS of Sri Lanka has been recounted by Dr Uragoda in his book. According to his account, the ABC LABS (as it was then known) was established during Sir Henry Wards governorship (1855-1860), with 3000 pounds sterling being earmarked for the project. .</p>
                            <p>Until then, the government policy had been to contribute to natively-run charitable health organisations. However, after the establishment of the General Hospital, this policy was abandoned. Furthermore, the General Hospital also succeeded the Pettah Hospital, since its capacity to treat patients was very low. Accordingly, the General Hospital was opened in Longden Place in 1864, under the inaugural administration of Chief Civil Medical Officer Dr Parsley.</p>
                            <a href="ServiceDetails.aspx" class="btn post-btn">Apply Service</a>
                        </div>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6">
                    <div class="support-location-img">
                        <img src="../assets/img/service/support-img2.jpg" alt="">
                        <div class="support-img-cap text-center">
                            <p>Since</p>
                            <span>1855</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Support Company End-->
    <!-- How  Apply Process Start-->
 <div class="apply-process-area apply-bg pt-150 pb-150" data-background="../assets/img/gallery/how-applybg1.jpg">
     <div class="container">
         <!-- Section Tittle -->
         <div class="row">
             <div class="col-lg-12">
                 <div class="section-tittle white-text text-center">
                     <h2>How Can Apply</h2>
                 </div>
             </div>
         </div>
         <!-- Apply Process Caption -->
         <div class="row">
             <div class="col-lg-4 col-md-6">
                 <div class="single-process text-center mb-30" style="background-color:#808080">
                     <div class="process-ion">
                         <span class="flaticon-search"></span>
                     </div>
                     <div class="process-cap">
                         <h5>1. Search Us</h5>
                         <p>Your journey to finding the ideal service starts here, Discover your perfect match in just a click.</p>
                     </div>
                 </div>
             </div>
             <div class="col-lg-4 col-md-6">
                 <div class="single-process text-center mb-30" style="background-color:#808080">
                     <div class="process-ion">
                         <span class="flaticon-curriculum-vitae"></span>
                     </div>
                     <div class="process-cap">
                         <h5>2. Apply to Us</h5>
                         <p>Apply in minutes, enjoy the benefits for a lifetime, Simplify your journey to access top-notch service.</p>
                     </div>
                 </div>
             </div>
             <div class="col-lg-4 col-md-6">
                 <div class="single-process text-center mb-30" style="background-color:#808080">
                     <div class="process-ion">
                         <span class="flaticon-tour"></span>
                     </div>
                     <div class="process-cap">
                         <h5>3. Get Service</h5>
                         <p>Get ready to experience service like never before, Your service, your way, delivered at your convenience.</p>
                     </div>
                 </div>
             </div>
         </div>
     </div>
 </div>
 <!-- How  Apply Process End-->
  
</main>

</asp:Content>
