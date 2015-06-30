/*Prototypal Inheritance
 Task 1.

 Create an object domElement, that has the following properties and methods:

 Use prototypal inheritance, without function constructors
 Method init() that gets the domElement type
 i.e. Object.create(domElement).init('div');
 Property type that is the type of the domElement
 a valid type is any non-empty string that contains only Latin letters and digits
 Property innerHTML of type string
 gets the domElement, parsed as valid HTML:
 <type attr1="value1" attr2="value2" ... > ... content / children's.innerHTML</type>
 attributes must be sorted in ascending alphabetical order by their name, not in the order they were added
 Property content of type string
 sets the content of the element
 works only if there are no children
 Property attributes
 each attribute has name and value
 a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes -
 Property children
 each child is a domElement or a string
 Property parent
 parent is a domElement
 Method appendChild(domElement / string)
 appends to the end of children list
 Method addAttribute(name, value)
 throw Error if type is not valid
 Method removeAttribute(attribute)
 throw Error if attribute does not exist in the domElement
 Example:

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'myid')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:

 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="myid"><div style="font-size: 42px">Hello, world!</div></body></html>*/

function solve() {
    var domElement = (function () {
        var domElement = {
            init: function (type) {
                this.type = type;
                this._attributes = [];
                this._children = [];

                return this;
            },
            addAttribute: function (name, value) {
                if (arguments.length != 2) {
                    throw 'invalid number of args'
                }
                else if (value === null || name === null) {
                    throw 'null value or name attribute'
                }
                else if (name.length === 0 || /[^a-zA-z0-9\-]/.test(name)) {
                    throw 'empty string ot invalid input of name attr'
                }
                //overrides if is needed
                for(var i=0;i<this._attributes.length;i+=1){
                    if(this._attributes[i].name===name){
                        this._attributes[i].value=value;
                        return this;
                    }
                }
                this._attributes.push({name: name, value: value});
                return this;
            },
            appendChild: function (child) {
                if (child === null || arguments.length === 0) {
                    throw 'null child or wrong number of args'
                }
                else if (typeof child === 'string') {
                    this._children.push(child);
                }
                else {
                    child.parent = this;
                    this._children.push(child);
                }
                return this;
            }
            ,
            removeAttribute: function (attribute) {
                var isExisting = false;
                for (var i = 0; i < this._attributes.length; i += 1) {
                    if (this._attributes[i].name === attribute) {
                        this._attributes.splice(i, 1);
                        i -= 1;
                        isExisting = true;
                    }
                }
                if (!isExisting) {
                    throw 'attr does not exist'
                }
                return this;
            }
        }

        Object.defineProperties(domElement, {
                type: {
                    set: function (value) {
                        if (arguments.length === 0 || value === null) {
                            throw 'null type'
                        }
                        else if(typeof value!=='string'){
                            throw 'type not a string';
                        }
                        else if (value.length === 0 || !/^[A-Z\d]+$/i.test(value)) {
                            throw 'zero length or invalid symbols of type'
                        }
                        this._type = value;
                    },
                    get: function () {
                        return this._type;
                    }
                },
                content: {
                    set: function (value) {
                        if (value === null) {
                            throw 'null type'
                        }
                        else if (this._children.length > 0||this._content) {
                            return;
                        }
                        else{
                            this._content = value;
                        }
                    },
                    get: function () {
                        return this._content;
                    }
                }
                ,
                attributes: {
                    set: function (value) {
                        if (value === null) {
                            throw 'null attribute'
                        }
                        value.some(function (value) {
                            if (value.name.length === null || value.value.length === null) {
                                throw 'null value or name of attribute'
                            }
                            else if (value.name.length === 0 || /[^a-zA-z0-9\-]/.test(value.name)) {
                                throw 'empty string ot invalid input of attributes'
                            }
                        })

                        this._attributes = value;
                    },
                    get: function () {
                        return this._attributes;
                    }
                }
                ,
                children: {
                    set: function (array) {
                        if (array === null) {
                            throw 'null children'
                        }
                        this._children = array;
                    },
                    get: function () {
                        return this._children;
                    }
                },
                parent: {
                    set: function (value) {
                        if (!(Object.getPrototypeOf(this) === Object.getPrototypeOf(value))) {
                            throw 'invalid parent type'
                        }
                        this._parent = value;
                    },
                    get: function () {
                        return this._parent;
                    }

                },
                innerHTML: {
                    get: function () {
                        var result = '';
                        result += parseOpenTag(this);
                        if (this.content) {
                            result += this.content;
                        }
                        for (var i = 0; i < this.children.length; i += 1) {
                            if(typeof this.children[i]==='string'){
                                result+=this.children[i];
                            }
                            else{
                                result += this.children[i].innerHTML;
                            }
                        }
                        result += parseCloseTag(this);

                        return result;
                    }
                }
            }
        );

        function parseOpenTag(element) {
            var result = '';
            //console.log(element)
            result += '<' + element.type;
            element.attributes.sort(function (a, b) {
                if (a.name > b.name) {
                    return 1;
                }
                if (a.name < b.name) {
                    return -1;
                }
                return 0;
            })
            for (var attr in element.attributes) {
                result += ' ' + element.attributes[attr].name + '="' + element.attributes[attr].value + '"'
            }
            result += '>';
            return result;
        }

        function parseCloseTag(element) {
            return '</' + element.type + '>';
        }
        return domElement;
    }());
    return domElement;
}

module.exports = solve;
