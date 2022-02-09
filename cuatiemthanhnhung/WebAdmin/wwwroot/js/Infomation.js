$(document).ready(function () {

    Load();


    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '.update').on('click', '.update', Update);
    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);
    $('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);

    function Load() {


        $.ajax({
            type: 'post',
            url: '/Information/GetPagination_Pta',
            success: function (data) {

                $("#table-content").html(data);

            }
        })
    }


    function Add() {
        $('#hid-id').text('');
        $('#txt-OfficeName').val('');
        $('#txt-Mobile').val('');
        $('#txt-Email').val('');
        $('#txt-Address').val('');
        $('#txt-Position').val('');
        $('#select-Status').val('');


    };

    function Update() {

        var tranferId = $(this).data('id');
        $.ajax({
            type: 'post',
            url: '/Information/GetById',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {

                var data = response.result;

                $('#hid-id').text(data.informationId);
                $('#txt-OfficeName').val(data.officeName);
                $('#txt-Mobile').val(data.mobile);
                $('#txt-Email').val(data.email);
                $('#txt-Address').val(data.address);
                $('#txt-Position').val(data.position);
                $('#select-Status').val(data.status);

            }
        })

    }
    function Save() {


        var model = new Object();

        model.InformationId = $('#hid-id').text();
        model.OfficeName = $('#txt-OfficeName').val();
        model.Mobile = $('#txt-Mobile').val();
        model.Email = $('#txt-Email').val();
        model.Address = $('#txt-Address').val();
        model.Position = $('#txt-Position').val();
        model.Status = $('#select-Status').val();


        $.ajax({
            type: 'post',
            url: '/Information/Save',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                if (response.statusCode == 1) {
                    bootbox.alert("Thêm mới thành công!", function () {
                        Load();
                    })
                }
                else if (response.statusCode == 2) {
                    bootbox.alert("Cập nhật thành công!", function () {
                        Load();
                    })
                }

                else {
                    bootbox.alert("Đã xảy ra lỗi!", function () {

                    })
                }
            }
        })
        $('#modal-add').modal('hide');


    };
    function ComfirmDelete() {
        var tranferId = $(this).data('id');
        bootbox.confirm("Bạn chắc chắn muốn xóa!", function (result) {
            if (result) {
                Delete(tranferId);
            }
        })
    }
    function Delete(tranferId) {


        $.ajax({
            type: 'post',
            url: '/Information/Delete',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {

                if (response.statusCode == 200) {

                   Load()
                }
            }
        })

    }


})