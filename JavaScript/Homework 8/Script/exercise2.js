$(document).ready(function(){

    let button = $("#button");
    button.on("click", function(){
        let text = $("#text");
        let color = $("#color");
        console.log(color.val());
        let heading = $("#heading3");
        if (text.val() == ""){
            heading.html(`<h3>Invalid text !</h3>`);
        }
        else if (!color.val() == "#dc0909"){
            heading.html(`<h3>Invalid color !</h3>`);
        }
        else {
            heading.css("color", `${color.val()}`);
            heading.html(`<h3>Hello there ${text.val()} !</h3>`);
        }
    });

});



//color validate