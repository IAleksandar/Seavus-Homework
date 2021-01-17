// -------- First h1 -----------------------------//

let myTitle = document.getElementById("myTitle");
myTitle.textContent = "First Heading";

// -------- First p -----------------------------//

let paragraph = document.getElementsByClassName("paragraph")[0];
console.log(`First paragraph: ${paragraph}`);
console.log(`First paragraph text: ${paragraph.innerHTML}`);
paragraph.innerHTML = "First Paragraph";

// ----------Second p -----------------------------//

let paragraphSecond = document.getElementsByClassName("paragraph")[1];
console.log(`Second paragpraph: ${paragraphSecond}`);
console.log(`Second paragraph text: ${paragraphSecond.innerHTML}`);
paragraphSecond.innerHTML = "Second Paragraph";

// ------------------- text -------------------------//

let text = document.getElementsByTagName("text")[0];
console.log(`Text: ${text}`);
console.log(`Text text: ${text.innerHTML}`);
text.textContent = "This is text";


// ------------- Second h1 -------------------------//

let secondHeading = document.getElementsByTagName("h1")[1];
console.log(`Second heading: ${secondHeading}`);
console.log(`Second heading text: ${secondHeading.textContent}`);
secondHeading.innerHTML = "Second Heading";


// --------------- h3 -----------------------------//

let headingThird = document.getElementsByTagName("h3")[0];
console.log(`heading 3: ${headingThird}`);
console.log(`heading 3 text: ${headingThird.innerHTML}`);
headingThird.innerHTML = "Third Heading";


