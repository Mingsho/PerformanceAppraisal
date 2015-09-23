$(document).ready(function() {

    $('#form1').validate();

    $('#' + txtDeptName).rules("add", {

        required: true,
        rangelength: [3, 25],
        messages: {

            required: "Department name cannot be blank!",
            rangelength: "Number of character need to be min 3 characters and maximum 25 characters"
        }
    });
       
});