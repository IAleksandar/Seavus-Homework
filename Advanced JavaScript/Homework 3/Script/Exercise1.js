function Product(pName, cat, hasDisc, price) {
    this.productName = pName;
    this.category = cat;
    this.hasDiscount = hasDisc;
    this.price = price;
}

let products = [new Product("Milk", "liquid", "yes", 50), new Product("Cheese", "food", "yes", 75), new Product("Egg", "food", "no", 10), 
                new Product("Chocolate", "food", "no", 60), new Product("Coca Cola", "liquid", "yes", 65), new Product("Fanta", "liquid", "no", 55), 
                new Product("Pepsi", "liquid", "yes", 45), new Product("Oats", "food", "no", 80), new Product("Jogurt", "liquid", "no", 45), 
                new Product("Beens", "food", "no", 5), new Product("Salami", "food", "yes", 56), new Product("Ketchup", "liquid", "yes", 42), 
                new Product("Mustard", "liquid", "no", 35), new Product("Apple", "food", "no", 4), new Product("Banana", "food", "yes", 7)];



console.log("Find all products with price greater than 20");
function priceGreater20(prices){
    return prices.price > 20;
}
let ProductsGreater20 = products.filter(priceGreater20);
console.log(ProductsGreater20);

console.log("Get the names of all products of Category Food, that are on discount");
let CategoryFood = products.filter(product => product.category === "food");
let FoodOnDiscount = CategoryFood.filter(product => product.hasDiscount === "yes");
console.log(FoodOnDiscount);

console.log("The average price of all products that are on discount");
let average = 0;
let productsOnDiscount = products.filter(product => product.hasDiscount !== "no");
console.log(productsOnDiscount);
for (let i = 0; i < productsOnDiscount.length; i++){
    average += productsOnDiscount[i].price / productsOnDiscount.length;
}
console.log(average);

console.log("Find the name and price of all products with name starting with a vowel, that are not on discount");
function productsNotOnDiscount(product){
    return product.hasDiscount == "no";
}
let productsNotOnDiscount1 = products.filter(productsNotOnDiscount);
console.log(productsNotOnDiscount1);
for (let i = 0; i < productsNotOnDiscount1.length; i++){
    let letter = productsNotOnDiscount1[i].productName[0];
    // console.log(letter);
    if(letter == "a" || letter == "e" || letter == "o" || letter == "u"){
        console.log("Product: " + productsNotOnDiscount1[i].productName);
        console.log("Price: " + productsNotOnDiscount1[i].price);
    }
}

console.log("Sort the products by price, ascending, without changing the original array");
function productsCopy(arr){
    let copied = [];
    arr.forEach(product => copied.push(product));
    return copied;
}
let copy = productsCopy(products);
copy.sort((p1, p2) => p1.price - p2.price);
copy.forEach(product => console.log("Products: " + product.productName + " " + "Price: " + " " + product.price));
console.log(copy);
//console.log(products);


