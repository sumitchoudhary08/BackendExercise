$(document).ready(function () {
    //On click of Create user button creates user.
    $("#btnCreateUser").click(function () {
        createUser();
    });
});

//Sends the Email.
function createUser() {
    loadingStart();

    var userObj = {
        Name: $("#txtName").val(),
        Email: $("#txtEmail").val(),
        PhoneNumber: $("#txtPhone").val()
    };

    $.ajax({
        type: 'POST',
        url: '/CreateUser.aspx/CreatesUser',
        data: JSON.stringify({ 'userObj': userObj }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.d === true) {
                customAlert(1, "User Created sucessfully.");
            }
            else {
                customAlert(0, "Fail to Create User.")
            }
        },
        complete: function (data) {
            loadingStop();
        },
        failure: function (data) {
            alert(data.d);
        },
        error: function (msg) {
            customAlert(0, "Oops!! Something went wrong");
        }
    });
}