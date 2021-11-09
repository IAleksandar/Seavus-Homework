$(document).ready(function(){
    
    let myButton = $("#firstTen");
    let nextButton = $("#next");
    let previousButton = $("#previous");
    let table = $("table");

    table.css("border", "1px solid black");
    let nextUrl = "";
    let previousUrl = "";
    nextButton.hide();
    previousButton.hide();

    let firstTen = url => {
        $.ajax({
            url: url,
            success: (result) => {
                console.log(result);
                table.append("<thead>");
                let tableHeader = $("thead");
                tableHeader.append(`<tr><th>Planet Name</th><th>Population</th><th>Climate</th><th>Gravity</th></tr>`);
                let tableBody = tableHeader.after("<tbody>");
                tableBody = $("tbody");
                for (let i = 0; i < 10; i++){
                    tableBody.append(`<tr><td>${result.results[i].name}</td><td>${result.results[i].population}</td><td>${result.results[i].climate}</td><td>${result.results[i].gravity}</td></tr>`);
                }
                nextUrl = result.next;
                prevUrl = result.previous;
            },
            error: (err) => {
                console.log(err);
            }
        });
    }
    myButton.click(() => {
        table.html("");
        firstTen("https://swapi.dev/api/planets/?page=2");
        nextButton.show();
        previousButton.hide();
    })

    nextButton.click(() => {
        table.html("");
        firstTen(nextUrl);
        nextButton.show();
        previousButton.show();
    })

    previousButton.click(() => {
        table.html("");
        firstTen(prevUrl);
        nextButton.show();
        previousButton.show();
    })
});



