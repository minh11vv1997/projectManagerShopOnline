

$(document).ready(function () {

    var blogId = $('#hid-blogId').text();

    var blogDetailId = $('#hid-blogDetailId').text();

    function Init() {
        if (blogDetailId == "") {
            Add();
        }
        else {
            Update();
        }

    }

    Init();

    function Add() {
        $('#hid-blogDetailId').text('');
        $('#txt-Number').val(0);
        $('#txt-Tittle').val('');
        CKEDITOR.replace("txt-Content");
        CKEDITOR.instances['txt-Content'].setData();
    };

    function Update() {

        $.ajax({
            type: 'post',
            url: '/BlogDetail/GetById',
            dataType: 'json',
            data: { id: blogDetailId },

            success: function (response) {

                var data = response.result;
                $('#txt-Number').val(data.number);
                $('#txt-Tittle').val(data.tittle);
                CKEDITOR.replace("txt-Content");
                CKEDITOR.instances['txt-Content'].setData(data.content);
            }
        })

    }

    //Luu content
    $('#frm-save').validate({
        rules: {
            Tittle:
            {
                required: true,

            },
            Number:
            {
                required: true,
                min: 1
            },
        

        },
        messages: {
            Tittle:
            {
                required: "Bạn phải nhập trường này",
            },
            Number:
            {
                required: "Bạn phải nhập trường này",
                min: "Số nhập vào tối thiểu là 1"

            },
        }
    });

    $('body').off('click', '#btn-save').on('click', '#btn-save', Save);

    function Save() {
        if ($('#frm-save').valid()) {
            var model = new Object();
            var content = CKEDITOR.instances['txt-Content'].getData()
            model.Tittle = $('#txt-Tittle').val();
            model.Content = content;
            model.Number = $('#txt-Number').val();
            model.BlogId = blogId;
            model.BlogDetailId = blogDetailId;


            $.ajax({
                type: 'post',
                url: '/BlogDetail/Save',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    if (response.statusCode == 1) {
                        bootbox.alert("Thêm mới thành công!", function () {
                            window.location.href = "/BlogDetail/BlogDetail/" + blogId
                        })

                        
                    }
                    else if (response.statusCode == 2) {
                        bootbox.alert("Cập nhật thành công!", function () {

                            window.location.href = "/BlogDetail/BlogDetail/" + blogId

                        })
                    }
                    else {
                        bootbox.alert("Đã xảy ra lỗi!")
                    }

                }
            })

        }
    }






})