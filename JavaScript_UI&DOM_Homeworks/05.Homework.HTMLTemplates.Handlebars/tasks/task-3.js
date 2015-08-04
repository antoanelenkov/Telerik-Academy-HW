function solve(){
  return function(){
    $.fn.listview = function(data){
      var $this=$(this);
      var templateScriptId=$this.attr('data-template');
      var templateScript=$('#'+templateScriptId).html();
      var template=handlebars.compile(templateScript);

      data.forEach(function(item){
        $this.append(template(item));
      })
    };
  };
}

module.exports = solve;