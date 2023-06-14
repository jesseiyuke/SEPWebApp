var dataTable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Approver/Employer/GetAll"
		},
		"columns": [
/*			{ "data": "applicationUser.firstname", "width": "15%" },*/
/*			{ "data": "applicationUser.lastname", "width": "15%" },*/
			{ "data": "businessName", "width": "15%" },
			{ "data": "tradingName", "width": "15%" },
			{ "data": "companyRegNo", "width": "15%" },
			{ "data": "status.name", "width": "15%" },

			{
				"data": "id",
				"render": function (data) {
					return `
						<div class="w-75 btn-group" role="group">
						<a href="/Approver/Employer/JobPost/Upsert?id=${data}"
						class="btn btn-primary mx-2">Review</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}