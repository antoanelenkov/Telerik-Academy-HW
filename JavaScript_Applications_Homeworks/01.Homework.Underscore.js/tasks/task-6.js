/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */
var _=require('./node_modules/underscore/underscore.js');

function solve(){
    return function (books) {
        var booksGroupedByAuthor= _.chain(books)
            .groupBy(function(book){
               return book.author.firstName+' '+book.author.lastName;
            })
            .value();

        var count=0;
        var authors=[];
        var sorted= _.chain(booksGroupedByAuthor)
            .each(function(books){
                if(count<books.length){
                    count=books.length
                }
            })
           .each(function(books){
               if(books.length===count){
                   authors.push({fullName:books[0].author.firstName+' '+books[0].author.lastName});
               }
           })

        _.chain(authors)
            .sortBy('fullName')
            .each(function(author){
                console.log(author.fullName)
            })
    };
}

var book1 = {title:'peese niunsa sivo',author:{firstName:'authorFirstName1',lastName:'authorLastName1'}};
var book2 = {title:'peese niunsa sivo2',author:{firstName:'authorFirstName1',lastName:'authorLastName1'}};
var book3 = {title:'peese niunsa sivo3',author:{firstName:'authorFirstName3',lastName:'authorLastName3'}};
var book4 = {title:'peese niunsa sivo4',author:{firstName:'authorFirstName3',lastName:'authorLastName3'}};
var book5 = {title:'peese niunsa sivo5',author:{firstName:'authorFirstName5',lastName:'authorLastName5'}};
var books = [book1, book2, book3,book4,book5];

solve()(books);

module.exports = solve;