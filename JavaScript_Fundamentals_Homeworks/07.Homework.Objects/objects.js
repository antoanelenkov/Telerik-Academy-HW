//format function(Copy - paste from Google)
String.prototype.format = function () {
    var args = arguments;
    return this.replace(/\{\{|\}\}|\{(\d+)\}/g, function (m, n) {
        if (m == "{{") {
            return "{";
        }
        if (m == "}}") {
            return "}";
        }
        return args[n];
    });
};


/*Problem 1. Planar coordinates
 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.*/

//This task is based on Object oriented programming with JavaScript. If you do not understand what I have done,
//check out this link: http://www.phpied.com/3-ways-to-define-a-javascript-class/
function Point(x, y) {
    this.x = x;
    this.y = y;
    this.toString = function () {
        return '[{0},{1}]'.format(this.x, this.y);
    }
}

function Line(point1, point2) {
    this.firstPoint = point1;
    this.secondPoint = point2;
    this.toString = function () {
        return '({0},{1})'.format(this.firstPoint.toString(), this.secondPoint.toString());
    }
}

var p1 = new Point(0, 0);
var p2 = new Point(0, 4);
var p3 = new Point(3, 0);
var p4 = new Point(0, 5);

var line1 = new Line(p1, p2);
var line2 = new Line(p1, p3);
var line3 = new Line(p1, p4);


function calcDistance(p1, p2) {
    return Math.sqrt(Math.pow(Math.abs(p1.x - p2.x), 2) + Math.pow(Math.abs(p1.y - p2.y), 2));
}

function checkForTriangle(line1, line2, line3) {
    if ((Math.pow(calcDistance(line1.firstPoint, line1.secondPoint), 2) +
        Math.pow(calcDistance(line2.firstPoint, line2.secondPoint), 2) === Math.pow(calcDistance(line3.firstPoint, line3.secondPoint), 2))) {
        return true;
    }
    else if (Math.pow(calcDistance(line1.firstPoint, line1.secondPoint), 2) +
        Math.pow(calcDistance(line3.firstPoint, line3.secondPoint), 2) === Math.pow(calcDistance(line2.firstPoint, line2.secondPoint), 2)) {
        return true;
    }
    else if (Math.pow(calcDistance(line3.firstPoint, line3.secondPoint), 2) +
        Math.pow(calcDistance(line2.firstPoint, line2.secondPoint), 2) === Math.pow(calcDistance(line1.firstPoint, line1.secondPoint), 2)) {
        return true;
    }
    else {
        return false;
    }
}
console.log('TASK 1');
console.log('Point 1: [{0},{1}]'.format(p1.x, p1.y));
console.log('Point 2: [{0},{1}]'.format(p2.x, p2.y));
console.log('The distance between first and second point is: {0}'.format(calcDistance(p1, p2).toFixed(2)));
console.log('Line 1: [{0},{1}]'.format(line1.firstPoint, line1.secondPoint));
console.log('Line 2: [{0},{1}]'.format(line2.firstPoint, line2.secondPoint));
console.log('Line 2: [{0},{1}]'.format(line3.firstPoint, line3.secondPoint));
console.log('There is possibility to form triangle with those 3 lines: ' + checkForTriangle(line1, line2, line3));

/*Problem 2. Remove elements
 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.
 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];*/

var arr = [1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 6, 7, 2, 1, 1, 1];

Array.prototype.remove = function (element) {
    var resultArr = [];
    for (var i = 0; i < this.length; i += 1) {
        if (this[i] !== element) {
            resultArr.push(this[i]);
        }
    }
    this.length = 0;
    for (var i = 0; i < resultArr.length; i += 1) {
        this[i] = resultArr[i];
    }
    return this;
};
var element = 1;
console.log('TASK 2');
console.log('The array before removing [{0}] looks like: {1}'.format(element, arr.join(',')));
console.log('The array after removing [{0}] looks like: {1}'.format(element, arr.remove(element).join(',')));

/*Problem 3. Deep copy
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.*/
var object = {
    name: 'asd',
    age: 15,
    childObject: {
        name: 'abv',
        age: 13,
        nestedChildObject: {
            name: 'abc',
            age: 100
        }
    }
}

function copy(object) {
    var copyObject = new Object();
    for (var el in object) {
        if (typeof object[el] === 'object') {
            copyObject[el] = copy(object[el]);
        }
        else {
            copyObject[el] = object[el];
        }
    }
    return copyObject;
}

//pseudo copy. Works only for the direct primitive type children.
var pseudoCopy = object;
//deep copy. No matter how deep the original object is changed, that will not reflect on the copied object.
var copyObject = copy(object);
console.log('TASK 3');
console.log('click the left arrow near the description of the object to see nested childs\'s properties');
console.log('The original object before modifying the most nested child:');
console.log(object);

object.childObject.nestedChildObject.age = 1000000000;
console.log('The original object after modifying the most nested child:');
console.log(object);
console.log('The pseudoCopy object after modifying the most nested child of the original one:');
console.log(pseudoCopy);
console.log('The deep copied object after modifying the most nested child of the original one:');
console.log(copyObject);

/*Problem 4. Has property
 Write a function that checks if a given object contains a given property.
 var obj  = …;
 var hasProp = hasProperty(obj, 'length');*/
var person = {
    name: 'dqdo koleda',
    age: 30
}

function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop === property) {
            return true;
        }
    }
    return false;
}
var propertyName1 = 'name';
var propertyName2 = 'sex';
console.log('TASK 4');
console.log('There is property "{0}" in the object: {1}'.format(propertyName1, hasProperty(person, propertyName1)));
console.log('There is property "{0}" in the object: {1}'.format(propertyName2, hasProperty(person, propertyName2)));

/*Problem 5. Youngest person
 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.
 Example:
 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];*/
var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Pesho', lastname: 'Goshov', age: 81},
    {firstname: 'Bay', lastname: 'Ivan', age: 50},
    {firstname: 'Bay', lastname: 'Georgi', age: 15}
];

function findYoungestPerson(arrOfPeople) {
    var minAge = arrOfPeople[0].age;
    var youngestPerson = arrOfPeople[0];
    for (var person in arrOfPeople) {
        if (arrOfPeople[person].age < minAge) {
            minAge = arrOfPeople[person].age;
            youngestPerson = arrOfPeople[person];
        }
    }
    return youngestPerson
}

var resultPerson = findYoungestPerson(people);

console.log('TASK 5');
console.log('The youngest person names are: {0} {1} with age of: {2}'.format(resultPerson.firstname, resultPerson.lastname, resultPerson.age));


/*Problem 6.
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)
 Example:
 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');*/

var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Pesho', lastname: 'Goshov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 50},
    {firstname: 'Bay', lastname: 'Georgi', age: 15},
    {firstname: 'Ivan', lastname: 'Ivanov', age: 50},
    {firstname: 'Petar', lastname: 'Angelov', age: 15},
    {firstname: 'Angel', lastname: 'Angelov', age: 30},
    {firstname: 'Angel', lastname: 'Iordanov', age: 30},
    {firstname: 'Petar', lastname: 'Iordanov', age: 30}
];

function group(array, criterii) {
    var hashMap = {};
    for (var person in array) {
        if (!array.hasOwnProperty(person)) {
            continue;
        }
        else {
            if (!hashMap[array[person][criterii]]) {
                hashMap[array[person][criterii]] = [];
                hashMap[array[person][criterii]].push(array[person].firstname + ' ' + array[person].lastname);
            }
            else {
                hashMap[array[person][criterii]].push(array[person].firstname + ' ' + array[person].lastname);
            }
        }
    }
    return hashMap;
}

console.log('TASK 6');
var criterii='age';
var result = group(people, criterii);
console.log('Sorted by {0}:'.format(criterii));
for (var key in result) {
    console.log(key + ' : ' + result[key]);
}

