function fixage(a) {

    if (!a || a.constructor !== Array) {
        alert("Parameter has to be an array");
        return;
    }
    if (a.find(isNotInteger)) {
        alert("Parameter has to be an array of integers");
        return;
    }
    var filteredByAge = a.filter(isInRange);
    if (filteredByAge.length == 0)
        return "NA";

    return filteredByAge.join(",");

}

function isInRange(i) {
    return i >= 18 && i <= 60;
}

function isNotInteger(i) {
    return !Number.isInteger(i);
}
