var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Employer/JobPost/GetAllApplicant"
		},
		"columns": [
			{ "data": "id", "width": "15%" },
/*			{ "data": "student.applicationUser.lastName", "width": "15%" },*/

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="w-75 btn-group" role="group">
						<a href="/Employer/JobPost/Detail?id=${data}"
						class="btn btn-primary mx-2">Details</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}
