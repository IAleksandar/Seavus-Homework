function Library(name, books, address){
    this.name = name;
    this.books = books === undefined ? [] : books;  
    this. address = address;
    this.numberOfMembers = this.books.length * 15;
    this.printBooks = function(){
        this.books.forEach(book => {
            console.log(book.title);
        });
    }
}

function Book(title, genre, libraries, authors){
    this.title = title;
    this.genre = genre;
    this.libraries = libraries;
    this.authors = authors;
    this.addLibrary = (library => {
        this.libraries.push(library);
        console.log(library);
    }),
    
    this.removeLibrary = (library => {
        this.libraries.pop(library);
    })  
}

function Author(firstName, lastName, yearOfBirth){
    this.firstName = firstName;
    this.lastName = lastName;
    this.yearOfBirth = yearOfBirth;
    this.books = [];
    this.currentBook = null;
    this.startBook = (book => {
        this.currentBook = book;
        this.books.push(this.currentBook);
    })
}

let library = new Library("Paris Student Library", [], "Paris");
let author = new Author("Douglas", "Crockford", 1983);
let book = new Book("JavaScript: The good parts", "programming", ["Paris Student Library", "Skopje public library"], [author]);
let secondBook = new Book("Makbet", "romance", ["Paris Student Library", "Berovo public library"], [author]);


book.addLibrary(library);
library.printBooks(book);

book.removeLibrary(library);
library.printBooks(book);

author.startBook(book);
author.startBook(secondBook);
console.log(author);

let newLibrary = Object.create(library);
newLibrary.addBook = function(){
    this.books.push(book);
}

newLibrary.addBook();







