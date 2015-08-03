/* globals $ */

/*

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    var validator={
        validateNumberOfArgs:function(number){
            if(number!==2){
                throw new Error('invalid number of args');
            }
        },
        validateNumber:function(value){
            if(value != Number(value)){
                throw new Error('not a number');
            }
            if(value<1){
                throw new Error('less tahn 1');
            }
        },
        validateSelector:function(value){
            if(typeof value !== 'string'){
                throw new Error('not a string');
            }
        }
    }


    return function (selector, count) {
        validator.validateNumberOfArgs(arguments.length);
        validator.validateNumber(count);
        validator.validateSelector(selector);

        var $selectedElement=$(selector);
        var $ul=$('<ul>').addClass('items-list');
        //console.log($ul);

        for(var i=0;i<count;i+=1){
            var $li=$('<li>')
                .html('List item #'+i)
                .addClass('list-item');
            $ul.append($li);
        }
        //console.log($ul)
        $selectedElement.append($ul);
    };
};

//var $element=$('#root')
//solve()($element,5);

module.exports = solve;
