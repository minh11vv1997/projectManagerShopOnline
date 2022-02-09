$(document).ready(function () {

    $('body').off('click', '.update').on('click', '.update', Update);
    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);
    $('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);
     
    function ComfirmDelete() {

        var tranferName = $(this).data('username');
        bootbox.confirm(`Are you sure to delete ${tranferName}?`, function (result) {
            if (result) {
                Delete(tranferName)
            }
        });
         
    }
    function Delete(tranferName) {
    
        $.ajax({
            type: 'post',
            url: '/Account/Delete',
            dataType: 'json',
            data: { username: tranferName },

            success: function (response) {

                var data = response.statusCode;
                if (data == 200) {
                    bootbox.alert(`Delete ${tranferName} successfully`, function () {
                        location.reload();
                    })
                }
                else {
                    bootbox.alert("Error");
                }

              
            }
        })
    }



    function Update() {

        var tranferName = $(this).data('username');
        $.ajax({
            type: 'post',
            url: '/Account/GetByName',
            dataType: 'json',
            data: { username: tranferName },

            success: function (response) {
         
                var data = response.result;

                $('#hid-UserId').text(data.id);
                $('#txt-UserName').val(data.userName);
                $('#txt-Email').val(data.email);
            }
        })

    }
    $('#frm-save').validate({
        rules: {
            Email:
            {
                required: true,
                email: true
            },
            UserName:
            {
                required: true,

            },
        },
        messages: {
            Email:
            {
                required: "You need fill in email",
                email: "Email is not in correct pattern",
            },
            UserName:
            {
                required: "You need fill in username",

            },
        }
    });


    function Save() {
        if ($('#frm-save').valid()) {
            var model = new Object();
            model.UserId = $('#hid-UserId').text();
            model.UserName = $('#txt-UserName').val();
            model.Email = $('#txt-Email').val();

            $.ajax({
                type: 'post',
                url: '/Account/Save',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    if (response.statusCode == 200) {
                        bootbox.alert("Update Successfully!", function () {
                            $('#modal-add').modal('hide');
                            location.reload();
                        })


                    }
                    else {
                        bootbox.alert("Error!", function () {

                        })
                    }
                }
            })
        }
    }



})