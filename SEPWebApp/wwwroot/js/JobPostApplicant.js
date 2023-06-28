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
			{ "data": "student.applicationUser.firstName", "width": "15%" },
			{ "data": "student.applicationUser.lastName", "width": "15%" },
			{ "data": "student.department.faculty.name", "width": "15%" },
			{ "data": "student.department.name", "width": "15%" },

			{ "data": "student.yearOfStudy.name", "width": "15%" },
			{ "data": "student.gender.name", "width": "15%" },
			{ "data": "applicationStatus.name", "width": "15%" },

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
