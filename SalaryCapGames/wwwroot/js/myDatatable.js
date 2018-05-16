$(document).ready(function () {
    $('#pitchersTable').DataTable({
        "ordering": true,
        "paging": true,
        "FixedHeader": true,
        "fixedColumns": true
    });

    $("input[name='franchiseId']:radio").change(function () {
        var value = $(this).val();
        alert(value);

    });

    var span = document.getElementsByName("franchiseId");
    var inputs = span.getElementsByTagName("input");
    for (var i = 0; i < inputs.length; ++i) {
        if (inputs[i].checked) {
            i = inputs[i].value;
            alert(i);
        }
    }


});

$(document).ready(function () {
    var table = $('#franchiseTable').DataTable(
        {
            "paging": false,
            "searching": false,
            "info": false
        });



    $('#franchiseTable tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });


});

 //Add event listener for opening and closing details
$('#pitchersTable tbody').on('click', 'td.details-control', function () {
    var table = $('#pitchersTable').DataTable();
    var tr = $(this).closest('tr');
    var tdi = tr.find("i.fa");
    var row = table.row(tr);

    if (tr.hasClass('dropPlayer')) {
        //tdi.first().hasClass('addPlayer'))
        //tr.removeClass('addPlayer');
        tdi.first().removeClass('fa-minus-square');
        tdi.first().addClass('fa-plus-square');
        tr.removeClass('dropPlayer');


    }
    else {
        // Open this row
        //row.child(format(row.data())).show();
        tr.addClass('dropPlayer');

        tdi.first().removeClass('fa-plus-square');
        tdi.first().addClass('fa-minus-square');

    }
});