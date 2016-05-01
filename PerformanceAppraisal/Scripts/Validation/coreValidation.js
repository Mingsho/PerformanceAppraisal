$(document).ready(function() {

    $('#form1').validate({

        onkeyup: false,
        onfocusout: false,
        highlight:function(element, errorClass)
        {
            var controlGroup = $(element).closest('.form-group').addClass(errorClass);
        }
    });


    $('#' + txtDeptName).rules("add", {

        required: true,
        rangelength: [3, 50],
        messages: {

            required: "Department name cannot be blank!",
            rangelength: "Number of character need to be min 3 characters and maximum 50 characters"
        }
    });

    
       
});