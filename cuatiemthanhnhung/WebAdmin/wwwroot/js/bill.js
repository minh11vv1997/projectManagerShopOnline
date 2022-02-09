$(function () {
    $("#txt-fromTime, #txt-toTime").datepicker({ dateFormat: 'dd/mm/yy' });
});

var homeconfig = {
    pageSize: 10,
    pageIndex: 1
}

var BillTable =
{
    loadData: function (changePageSize) {

        var totalBill = 0;
        var status = $('#filter-Status').val();
        var from = $('#txt-fromTime').val();
        var to = $('#txt-toTime').val();

        var model = new Object();
        model.PageSize = homeconfig.pageSize
        model.PageIndex = homeconfig.pageIndex - 1;
        model.Status = status;
        model.FromTime = from;
        model.ToTime = to;

        $.ajax({
            type: 'post',
            url: '/Bill/CountPagination',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                totalBill = parseInt(data.result);

            }
        });
        $.ajax({
            type: 'post',
            url: '/Bill/GetPagination_Pta',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {

                $("#table-content").html(data);

                BillTable.paging(totalBill, function () {

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
                BillTable.loadData();

            }
        });
    },
}

BillTable.loadData();

$('#txt-fromTime, #txt-toTime').off('keypress').on('keypress', function (e) {
    if (e.which == 13) {
        SearchBill();
    }
})
$('body').off('change', '#filter-Status').on('change', '#filter-Status', SearchBill);
$('body').off('click', '#btn-unsearch').on('click', '#btn-unsearch', UnsearchBill);
$('body').off('click', '#btn-search').on('click', '#btn-search', SearchBill);


function SearchBill() {

    BillTable.loadData(true);
}
function UnsearchBill() {
    $('#filter-Status').val(0);
    $('#txt-fromTime').val("");
    $('#txt-toTime').val("");


    BillTable.loadData(true);
}

$('body').off('click', '.update').on('click', '.update', Update);

function Update() {

    var tranferId = $(this).data('id');
    $.ajax({
        type: 'post',
        url: '/Bill/GetById',
        dataType: 'json',
        data: { id: tranferId },

        success: function (response) {
            var data = response.result;

            $('#hid-id').text(data.billId);
            $('#txt-Status').val(data.status);

        }
    })

}

$('#frm-save').validate({
    rules: {
        Status:
        {
            required: true,
        },


    },
    messages: {
        Status:
        {
            required: "Bạn phải nhập trường này",
        },

    }
});

$('body').off('click', '#btn-save').on('click', '#btn-save', Save);
function Save() {
    if ($('#frm-save').valid()) {

        var model = new Object();

        model.BillId = $('#hid-id').text();
        model.Status = $('#txt-Status').val();

        $.ajax({
            type: 'post',
            url: '/Bill/Save',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                if (response.statusCode == 200) {
                    $.notify("Cập nhật thành công!", "success")
                    $('#modal-save').modal('hide');
                    BillTable.loadData();
                }
                else {
                    $.notify("Đã xảy ra lỗi!", "error")
                }

            }
        })

    }

};

//delete
$('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);
function ComfirmDelete() {
    var billId = $(this).data('id');

    bootbox.confirm("Bạn chắc chắn muốn xóa!", function (result) {
        if (result) {
            DeleteBill(billId);

        }
    })
}
function DeleteBill(billId) {

    $.ajax({

        type: 'post',
        url: '/Bill/Delete',
        dataType: 'json',
        data: { id: billId },

        success: function (response) {

            if (response.statusCode == 200) {

                $('#tr-' + billId).hide();
            }
        }
    })

}

$('body').off('click', '.billDetail').on('click', '.billDetail', ShowBillDetail);

function ShowBillDetail() {

    var tranferId = $(this).data('id');
    var total = $('#total-' + tranferId).text()
    $.ajax({
        type: 'post',
        url: '/Bill/GetBillDetail_Pta',
        data: { id: tranferId },

        success: function (response) {
            $('#table-billDetail').html(response);
            $('#txt-total').text(total);

        }
    })

}

