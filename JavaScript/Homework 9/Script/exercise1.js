$(document).ready(function(){
let button = $("#button");
let div = $("#div");

function getData(number){
    $.ajax({
        url: `https://jsonplaceholder.typicode.com/todos/${number}`,
        success: function(result){
            debugger;
            if(result.completed == false)
            {
                div.append(`<p>ID: ${result.id}, title: ${result.title}, Not Completed</p>`);
            }
            else {
                div.append(`<p>ID: ${result.id}, title: ${result.title}, Completed</p>`);
            }
            
        },
        error: function(err){
            console.log(err);
        }
    })
};

button.click(function(){
    getData(4);
});
});