/*   Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **finds** and **prints** the total number of legs to the console in the format:
 *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
 *   **Use underscore.js for all operations**
 */

var _=require('./node_modules/underscore/underscore.js');

var animal = (function () {
    var animal = {
        init: function (name, species, legsCount) {
            this.name = name;
            this.species = species;
            this.legsCount = legsCount;

            return this;
        }
    };
    return animal;
})();

function solve(){
    return function (animals) {
        var allLegs=0;

        _.chain(animals)
            .each(function(animal){
                allLegs+=animal.legsCount*1;
            })

        console.log("Total number of legs: "+allLegs)
    };
}

var animal1 = Object.create(animal).init('Minkov', 'Mosquito', 2);
var animal2 = Object.create(animal).init('Doncho', 'Mosquito', 2);
var animal3 = Object.create(animal).init('Komara', 'Mosquito', 4);
var animal4 = Object.create(animal).init('aaaa', 'dog', 4);
var animals = [animal1, animal2, animal3];

solve()(animals);


module.exports = solve;