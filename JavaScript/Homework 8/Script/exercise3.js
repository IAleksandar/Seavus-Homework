$(document).ready(function(){

    let button = $("#button");
    button.on("click", function(){
        $("#myColor option[value='Red']").each(function() {
            $(this).remove();
        });
        $("#myColor option[value='Blue']").each(function() {
            $(this).remove();
        });
        $("#myColor option[value='Green']").each(function() {
            $(this).remove();
        });
        let o = new Option("option text", "value");
        $(o).html("Yellow");
        $("#myColor").append(o);
        let y = "Yellow";
       
        let heading2 = $("#content");
        heading2.html(`<h2>${y}</h2>`);
    });

});



/// PRINT YELLOW