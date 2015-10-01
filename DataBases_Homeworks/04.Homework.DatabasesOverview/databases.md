# Database Systems - Overview

## 1.What database models do you know?
### relational 
* ierarchical (tree)
* Network / graph
* Relational (table)
* Object-oriented
### non-relational 

## 2.Which are the main functions performed by a Relational Database Management System (RDBMS)?
* CRUD(create, read, update, delete) operations.
* Support for using SQL language
* Transactions(optional)

## 3.Define what is "table" in database terms.
Certain table is a type of object with all of its properties(analogy with C# type). The name of the table represents the type of the object (Student). The columns represent its properties(Name, Age) and every row represents different record of Student. As a conclusion the table is collcetion of students.

## 4.Explain the difference between a primary and a foreign key.
Primary key is unique identifier of the record(certain property) in the table, while foreign key is a reference to other/self table certain property.

## 5.Explain the different kinds of relationships between tables in relational databases.
* 1:1 - When object(record) of certain type can be assosiated with only one other object of other type(head -> brain)
* 1:many - When object of one type has collection of other objects from other type(teacher -> students)
* many:many - When object has collection of other objects and the same object is in collection of more than one other obejcts(student -> course(one student has a lot of courses, as weel one course has a lot of students))

## 6.When is a certain database schema normalized? What are the advantages of normalized databases?
Database is normalized when there are no repeating data in the database tables. The advantages are that the database needs less memory. Disadvanteges are the processes of joining the tables which makes the communication betweeen client and database slower.

## 7. What are database integrity constraints and when are they used?
Enforce data rules when creating or updating record in the database which cannot be violated.
They can be used when we want the data to meet certain requirements and restrictions.

## 8. Point out the pros and cons of using indexes in a database.
Pros of using indexes is that the database create B-Tree which is responsible for really faster searching process of the indexed properties of the object. This tree has reference to the real adress of the record in the hard drive(in case it is not clusterized index. They are stored directly at adress they point to).

Cons of using indexes is that the database become slower when adding new elements, because the tree has to preorder itself.

As a conclusion indexes are used when the most common operation over the records is "reading" or just when getting the data is important to be fast. 

## 9. What's the main purpose of the SQL language?
The main purpose ot the language is to perform text format queries which can be send to the database remotely. In both cases, when client has access to the physical server where is the database, or not,
using SQL language is a lot easier to perform operations over the data than clicking the interface with the mouse.

## 10. What are transactions used for? Give an example.
Transactions are sequence of operations which can be processed only all together or if not, the process of performing the operations will fail and not a single one will be processed.

Example:
When withdraw money from ATM:
1.The bank subtract the sum you try to withdraw from your account.
2.Tha ATM give you the money.

Let's say that the bank subtract the money from you account and after this happens, the ATM does not have enough money in it. You would be broken if there were no transactians, which take care about processing all of the operations or fail if not possible before commiting them.

## 11. What is a NoSQL database?
NoSQL database is a database, which save its records without making any relations between them. Similar to unnormalized table in SQL. 

## 12. Explain the classical non-relational data models.
The classical non-relational data models are documents with key-value pairs, which has for key - the name of the object property, and for value - it's value :)

## 13. Give few examples of NoSQL databases and their pros and cons.
MongoDB, Redis, HBase, Cassandra

Getting data is very fast, because the database does not have to join tables, just finds the record and returns it.
As a cons is that this database uses a lot of memory to save its records.


