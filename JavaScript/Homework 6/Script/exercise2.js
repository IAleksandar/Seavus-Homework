var button = document.getElementsByTagName("input")[0];



function insert_Row(){
    let table = document.getElementById("sampleTable");
    let template = `<tr>
                        <td>Row3 Cell1</td>
                        <td>Row3 Cell2</td>
                    </tr>`;
    table.innerHTML += template;
}

button.addEventListener("onclick", insert_Row);