/*01.Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.*/

var arr = new Array(20);

for (var i = 0; i < arr.length; i += 1) {
    arr[i] = i * 5;
}

console.log(arr.join(','));

//02.Write a script that compares two char arrays lexicographically (letter by letter).
var arr1 = [1, 2, 3, 4, 'a'];
var arr2 = [1, 2, 3, 4, 'b'];
var areEqual = true;

for (var i = 0; i < arr.length; i += 1) {
    if (arr1[i] !== arr2[i]) {
        areEqual = false;
        break;
    }
}

console.log('Arrays are equal: ' + areEqual);

//03.Write a script that finds the maximal sequence of equal elements in an array.
var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 9, 9, 9, 9, 9, 9, 9, 1];
var count = 1;
var maxCount = 0;
var currentNumber;
var resultNumber;

for (var i = 1; i < arr.length; i += 1) {
    var current = arr[i];
    if (current === arr[i - 1]) {
        currentNumber = arr[i];
        count++;
        if (count > maxCount) {
            maxCount = count;
            resultNumber = currentNumber;
        }
    }
    else {
        count = 1;
    }
}

console.log('The maximal sequence of equal elements has ' + maxCount + ' occurances and it\'s number is: ' + resultNumber);

//04.Write a script that finds the maximal increasing sequence in an array.
var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 2, 3, 4, 6, 9, 12, 50, 1];
var count = 1;
var maxCount = 0;
var currentArr = [];
var resultArr = [];

for (var i = 1; i < arr.length; i += 1) {
    var current = arr[i];

    if (current > arr[i - 1]) {
        currentArr[count] = current;
        count++;
        if (count > maxCount) {
            maxCount = count;
            for (var j = 0; j < currentArr.length; j += 1) {
                resultArr[j] = currentArr[j];
            }
        }
    }
    else {
        count = 1;
        currentArr = [];
        currentArr[0] = arr[i];
    }
}

console.log('The maximal sequence of increasing elements is: ' + resultArr.join(','));

//05.Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.
var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

for (var i = 0; i < arr.length; i += 1) {
    for (var j = i; j < arr.length; j += 1) {
        if (arr[j] < arr[i]) {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

console.log(arr.join(','));

//06.Write a script that finds the most frequent number in an array.
var arr = [4, 1, 1, 4, 2, 3, 4, 4, 4, 4, 1, 2, 4, 9, 3];
var currentNumber;
var count = 0;
var resultArr = [];

for (var i = 0; i < arr.length; i += 1) {
    if (resultArr[arr[i]]) {
        var count = resultArr[arr[i]];
        count++;
        resultArr[arr[i]] = count;
    }
    else {
        resultArr[arr[i]] = 1;
    }
}

var occurances = 0;
var finalNumber;
for (var i = 0; i < resultArr.length; i += 1) {
    if (occurances < resultArr[i]) {
        occurances = resultArr[i];
        finalNumber = i;
    }
}

console.log('The most frequent number is: ' + finalNumber + ' with ' + occurances + ' occurances');

//07.Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
var arr = [0, 1, 1, 2, 2, 3, 3, 4, 4, 9, 11, 12, 13, 14, 16, 20, 37];

//iteration
function BinarySearch(arr, number) {
    var result;
    var index = Math.floor((arr.length-1 ) / 2);
    var range=index;
    var count=0;
    while (count<=2){
        range=Math.ceil(range/2);
        if (arr[index] === number) {
            result = index;
            break;
        }
        else if (number > arr[index]) {
            index = index + range;
        }
        else if (number < arr[index]) {
            index = index - range;
        }

        if(range===1){
            count++;
        }
    }
    if (result === undefined) {
        return -1;
    }
    else {
        return result;
    }
}

var resultIndex = BinarySearch(arr, 0);
console.log(resultIndex === -1 ? 'The number is not found!' : 'The number is found at index: ' + resultIndex);

//Solution with recursion
var index = Math.floor((arr.length - 1) / 2);
var range=index;
var count=0;
function BinarySearch2(arr, number, range) {
    range=Math.ceil(range/2);
    var result;
    console.log(range);
    if(range===1){
        count++;
    }
    if (count>=2) {
        return -1;
    }
    if (arr[index] === number) {
        return index;
    }
    else if (number > arr[index]) {
        index = index + range;
        return BinarySearch2(arr, number, range);
    }
    else {
        index = index - range;
        return BinarySearch2(arr, number, range);
    }
}

var resultIndex = BinarySearch2(arr, 327,range);
console.log(resultIndex === -1 ? 'The number is not found!' : 'The number is found at index: ' + resultIndex);