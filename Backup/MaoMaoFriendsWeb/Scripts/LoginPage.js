$(function () {
    var cookieName = "username";
    if ($.cookie(cookieName)) {
        $("#username").val($.cookie(cookieName));
    }
    $("#remuser").click(function(){
        if(this.checked){
            $.cookie(cookieName, $("#username").val(), {path: '/', expires: 10});
        }
        else{
            $.cookie(cookieName, null, {path: '/' });
        }
           
    })
})