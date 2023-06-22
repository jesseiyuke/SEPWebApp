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
						<a href="/Student/ViewDocument?id=${data}"
						class="btn btn-primary mx-2">View</a>
						<a href="/Student/DeleteDocument?id=${data}"
						class="btn btn-primary mx-2">Delete</a>
					</div>
						`
				},
				"width": "15%"
			}

		]
	});
}
