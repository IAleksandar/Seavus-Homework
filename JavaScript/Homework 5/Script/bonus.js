let ingridients=[];


    var recipe = prompt("Enter the name of the recipe: ");
    counter = parseInt(prompt("Enter how many ingridients do we need for the recipe: "));
    for(let i = 0; i < counter; i++){
        var item = prompt("Enter the name of the ingridient: ");
        ingridients.push(`${item}`);
    }


    
    let heading = document.createElement("h2");
    heading.innerText = `${recipe}`;
    document.body.append(heading);

    let unorderedList = document.createElement("ul");


    ingridients.forEach(function (ingridient) {
        var li = document.createElement('li');
        li.textContent = ingridient;
        document.body.appendChild(li);
    });