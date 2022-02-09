var homeconfig = {
    pageSize: 10,
    pageIndex: 1
}

var ProductTable =
{
    loadData: function (changePageSize) {

        var totalProduct = 0;
        var categoryId = $('#filter-CategoryId').val();
        var keyWord = $('#filter-KeyWord').val();
        var model = new Object();

        model.PageSize = homeconfig.pageSize
        model.PageIndex = homeconfig.pageIndex - 1;
        model.CategoryId = categoryId;
        model.KeyWord = keyWord;


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

$('#filter-KeyWord').off('keypress').on('keypress', function (e) {
    if (e.which == 13) {
        SearchProduct();
    }
})
$('body').off('change', '#filter-CategoryId').on('change', '#filter-CategoryId', SearchProduct);
$('body').off('click', '#btn-unsearch').on('click', '#btn-unsearch', UnsearchProduct);
$('body').off('click', '#btn-search').on('click', '#btn-search', SearchProduct);
$('body').off('click', '#btn-save').on('click', '#btn-save', Save);


function SearchProduct() {

    ProductTable.loadData(true);
}
function UnsearchProduct() {

    $('#filter-CategoryId').val('');
    $('#filter-KeyWord').val('');

    ProductTable.loadData(true);
}
//End load data
$('body').off('click', '.update').on('click', '.update', Update);
$('body').off('click', '#btn-add').on('click', '#btn-add', Add);

function Add() {
    $('#hid-id').text('');
    $('#txt-ProductName').val('');
    $('#txt-Summary').val('');
    $('#txt-Detail').val('');
    $('#txt-SeoTittle').val('');
    $('#txt-SeoDescription').val('');
    $('#txt-Image').val('');
    $('#txt-Price').val('');
    $('#select-Status').val('');
    $('#select-CategoryId').val('');

};
function Update() {
  
    var tranferId = $(this).data('id');
    $.ajax({
        type: 'post',
        url: '/Product/GetById',
        dataType: 'json',
        data: { id: tranferId },

        success: function (response) {

            var data = response.result;
            $('#hid-id').text(data.productId);
            $('#txt-ProductName').val(data.productName);
            $('#txt-Summary').val(data.summary);
            $('#txt-Detail').val(data.detail);
            $('#txt-SeoTittle').val(data.seoTittle);
            $('#txt-SeoDescription').val(data.seoDescription);
            $('#txt-Image').val(data.image);
            $('#txt-Price').val(data.price);
            $('#select-CategoryId').val(data.categoryId);
            $('#select-Status').val(data.status);

        }
    })

}
$('#frm-save').validate({
    rules: {
        ProductName:
        {
            required: true,
        },
        Summary:
        {
            required: true,

        },
        Detail:
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
        Detail:
        {
            required: true,
        },

        Status:
        {
            required: true,
        },
        CategoryId:
        {
            required: true,
        },

    },
    messages: {
        Name:
        {
            required: "Bạn phải nhập trường này",
        },
        LinkProduct:
        {
            required: "Bạn phải nhập trường này",

        },
        LinkProductV:
        {
            required: "Bạn phải nhập trường này",
        },

        Status:
        {
            required: "Bạn phải nhập trường này",
        },
        CategoryId:
        {
            required: "Bạn phải nhập trường này",
        },
    }
});

function Save() {
    debugger
    if ($('#frm-save').valid()) {

        var model = new Object();
        model.ProductId = $('#hid-id').text();
        model.ProductName = $('#txt-ProductName').val();
        model.Summary = $('#txt-Summary').val();
        model.Detail = $('#txt-Detail').val();
        model.SeoTittle = $('#txt-SeoTittle').val();
        model.SeoDescription = $('#txt-SeoDescription').val();
        model.Price = $('#txt-Price').val();
        model.Image = $('#txt-Image').val();
        model.Status = $('#select-Status').val();
        model.CategoryId = $('#select-CategoryId').val();
       
        $.ajax({
            type: 'post',
            url: '/Product/Save',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                if (response.statusCode == 1) {
                    $('#modal-add').modal('hide');
                    ProductTable.loadData(true);
                    $.notify("Thêm mới thành công", "success")

                } else if (response.statusCode == 2) {
                    $('#modal-add').modal('hide');
                    ProductTable.loadData(true);
                    $.notify("Cập nhật thành công", "success")
                }
                else {
                    $.notify("Đã xảy ra lỗi", "error")
                }
            }
        })
    }
};
//delete
$('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);
function ComfirmDelete() {
    var ProductId = $(this).data('id');

    bootbox.confirm("Bạn chắc chắn muốn xóa!", function (result) {
        if (result) {
            DeleteProduct(ProductId);
        }
    })
}
function DeleteProduct(ProductId) {

    $.ajax({

        type: 'post',
        url: '/Product/Delete',
        dataType: 'json',
        data: { id: ProductId },

        success: function (response) {

            if (response.statusCode == 200) {

                $('#tr-' + ProductId).hide();
            }
        }
    })

}
$('body').off('click', '#btn-exportEx').on('click', '#btn-exportEx', ExportExcel);
function ExportExcel() {

    
    var categoryId = $('#filter-CategoryId').val();
    var keyWord = $('#filter-KeyWord').val();
    var model = new Object();
    model.PageSize = homeconfig.pageSize
    model.PageIndex =  $('.page-item.active .page-link').text() -1 ;
    model.CategoryId = categoryId;
    model.KeyWord = keyWord;



    $.ajax({
        type: 'post',
        url: '/Product/ExportExcel',
        data: JSON.stringify(model),
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            location.href = data.result;
        }
    });
}


