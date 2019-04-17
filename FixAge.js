function fixage(a) {

    if (!a || a.constructor !== Array) {
        alert("Parameter has to be an array");
        return;
    }
    if (a.find(isInputInValid)) {
        alert("Parameter has to be an array of integers between 0 and 100");
        return;
    }
    var filteredByAge = a.filter(isInRange);
    if (filteredByAge.length == 0)
        return "NA";

    return filteredByAge.join(",");
}

function isInputInValid(i) {
    return !Number.isInteger(i) || i < 0 || i > 100;
}

function isInRange(i) {
    return i >= 18 && i <= 60;
}

