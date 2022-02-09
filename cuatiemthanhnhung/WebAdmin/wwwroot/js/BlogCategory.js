$(document).ready(function () { 

    Load()

    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '.update').on('click', '.update', Update);
    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);
    $('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);

    function Load() {



        $.ajax({
            type: 'post',
            url: '/BlogCategory/GetAll_Pta',
            success: function (data) {

                $("#table-content").html(data);

            }
        })
    }
    function Add() {
        $('#hid-id').text('');
        $('#txt-BlogCateName').val('');
        $('#txt-SeoTittle').val('');
        $('#txt-SeoDescription').val('');
    };

    function Update() {

        var tranferId = $(this).data('id');
        $.ajax({
            type: 'post',
            url: '/BlogCategory/GetById',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {
                debugger
        
                var data = response.result;

                $('#hid-id').text(data.blogCateId);
                $('#txt-BlogCateName').val(data.blogCateName);
                $('#txt-SeoTittle').val(data.seoTittle);
                $('#txt-SeoDescription').val(data.seoDescription);
         

            }
        })

    }

    $('#frm-save').validate({
        rules: {
            BlogCateName:
            {
                required: true,
            },
            SeoTittle:
            {
                required: true,

            },
            SeoDescription:
            {
                required: true,
            },

            Status:
            {
                required: true,
            },

        },
        messages: {
            BlogCateName:
            {
                required: "Bạn phải nhập trường này",
            },
            SeoTittle:
            {
                required: "Bạn phải nhập trường này",

            },
            SeoDescription:
            {
                required: "Bạn phải nhập trường này",
            },

            Status:
            {
                required: "Bạn phải nhập trường này",
            },
        }
    });
    function Save() {
        if ($('#frm-save').valid()) {

            var model = new Object();

            model.BlogCateId = $('#hid-id').text();
            model.BlogCateName = $('#txt-BlogCateName').val();
            model.SeoTittle = $('#txt-SeoTittle').val();
            model.SeoDescription = $('#txt-SeoDescription').val();


            $.ajax({
                type: 'post',
                url: '/BlogCategory/Save',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    if (response.statusCode == 1) {
                        bootbox.alert("Thêm mới thành công!", function () {
                            Load();
                        })
                    } else {
                        bootbox.alert("Cập nhật thành công!", function () {
                            Load();
                        })
                    }

                }
            })
            $('#modal-add').modal('hide');
        }

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
            url: '/BlogCategory/Delete',
            dataType: 'json',
            data: { id: tranferId},

            success: function (response) {
             
                if (response.statusCode == 200) {

                    $('#tr-' + tranferId).hide();
                }


            }
        })

    }


})