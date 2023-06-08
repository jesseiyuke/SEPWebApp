var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Approver/JobPost/GetAll"
		},
		"columns": [
			{ "data": "jobTitle", "width": "15%" },
			{ "data": "department.name", "width": "15%" },
			{ "data": "jobType.name", "width": "15%" },
			{ "data": "startDate", "width": "15%" },
			{ "data": "endDate", "width": "15%" },
			{ "data": "status.name", "width": "15%" },

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="w-75 btn-group" role="group">
						<a href="/Approver/JobPost/Upsert?id=${data}"
						class="btn btn-primary mx-2">Review</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}