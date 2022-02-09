$(document).ready(function () { 

    Load()

    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '.update').on('click', '.update', Update);
    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);
    $('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);

    function Load() {



        $.ajax({
            type: 'post',
            url: '/Category/GetAll_Pta',
            success: function (data) {

                $("#table-content").html(data);

            }
        })
    }

    function Add() {
        $('#hid-id').text('');
        $('#txt-CategoryName').val('');
        $('#txt-Image').val('');
        $('#txt-SeoTittle').val('');
        $('#txt-SeoDescription').val('');
    };

    function Update() {

        var tranferId = $(this).data('id');
        $.ajax({
            type: 'post',
            url: '/Category/GetById',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {
               
        
                var data = response.result;

                $('#hid-id').text(data.categoryId);
                $('#txt-CategoryName').val(data.categoryName);
                $('#txt-Image').val(data.image);
                $('#txt-SeoTittle').val(data.seoTittle);
                $('#txt-SeoDescription').val(data.seoDescription);

            }
        })

    }

    $('#frm-save').validate({
        rules: {
            CategoryName:
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

            Image:
            {
                required: true,
            },

        },
        messages: {
            CategoryName:
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

            Image:
            {
                required: "Bạn phải nhập trường này",
            },
        }
    });
    function Save() {
        if ($('#frm-save').valid()) {

            var model = new Object();

            model.CategoryId= $('#hid-id').text();
            model.CategoryName = $('#txt-CategoryName').val();
            model.Image = $('#txt-Image').val();
            model.SeoTittle = $('#txt-SeoTittle').val();
            model.SeoDescription = $('#txt-SeoDescription').val();


            $.ajax({
                type: 'post',
                url: '/Category/Save',
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
            url: '/Category/Delete',
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