$(document).ready(function(){
let n1 = $("#n1");
let n2 = $("#n2");

let button = $("#button");
button.click(function(){
    debugger;
    let area = (n1.val()*n2.val());
    let p = $("#paragraph");
    p.html(`<p>${area}</p>`);
});

button.mouseover(function(){
    let perimetar = ((n1.val()*2)+(n2.val()*2));
    let p = $("#paragraph");
    p.html(`<p>${perimetar}</p>`);
    p.css("color", "red");
    p.css("fontSize", 50);
    
});

});