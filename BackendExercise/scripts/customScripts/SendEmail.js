$(document).ready(function () {

    //On click of send email button sends the email.
    $("#btnSendEmail").click(function () {
        sendEmail();
    });
});

//Sends the Email.
function sendEmail() {
    loadingStart();

    var emailObj = {
        ToEmail: $("#txtToAddress").val(),
        FromEmail: $("#txtFromAddress").val(),
        Subject: $("#txtSubject").val(),
        Body: $("#txtBody").val(),
    };

    $.ajax({
        type: 'POST',
        url: '/SendEmail.aspx/SendsEmail',
        data: JSON.stringify({ 'emailObj': emailObj }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.d === true) {
                customAlert(1, "E-mail was sent sucessfully.");
            }
            else {
                customAlert(0, "Fail to send email.")
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