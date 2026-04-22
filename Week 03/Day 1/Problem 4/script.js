$(document).ready(function(){

var total = 0
var completed = 0

$("#addBtn").click(function(){

    var t = $("#taskInput").val()

    if(t != ""){
        $("#list").append("<li>"+t+" <button class='complete'>Done</button> <button class='delete'>X</button></li>")
        total++
        $("#total").text(total)
        $("#taskInput").val("")
    }

})

$("#list").on("click",".complete",function(){

    if(!$(this).parent().hasClass("done")){
        $(this).parent().addClass("done")
        completed++
        $("#done").text(completed)
    }

})

$("#list").on("click",".delete",function(){

    if($(this).parent().hasClass("done")){
        completed--
        $("#done").text(completed)
    }

    total--
    $("#total").text(total)

    $(this).parent().remove()

})

})