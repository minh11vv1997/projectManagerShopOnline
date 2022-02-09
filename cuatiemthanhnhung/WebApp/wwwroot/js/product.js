$(document).ready(function () {
    var homeconfig = {
        pageSize: 12,
        pageIndex: 1
    }
    var categoryId = "";
    var ProductTable =
    {
        loadData: function (changePageSize) {

            var totalProduct = 0;
           
            var model = new Object();

            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.CategoryId = categoryId;
     


            $.ajax({
                type: 'post',
                url: '/Product/CountPagination',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalProduct = parseInt(data.result);

                }
            });
            $.ajax({
                type: 'post',
                url: '/Product/GetPagination_Pta',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {

                    $("#table-content").html(data);

                    ProductTable.paging(totalProduct, function () {

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
                    ProductTable.loadData();

                }
            });
        },
    }

    ProductTable.loadData();
    $('body').off('click', '.category').on('click', '.category', Search);
    function Search() {
        $('.category').removeClass('active')
        $(this).addClass('active')
        categoryId = $(this).data('id');
        ProductTable.loadData(true);
        
    }















})