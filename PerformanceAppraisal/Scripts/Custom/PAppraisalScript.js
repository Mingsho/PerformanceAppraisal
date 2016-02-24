$(function () {

    $('#dialog-confirm').hide();

    $('[id*=lnkTest]').click(function () {


        $('#dialog-confirm').dialog({

            resizable: false,
            height: 160,
            modal: true,
            buttons: {

                "Yes": function () {
                    $(this).dialog("close");
                },
                Cancel: function () {
                    $(this).dialog("close");
                }
            }

        });

        return false;

    });
});