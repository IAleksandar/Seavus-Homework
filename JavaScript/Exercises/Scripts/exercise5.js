$(document).ready(function(){

    let input = $("#text");
    let s = $(".s");
    let button = $("#button");




    button.on("click", function(){
        input.blur(function(){
            if(input.val() == " "){
                console.log("No input");
            }
            else {
                s.val() = input.val();
                s.html(`<option>${s.val()}</option>`);

            }
        });
    });

});