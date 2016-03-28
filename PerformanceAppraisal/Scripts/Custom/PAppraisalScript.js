$(function () {

    $('#dialog-confirm').hide();

    $('[id*=lnkBtnDelete]').click(function () {


        $('#dialog-confirm').dialog({

            resizable: false,
            height: 160,
            modal: true,
            buttons: {

                "Yes": function () {
                    $(this).dialog("close");
                    $('#form[id$="form1"]').submit();
                },
                "Cancel": function () {
                    $(this).dialog("close");
                }
            }

        });

        return false;

    });

    $('#errorDiv').hide();

    $('#form1').submit(function (event) {

        $('#errorDiv').show();
        //event.preventDefault();
    });

    //$('[id$="LoginButton"]').click(function () {

    //    if (!$('#form1')[0].checkValidity()) {
    //        console.log("You have reached this part!");
    //        $('#errorDiv').show();
    //    }
        
        
    //});

    
});

