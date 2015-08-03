/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (element) {
        var allElements = $(element),
            selectedElements;

        if (allElements.length === 0) {
            throw new Error('invalid input');
        }

        // Change buttons content
        selectedElements = allElements.children('.button');
        selectedElements.html('hide');

        // Add functionality to hide content of elements with class 'content'
        selectedElements.on('click', function (ev) {
                //var $currentSibling = $(ev.target).next();
                var $currentSibling = $(this).next();

                while (!($currentSibling.hasClass('content'))
                && !($currentSibling.hasClass('button'))) {
                    $currentSibling = $currentSibling.next();
                }

                if ($currentSibling.hasClass('content')) {
                    if ($($currentSibling).css('display') !== 'none') {
                        $currentSibling.css('display', 'none');
                        $(ev.target).html('show');
                    }
                    else {
                        $currentSibling.css('display', '');
                        $(ev.target).html('hide');
                    }
                }
            }
        );
    };
};


module.exports = solve;