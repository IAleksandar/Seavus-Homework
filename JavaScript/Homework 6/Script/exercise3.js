let button = document.getElementById("button");


button.addEventListener("click", addP);



function x(p){
    fName = document.getElementById("first").value;
    lName = document.getElementById("last").value;
    eMail = document.getElementById("mail").value;
    pass = document.getElementById("pass").value;
    
    return this.fName + " " + this.lName + " " + this.eMail + " " + this.pass;
    

}

function addP(paragraph){
    let p1 = document.getElementById("print");
    p1.innerHTML =  `${x()}`;
}
