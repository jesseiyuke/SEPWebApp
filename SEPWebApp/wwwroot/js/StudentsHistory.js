var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Student/Student/GetAllAppyJobPost"
		},
		"columns": [
			{ "data": "jobPost.jobTitle", "width": "16%" },
			{ "data": "jobPost.department.name", "width": "16%" },
			{ "data": "jobPost.weekHour.name", "width": "12%" },
			{
				"data": "jobPost.startDate",
				"width": "12%",
				"render": function (data) {
					return formatDate(data);
				}
			},
			{
				"data": "jobPost.endDate",
				"width": "12%",
				"render": function (data) {
					return formatDate(data);
				}
			},
			{ "data": "applicationStatus.name","width":"12%"},

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="col" >

							<a href="/Student/Student/ReviewApplication?Id=${data}"
						class="btn btn-primary mx-2">Details</a>



						<a onClick=Delete('/Student/Student/WithdrawApplication/${data}')
						class="btn btn-primary mx-2">Withdraw</a>
						</div>

						`
				},
				"width": "22%"
			}

		]
	});
}
function formatDate(date) {
	var formattedDate = new Date(date).toLocaleDateString('en-GB', {

		year: 'numeric',
		month: '2-digit',
		day: '2-digit'
	});
	return formattedDate;
}

function Delete(url) {
	Swal.fire({
		title: 'Are you sure?',
		text: "You won't be able to apply to this job post again!",
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

