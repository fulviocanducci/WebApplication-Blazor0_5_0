window.functions = {
    myAlert: function (message) {
        alert(message);
    },
    mySweetAlertSuccess: function (title, message) {
        swal(title, message,'success');
    },
    myConsole: function (message) {
        console.log(message);
    }
}