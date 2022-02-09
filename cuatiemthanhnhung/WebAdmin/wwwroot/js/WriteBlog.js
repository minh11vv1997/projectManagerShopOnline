
$(document).ready(function () {
    //initialization

    var blogId = $('#hid-BlogId').text();
    function Init() {
        if (blogId == "") {

            AddBlog();
        } else {
            UpdateBlog();
        }
   

    }
    Init()


    function AddBlog() {
        $('#span-title').text('Thêm mới bài viết')
        blogId = "";
        $('#hid-BlogId').text('');
        $('#txt-Tittle').val('');
        $('#txt-SeoTittle').val('');
        $('#txt-BackGround').val('');
        $('#txt-Summary').val('');
        $('#txt-SeoDescription').val('');
        $('#txt-Seen').val(0);
        $('#txt-BlogImage').val('');
        $('#select-Status').val('');
        $('#select-BlogCateId').val('');
   

    };
    function UpdateBlog() {
        $('#span-title').text('Cập nhật bài viết')

        $.ajax({
            type: 'post',
            url: '/Blog/GetById',
            dataType: 'json',
            data: { id: blogId },

            success: function (response) {

                var data = response.result;
                $('#hid-BlogId').text(data.blogId);
                $('#txt-Tittle').val(data.tittle);
                $('#txt-SeoTittle').val(data.seoTittle);
                $('#txt-SeoDescription').val(data.seoDescription);
                $('#txt-Summary').val(data.summary);
                $('#txt-BlogImage').val(data.blogImage);
                $('#txt-Seen').val(data.seen);
                $('#txt-BackGround').val(data.backGround);
                $('#select-Status').val(data.status);
                $('#select-BlogCateId').val(data.blogCateId);

            }
        })
    }

    //Luu bai viet 
    $('body').off('click', '#btn-saveBlog').on('click', '#btn-saveBlog', SaveBlog);
    $('#frm-save').validate({
        rules: {
            Tittle:
            {
                required: true,
            },
            Summary:
            {
                required: true,

            },

            BlogImage:
            {
                required: true,

            },
            BackGround:
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
            BlogCateId:
            {
                required: true,

            },

        },
        messages: {
            Tittle:
            {
                required: "Bạn phải nhập trường này",
            },
            Summary:
            {
                required: "Bạn phải nhập trường này",

            },

            BlogImage:
            {
                required: "Bạn phải nhập trường này",

            },
            BackGround:
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
            BlogCateId:
            {
                required: "Bạn phải nhập trường này",

            },

        }
    });


    function SaveBlog() {
        if ($('#frm-save').valid()) {
            var model = new Object();
            var cateId = $('#select-BlogCateId').val();
            model.BlogId = $('#hid-BlogId').text();
            model.Tittle = $('#txt-Tittle').val();
            model.SeoTittle = $('#txt-SeoTittle').val().trim();
            model.SeoDescription = $('#txt-SeoDescription').val().trim();
            model.Seen = $('#txt-Seen').val();
            model.BlogImage = $('#txt-BlogImage').val().trim();
            model.BackGround = $('#txt-BackGround').val().trim();
            model.Status = $('#select-Status').val();
            model.Summary = $('#txt-Summary').val().trim();
            model.BlogCateId = cateId;



            $.ajax({
                type: 'post',
                url: '/Blog/Save',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    if (response.statusCode == 1) {
                        bootbox.alert("Thêm mới bài viết thành công!", function () {
                            blogId = response.blogId
                            UpdateBlog();


                        })
                    }
                    else if (response.statusCode == 2) {
                        bootbox.alert("Cập nhật bài viết thành công!", function () {

                        })
                    }
                    else {
                        bootbox.alert("Đã xảy ra lỗi!")
                    }

                }
            })

        }
    }




    //Refresh trang bai viet

    $('body').off('click', '#btn-refresh').on('click', '#btn-refresh', AddBlog);

    $('body').off('click', '#btn-addTag').on('click', '#btn-addTag', CheckSaveBlog);
    function CheckSaveBlog() {

        if (!blogId == "") {
            $('#modal-addTag').modal('show');
        } else {
            bootbox.alert("Bạn phải lưu bài viết trước khi thêm các khóa học liên quan!")
        }
    }

    //them course vao bai viet

    $('body').off('click', '.addCourse').on('click', '.addCourse', AddCourseToBlog);

    function AddCourseToBlog() {
        var courseId = $(this).data('courseid');
        var model = new Object();
        model.BlogId = blogId;
        model.CourseId = courseId;

        $.ajax({
            type: 'post',
            url: '/BlogCourse/Save',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.statusCode == 409) {
                    bootbox.alert("Đã thêm khóa học này rồi!")

                }
                else if (data.statusCode == 400) {
                    bootbox.alert("Đã xảy ra lỗi!")
                }
                else {
                    $('#tr-' + courseId).hide();
                    ShowCoursesOfBlog()
                }

            }
        });

    }
    //Hien thi tag cua bai viet
 

    //Xoa tag khoi bai viet

    $('body').off('click', '.delete-tag').on('click', '.delete-tag', DeleteCourseInBlog);

    function DeleteCourseInBlog() {

        var transferId = $(this).data('id');
        $.ajax({
            type: 'post',
            data: { id: transferId },
            url: '/BlogCourse/Delete',

            success: function (data) {

                $('#tag-' + transferId).hide()
            }
        });

    }
}) 