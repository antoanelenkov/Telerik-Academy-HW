/*01.Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.*/
var counter = 0;
function generateTaskNumber() {
    return 'Task ' + ++counter + ': \n';
}
var first = 7.5;
var second = 6.5;
if (first > second) {
    var temp = first;
    first = second;
    second = temp;
}
document.getElementById("task1").innerHTML = (generateTaskNumber() + first + ' ' + second);


/*02.Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.*/
var a = 4,
    b = -5,
    c = -6,
    result;

if ((a * b > 0 && c > 0) || (a * c > 0 && b > 0) || (b * c > 0 && a > 0)) {
    result = '+';
}
else if (a === 0 || b === 0 || c === 0) {
    result = '0';
}
else {
    result = '-';
}

document.getElementById("task2").innerHTML = generateTaskNumber() + 'The sign is: ' + '"' + result + '"';


/*03.Write a script that finds the biggest of three numbers.
 Use nested if statements.*/
var a = 6,
    b = 7,
    c = 8,
    result;

if (a > b) {
    if (a > c) {
        result = a;
    }
    else {
        result = c;
    }
}
else {
    if (b > c) {
        result = b;
    }
    else {
        result = c;
    }
}

document.getElementById("task3").innerHTML = generateTaskNumber() + 'The biggest number is: ' + '"' + result + '"';


/*04.Sort 3 real values in descending order.
 Use nested if statements.*/

var a = 12,
    b = 11,
    c = 8;
var sortedCollection = [];
if (a > b) {
    if (a > c) {
        if (b < c) {
            sortedCollection[0] = b;
            sortedCollection[1] = c;
            sortedCollection[2] = a;
        }
        else {

            sortedCollection[0] = c;
            sortedCollection[1] = b;
            sortedCollection[2] = a;
        }
    }
    else {
        sortedCollection[2] = c;
        sortedCollection[1] = a;
        sortedCollection[0] = b;
    }
}
else {
    if (b > c) {
        if (a > c) {
            sortedCollection[0] = c;
            sortedCollection[1] = a;
            sortedCollection[2] = b;
        }
        else {
            sortedCollection[0] = a;
            sortedCollection[1] = c;
            sortedCollection[2] = b;
        }
    }
    else {
        sortedCollection[2] = c;
        sortedCollection[1] = b;
        sortedCollection[0] = a;
    }
}

document.getElementById("task4").innerHTML = generateTaskNumber() + 'The sorted numbers look like: ' + sortedCollection.join(',');

/*5.Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.*/
function convertDigit(){
    var input=document.getElementById('digit').value;
    switch(input){
        case '1': result= 'one';break;
        case '2': result= 'two';break;
        case '3': result='three';break;
        case '4': result='four';break;
        case '5': result='five';break;
        case '6': result='six';break;
        case '7': result='seven';break;
        case '8': result='eight';break;
        case '9': result='nine';break;
        case '10': result='ten';break;
        default: result='not a digit';
    }

    document.getElementById("result5").innerHTML = result;
}
document.getElementById("task5span").innerHTML = generateTaskNumber();
/*06.*Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.*/
function findRoots(){
    var a=document.getElementById('a').value;
    var b=document.getElementById('b').value;
    var c=document.getElementById('c').value;
    var result;

    var d=(b*b -4*a*c);
    if(d>=0){
        var root1=(-b+Math.sqrt(d))/(2*a);
        var root2=(-b-Math.sqrt(d))/(2*a);

        if(root1===root2){
            result='x1=x2='+root1;
        }
        else {
            result='x1='+root1+" x2="+root2;
        }
    }
    else{
        result='no real roots'
    }
    console.log(root1);
    console.log(root2);
    document.getElementById("result6").innerHTML = result;
}
document.getElementById("task6span").innerHTML = generateTaskNumber();

/*07.Write a script that finds the greatest of given 5 variables.
 Use nested if statements.*/
var a = 12,
    b = 11,
    c = 8,
    d= 2,
    e= 500,
    max=a;
if(b>max){
    max=b;
}
if(c>max){
    max=b;
}
if(d>max){
    max=d;
}
if(e>max){
    max=e;
}

document.getElementById("task7").innerHTML = generateTaskNumber() + 'The biggest number is: ' + max;

/*08.Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.*/
function convertNumbers(){
    var a=document.getElementById('numberToConvert').value;
    var result='';
    switch(Math.floor(a/100))
    {
        case 0:if(a==0){result="zero";break;}
        case 1: result+="one hundred ";break;
        case 2: result+="two hundred ";break;
        case 3: result+="three hundred ";break;
        case 4: result+="four hundred ";break;
        case 5: result+="five hundred ";break;
        case 6: result+="six hundred ";break;
        case 7: result+="seven hundred ";break;
        case 8: result+="eight hundred ";break;
        case 9: result+="nine hundred ";break;
        default: break;
    }
    switch(Math.floor(a%100/10))
    {
        case 1:
            if(Math.floor(a%10)==0){result+="ten";break;
            }
            if(Math.floor(a%10)==1){result+=("eleven");break;
            }
            if(Math.floor(a%10)==2){result+=("twelve");break;
            }

            if(Math.floor(a%10)==3){result+=("and thirteen");break;
            }
            if(Math.floor(a%10)==4){result+=("and fourteen");break;
            }
            if(Math.floor(a%10)==5){result+=("and fifteen");break;
            }
            if(Math.floor(a%10)==6){result+=("and sixteen");break;
            }
            if(Math.floor(a%10)==7){result+=("and seventeen");break;
            }
            if(Math.floor(a%10)==8){result+=("and eighteen");break;
            }
            if(Math.floor(a%10)==9){result+=("and nineteen");break;
            }
            break;
        case 2:result+=("twenty ");break;
        case 3:result+=("thirty ");break;
        case 4:result+=("forty ");break;
        case 5:result+=("fifty ");break;
        case 6:result+=("sixty ");break;
        case 7:result+=("seventy ");break;
        case 8:result+=("eighty ");break;
        case 9:result+=("ninty ");break;
        default: break;
    }
    switch (Math.floor(a % 10))
    {
        case 1:
            if (Math.floor(a % 100) / 10 == 1)
            {
                result+=(""); break;
            }
            else
            {
                result+=("one");
            }; break;
        case 2: result+=("two"); break;
        case 3: result+=("three"); break;
        case 4: result+=("four"); break;
        case 5: result+=("five"); break;
        case 6: result+=("six"); break;
        case 7: result+=("seven"); break;
        case 8: result+=("eight"); break;
        case 9: result+=("nine"); break;
    }
    document.getElementById("result8").innerHTML = result;
}
document.getElementById("task8span").innerHTML = generateTaskNumber();