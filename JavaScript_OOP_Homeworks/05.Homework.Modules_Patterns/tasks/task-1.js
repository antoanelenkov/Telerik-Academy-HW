/* Task Description */
/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var course = (function () {
        function validateTitle(title) {
            return /^\s/.test(title) || /\s$/.test(title) || /\s{2,}/.test(title) || title.length < 1;
        }

        function validateStudentName(studentName) {
            return /^[A-Z][a-z]*\s{1}[A-Z][a-z]*$/.test(studentName);
        }

        function validateHomeworkId(hwID, array) {
            return hwID !== undefined
                && (typeof hwID === 'number')
                && hwID <= array.length
                && hwID >= 1
                && /[0-9]+/.test(hwID);
        }

        function validateStudentId(studentID, array) {
            return studentID !== undefined
                && (typeof studentID === 'number')
                && studentID <= array.length
                && studentID > 0
                && /[0-9]+/.test(studentID);
        }

        function validateCheaters(arr) {
            var dict = [];
            arr.forEach(function (item) {
                dict[item.StudentID] === 1 ? 2 : 1;
                if (dict[item.StudentID] === 2) {
                    return false;
                }
            });
            return true;
        }

        var course = {
            init: function (title, presentations) {
                this.title = title;
                this.presentations = presentations;
                this._students = [];
                this._homeworks = [];
                this._results = [];

                return this;
            },
            addStudent: function (studentName) {
                var student = {};
                if (studentName === undefined) {
                    throw 'undefined student name';
                }
                else if (!validateStudentName(studentName)) {
                    throw 'invalid symbols of name';
                }

                student.firstname = studentName.split(' ')[0];
                student.lastname = studentName.split(' ')[1];
                student.id = this._students.length + 1;

                this._students.push(student);

                return student.id;
            },
            getAllStudents: function () {
                return this._students;
            },
            submitHomework: function (studentID, homeworkID) {
                var homework = {};

                if (!validateHomeworkId(homeworkID, this.presentations)) {
                    throw 'invalid homeworkID'
                }
                else if (!validateStudentId(studentID, this._students)) {
                    throw 'invalid studentID'
                }

                homework.ID = homeworkID;
                homework.studentID = studentID;
                this._homeworks.push(homework);

                return this;
            },
            pushExamResults: function (results) {
                if (results.some(function (item) {
                        return !validateStudentId(item.StudentID, this._students);
                    })) {
                    throw 'invalid Student ID'
                }
                else if (!validateCheaters(results)) {
                    throw 'there are cheaters'
                }
                else if (results.some(function (item) {
                        return isNaN(item.Score);
                    })) {
                    throw 'score is not a number'
                }
                results.forEach(function (item) {
                    this._results[item.StudentID] = item.Score;
                });
            },
            getTopStudents: function () {
                this._results.sort(function (a, b) {
                    if (a.Score > b.Score) {
                        return 1;
                    }
                    if (a.Score < b.Score) {
                        return -1;
                    }
                    return 0;
                });

                return this._results.splice(10, 1000000000);
            }
        };

        Object.defineProperties(course, {
            title: {
                get: function () {
                    return this._title;
                },
                set: function (title) {
                    if (title === undefined) {
                        throw 'undefined title';
                    }
                    else if (validateTitle(title)) {
                        throw 'Error - the title of course cannot starts or ends with space';
                    }
                    this._title = title;
                }
            },
            presentations: {
                get: function () {
                    return this._presentations;
                },
                set: function (presentations) {
                    if (presentations === undefined) {
                        throw 'undefined  presentation';
                    }
                    else if (!(presentations instanceof Array)) {
                        throw 'Not array'
                    }
                    else if (presentations.length < 1) {
                        throw 'Error - no presentations available';
                    }
                    else if (presentations.some(function (item) {
                            return item === undefined || validateTitle(item);
                        })) {
                        throw 'Error - the title of presentation cannot starts or ends with space';
                    }
                    this._presentations = presentations;
                }
            }
        })

        return Object.create(course);
    }());

    return course;
}

module.exports = solve;
