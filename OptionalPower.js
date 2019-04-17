
function optionalPow(a, b) {
    if (isNaN(a) || isNaN(b)) {
        alert("Parameters have to be numbers");
        return;
    }
    if (confirm("Is a the base?"))
        return Math.pow(a, b);
    return Math.pow(b, a);
}

