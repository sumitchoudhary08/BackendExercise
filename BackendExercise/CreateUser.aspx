<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="BackendExercise.CreateUser" %>

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
                    <h1>Create User</h1>
                </div>
            </div>

            <div class="mt-5 formBackGroundColor">
                <div class="row justify-content-center">
                    <div class="col-3 text-left">
                        <label>Name : </label>
                    </div>
                    <div class="col-3">
                        <input type="text" id="txtName" class="form-control" />
                    </div>
                </div>
                <div class="row justify-content-center mt-2">
                    <div class="col-3 text-left">
                        <label>E-mail : </label>
                    </div>
                    <div class="col-3">
                        <input type="text" id="txtEmail" class="form-control" />
                    </div>
                </div>
                <div class="row justify-content-center mt-2">
                    <div class="col-3 text-left">
                        <label>Phone Number : </label>
                    </div>
                    <div class="col-3">
                        <input type="text" id="txtPhone" class="form-control" />
                    </div>
                </div>
                <div class="row justify-content-center mt-4">
                    <input type="button" value="Create User" id="btnCreateUser" class="btn btn-primary" />
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.2.0/jquery-confirm.min.js"></script>
    <script src="scripts/customScripts/Common.js"></script>
    <script src="scripts/customScripts/CreateUser.js"></script>
</body>
</html>
