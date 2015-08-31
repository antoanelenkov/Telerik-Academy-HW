/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **groups** the animals by `species`
 *   the groups are sorted by `species` descending
 *   **sorts** them ascending by `legsCount`
 *	if two animals have the same number of legs sort them by name
 *   **prints** them to the console in the format:
 ```
 ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
 GROUP_1_NAME:
 ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in group 1
 NAME has LEGS_COUNT legs //for the second animal in group 1
 ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
 GROUP_2_NAME:
 ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in the group 2
 NAME has LEGS_COUNT legs //for the second animal in the group 2
 NAME has LEGS_COUNT legs //for the third animal in the group 2
 NAME has LEGS_COUNT legs //for the fourth animal in the group 2
 ```
 *   **Use underscore.js for all operations**
 */
var _ = require('./node_modules/underscore/underscore.js');

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

function solve() {
    return function (animals) {
        var groupedBySpecies = _.chain(animals)
            .sortBy('species')
            .reverse()
            .groupBy('species')
            .value();

        var sortedByNameAndLegs = _.chain(groupedBySpecies)
            .each(function (group,key) {
                var sorted=_.chain(group)
                    .sortBy('name')
                    .sortBy('legsCount')
                    .value();

                console.log(Array(key.length + 2).join('-'))
                console.log(key + ':')
                console.log(Array(key.length + 2).join('-'))
                _.each(sorted, function (value) {
                    console.log(value.name + ' has ' + value.legsCount + ' legs')
                });
            })
            .value();
    };
}

var animal1 = Object.create(animal).init('Minkov', 'Mosquito', 2);
var animal2 = Object.create(animal).init('Doncho', 'Mosquito', 2);
var animal3 = Object.create(animal).init('Komara', 'Mosquito', 4);
var animal4 = Object.create(animal).init('aaaa', 'dog', 4);
var animals = [animal1, animal2, animal3];

solve()(animals);

module.exports = solve;