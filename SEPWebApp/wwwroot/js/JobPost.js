﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Employer/JobPost/GetAll"
        },
        "columns": [
            { "data": "jobTitle", "width": "15%" },
            { "data": "Department.Name", "width": "15%" },
            { "data": "JobType.Name", "width": "15%" },
            { "data": "startDate", "width": "15%" },
            { "data": "endDate", "width": "15%" },
            { "data": "Status.Name", "width": "15%" },

            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                        <a href="/Employer/JobPost/Upsert?id=${data}"
                        class="btn btn-primary mx-2">Review</a>
					</div>
                        `
                },
                "width": "15%"
            }

        ]
    });
}