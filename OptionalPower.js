
function optionalPow(x, y) {
    if (isNaN(x) || isNaN(y)) {
        alert("Parameters have to be numbers");
        return;
    }
    if (confirm("Is x the base?"))
        return Math.pow(x, y);
    return Math.pow(y, x);
}

