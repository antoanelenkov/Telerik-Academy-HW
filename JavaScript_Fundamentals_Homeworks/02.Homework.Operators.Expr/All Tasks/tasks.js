/*1.Write an expression that checks if given integer is odd or even.*/
console.log('Task 1');
var number = 3;
var isEven = false;

if (number % 2 === 0) {
    isEven = true;
}
else {
    isEven = false;
}

console.log(isEven);

/*2.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/
console.log('Task 2');
var number = 35;
var isDivisble = false;

if (number % 5 === 0 && number % 7 === 0) {
    isDivisble = true;
}
else {
    isDivisble = false;
}

console.log(isDivisble);

/*3. Write an expression that calculates rectangle’s area by given width and height.*/
console.log('Task 3');
var width = 2.5;
var height = 2.6;
var result = width * height;
console.log(result);

/*4. Write an expression that checks for given integer if its third digit (right-to-left) is 7.*/
console.log('Task 4');
var number = 2312734;
var thirdDigit = Math.floor(number / 100) % 10;
if (thirdDigit === 7) {
    console.log('true');
}
else {
    console.log('false');
}

/*5. Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/
console.log('Task 5');
var number = 2312;
var mask = 1;
console.log(number & (mask << 3));
if (number & (mask << 3) !== 0) {
    console.log(1);
}
else {
    console.log(0);
}

/*6.Write an expression that checks if given point P(x, y) is within a circle K(O, 5).*/
console.log('Task 6');
var x = 5;
var y = 2;
var circleRadius = 5;


if (Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)) < circleRadius) {
    console.log('this point is in the circle')
}
else {
    console.log('this point is not in the circle')
}

/*7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime.*/
console.log('Task 7');
var number = 89;
var isPrime = true;
var i = 2;

//works for numbers in any range
for (i; i < Math.sqrt(number) ; i += 1) {
    if (number % i === 0) {
        isPrime = false;
    }
}

console.log('The number is prime: ' + isPrime);

/*8. Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
console.log('Task 8');
var a = 5;
var b = 6;
var h = 3;
var area = (a + b) * h / 2;

console.log("The area is " + area);

/*9. Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
console.log('Task 9');
var x1 = 0;
var y1 = 1;
var isInsideCircle = Math.pow((x1 - 1), 2) + Math.pow((y1 - 1), 2) <= 3 * 3;
var isOutsideRectangle = (x1 < -1 && x1 > 5) && (y1 > -1 && y1 < 1);

console.log('the point is in the circle and outside the rectangle: ' + (isInsideCircle && isOutsideRectangle));
