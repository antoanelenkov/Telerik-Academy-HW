/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName`, `lastName` and `age` properties
 *   **finds** the students whose age is between 18 and 24
 *   **prints**  the fullname of found students, sorted lexicographically ascending
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

var _=require('./node_modules/underscore/underscore.js');

function solve(){
    return function (students) {
        var resultStudents= _.chain(students)
            .filter(function(student){
                return student.age > 17 && student.age < 25;
            })
            .map(function(student){
                return student={fullName:student.firstName+' '+student.lastName};
            })
            .sortBy('fullName')
            .each(function(person){
                console.log(person.fullName)
            });
    };
}

var student1={firstName:"Antoan",lastName:"Elenkov",age:29};
var student2={firstName:"Antoan",lastName:"Nikolov",age:18};
var student3={firstName:"Petar",lastName:"Ivanov",age:22};
var student4={firstName:"Qnko",lastName:"Atanasov",age:23};
var student5={firstName:"Antoan",lastName:"Atanasov",age:13};
var students=[student1,student2,student3,student4,student5];

var students=solve()(students);

module.exports = solve;