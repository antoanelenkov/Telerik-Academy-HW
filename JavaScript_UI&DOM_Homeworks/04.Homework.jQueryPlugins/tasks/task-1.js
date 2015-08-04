function solve() {

    return function (selector) {
        var $container = $('<div>').addClass('dropdown-list'),
            $this = $(selector).css('display', 'none'),
            $children = $this.children(),
            $current = $('<div />')
                .addClass('current')
                .attr('data-value', '')
                .html($children.first().text()),
            $optionsContainer = $('<div />')
                .addClass('options-container')
                .css({'position': 'absolute', 'display': 'none'});


        var $currentChild = $children.first();
        for (var i = 0; i < $children.length; i += 1) {

            var $currentOption = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $currentChild.val())
                .attr('data-index', i)
                .text($currentChild.text());

            $optionsContainer.append($currentOption);
            $currentChild = $currentChild.next();
        }


        $current.on('click', function () {
            if ($optionsContainer.css('display') === 'none') {
                $optionsContainer.css('display', '');
            }
            else {
                $optionsContainer.css('display', 'none');
            }
        })

        $optionsContainer.on('click', function (ev) {
            var $selected=$(ev.target);
            $current.html($selected.html())
                .attr('data-value',$selected.attr('data-value'));
            $optionsContainer.css('display', 'none');

            // FUCK THIS SHIT!!!!
            // FUCK THIS SHIT!!!!
            $this.val($selected.attr('data-value'));
            // FUCK THIS SHIT!!!!
            // FUCK THIS SHIT!!!!
        })


        $container.append($this);
        $container.append($current);
        $container.append($optionsContainer);
        $('body').append($container);

    }
}

module.exports = solve;