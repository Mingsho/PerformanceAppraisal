$(function () {

    $('#dialog-confirm').dialog({
        
        resizable: false,
        height: 140,
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
});