$(document).ready(function(){

    let button = $("#button");
    button.on("click", function(){
        let text = $("#text");
        text = text.val();
        let header = $("#header");
        header.html(`<h1>Hello there ${text}!</h1>`);
    });

});