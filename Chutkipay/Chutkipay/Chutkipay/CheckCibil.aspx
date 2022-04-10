﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="CheckCibil.aspx.cs" Inherits="CheckCibil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="bg-light">
      <div class="container">
        <div class="row d-flex align-items-center">
          <div class="col-lg-5 col-md-12 col-12">
            <div class="p-3 p-lg-0 py-md-6">
              <h1 class="display-3">Get Your Credit Score - It's FREE</h1>
              <p class="lead">
                The smart choice when it comes to finding credit that’s just
                right for you
              </p>
              <div class="mb-4">
                  <asp:TextBox ID="txtmob" runat="server" class="form-control"  placeholder="Mobile Number +91-"  required=""></asp:TextBox>
                   <asp:Button ID="btnget" runat="server"  class="btn btn-primary"  Text="Get Credit Score" OnClick="btnget_Click" />
                 <asp:TextBox ID="TextBox1" runat="server" class="form-control"  placeholder="Mobile Number +91-"  ></asp:TextBox>
               
              </div>
              <p class="mb-0">No credit card required—ever</p>
              <p>Checking your score won't hurt your credit</p>
              <a href="#!" class="btn-link border-bottom fs-5 border-2
                border-primary fw-bold">Advertiser Disclosure</a>
            </div>
          </div>
          <div class="col-lg-7 col-md-7 col-12 d-md-none d-lg-block">
            <div class="pt-8">
              <img src="https://easetemplate.com/borrow/assets/images/background/hero-creditstore.png"
                alt="Rajkarm- Loan Company Responsive Website Templates"
                class="img-fluid" />
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="py-lg-14 py-10 bg-white">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 col-md-12 col-12">
            <div class="mb-5 text-center">
              <h1>How the service works</h1>
              <p>
                Being aware of your credit score may allow you to negotiate a
                better rate <br />with some lenders.
              </p>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-3 col-md-6 col-12 mb-4 mb-lg-0">
            <div class="card h-100">
              <div class="card-body">
                <img src="https://easetemplate.com/borrow/assets/images/icon/icon-1.svg" alt="Rajkarm- Loan
                  Company Responsive Website Templates" class="mb-4 icon-xl" />
                <p class="mb-0">
                  Fill out your profile so that we can accurately determine your
                  credit rating.
                </p>
              </div>
            </div>
          </div>
          <div class="col-lg-3 col-md-6 col-12 mb-4 mb-lg-0">
            <div class="card h-100">
              <div class="card-body">
                <img src="https://easetemplate.com/borrow/assets/images/icon/icon-2.svg" alt="Rajkarm- Loan
                  Company Responsive Website Templates" class="mb-4 icon-xl" />
                <p class="mb-0">
                  We got the your form request and We will make your personal
                  rating and solutions.
                </p>
              </div>
            </div>
          </div>
          <div class="col-lg-3 col-md-6 col-12 mb-4 mb-lg-0">
            <div class="card h-100">
              <div class="card-body">
                <img src="https://easetemplate.com/borrow/assets/images/icon/icon-3.svg" alt="Rajkarm- Loan
                  Company Responsive Website Templates" class="mb-4 icon-xl" />
                <p class="mb-0">
                  We will offer you recommendations on how to improve your
                  rating.
                </p>
              </div>
            </div>
          </div>
          <div class="col-lg-3 col-md-6 col-12 mb-4 mb-lg-0">
            <div class="card h-100">
              <div class="card-body">
                <img src="https://easetemplate.com/borrow/assets/images/icon/icon-4.svg" alt="Rajkarm- Loan
                  Company Responsive Website Templates" class="mb-4 icon-xl" />
                <p class="mb-0">
                  An additional bouns for cutomers with a good rating is a
                  credit solution from banks online.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
      <hr class="my-lg-16 my-10" />
    <%--  <div class="container">
        <div class="row">
          <div class="col-lg-12 col-md-12 col-12">
            <div class="mb-8 text-center">
              <h1>We’ll help you make smarter choices</h1>
              <p>
                We’ve got the data that matters. We use it to benefit you best
                by finding <br /> credit cards and personal loans that you’re
                more likely to get.
              </p>
            </div>
          </div>
        </div>
        <div class="row align-items-center">
          <div class="offset-lg-1 col-lg-4 col-md-6 col-12 mb-4 mb-lg-0">
            <div class="d-flex align-items-center mb-4">
              <img src="https://easetemplate.com/borrow/assets/images/avatar/avatar-1.jpg" class="icon-md
                icon-shape rounded-circle" alt="..." />
              <div class="ms-3">
                <h5 class="mb-0">Hi, Bernard Fisher</h5>
              </div>
            </div>
            <h5 class="mb-3">Your credit card result</h5>

            <div class="card mb-3 smooth-shadow-sm border-0">
              <span class="badge bg-info position-absolute end-0 rounded-0 fs-7
                rounded-top-end-2 rounded-bottom-start-2">Guaranteed Rate</span>
              <div class="card-body">
                <div class="d-flex align-items-start">
                  <img src="https://easetemplate.com/borrow/assets/images/png/card-1.png" alt="Rajkarm- Loan
                    Company Responsive Website Templates" class="w-25"/>
                  <div class="ms-3">
                    <h5 class="mb-1">RajkarmPlus Money</h5>
                    <p class="fs-7 mb-0">
                      <span class=" text-dark">21.9%</span>
                      <span class="me-1">Guaranteed APR</span>
                      <span><i class="fas fa-check-circle me-1 text-success"></i>Pre
                        Approved</span>
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="card mt-2 mb-3 smooth-shadow-sm border-0">
              <div class="card-body">
                <div class="d-flex align-items-start">
                  <img src="https://easetemplate.com/borrow/assets/images/png/card-2.png" alt="Rajkarm- Loan
                    Company Responsive Website Templates" class="w-25" />
                  <div class="ms-3">
                    <h5 class="mb-1">RajkarmDemo Privileges</h5>
                    <p class="fs-7 mb-0">
                      <span class="text-dark">20.9%</span>
                      <span class="me-1">Guaranteed APR</span>
                      <span><i class="fas fa-check-circle me-1 text-success"></i>Pre
                        Approved</span>
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="card smooth-shadow-sm border-0">
              <div class="card-body">
                <div class="d-flex align-items-start">
                  <img src="https://easetemplate.com/borrow/assets/images/png/card-3.png" alt="Rajkarm- Loan
                    Company Responsive Website Templates" class="w-25" />
                  <div class="ms-3">
                    <h5 class="mb-1">RajkarmMoney Back</h5>
                    <p class="fs-7 mb-0">
                      <span class="text-dark">18.2%</span>
                      <span class="me-1 fs-7">Guaranteed APR</span>
                      <span><img
                          src="https://easetemplate.com/borrow/assets/images/svg/dougnut-small.svg"
                          alt="Rajkarm- Loan Company Responsive Website
                          Templates"
                          class="me-1 icon"
                          />
                        Eligiblity</span>
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="offset-lg-1 col-lg-5 col-md-6 col-12">
            <div class="d-flex mb-5 align-items-center">
              <img src="https://easetemplate.com/borrow/assets/images/svg/eligibility.svg" alt="..."
                />
              <div class="ms-5">
                <h3 class="mt-0">Eligibility</h3>
                <p class="mb-0">
                  See how likely you are to be accepted for certain offers,
                  before
                  applying
                </p>
              </div>
            </div>
            <div class="d-flex mb-5">
              <img src="https://easetemplate.com/borrow/assets/images/svg/preapproval.svg" alt="..."
                />
              <div class="ms-5">
                <h3 class="mt-0">Pre-approval</h3>
                <p class="mb-0">
                  Our green tick gives you the green-light to apply with
                  confidence
                </p>
              </div>
            </div>
            <div class="d-flex">
              <img src="https://easetemplate.com/borrow/assets/images/svg/guaranteed.svg" alt="..."
                />
              <div class="ms-5">
                <h3 class="mt-0">Guaranteed rates</h3>
                <p class="mb-0">
                  These rates are guaranteed, so the rate you see, is the rate
                  you’ll get
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="py-12 bg-primary">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 col-md-12 col-12">
            <div class="text-center mb-6">
              <h1 class="text-white">Find out your credit rating</h1>
              <p class="text-white">
                We will create your personal account in which you can track the
                <br />change in your rating.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="mt-n14">
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-xl-7 col-lg-12 col-md-12 col-12">
            <div class="card mx-4 bg-white shadow">
              <div class="card-body">
                <form class="row g-1">
                  <div class="col-lg-8 col-md-6 col-12">
                    <label for="phonenumber" class="sr-only"></label>
                    <input
                      class="form-control"
                      type="text"
                      placeholder="+91"
                      id="phonenumber"
                      required=""
                      />
                  </div>
                  <div class="col-lg-4 col-md-6 col-12">
                    <div class="d-grid">
                      <button type="submit" class="btn btn-dark">
                        Get Code by SMS
                      </button>
                    </div>
                  </div>
                </form>
                <p class="mt-2 fs-6">
                  We will create your personal account in which you can track
                  the
                  change in your rating.
                </p>
                <div class="form-check custom-checkbox">
                  <input
                    type="checkbox"
                    class="form-check-input"
                    id="information"
                    />
                  <label class="form-check-label fs-6" for="information">I agree
                    with the rules for the provision of
                    information.</label>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>--%>
    </div>
    
    


</asp:Content>

