$(document).ready(function() {

    $('#form1').validate({

        submitHandler: function(form)
        {
            //select the closest div of input[id=txtDeptName] i.e div class="form-group"
            var controlGroup = $('input[id=' + txtDeptName + ']').closest('.form-group');

            //add the 'has-error' class to it.
            $(controlGroup).addClass('has-error');

            form.submit();
        }
    });

     

    $('#' + txtDeptName).rules("add", {

        required: true,
        rangelength: [3, 25],
        messages: {

            required: "Department name cannot be blank!",
            rangelength: "Number of character need to be min 3 characters and maximum 25 characters"
        }
    });

    
       
});