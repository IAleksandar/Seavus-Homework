$(document).ready(function(){
    let people = $("#btnPeople");
    let rocket = $("#btnShips");
    let div = $("#result");

    function getPeople(number){
        $.ajax({
            url: `https://swapi.dev/api/people/?page=${number}`,
            success: function(results){
            
                div.append(`
                    <table>
                        <tr>
                            <td style="color:yellow">Name</td>
                            <td style="color:yellow">Height</td>
                            <td style="color:yellow">Mass</td>
                            <td style="color:yellow">Gender</td>
                            <td style="color:yellow">Birth year</td>
                            <td style="color:yellow">Films</td>
                        </tr>
                    </table>`);

                for(let person of results){
                    div.append(`
                    <table>
                        <tr>
                            <td>${results.name}</td>
                            <td>${results.height}</td>
                            <td>${results.mass}</td>
                            <td>${results.gender}</td>
                            <td>${results.birth_year}</td>
                            <td>${results.films}</td>
                        </tr>
                    </table>
                    `);
                }    
            },
            error: function(err){
                console.log(err);
            }
        })
    };

    people.click(function(){
        getPeople(1);
    });

    function getShips(number){
        $.ajax({
            url: `https://swapi.dev/api/starships/?page=${number}`,
            success: function(results){
                
                div.append(`
                    <table>
                        <tr>
                            <td style="color:yellow">Name</td>
                            <td style="color:yellow">Model</td>
                            <td style="color:yellow">Manufacturer</td>
                            <td style="color:yellow">Cost</td>
                            <td style="color:yellow">People Capacity</td>
                            <td style="color:yellow">Class</td>
                        </tr>
                    </table>`);

                    for(let person of results){
                    div.append(`
                    <table>
                        <tr>
                            <td>${results.name}</td>
                            <td>${results.model}</td>
                            <td>${results.manufacturer}</td>
                            <td>${results.cost_in_credits}</td>
                            <td>${results.passengers}</td>
                            <td>${results.starship_class}</td>
                        </tr>
                    </table>
                    `);
                
            },
            error: function(err){
                console.log(err);
            }
        })
    };

rocket.click(function(){
    getShips(1);
});

});