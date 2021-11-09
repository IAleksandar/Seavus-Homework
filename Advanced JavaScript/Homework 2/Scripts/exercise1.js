$(document).ready(function(){
    $("button").click(function(){
        $.ajax({
            url: "https://swapi.dev/api/planets/?page=1",
            success: function(data){
                console.log(data);
                console.log(data.results);
                for (let i = 0; i < 10; i++){
                    let planetName = data.results[i].name;
                    let population = data.results[i].population;
                    let climate = data.results[i].climate;
                    let gravity = data.results[i].gravity;
                    $("table").after(`
                    <tr>
                        <td>${planetName}</td>
                        <td>${population}</td>
                        <td>${climate}</td>
                        <td>${gravity}</td>
                    </tr>
                    `);
                }

            },
            error: function(data){
                console.log(data);
            }
        })
    })
})