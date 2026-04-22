$(document).ready(function(){

$(".q").click(function(){

    $(this).next(".a").slideToggle()

    $(".q").removeClass("active")
    $(this).addClass("active")

})

})