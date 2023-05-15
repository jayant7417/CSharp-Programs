var studentlist = [];
$(document).ready(function () {
    debugger
    //load courses
    $.ajax({
        type: 'GET',
        url: '/Home/GetCourseData',
        dataType: 'json',
        data: { id: '' },
        success: function (data) {

            for (var i = 0; i < data.length; i++) {
                var option = '<option value="' + data[i].CourseId + '">' + data[i].CourseName + '</option>';
                $("#ddlCourses").append(option);
            }
        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });

    $("#btnload").click(function () {
        var courseId = $("#ddlCourses").val();
        loaddata(parseInt(courseId));
    })


    //Load Students List
    function loaddata(value) {
        $("#mydata").empty();
        $.ajax({
            type: 'GET',
            url: '/Home/GetStudentData',
            dataType: 'json',
            data: { courseId: value },
            success: function (data) {
                studentlist = data;

                for (var i = 0; i < data.length; i++) {
                    var row = '<tr><td>' + data[i].Id + '</td>' +
                        '<td> ' + data[i].Name + '</td>' +
                        '<td>' + data[i].City + '</td>';
                    row += '<td><a href="javascript:void(0)" class="edit" data-id=' + data[i].Id + '>Edit</a> | <a href="javascript:void(0)" class="delete" data-id=' + data[i].Id + '>Delete</a></td>';
                    row += '</tr>';
                    $("#mydata").append(row);
                }

                $('.edit').click(function () {
                    var self = $(this);
                    var studentId = self.attr('data-id');
                    getRecordfromlist(studentId);
                })

                $(".delete").click(function () {
                    if (confirm("Are you sure you want to delete this?")) {
                        debugger
                        var self = $(this);
                        var studentId = self.attr('data-id');
                        deleteRecord(parseInt(studentId));
                    }
                    else {
                        return false;
                    }
                });
            },
            error: function (ex) {
                var r = jQuery.parseJSON(response.responseText);
                alert("Message: " + r.Message);
                alert("StackTrace: " + r.StackTrace);
                alert("ExceptionType: " + r.ExceptionType);
            }
        });
    }

    //Binding data to edit section
    function getRecordfromlist(studentId) {
        var studentdetail = studentlist.find(function (item) {
            return item.Id == studentId;
        })
        $("#Id").val(studentdetail.Id);
        $("#Name").val(studentdetail.Name);
        $("#City").val(studentdetail.City);
        $("#editsection").show();

    }

    $("#btnSave").click(function () {
        if (ValidateForm()) {
            var stuObj = {
                Id: $('#Id').val(),
                Name: $('#Name').val(),
                City: $('#City').val(),
            };

            //ajx call with all param

            $.ajax({
                url: "/Home/Update",
                data: JSON.stringify(stuObj),
                type: "POST",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (result) {
                    if (result > 0) {
                        loaddata(0);
                        $("#editsection").hide();
                    }
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }
    })

    function deleteRecord(studentId) {
        debugger
        $.ajax({
            url: "/Home/Delete",
            data: { id: studentId },
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                debugger
                if (result > 0) {
                    alert("Sucessfully Deleted....");
                    loaddata(0);
                }
            },
            error: function (errormessage) {
                debugger
                alert(errormessage.responseText);
            }
        });
    }
})

function ValidateForm() {
    debugger
    if ($('#Name').val() == "") {
        alert("Student Name cannot be empty.");
        return false;
    } else if ($('#City').val() == "") {
        alert("City cannot be empty.");
        return false;
    } else {
        return true;
    }

    //if (!$("#registerFormId").valid()) {
    //    return false;
    //}
    //return true;
}