/*Task 1.

 Create a function constructor for Person. Each Person must have:
 properties firstname, lastname and age
 firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 age must always be a number in the range (0, 150), inclusive
 the setter of age can receive a convertible-to-number value
 if any of the above is not met, throw Error
 property fullname
 the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 it must parse it and set firstname and lastname
 method introduce() that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 all methods and properties must be attached to the prototype of the Person*/

(function(){var Person = (function () {
    var _firstname,
        _lastname,
        _age;

    function Person(firstname, lastname, age) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
    }

    Object.defineProperty(Person.prototype, 'age', {
        set: function (value) {
            validateAge(value);
            this._age = value;

            return this;
        },
        get: function () {
            return this._age;
        }
    });

    Object.defineProperty(Person.prototype, 'firstname', {
        set: function (value) {
            validateName(value);
            this._firstname = value;

            return this;
        },
        get: function () {
            return this._firstname;
        }
    });

    Object.defineProperty(Person.prototype, 'lastname', {
        set: function (value) {
            validateName(value);
            this._lastname = value;

            return this;
        },
        get: function () {
            return this._lastname;
        }
    });

    Object.defineProperty(Person.prototype, 'fullname', {
        set: function (value) {
            if (value.split(' ').length !== 2) {
                throw new Error('invalid format');
            }
            this.firstname = value.split(' ')[0];
            this.lastname = value.split(' ')[1];
            this._fullname = this.firstname + ' ' + this.lastname;

            return this;
        },
        get: function () {
            return this.firstname + ' ' + this.lastname;
        }
    });

    Person.prototype.introduce = function () {
        return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
    }

    function validateName(value) {
        if (value.length < 3 || value.length >20) {
            throw new Error('invalid count of symbols');
        }
        else if (!(/^[a-zA-Z]+$/.test(value))) {
            throw new Error('invalid letters');
        }
        return this;
    }

    function validateAge(value) {
        if (value < 0 || value > 150) {
            throw new Error('invalid age');
        }
        else if (isNaN(+value)) {
            throw new Error('invalid format');
        }
        return this;
    }

    return Person;
})();
    return Person;}());