var dataTable;

$(document).ready(function () {
	var url = window.location.search;
	var urlParams = new URLSearchParams(url);
	var param = urlParams.get('id');
	loadDataTable(param);
});

function loadDataTable(id) {
	dataTable = $('#tblData').DataTable({
		"ajax": {
			"url": "/Employer/JobPost/GetAllApplicant?id=" + id
		},
		"columns": [
			{ "data": "applicationUser.firstName", "width": "15%" },
			{ "data": "applicationUser.lastName", "width": "15%" },
			{ "data": "studentDepartment.name", "width": "15%" },

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
