

$(document).ready(function () {
    loaddatatable();
});

function loaddatatable() {
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            {data:'title'},
            { data: 'description' },
            { data: 'author' },
            { data: 'isbn' },
            { data: 'listPrice' },
            { data: 'category.name' },
            {
                data: 'productId',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i>Edit
                        </a>
                        <a onClick=Delete("/admin/product/delete?id=${data}") class="btn btn-primary mx-2"><i class="bi bi-trash-fill"></i>Delete
                        </a>
                        
                    </div>`
                }
            }

        ]
    });
}
function Delete(url) {

    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes, delete it!",
        cancelButtonText: "No, cancel!",
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'Delete',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
                
            });

        }
    });

 }
       
