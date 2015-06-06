//01.Write a JavaScript function that reverses a string and returns it.
//Example:
//input	    output
//sample	elpmas
var string = 'dqdo koleda';

function reverseString(word) {
    word = word.split('').reverse().join('');
    return word;
}

console.log('TASK 1');
console.log(reverseString(string));

//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
var char1 = '(';
var char2 = ')';
var expression = ')(((a+b))';

function checkForCorrectBrackets(expression) {
    var count = 0;

    for (var char in expression) {
        if (expression[char] === '(') {
            count += 1;
        }
        if (expression[char] === ')') {
            count -= 1;
        }
        if (count < 0) {
            return false;
        }
    }
    if (count !== 0) {
        return false;
    }

    return true;
}

console.log('\nTASK 2');
console.log(checkForCorrectBrackets(expression));

//03.Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
// So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
var text = 'The text is as follows: We are living in an yellow submarine. ' +
    'We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
var subString = 'In';

function countSubStringOccurrences(text, subString) {
    text = text.toLowerCase();
    subString = subString.toLowerCase();
    var index = text.indexOf(subString) + 1;
    var counter = 1;

//if  indexOf does not find the string it will return '-1'+1=0.That's why I check this condition 'index===0'
    if (index === 0) {
        return 0;
    }

    while (index > 0) {
        if (text.indexOf('in', index) > 0) {
            counter += 1;
            index = text.indexOf('in', index) + 1;
        }
        else {
            return counter;
        }
    }
}

console.log('\nTASK 3');
console.log(countSubStringOccurrences(text, subString));

//04.You are given a text. Write a function that changes the text in all regions:
//
//    <upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
//Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

//extension function which I will use in my script.
String.prototype.replaceAt = function (index, character) {
    return this.substr(0, index) + character + this.substr(index + character.length);
};

var mixCase = '<mixcase>';
var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYthing</lowcase> else.';
function convertText(text) {
    var openTags = ['<mixcase>', '<upcase>', '<lowcase>'];
    var closeTags = ['</mixcase>', '</upcase>', '</lowcase>'];
    var openTag;
    var closeTag;

    //checks for every tag and replace its content depending on the type of the tag
    for (var i = 0; i < openTags.length; i += 1) {
        openTag = openTags[i];
        closeTag = closeTags[i];
        var index1 = text.toLowerCase().indexOf(openTag) + 1;
        var index2 = text.toLowerCase().indexOf(closeTag) + 1;
        var toChange;

        //if  indexOf does not find the string it will return '-1'+1=0.That's why I check this condition 'index===0'
        if (index1 === 0) {
            break;
        }
        else {
            toChange = text.substr(index1 + openTag.length - 1, index2 - (index1 + openTag.length));
            //replace its content depending on the type of the tag
            toChange = convertType(openTag, toChange);
            text = text.replaceAt(index1 + openTag.length - 1, toChange);
        }

        while (index1 > 0) {
            if (text.indexOf(openTag, index1) > 0) {
                index1 = text.toLowerCase().indexOf(openTag, index1) + 1;
                index2 = text.toLowerCase().indexOf(closeTag, index2) + 1;
                toChange = text.substr(index1 + openTag.length - 1, index2 - (index1 + openTag.length));
                toChange = convertType(openTag, toChange);
                text = text.replaceAt(index1 + openTag.length - 1, toChange);
            }
            else {
                break;
            }
        }
    }

    //removes the tags
    for (var i = 0; i < openTags.length; i += 1) {
        text = text.split(openTags[i]).join('');
        text = text.split(closeTags[i]).join('');
    }

    return text;
}

function convertType(type, toChange) {
    if (type === '<mixcase>') {
        for (var i = 0; i < toChange.length; i += 1) {
            var upper = Math.random() < 0.5;
            if (upper) {
                toChange = toChange.replaceAt(i, toChange[i].toUpperCase());
            }
            else {
                toChange = toChange.replaceAt(i, toChange[i].toLowerCase());
            }
        }
    }
    else if (type === '<upcase>') {
        toChange = toChange.toUpperCase();
    }
    else if (type === '<lowcase>') {
        toChange = toChange.toLowerCase();
    }
    return toChange;
}

console.log('\nTASK 4');
text = convertText(text);
console.log(text);

//05Write a function that replaces non breaking white-spaces in a text with &nbsp;
function replaceWith(text, index, character) {
    return text.substr(0, index) + character + text.substring(index + 1);
};

var text = "This is   an example .";
var space = "&nbsp;";

function switchWhiteSpace(text, symbol) {
    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === ' ') {
            text = replaceWith(text, i, '&nbsp;');
        }
    }
    return text;
}

console.log('\nTASK 5');
console.log('Original text:' + text);
console.log('Converted text: ' + switchWhiteSpace(text, space));
//second easier way of solving the problem
console.log('Converted text: ' + text.split(' ').join('&nbsp;'));

//Problem 6. Extract text from HTML
//Write a function that extracts the content of a html page given as text.
//    The function should return anything that is in a tag, without the tags.
//    Example:
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//Result: Sample sitetextmore textand more...in body


var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body </body></html>';

function extractText(text) {
    var result = '';
    var toWrite = false;

    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === '<') {
            toWrite = false;
            continue;
        }
        if (text[i] === '>') {
            toWrite = true;
            continue;
        }
        if (toWrite) {
            result += text[i];
        }
    }
    return result;
}

console.log('\nTASK 6');
console.log(extractText(text));

//Problem 7. Parse URL
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseURL(text) {
    var protocol = url.substr(0, url.indexOf(':'));
    var server = url.substring(url.indexOf('/') + 2, url.indexOf('/', url.indexOf('/') + 2));
    var resource = url.substring(url.indexOf('/', url.indexOf('/') + 2));

    var result = {
        protocol: protocol,
        server: server,
        resource: resource
    };

    //converts javascript object in JSON object
    return JSON.stringify(result);
}

//converts JSON object back in javaScript object
var jsObject = JSON.parse(parseURL(text));

console.log('\nTASK 7');
for (var item in jsObject) {
    console.log('[' + item + ']' + ' = ' + jsObject[item]);
}


//Problem 8. Replace tags
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceAnchor(html) {
    var index = html.indexOf('<a href=');

    while (index !== -1) {
        html = replaceFrom(html, index, '<a href=', '[URL=');
        html = replaceFrom(html, index, '>', ']');
        html = replaceFrom(html, index, '</a>', '[URL]');
        index = html.indexOf('<a href=', index + 1);
    }

    return html;
}

function replaceFrom(text, index, oldStr, newStr) {
    var startString = text.substring(0, index);
    var endString = text.substring(index, text.length);
    endString = endString.replace(oldStr, newStr);

    return startString + endString;
}

console.log('\nTASK 8');
console.log('BEFORE: ' + html);
html = replaceAnchor(html);
console.log('AFTER: ' + html);

//Problem 9. Extract e-mails
//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.
var text = 'My email is - "dqdo.Koleda@abv.bg" and my girlfriend email si - "snejanka@gmail.com". fake.email@abv';

function extractEmails(text) {
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

var emails = extractEmails(text);

console.log('\nTASK 9');
for (var item in emails) {
    console.log(emails[item]);
}

//Problem 10. Find palindromes
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
var text = 'ABBA-.lamal,exe.Not a "palindrome. test asddsa! aha hahaha hahah'
var words = text.split(/[\s,!.-/"/']+/);
console.log(words.join(' '));
var resultArr = [];
for (var i = 0; i < words.length; i += 1) {
    var isPalindrome = true;
    for (var j = 0; j < words[i].length / 2; j += 1) {
        if (words[i][j] !== words[i][words[i].length - 1 - j]) {
            isPalindrome = false;
            break;
        }
    }
    if (isPalindrome) {
        resultArr.push(words[i]);
    }
}

console.log('\nTASK 10');
console.log('TEXT: ' + text);
console.log('Palindromes in the text are: \n' + resultArr);

//Problem 12. Generate list
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
//    Example: HTML:
//
//    <div data-type="template" id="list-item">
//    <strong>-{name}-</strong> <span>-{age}-</span>
///div>
//JavaScript:
//
//var people = [{name: 'Peter', age: 14},…];
//var tmpl = document.getElementById('list-item').innerHtml;
//var peopleList = generateList(people, template);
////peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

var people = [{name: 'Peter', age: 14}, {name: 'Lady Gaga', age: 29}, {name: 'My car', age: 16}];
var element = document.getElementById('list-item').innerHTML;
var peopleList = generateList(people, element);
document.getElementById('list-item').innerHTML = peopleList;
//peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

function generateList(people, element) {
    var result = '<ul>';
    for (var person in people) {
        result += '<li>' + element.replace('-{name}-', people[person].name).replace('-{age}-', people[person].age) + '</li>'
    }
    result += '</ul>';

    return result;
}

var  antoan=function(){
    var name = 'peter';
    var age=16;
    console.log('as');
    var obj;
    return {name:'antoan'};
}();
//console.log(antoan.name);
