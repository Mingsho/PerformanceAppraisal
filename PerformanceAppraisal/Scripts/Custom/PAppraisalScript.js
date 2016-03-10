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

    $('[id$="LoginButton"]').click(function () {

        
        $('#errorDiv').show();
        
    });

    
});

