$(document).ready(function () {

    GetCart()
    CaculateTotalMoney()


    function GetCart() {

        $.ajax({
            type: 'post',
            url: '/Cart/GetCart_Pta',
            success: function (response) {

                $('#table-content').html(response)

            }
        })

    }

    function CaculateTotalMoney() {

        $.ajax({
            type: 'post',
            url: '/Cart/CaculateTotalMoney',
            success: function (response) {

                $('#total-money').text(response.result)


            }
        })

    }



    $('body').off('click', '.remove').on('click', '.remove', Remove);

    function Remove() {

        var tranferId = $(this).data('id');
        $.ajax({
            type: 'post',
            url: '/Cart/RemoveFromCart',
            data: { productId: tranferId },

            success: function (response) {

                $('#a').load('/Cart/UpdateCartViewComponent');
                $('#table-content').load('/Cart/GetCart_Pta');
            }
        })

    }
    $('body').off('click', '.update').on('click', '.update', Update);
    function Update() {

        var id = $(this).data('id');
        var quantity = $('#quantity-' + id).val();
        var model = new Object();

        model.Quantity = quantity;
        model.ProductId = id;


        $.ajax({
            type: 'post',
            url: '/Cart/UpdateCart',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                GetCart();
                $.notify("Cập nhật thành công", "success")

                $('#total-money').text(response.total)
                $('#a').load('/Cart/UpdateCartViewComponent');
                $('#table-content').load('/Cart/GetCart_Pta');

            }
        })

    }
    $('#frm-save').validate({
        rules: {
            FullName:
            {
                required: true,
            },
            Mobile:
            {
                required: true,

            },
            Email:
            {
                required: true,
            },

            Address:
            {
                required: true,
            },

        },
        messages: {
            FullName:
            {
                required: "Bạn phải nhập trường này",
            },
            Mobile:
            {
                required: "Bạn phải nhập trường này",

            },
            Email:
            {
                required: "Bạn phải nhập trường này",
            },

            Address:
            {
                required: "Bạn phải nhập trường này",
            },
        }
    });

    $('body').off('click', '#checkout').on('click', '#checkout', CheckOut);

    function CheckOut() {
        if ($('#frm-save').valid()) {
            var model = new Object();

            model.FullName = $('#txt-FullName').val();
            model.Email = $('#txt-Email').val();
            model.Mobile = $('#txt-Mobile').val();
            model.Address = $('#txt-Address').val();
            model.Total = $('#total-money').text();

            $.ajax({
                type: 'post',
                url: '/Bill/CheckOut',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",

                success: function (response) {
                    if (response.statusCode == 200) {
                        $('#checkout').notify("Cảm ơn bạn đã đặt hàng", "success")
                        $('#a').load('/Cart/UpdateCartViewComponent');
                        $('#table-content').load('/Cart/GetCart_Pta');
                        GetCart()
                    }
                    else {
                        $('#checkout').notify("Đã xảy ra lỗi", "error")
                    }
                }
            })
        }
    }
})