"use strict";
function getMarginLeft(margin) {
    // margin may be a string or number here
    if (typeof margin === 'string') {
        // margin must be a string here
        return margin.toLowerCase();
    }
    // margin.toLowerCase(); // error since toLowerCase method doesn't exist on number type
}
const pettingZooAnimal = { isPettable: true };
console.log(pettingZooAnimal.isPettable); // No TypeScript error
console.log(pettingZooAnimal.hasHoofs); // TypeScript error
