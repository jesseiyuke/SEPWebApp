var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Student/Student/GetAllDocuments"
		},
		"columns": [
			{ "data": "name", "width": "30%" },
			{ "data": "description", "width": "30%" },

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="w-75 btn-group" role="group">
						<a href="/Student/Student/ViewDocument?id=${data}"
						class="btn btn-primary mx-2">View</a>
						<a onClick=Delete('/Student/Student/DeleteDocument/${data}')
						class="btn btn-primary mx-2">Delete</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}

function Delete(url) {
	Swal.fire({
		title: 'Are you sure?',
		text: "You won't be able to revert this!",
		icon: 'warning',
		showCancelButton: true,
		confirmButtonColor: '#3085d6',
		cancelButtonColor: '#d33',
		confirmButtonText: 'Yes, delete it!'
	}).then((result) => {
		if (result.isConfirmed) {
			$.ajax({
				url: url,
				type: 'DELETE',
				success: function (data) {
					if (data.success) {
						dataTable.ajax.reload();
						toastr.success(data.message);
					}
					else {
						toastr.error(data.message);
					}
				}
			})
		}
	})
}
