/*Write a function that sums an array of numbers:
    Numbers must be always of type Number
Returns null if the array is empty
Throws Error if the parameter is not passed (undefined)
Throws if any of the elements is not convertible to Number*/

function sum(array){
        var isNumber=true;
        array=array.map(Number);
        array.forEach(function(element){
            if(isNaN(element)){
                isNumber=false;
            }
        })

        if(array.length==0){
            return null;
        }
        else if(array===undefined){
            throw  "parameter is not passed";
        }
        else if(!isNumber){
            throw "not a number";
        }
        else{
            var sum=array.reduce(function (a,b) {
                return a+b;
            })
            return sum;
        }
}

module.exports = sum;
//var arr=[1,2,'3'];

