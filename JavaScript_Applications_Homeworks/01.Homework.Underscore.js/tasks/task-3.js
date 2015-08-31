/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName`, `age` and `marks` properties
 *   `marks` is an array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */
var _=require('./node_modules/underscore/underscore.js');

var student=(function(){
    var student={
        init:function(firstName,lastName,age,marks){
            this.firstName=firstName;
            this.lastName=lastName;
            this.age=age;
            this.marks=marks;

            return this;
        }
    };
    return student;
})();

function solve(){
    return function (students) {
        var theBestStudent=_.chain(students)
            .each(function(student){
                _.extend(student,{averageMarks:function(){
                    var allMarks=0;

                    _.each(student.marks,function(mark){
                        allMarks+=mark;
                    })

                    return allMarks/student.marks.length;
                }()})
            })
            .sortBy(function(person){
                return -person.averageMarks;
            })
            .first()
            .value();

        console.log(theBestStudent.firstName+' '+theBestStudent.lastName+' has an average score of '+theBestStudent.averageMarks);
    };
}

var student1=Object.create(student).init('Antoan','Elenkov',18,[1,2,3,4,5]);
var student2=Object.create(student).init('Antoan2','Elenkov2',18,[1,4,3,4,5]);
var student3=Object.create(student).init('Antoan3','Elenkov4',18,[1,2,6,4,5]);
var student4=Object.create(student).init('Antoan5','Elenkov5',18,[6,6,6,6,5]);
var students=[student1,student2,student3,student4];

var students=solve()(students);

module.exports = solve;