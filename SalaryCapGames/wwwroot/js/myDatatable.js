//$(document).ready(function () {
//    $('#pitchersTable').DataTable(){
//        "ordering": true,
//        "paging": true,
//        "FixedHeader": true,
//        "fixedColumns": true
//    });

$(document).ready(function () {
    $('#pitchersTable').DataTable({
        select: {
            style: 'single'
        }
    });

    $('#franchiseTable').DataTable({
        select: {
            style: 'single'
        },
        "ordering": false,
        "paging": false,
        "info": false,
        "searching":false
    });

    var hitterTable = $('#hittersTable').DataTable({
        select: {
            style: 'single'
        },
        initComplete: function () {
            this.api().columns().every(function () {
                var column = this;
                var select = $('<select><option value=""></option></select>')
                    .appendTo($(column.footer()).empty())
                    .on('change', function () {
                        var val = $.fn.dataTable.util.escapeRegex(
                            $(this).val()
                        );

                        column
                            .search(val ? '^' + val + '$' : '', true, false)
                            .draw();
                    });

                column.data().unique().sort().each(function (d, j) {
                    select.append('<option value="' + d + '">' + d + '</option>');
                });
            });
        }

    });
    $('#hittersTable tbody').on('click', 'tr', function () {
        var table = $('#hittersTable').DataTable();
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            //table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
            $('#addPlayer').click(function () {


                alert(table.row('.selected').data());
            });
        }
    });

    $('#franchiseTable tbody').on('click', 'tr', function () {
        var table = $('#franchiseTable').DataTable();
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
            var franchiseId = table.row('.selected').data()[0];
            alert(franchiseId);
            $.get("@Url.Action( 'Index', 'Dashboard' )", { Id: $(franchiseId) }, function () {
                alert(data)
            });



            //$.ajax({
            //    type: 'GET',
            //    url: '@Url.Action( "Index" )',
            //    data: { franchiseId: $(franchiseId) },
            //    success: function ()

            //});
            //$('#myTeamPartialContainer').load( '@Url.Action("Index", new {franchiseId = "f)
            //$('.js-reload-details')( function (evt) {
            //    evt.preventDefault();
            //    evt.stopPropagation();

            //    var $detailDiv = $('#detailsDiv'),
            //        url = $(this).data('url');

            //    $.get(url, function (data) {
            //        $detailsDiv.replaceWith(data);
            //    });
            //});
        }
    });

    //$('.js-reload-details').on('click', function (evt) {
    //    evt.preventDefault();
    //    evt.stopPropagation();

    //    var $detailDiv = $('#detailsDiv'),
    //        url = $(this).data('url');

    //    $.get(url, function (data) {
    //        $detailsDiv.replaceWith(data);
    //    });
    //});
    // Add event listener for opening and closing details
    $('#pitchersTable tbody').on('click', 'td.details-control', function () {
        var table = $('#pitchersTable').DataTable();
        var tr = $(this).closest('tr');
        var tdi = tr.find("i.fa");
        var row = table.row(tr);
        var cell = table.row().data()[1];
        

        alert(cell);
        
        

        if (tr.hasClass('dropPlayer')) {
            //tdi.first().hasClass('addPlayer'))
            //tr.removeClass('addPlayer');
            tdi.first().removeClass('fa-minus-square');
            tdi.first().addClass('fa-plus-square');
            tdi.first().css("color", "green");
            tr.removeClass('dropPlayer');


        }
        else {

            tr.addClass('dropPlayer');

            tdi.first().removeClass('fa-plus-square');
            tdi.first().addClass('fa-minus-square');
            tdi.first().css("color", "red");

        }



    });
});

    //$("input[name='franchiseId']:radio").change(function () {
    //    var value = $(this).val();
    //    alert(value);

    //});

    //var span = getElementByName("franchiseId");
    //var inputs = getElementByTagName("input");
    //for (var i = 0; i < inputs.length; ++i) {
    //    if (inputs[i].checked) {
    //        i = inputs[i].value;
    //        alert(i);
    //    }
    //}


//});

//$(document).ready(function () {
//    var table = $('#franchiseTable').DataTable(
//        {
//            "paging": false,
//            "searching": false,
//            "info": false
//        });



//    $('#franchiseTable tbody').on('click', 'tr', function () {
//        if ($(this).hasClass('selected')) {
//            $(this).removeClass('selected');
//        }
//        else {
//            table.$('tr.selected').removeClass('selected');
//            $(this).addClass('selected');
//        }
//    });


//});

 //Add event listener for opening and closing details
//$('#pitchersTable tbody').on('click', 'td.details-control', function () {
//    var table = $('#pitchersTable').DataTable();
//    var tr = $(this).closest('tr');
//    var tdi = tr.find("i.fa");
//    var row = table.row(tr);

//    if (tr.hasClass('dropPlayer')) {
//        //tdi.first().hasClass('addPlayer'))
//        //tr.removeClass('addPlayer');
//        tdi.first().removeClass('fa-minus-square');
//        tdi.first().addClass('fa-plus-square');
//        tr.removeClass('dropPlayer');


//    }
//    else {
//        // Open this row
//        //row.child(format(row.data())).show();
//        tr.addClass('dropPlayer');

//        tdi.first().removeClass('fa-plus-square');
//        tdi.first().addClass('fa-minus-square');

//    }
//});