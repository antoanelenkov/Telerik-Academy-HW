/*Write a function that finds all the prime numbers in a range
 It should return the prime numbers in an array
 It must throw an Error if any of the range params is not convertible to Number
 It must throw an Error if any of the range params is missing*/

function filterPrime(start,end){
    var i,
        j,
        primeArr,
        isPrime;
    if(arguments.length<2){
        throw 'Error: input arguments are missing';
    }
    else if(isNaN(+start)||isNaN(+end)){
        throw 'Error: input values are not convertible to "Number"';
    }

    primeArr=[];
    isPrime=true;
    if(start==0||start==1){
        start=2;
    }
    for(i=start;i<=end;i+=1){
        for(j=2;j<=Math.sqrt(i);j+=1){
            if(i%j===0){
                isPrime=false;
            }
        }
        if(isPrime){
            primeArr.push(i);
        }
        isPrime=true;
    }

    return primeArr;
}

module.exports = filterPrime;