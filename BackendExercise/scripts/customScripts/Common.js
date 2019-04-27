//Displays loader
function loadingStart() {
    $("#loaderHolder").show();
}

//Hides loader
function loadingStop() {
    $("#loaderHolder").hide();
}

//Pops the alert msg box with message.
function customAlert(type, content) {
    var msgtype;
    var btn;
    if (type == 1) {
        msgtype = "green";
        btn = "btn-green";
    }
    else {
        msgtype = "red";
        btn = "btn-red";
    }

    $.alert({
        title: "",
        type: msgtype,
        content: content,
        buttons: {
            Ok: {
                btnClass: btn,
                action: function () {
                    return true;
                }
            }
        }
    });
}