$(document).ready(function () {

    Load();

    
    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);
    $('body').off('click', '.delete').on('click', '.delete', ComFirmDelete);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);

    function Load() {

        $.ajax({
            type: 'post',
            url: '/Role/GetAll_Pta',
            success: function (data) {

                $("#table-content").html(data);
            }
        })
    }

    function Add() {

        $('#hid-id').text('');
        $('#txt-RoleName').val('');
    }
    $('body').off('click', '.update').on('click', '.update', Update);
    function Update() {

        var tranferId = $(this).data('id');
        $.ajax({
            type: 'post',
            url: '/Role/GetById',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {
                var data = response.result;

                $('#hid-id').text(data.id);
                $('#txt-RoleName').val(data.name);


            }
        })

    }

    $('#frm-save').validate({
        rules: {

            RoleName:
            {
                required: true,
            },
          


        },
        messages: {
            RoleName:
            {
                required: "You need fill in the RoleName",
            },
          

        }
    });

    function Save() {
        if ($('#frm-save').valid()) {
            var model = new Object();
            model.RoleId = $('#hid-id').text();
            model.RoleName = $('#txt-RoleName').val();
         
            $.ajax({
                type: 'post',
                url: '/Role/Save',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    var response = data.result

                    if (response == 1) {

                        bootbox.alert("Add role successfully!", function () {
                            Load()
                        })
                        $('#modal-add').modal('hide');
                    }
                    else if (response == 2) {

                        bootbox.alert("Update role successfully!", function () {
                            Load()
                        })
                        $('#modal-add').modal('hide');
                    }


                    else {
                        bootbox.alert("Error", function () {
                          
                        })
                    }
                }
            })

        }


    }



    function ComFirmDelete() {
        var id = $(this).data('id');

        bootbox.confirm("Are you sure ?", function (result) {
            if (result) {
                Delete(id)
            }
        });
    }

    function Delete(tranferId) {
        debugger
        $.ajax({
            type: 'post',
            url: '/Role/Delete',
            dataType: 'json',
            data: { id: tranferId },

            success: function (data) {

                debugger
                var response = data.result;
                if (response.statusCode == 200) {

                    bootbox.alert("Xóa thành công!", function () {
                        Load()
                    })

                } else {
                    bootbox.alert("Đã xảy ra lỗi!", function () {

                    })
                }



            }
        })

    }





















})