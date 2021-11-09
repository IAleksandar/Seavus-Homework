let book = {
    title: prompt("Enter the title: "),
    author: prompt("Enter the author"),
    readingStatus: true,
    isReading: function(){
        if (this.readingStatus != true){
            console.log(`You still need to read ${this.title} by ${this.author} `);
        }
        else{
            console.log(`Already read ${this.title} by ${this.author} `);
        }
    }

}

book.isReading();