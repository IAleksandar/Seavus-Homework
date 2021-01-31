let button = document.getElementById("button");
let div = document.getElementById("div");
function getData(response){
    fetch(`https://jsonplaceholder.typicode.com/todos/${response}`)
    .then(response =>{
        
        debugger;
        response.json()
        .then(response=>{
            if(response.completed == false)
        {
            div.append(`<p>ID: ${response.id}, title: ${response.title}, Not Completed</p>`);
        }
        else {
            div.append(`<p>ID: ${response.id}, title: ${response.title}, Completed</p>`);
        }
        });
    })
    .catch(err=>{
        console.log(err);
    });
}
button.addEventListener("click", function(){
    getData(4);
});