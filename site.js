"use strict";

function fizzbuzz() {
    let i;
    let response = "";
    for (i = 0; i <= 100; i++) {
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