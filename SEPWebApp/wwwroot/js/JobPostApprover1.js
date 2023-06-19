var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData1').DataTable({
		"ajax": {
			"url": "/Approver/JobPost/GetAll"
		},
		"columns": [
			{ "data": "jobTitle", "width": "10%" },
			{ "data": "department.name", "width": "10%" },
			{ "data": "jobType.name", "width": "10%" },
			{ "data": "startDate", "width": "10%" },
			{ "data": "endDate", "width": "10%" },
			{ "data": "emoloyerType", "width": "10%" },
			{ "data": "status.name", "width": "10%" },

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
			},

		]
	});
}