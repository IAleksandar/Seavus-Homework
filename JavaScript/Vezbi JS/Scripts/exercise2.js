let atm = {
    balance: 500
};

let choice = parseInt(prompt("Enter number: \n 1 -> get balance, 2-> make deposit, 3 -> withdrawal, 4 - exit"));

let button = document.getElementById("button");
button.addEventListener("click", function(){

        if(choice == 1){
            console.log(atm.balance);
        }
        if(choice == 2){
            let deposit = parseInt(prompt("Enter how much money would you like to deposit: "));
            deposit = atm.balance + deposit;
            console.log(deposit);
    
        }
        if(choice == 3){
            let withdraw = parseInt(prompt("Enter how much money would you like to withdraw: "));
            if (atm.balance < withdraw){
                console.log("You don't have enough money");
            }
            else {
                withdraw = atm.balance - withdraw;
                console.log(withdraw);
            }

        }
        if(choice == 4){
            console.log("You can get your card");
        }
})