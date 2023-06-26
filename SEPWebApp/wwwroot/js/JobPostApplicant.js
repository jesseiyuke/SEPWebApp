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
			{ "data": "applicationUser.firstName", "width": "10%" },
			{ "data": "applicationUser.lastName", "width": "10%" },
			{ "data": "faculty.name", "width": "10%" },
			{ "data": "studentDepartment.name", "width": "10%" },
			{ "data": "yearOfStudy.name", "width": "10%" },
			{ "data": "gender.name", "width": "10%" },
			{ "data": "status.name", "width": "10%" },


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
				"width": "10%"
			}

		]
	});
}
