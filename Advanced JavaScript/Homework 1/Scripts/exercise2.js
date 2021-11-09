document.getElementById("button").addEventListener("click", function(){
    fetch("https://jsonplaceholder.typicode.com/users/1")
    .then(function(response){



       response.json().then(
           function(data){

                let details = document.getElementById("details");
                let table = document.createElement("table");
                table.innerHTML = `
                <tr>
                    <td>ID</td>
                    <td>name</td>
                    <td>username</td>
                    <td>email</td>
                    <td>street</td>
                    <td>suite</td>
                    <td>city</td>
                    <td>zipcode</td>
                    <td>geo lat</td>
                    <td>geo lng</td>
                    <td>phone</td>
                    <td>website</td>
                    <td>company name</td>
                    <td>company catch phrase</td>
                    <td>company bs</td>
                </tr>
                <tr>
                    <td>${data.id}</td>
                    <td>${data.name}</td>
                    <td>${data.username}</td>
                    <td>${data.email}</td>
                    <td>${data.address.street}</td>
                    <td>${data.address.suite}</td>
                    <td>${data.address.city}</td>
                    <td>${data.address.zipcode}</td>
                    <td>${data.address.geo.lat}</td>
                    <td>${data.address.geo.lng}</td>
                    <td>${data.phone}</td>
                    <td>${data.website}</td>
                    <td>${data.company.name}</td>
                    <td>${data.company.catchPhrase}</td>
                    <td>${data.company.bs}</td>
                </tr>`;
                details.append(table);


           }
       )
    })
    .catch(function(error){
        console.log(error);
    });
});