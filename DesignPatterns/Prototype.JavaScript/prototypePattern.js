var myNamespace = myNamespace || {};
(function () {

    myNamespace.Calculator = function(id) {
        this.resultCtrl = document.getElementById(id);
    };

    myNamespace.Calculator.prototype = {
        add: function(x, y) {
            var val = x + y;
            this.resultCtrl.innerHTML = val;
        }
    };

})();