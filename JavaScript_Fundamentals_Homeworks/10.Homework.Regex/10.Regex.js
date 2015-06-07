//Problem 1. Format with placeholders
//Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype
//Example:
//input	output
//var options = {name: 'John'};
//'Hello, there! Are you #{name}?'.format(options);	'Hello, there! Are you John'
//var options = {name: 'John', age: 13};
//'My name is #{name} and I am #{age}-years-old').format(options);	'My name is John and I am 13-year
String.prototype.format = function (object) {
    var self=this;
    for (var item in object) {
        var replaceItem = object[item],
            regExp = new RegExp('#{' + item + '}');
        self=self.replace(regExp, replaceItem);
    }
    return self;
}

var object = {
    name: 'John',
    age: 15,
    gender: 'male'
};
var str = 'My name is #{name}, I am #{age}-years-old and my gender is #{gender}'.format(object);
console.log('TASK 1:\n'+str);

//Problem 2. HTML binding
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//Add the function to the String.prototype
//Example 1:
//input
//var str = '<div data-bind-content="name"></div>';
//str.bind(str, {name: 'Steven'});
//output
//<div data-bind-content="name">Steven</div
//Example 2:
//input
//var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'
//str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
//output
//<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</à>
String.prototype.bind=function(object){
    var self=this;
    var result=self.match(/data\-bind\-[A-z]*="[A-z]*"/g);
    for(var item in result){
        if(result[item]==='data-bind-content="name"'){
            self=self.replace('><','>'+object['name']+'<');
        }
         else if(result[item]==='data-bind-class="name"'){
            self=self.replace('">','" class="' +object['name'] +'">');
        }
         else if(result[item]==='data-bind-href="link"'){
            self=self.replace('">','" href="' +object['link'] +'">');
        }
        else{
            throw new Error('unknown binding attribute. Add it to the code');
        }
    }
    return self;

}

var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';

str=str.bind({name: 'Elena', link: 'http://telerikacademy.com'});
console.log('TASK 2:\n'+str);