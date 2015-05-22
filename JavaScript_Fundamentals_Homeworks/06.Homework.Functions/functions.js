//01.//01.Write a function that returns the last digit of given integer as an English word.
function returnLastDigitAsSymbol(number) {
    var lastDigit = number % 10;
    switch (lastDigit) {
        case 0:
            return 'zero';
        case 1:
            return 'one';
        case 2:
            return 'two';
        case 3:
            return 'three';
        case 4:
            return 'four';
        case 5:
            return 'five';
        case 6:
            return 'six';
        case 7:
            return 'seven';
        case 8:
            return 'eight';
        case 9:
            return 'nine';
        default :
            return 'this is not a number';
    }
}
var number = 235;
console.log('01.The last digit of ' + number + ' as word is: ' + returnLastDigitAsSymbol(number));

//02.Write a function that reverses the digits of given decimal number.
function reverseNumber(number) {
    var reversed = 0;
    var multiplier = Math.pow(10, number.toString().length - 1);
    while (number > 0) {
        reversed += (number % 10) * multiplier;
        multiplier /= 10;
        number = Math.floor((number / 10));
    }
    return reversed;
}
var number = 2350;
console.log('02.The reversed number of ' + number + ' is: ' + reverseNumber(number));

//03.Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

function findOccurrences(word, text, isSensitive) {
    var allWords = text.split(' ');
    var occurrences = 0;
    switch (arguments.length) {
        case 2:
            word = word.toLowerCase();
            for (var i = 0; i < allWords.length; i += 1) {
                if (allWords[i].toLowerCase() === word) {
                    occurrences++;
                }
            }
            return occurrences;
        case 3:
            for (var i = 0; i < allWords.length; i += 1) {
                if (allWords[i] === word) {
                    occurrences++;
                }
            }
            return occurrences;
    }
}

console.log('03.1.The number of occurrences with case sensitive: ' + findOccurrences('FiNds', 'Write a function that finds finds finds all the occurrences of word in a text.', true));
console.log('03.2.The number of occurrences with case insensitive: ' + findOccurrences('FiNds', 'Write a function that  finds finds finds all the occurrences of word in a text.'));

//04.Write a function to count the number of div elements on the web page
function findNumberOfElement() {
    return document.getElementsByTagName('div').length;
}

console.log('04.The number of divs is: ' + findNumberOfElement());

//05.Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.
var arr=[1,1,2,3,4,5,4,2,3,4,6,7,8,6,3,2,6,8,199];

function countNumberAppearance(array,number){
    var count=0;
    for(var num in array){
        if(array[num]===number){
            count++;
        }
    }
    return count;
}
var number=2;
console.log('05.The number ' + number + ' appears ' + countNumberAppearance(arr,number) + ' times.' );

//06.Write a function that checks if the element at given position in
//given array of integers is bigger than its two neighbours (when such exist).
var arr=[2,1,2,3,4,5,4,2,3,4,6,7,8,6,3,2,6,8,199];

function checkIfElementIsBiggerThanItsNeighbours(array,position){
    if(position>=0&&position<=array.length-1){
        if(position==0){
            if(array[position]>array[position+1]){
                return true;
            }
        }
        else if(position==array.length-1){
            if(array[position]>array[position-1]){
                return true;
            }
        }
        else{
            if(array[position]>array[position-1]&&array[position]>array[position+1]){
                return true;
            }
        }
    }
    return false;
}

var position=0;
console.log('06.The number at position ' + position + ' is bigger than its neighbours: ' + checkIfElementIsBiggerThanItsNeighbours(arr,position));

//07.Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.
var arr=[0,1,2,3,4,5,4,2,3,4,6,7,8,6,3,2,6,8,199];

function findIndexOfFirstLargerThanItsNeighbours(array){
    for(var i=0;array.length-1;i+=1){
        if(checkIfElementIsBiggerThanItsNeighbours(array,i)){
            return i;
        }
    }
    return -1;
}

console.log('07.The index of the first element in array that is larger than its neighbours is: ' + findIndexOfFirstLargerThanItsNeighbours(arr));