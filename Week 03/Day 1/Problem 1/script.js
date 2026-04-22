$(document).ready(function(){

$("#submitBtn").click(function(){

    var n = $("#name").val()
    var e = $("#email").val()

    if(n == "" || e == ""){
        $("#message").removeClass("success")
        $("#message").addClass("error")
        $("#message").text("Name and Email are required")
    }
    else{
        $("#message").removeClass("error")
        $("#message").addClass("success")
        $("#message").text("Feedback submitted successfully")

        $("#name").val("")
        $("#email").val("")
        $("#rating").val("")
        $("#comments").val("")
    }

})

})