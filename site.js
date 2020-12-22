"use strict";

function fizzbuzz() {
    let response = "";
    for (let i = 0; i <= 100; i++) {
        if (i % 3 === 0 && i % 5 === 0) {
            response += "fizzbuzz\n";
        } else if (i % 3 === 0) {
            response += "fizz\n";
        } else if (i % 5 === 0) {
            response += "buzz\n";
        } else {
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

function compressString() {
    let userInput = prompt("Enter a string of characters: ");
    let compressedUserInput = "";
    let counter = 1;
    for (let i = 0; i < userInput.length; i++) {
        if (i == 0) {
            if (userInput[i] != userInput[i+1]) {
                compressedUserInput += `${counter}${userInput[i]}`;
            }
        } else if (userInput[i] == userInput[i-1]) {
            counter++;
        } else if (i > 1) {
            compressedUserInput += `${counter}${userInput[i-1]}`;
            counter = 1;
        }
        if (i == userInput.length-1) {
            compressedUserInput += `${counter}${userInput[i]}`;
        }
    }
    alert(`Your compressed input is: ${compressedUserInput}`);
}

function palindrome() {
    let userInput = prompt("Enter a word or string to check if it is a palindrome:");
    let simplifiedInput = "";
    let reverseSimplifiedInput = "";
    for(let i = 0; i < userInput.length; i++) {
        // Regular expression; .test() returns boolean
        if(/[a-z0-9]/i.test(userInput[i])) {
            simplifiedInput += userInput[i].toLowerCase();
            reverseSimplifiedInput = userInput[i].toLowerCase() + reverseSimplifiedInput;
        }
    }
    if(simplifiedInput === reverseSimplifiedInput) {
        alert("This is a palindrome");
    } else {
        alert("This is not a palindrome");
    }
}

function happyNumber() {
    let userInput = prompt("Enter a number to check if it is a happy number: ");
    let currentNumber = userInput;
    let counter = 0;
    do {
        let newNumber = 0;
        for(let i = 0; i < currentNumber.length; i++) {
            newNumber += Number(currentNumber[i]);
        }
        currentNumber = String(newNumber);
        counter++;
    } while(counter < 1000 && currentNumber !== "1");
    if(counter === 1000 || currentNumber !== "1") {
        alert(`After 1000 iterations, ${userInput} has not been proven to be a happy number.`);
    } else {
        alert(`${userInput} is a happy number!`);
    }
}

function fibonacci() {
    let i = 1;
    let j = 0;
    let k = 0;
    let sequence = [];
    for(let counter = 0; counter < 20; counter++) {
        sequence.push(i);
        k = j;
        j = i;
        i = j + k;
    }
    alert(`The first 20 numbers of the Fibonacci sequence are: \n${sequence.join(`\n`)}`);
}