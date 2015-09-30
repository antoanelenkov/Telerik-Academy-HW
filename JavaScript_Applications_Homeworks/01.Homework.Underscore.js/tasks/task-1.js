/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName` and `lastName` properties
 *   **Finds** all students whose `firstName` is before their `lastName` alphabetically
 *   Then **sorts** them in descending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   Then **prints** the fullname of founded students to the console
 *   **Use underscore.js for all operations**
 */

var _=require('./node_modules/underscore/underscore.js');

function solve(){
    return function (students) {
        var resultStudents= _.chain(students)
            .filter(function(student){
                return student.firstName < student.lastName;
            })
            .map(function(student){
                return student={fullName:student.firstName+' '+student.lastName};
            })
            .sortBy('fullName')
            .reverse()
            .each(function(person){
                console.log(person.fullName)
            });

        return resultStudents;
    };
}

function solve(){
    return function (students) {
        var resultStudents= _.chain(students)
            .filter(function(student){
                return student.firstName < student.lastName;
            })
            .map(function(student){
                return student={fullName:student.firstName+' '+student.lastName};
            })
            .sortBy('fullName')
            .reverse()
            .each(function(person){
                console.log(person.fullName)
            });

        return resultStudents;
    };
}

module.exports = solve;


var student1={firstName:"Antoan",lastName:"Elenkov"};
var student2={firstName:"Antoan",lastName:"Nikolov"};
var student3={firstName:"Petar",lastName:"Ivanov"};
var student4={firstName:"Qnko",lastName:"Atanasov"};
var student5={firstName:"Antoan",lastName:"Atanasov"};
var students=[student1,student2,student3,student4,student5];

var students=solve()(students);


module.exports = solve;