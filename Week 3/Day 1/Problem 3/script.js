$(document).ready(function(){

var c = 0

$(".add").click(function(){

    c++
    $("#count").text(c)

    $(this).prop("disabled", true)

    $(this).next(".msg").text("Added")

})

})