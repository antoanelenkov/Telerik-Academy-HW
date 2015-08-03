/*
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */
var DOMOperationsModule = (function () {
    var helpers = {
        isString: function (value) {
            if (typeof value === 'string') {
                return true;
            }
            return false;
        },
        isNumber: function (value) {
            if (typeof value === 'number') {
                return true;
            }
            return false;
        },
        isArray: function (value) {
            if (value instanceof  Array) {
                return true;
            }
            return false;
        }
    }

    var validator = {
        validateDOMelement: function (value) {
            var allDOMElements = document.getElementsByTagName("*");
            var isValid = false;

            for (var i = 0; i < allDOMElements.length; i += 1) {
                if (allDOMElements[i].nodeName === value.nodeName) {
                    isValid = true;
                }
            }

            if (!isValid) {
                throw new Error('invalid DOM element')
            }
        },
        validateId: function (value) {
            var allDOMElements = document.getElementsByTagName("*");
            var isValid = false;

            for (var i = 0; i < allDOMElements.length; i += 1) {
                if (allDOMElements[i].id === value) {
                    isValid = true;
                }
            }

            if (!isValid) {
                throw new Error('invalid id')
            }
        },
        validateArray: function (value) {
            if (!helpers.isArray(value)) {
                throw new Error('not an array');
            }
        },
        validateNumberOfArgs: function (value) {
            if (value !== 2) {
                throw new Error('invalid number of arguments');
            }
        },
        validateContent: function (value) {
            var isNotValid = value.some(function (item) {
                return !helpers.isNumber(item) && !helpers.isString(item);
            });
            if (isNotValid) {
                throw new Error('invalid content');
            }
        }
    }

    var domOperations = function (element, contents) {
        var selectedElement,
            elFragment = document.createDocumentFragment(),
            currFirstChild,
            divElement;

        validator.validateNumberOfArgs(arguments.length);
        validator.validateArray(contents);

        if (helpers.isString(element)) {
            selectedElement = document.getElementById(element);
        }
        else {
            validator.validateDOMelement((element));
            selectedElement = element;
        }

        validator.validateContent(contents);

        currFirstChild = selectedElement.firstChild;
        while (currFirstChild) {
            selectedElement.removeChild(currFirstChild);
            currFirstChild = selectedElement.firstChild;
        }

        divElement = document.createElement('div');
        elFragment = document.createDocumentFragment()
        contents.forEach(function (item) {
            var current = divElement.cloneNode(true);
            current.innerHTML = item;
            elFragment.appendChild(current);
        });

        selectedElement.appendChild(elFragment);
    }

    return domOperations;
}());

module.exports = function () {
    return DOMOperationsModule;
};
