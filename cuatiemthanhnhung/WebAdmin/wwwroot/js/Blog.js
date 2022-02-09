$(function () {
    $("#txt-fromTime, #txt-toTime").datepicker({ dateFormat: 'dd/mm/yy'});
});

var homeconfig = {
    pageSize: 10,
    pageIndex: 1
}

var BlogTable =
{
    loadData: function (changePageSize) {
    
        var totalBlog = 0;
        var key = $('#txt-keyWord').val();
        var from = $('#txt-fromTime').val();
        var to = $('#txt-toTime').val();
        var blogcateId = $('#select-BlogCateId').val();
        var model = new Object();
        model.PageSize = homeconfig.pageSize
        model.PageIndex = homeconfig.pageIndex - 1;
        model.KeyWord = key;
        model.FromTime = from;
        model.ToTime = to;
        model.BlogCateId = blogcateId;

        $.ajax({
            type: 'post',
            url: '/Blog/CountPagination',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                totalBlog = parseInt(data.result);

            }
        });
        $.ajax({
            type: 'post',
            url: '/Blog/GetPagination_Pta',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {

                $("#table-blog").html(data);

                BlogTable.paging(totalBlog, function () {

                }, changePageSize);
            }
        });
    },
    paging: function (totalRow, callback, changePageSize) {

        var totalPage = 0;
        if (totalRow < homeconfig.pageSize) {
            totalPage = 1
        }
        else {
            totalPage = Math.ceil(totalRow / homeconfig.pageSize);
        }
        if ($('#pagination a').length === 0 || changePageSize === true) {
            $('#pagination').empty();
            $('#pagination').removeData("twbs-pagination");
            $('#pagination').unbind("page");
        }
        $('#pagination').twbsPagination({
            totalPages: totalPage,
            first: "Đầu",
            next: " Tiếp",
            last: "Cuối",
            prev: "Trước",
            visiblePages: 10,
            onPageClick: function (event, page) {

                homeconfig.pageIndex = page;
                BlogTable.loadData();

            }
        });
    },
}

BlogTable.loadData();

$('#txt-keyWord, #txt-fromTime, #txt-toTime').off('keypress').on('keypress', function (e) {
    if (e.which == 13) {
        SearchBlog();
    }
})
$('body').off('change', '#select-BlogCateId').on('change', '#select-BlogCateId', SearchBlog);
$('body').off('click', '#btn-unsearch').on('click', '#btn-unsearch', UnsearchBlog);
$('body').off('click', '#btn-search').on('click', '#btn-search', SearchBlog);


function SearchBlog() {

    BlogTable.loadData(true);
}
function UnsearchBlog() {
    $('#txt-keyWord').val("");
    $('#txt-fromTime').val("");
    $('#txt-toTime').val("");
    $('#select-blogcateId').val("");
   
    BlogTable.loadData(true);
}
//End load data

//delete
$('body').off('click', '.deleteBlog').on('click', '.deleteBlog', ComfirmDelete);
function ComfirmDelete() {
    var blogId = $(this).data('id');
   
    bootbox.confirm("Bạn chắc chắn muốn xóa!", function (result) {
        if (result) {
            DeleteBlog(blogId);
        
        }
    })
}
function DeleteBlog(blogId) {

    $.ajax({
    
        type: 'post',
        url: '/Blog/Delete',
        dataType: 'json',
        data: { id: blogId},

        success: function (response) {
         
            if (response.statusCode == 200) {
            
                $('#tr-' + blogId).hide();
            }
        }
    })

}

