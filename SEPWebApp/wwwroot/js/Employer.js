var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Approver/GetAll"
		},
		"columns": [
			{ "data": "firstName.name", "width": "15%" },
			{ "data": "lastName.name", "width": "15%" },
			{ "data": "legalName", "width": "15%" },
			{ "data": "tradingName", "width": "15%" },
			{ "data": "registrationNumber", "width": "15%" },
			{ "data": "status.name", "width": "15%" },

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="w-75 btn-group" role="group">
						<a href="/Approver/Upsert?id=${data}"
						class="btn btn-primary mx-2">Review</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}