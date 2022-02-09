$(document).ready(function () {

    $('body').off('click', '.delete').on('click', '.delete', ComfirmDelete);
    $('body').off('click', '.showDetail').on('click', '.showDetail', Show);
 

    function Show() {

        var overViewId = $(this).data('id')
        $.ajax({
            type: 'post',
            url: '/BlogDetail/GetById',
            dataType: 'json',
            data: { id: overViewId },

            success: function (response) {
            
                var data = response.result;
                $('#txt-Content').html(data.content);
                $('#modal-Tittle').text(data.tittle);
                

            }
        })
    }
   
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
            url: '/BlogDetail/Delete',
            dataType: 'json',
            data: { id: tranferId },

            success: function (response) {

                if (response.statusCode == 200) {

                    $('#tr-' + tranferId).hide();
                }
            }
        })

    }


})