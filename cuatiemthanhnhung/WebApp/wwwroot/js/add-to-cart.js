$('body').off('click', '.buy-now').on('click', '.buy-now', AddToCart);

function AddToCart() {

    var tranferId = $(this).data('id');
    $.ajax({
        type: 'post',
        url: '/Cart/AddToCart',
        data: { productId: tranferId },

        success: function (response) {

            $('#a').load('/Cart/UpdateCartViewComponent');
            $('#addcart-' + tranferId).notify("Thêm thành công", "success");

        }
    })

}