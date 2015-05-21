/*01.Write a script that prints all the numbers from 1 to N.*/
var output;
var collection=[];

function PrintNumbers(){
    var n=document.getElementById("input1").value;

    for (var i = 0; i <= n; i+=1) {
        collection[i]=i;
    }
    output=collection.join(',');
    document.getElementById("output1").innerHTML = output;
    collection=[];
}

/*02.Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time*/
var output;
var collection=[];

function PrintNumbersNotDevBy3and7(){
    var n=document.getElementById("input2").value;
    var count=0;
    for (var i = 0; i <= n; i+=1) {
        if(!((i%3===0)&&(i%7==0))){
            collection[count++]=i;
        }
    }
    output=collection.join(',');
    document.getElementById("output2").innerHTML = output;
    collection=[];
}

/*03.Write a script that finds the max and min number from a sequence of numbers.*/
var output;
var collection=[1,2,3,543,23,23,3,6,4,3,6,87,-43,7,34,123,5,7,6,4,32];
var min=collection[0];
var max=collection[0];

    for (var i = 0; i <= collection.length; i+=1) {
        if(collection[i]>max){
            max=collection[i];
        }
        if(collection[i]<min){
            min=collection[i];
        }
    }
    output='min number is: ' + min + '    and max number is: ' + max;
    document.getElementById("collection").innerHTML = collection.join(',');
    document.getElementById("output3").innerHTML = output;
    collection=[];

/*04.Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.*/
var documentElements = document.getElementsByTagName("*"),
    max = documentElements[0].tagName,
    min = documentElements[0].tagName;

for (var i = 1; i < documentElements.length; i++) {
    if (max < documentElements[i].tagName) {
        max = documentElements[i].tagName;
    }
    if (min > documentElements[i].tagName) {
        min = documentElements[i].tagName;
    }
}

output='min element is: ' + min + '    and max element is: ' + max;
document.getElementById("output4.1").innerHTML = output;

findMinAndMax(window,"output4.2");
findMinAndMax(navigator,"output4.3");

function findMinAndMax(object,inputID){
    max = 'a';
    min = 'z';
    for(var element in object){
        if(element>max){
            max=element;
        }
        if(element<min){
            min=element;
        }
    }

    output='min element is: ' + min + '    and max element is: ' + max;
    document.getElementById(inputID).innerHTML = output;
}





