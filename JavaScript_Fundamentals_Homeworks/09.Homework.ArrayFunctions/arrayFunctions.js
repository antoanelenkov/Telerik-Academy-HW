//Problem 1. Make person
//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

function createPerson(firstName, lastName, age, gender) {
    var person = {};
    person.firstName = firstName;
    person.lastName = lastName;
    person.age = age;
    person.isFemale = gender;

    return person;
}

var firstNames = ['Pesho1', 'Pesho2', 'Penka1', 'Gosho2', 'Penka2', 'Pesho6', 'Penka3', 'Gosho', 'Penka4', 'Penka5'];
var lastNames = ['Peshov1', 'Peshov2', 'Penkova1', 'Goshov2', 'Penkova2', 'Peshov6', 'Penkova3', 'Goshov', 'Penkova4', 'Penkova5'];
var ages = [19, 2, 3, 24, 18, 6, 7, 8, 9, 22];
var females = [false, false, true, false, true, false, true, false, true, true];

var persons = [];
persons[9] = undefined;

for (var i = 0; i < persons.length; i += 1) {
    persons[i] = createPerson(firstNames[i], lastNames[i], ages[i], females[i]);
}

console.log('TASK 1: ');
persons.forEach(function (item) {
    console.log(item);
});

//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)
console.log('\nTASK 2: ');
var ageOf18 = persons.some(function (item) {
    return item.age === 18;
});
console.log('There is person who is 18 years old: ' + ageOf18);

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)
var underAgePeople = persons.filter(function (item) {
    return item.age < 18;
});

console.log('\nTASK 3: ');
console.log('All under-age persons are:\n');
underAgePeople.forEach(function (item) {
    console.log(item.firstName + ' ' + item.lastName)
});

//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)
function averageAgeOfFemales(persons) {
    var allFemales = persons.filter(function (item) {
        return item.isFemale;
    })

    var ageOfFemales = allFemales.reduce(function (ageOfFemales, item) {
        all = allFemales.length + 1;
        return ageOfFemales + item.age / all;
    }, 0);

    return (ageOfFemales).toFixed(2);
}

console.log('\nTASK 4: ');
console.log('Average age of all females is: ' + averageAgeOfFemales(persons));

//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find
if (!Array.prototype.find) {
    Array.prototype.find = function (predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function findYoungestMale(persons) {
    var person = persons
        .sort(function (item1, item2) {
            return item1.age - item2.age;
        })
        .find(function (item) {
            return !item.isFemale;
        })

    return person.firstName + ' ' + person.lastName + ' with age of ' + person.age;
}

console.log('\nTASK 5: ');
console.log('The youngest person is ' + findYoungestMale(persons));

//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
//    Example:
//        result = {)
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };
function groupPersons(persons) {
    var obj = persons
        .sort
    (function (item1, item2) {
        return item1.firstName - item2.firstName;
    })
        .reduce(function (object, item) {
            if(!object[item.firstName[0]]){
                object[item.firstName[0]]=[item];
            }
            else{
                object[item.firstName[0]].push(item);
            }
        return object;
        }, {});

    return obj;
}

console.log('\nTASK 6: ');
console.log(groupPersons(persons));
