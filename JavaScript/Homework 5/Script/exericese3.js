function weightInChickens(weigh){

    let title = document.title;
    console.log(`title: ${title}`);
    document.body.append(title);
    weigh = parseInt(prompt(`Enter weigh: `));
    let chicken = 0.5 * weigh;
    // document.writeln(chicken);
    let paragraph = document.createElement("p");
    paragraph.innerText = `Chicken: ${chicken}`;
    console.log(`paragraph: ${paragraph}`);
    console.log(`paragraph text: ${paragraph.innerHTML}`);
    document.body.append(paragraph);
}

weightInChickens();





