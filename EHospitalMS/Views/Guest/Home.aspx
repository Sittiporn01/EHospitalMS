﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EHospitalMS.Views.Guest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../../Libs/Bootstrap/css/bootstrap.min.css"/>
</head>
<body>
    <!--<form id="form1" runat="server">
        <div>

        </div>
    </form>-->

<div class="container-fluid">
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#"><img src="../../Assets/Images/Capture.PNG" height="50px" width="40%" />Clinic MS</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link" href="">Doctors</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="">Laboratorian</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="">Receptionist</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="../Login.aspx">Login</a>
        </li>
      
    </div>
  </div>
</nav>
</div>

    <div class="row" style="background-image:url(../../Assets/Images/Capture2.PNG); height:480px; background-size:cover;">
        <div class="col-md-2">

        </div>
        <div class="col-md-5">
            <div class="row" style="height:100px">

            </div>
            <h2>Your Health is our only Priority</h2>
            <h2>Alway Serving and Taking Care</h2>
            <p class="h6">Our Clinic has been created in 2023 by a group of person who wanted</p> 
            <p class="h6">to really take care of the health of the population.</p> <br />
            <button class="btn btn-primary">Contact Us</button>
            <button class="btn btn-light border-primary text-primary">Feed Back</button>
            
        </div>
    </div>
    <div class="row bg-primary">
        <div class="row" style="height:20px"></div>
        <div class="row">
             <div class="col-md-3 bg-light offset-1 rounded-3">
           
            <div class="row">
            <div class="col-2">
                <img src="../../Assets/Images/icons8-lab-96.png"  height="50px" width="70%"/>
            </div>
            <div class="col-7">
                <h5 class="text-center">Sugery</h5>
                <p class="h6">The Clinic has a Surgery Department with highly qualified Doctors</p>
            </div>

            </div>
        </div>    

        <div class="col-md-3  bg-light offset-1 rounded-3">
            <div class="row">
            <div class="col-2">
                <img src="../../Assets/Images/icons8-lab-96.png"  height="50px" width="70%"/>
            </div>
            <div class="col-7">
                <h5 class="text-center">Urology</h5>
                <p class="h6">The Clinic has a Surgery Department with highly qualified Doctors</p>
            </div>

            </div>

         </div>

        <div class="col-md-3  bg-light offset-1 rounded-3">
            <div class="row">
            <div class="col-2">
                <img src="../../Assets/Images/icons8-lab-96.png"  height="50px" width="70%"/>
            </div>
            <div class="col-7">
                <h5 class="text-center">Ophtalmology</h5>
                <p class="h6">The Clinic has a Surgery Department with highly qualified Doctors</p>
            </div>

            </div>

        </div>
        </div>
      
        <div class="row" style="height:22px"></div>
    </div>
</body>
</html>
