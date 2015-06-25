/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
@	Add a new book to category
 *	Each book has unique title, author and ISBN
 @It must return the newly created book with assigned ID
@If the category is missing, it must be automatically created
 *	List all books
 @	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 @	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
@When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 @	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 @	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        function addBook(book) {
            validateBook(book);
            book.ID = books.length + 1;
            books.push(book);
            addToCategory(book.category);

            return book;
        }

        function listBooks(criteria) {
            if(arguments.length===1){
                if(criteria.author!==undefined){
                    return books.filter(function(item){
                        return item.author===criteria.author;
                    })
                }
                else if(criteria.category!==undefined){
                    return books.filter(function(item){
                        return item.category===criteria.category;
                    })
                }
            }
            return books;
        }

        function addToCategory(category) {
            validateCategory(category);
            if(validateIfCategoryIsUnique(category)) {
                category.ID = categories.length + 1;
                categories.push(category);
            }
        }

        function listCategories() {
            return categories;
        }



        function validateBook(book) {
            if (book.title === undefined || book.author === undefined || book.category === undefined || book.isbn === undefined) {
                throw new Error('Invalid properties of book');
            }
            else if (book.author === '') {
                throw new Error('Author empty string');
            }
            validateName(book.title);
            validateISBN(book.isbn);
            validateIfTitleIsUnique(book.title);
        }

        function validateName(name) {
            if (name.length < 2 || name.length > 100) {
                throw new Error('Invalid length of symbols');
            }
        }

        function validateISBN(value) {
            if (value.length !== 10 && value.length !== 13) {
                //console.log(value.length)
                throw new Error('invalid ISBN length');
            }
            else if (!/^\d+$/.test(value)) {
                throw new Error('invalid ISBN format');
            }
            else if (books.some(function(item){
                    return item.isbn===value;
                })) {
                throw 'duplicated ISBN';
            }
        }

        function validateIfTitleIsUnique(name) {
            books.forEach(function (item) {
                if (item.title === name) {
                    throw new Error('Duplicated name of title');
                }
            })
        }

        function validateCategory(category) {
            if (category === undefined) {
                throw new Error('Invalid properties of category');
            }
            validateName(category);
        }

        function validateIfCategoryIsUnique(category){
            return !categories.some(function(item){
                    return item===category;
                });
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

var myLibrary=solve();
var book1={title:'Book1',author: 'Me',isbn:'1233456789', category:'action'};
var book2={title:'Book3', author: 'Me', isbn:'1233456789111',category:'comedy'};
var book3={title:'Book2', author: 'Me', isbn:'1233456782',category:'action'};
//
//myLibrary.books.add(book1)


module.exports = solve;


