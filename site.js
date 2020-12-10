"use strict";

function fizzbuzz() {
    let response = "";
    for (let i = 0; i <= 100; i++) {
        if (i % 3 === 0 && i % 5 === 0) {
            response += "fizzbuzz\n";
        }
        else if (i % 3 === 0) {
            response += "fizz\n";
        }
        else if (i % 5 === 0) {
            response += "buzz\n";
        }
        else {
            response += i + "\n";
        }
    }
    alert(response);
}

function reverseString() {
    let userInput = prompt("Please enter a word or phrase: ");
    let reversedUserInput = "";
    for (let i = 1; i <= userInput.length; i++) {
        reversedUserInput += userInput[userInput.length - i];
    }
    alert(`Your reversed word or phrase is: ${reversedUserInput}`);
}

function capitalizeFirstLetters() {
    let userInput = prompt("Enter words to be capitalized: ");
    let capitalizedUserInput = "";
    for(let i = 0; i < userInput.length; i++) {
        if(i === 0 || userInput[i-1] === " ") {
            capitalizedUserInput += userInput[i].toUpperCase();
        } else {
            capitalizedUserInput += userInput[i];
        }
    }
    alert(`Your capitalized input is: ${capitalizedUserInput}`);
}