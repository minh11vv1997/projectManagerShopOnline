$(document).ready(function () {
    var rName = $('#txt-RoleName').text();
    Load();
    function Load() {
   
        $.ajax({
            type: 'post',
            url: '/Role/GetUsersInRole',
            data: { roleName: rName },
            success: function (response) {

                $('#table-a').html(response);
              

            }
        })
        $.ajax({
            type: 'post',
            url: '/Role/GetUsersNotInRole',
            data: { roleName: rName },
            success: function (response) {

                $('#table-b').html(response);


            }
        })

    }

    $('body').off('click', '.assign').on('click', '.assign', AssignRole);
    $('body').off('click', '.remove').on('click', '.remove', RemoveRole);

    function AssignRole() {
        debugger
        var username = $(this).data('username');
        var model = new Object();

        model.RoleName = rName;
        model.UserName = username;
      


        $.ajax({
            type: 'post',
            url: '/Role/AssignRole',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                if (response.statusCode == 200) {
                   
                    Load();
                   
                } else {
                    bootbox.alert("Error")
                }
            }
        })
        
    }


    function RemoveRole() {
        var username = $(this).data('username');
        var model = new Object();

        model.RoleName = rName;
        model.UserName = username;



        $.ajax({
            type: 'post',
            url: '/Role/RemoveRole',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                if (response.statusCode == 200) {

                    Load();

                } else {
                    bootbox.alert("Error")
                }
            }
        })

    }

 











})