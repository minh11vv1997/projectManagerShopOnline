var homeconfig = {
    pageSize: 10,
    pageIndex: 1
}
var categoryId = $('#hid-id').text();
if (categoryId !="") {
    $('#a-' + categoryId).addClass('active')
}
var BlogTable =
{
    loadData: function (changePageSize) {

        var totalBlog = 0;
        var key = $('#txt-KeyWord').val();
        var blogcateId = categoryId;
        var model = new Object();
        model.PageSize = homeconfig.pageSize
        model.PageIndex = homeconfig.pageIndex - 1;
        model.KeyWord = key;
      
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

                $("#table-content").html(data);

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
$('body').off('click', '.category').on('click', '.category', Search);
$('#txt-KeyWord').off('keypress').on('keypress', function (e) {txt-KeyWord
    if (e.which == 13) {
        BlogTable.loadData(true);
    }
})
function Search() {
    $('.category').removeClass('active')
    $(this).addClass('active')
    categoryId = $(this).data('id');
    BlogTable.loadData(true);

}
