<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="BackendExercise.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.2.0/jquery-confirm.min.css" />
    <link href="styles/CommonStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <%--Loader--%>
        <div id="loaderHolder">
            <div id="loader">
                <img src="images/ajax-loader.gif" alt="Loading.." />
            </div>
        </div>

        <div class="container text-center">
            <div class="row justify-content-center">
                <div class="col-12">
                    <h1>Send Email</h1>
                </div>
            </div>

            <div class="mt-5 formBackGroundColor">
                <div class="row justify-content-center">
                    <div class="col-md-3 text-left">
                        <label>To Email : </label>
                    </div>
                    <div class="col-md-3">
                        <input type="text" id="txtToAddress" class="form-control" />
                    </div>
                </div>
                <div class="row justify-content-center mt-2">
                    <div class="col-md-3 text-left">
                        <label>From Email : </label>
                    </div>
                    <div class="col-md-3">
                        <input type="text" id="txtFromAddress" class="form-control" />
                    </div>
                </div>
                <div class="row justify-content-center mt-2">
                    <div class="col-md-3 text-left">
                        <label>Subject : </label>
                    </div>
                    <div class="col-md-3">
                        <input type="text" id="txtSubject" class="form-control" />
                    </div>
                </div>

                <div class="row justify-content-center mt-2">
                    <div class="col-md-3 text-left">
                        <label>Body : </label>
                    </div>
                    <div class="col-md-3">
                        <textarea name="textarea" id="txtBody" rows="3" class="form-control"></textarea>
                    </div>
                </div>
                <div class="row justify-content-center mt-4">
                    <input type="button" value="Send Mail" id="btnSendEmail" class="btn btn-primary" />
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.2.0/jquery-confirm.min.js"></script>
    <script src="scripts/customScripts/Common.js"></script>
    <script src="scripts/customScripts/SendEmail.js"></script>
</body>
</html>
