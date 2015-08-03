/*
 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element
 */

var eventsModule = (function () {
    var helpers = {
        isString: function (value) {
            if (typeof value === 'string') {
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
        }
    }

    var domOperations = function (element) {
        var selectedElements;

        if (helpers.isString(element)) {
            validator.validateId((element));
            element = document.getElementById(element);
        }
        else {
            validator.validateDOMelement((element));
            selectedElements = element
        }

        // Change buttons content
        selectedElements = element
            .getElementsByClassName('button');
        for (var item in selectedElements) {
            selectedElements[item].innerHTML = 'hide';
        }

        // Add functionality to hide content of elements with class 'content'
        for (var i = 0; i < selectedElements.length; i += 1) {
            selectedElements[i].addEventListener('click', function (ev) {
                var currentSibling = ev.target.nextElementSibling;
                if (currentSibling) {
                    while (!(currentSibling.className ==='content')
                    && !(currentSibling.className==='button')) {
                        currentSibling = currentSibling.nextElementSibling;
                    }

                    if (currentSibling.className === 'content') {
                        if (currentSibling.style.display !== 'none') {
                            currentSibling.style.display = 'none';
                            ev.target.innerHTML = 'show'
                        }
                        else {
                            currentSibling.style.display = '';
                            ev.target.innerHTML = 'hide'
                        }
                    }
                }
            });
        }
    }

    return domOperations;
}());


var test = eventsModule('div');


module.exports = function () {
    return eventsModule;
}


