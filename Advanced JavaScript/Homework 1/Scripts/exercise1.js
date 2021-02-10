$(document).ready(function(){

    $("#button").click(function(){
        $.ajax({
            url: "https://pokeapi.co/api/v2/pokemon",
            success: function (data) {
                for (let i = 0; i < 10; i++){
                    let name = data.results[i].name;
                    let u = data.results[i].url;

                    $("#myList").append(`<li><b>Name:</b> ${name} &nbsp&nbsp <b>URL:</b> ${u}`);
                }
            },

            error: function(err){
                console.log(err);
            }
        })
    })
})