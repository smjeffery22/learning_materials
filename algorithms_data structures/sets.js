// Sets

// set data structure is kind of like an array
//  no duplicate items
//  values are not in any particular order
//  ex. to check for the presence of an item

function mySet() {
	// collection will hold the set
	const collection = [];

	// checks for the presence of an element and return true/false
	this.has = function (element) {
		// if element not in collection, left side = -1
		//  if not -1, returns true (present in collection)
		return collection.indexOf(element) !== -1;
	};

	// returns all the values in the set
	this.values = function () {
		return collection;
	};

	// adds an element to the set
	this.add = function (element) {
		// check if element already exists in the collection
		// if it doesn't exist, push into the collection
		if (!this.has(element)) {
			collection.push(element);
			return true;
		}

		return false;
	};

	// removes an element from a set
	this.remove = function (element) {
		if (this.has(element)) {
			index = collection.indexOf(element); // first find the index of the existing element
			collection.splice(index, 1); // remove the element from the collection; splice changes the content of the original array
			return true;
		}

		return false;
	};

	// returns the size of the collection
	this.size = function () {
		return collection.length;
	};

	/*
	 * all the methods above are included in ES6 implementation of the set
	 *  except 'remove' is 'delete'
	 *  'size' is a property, not a method so it can be called without ()
	 */

	/* below are not included in ES6 set */

	// returns the union of two sets without duplicates
	this.union = function (otherSet) {
		const unionSet = new mySet(); // initialize empty set
		const firstSet = this.values();
		const secondSet = otherSet.values();

		// add the firstSet to the unionSet
		firstSet.forEach((e) => unionSet.add(e));

		// add the secondSet to the unionSet
		// add method will check for duplicates
		secondSet.forEach((e) => unionSet.add(e));

		return unionSet;
	};

	// returns the intersection of two sets as a new set
	this.intersection = function (otherSet) {
		const intersectionSet = new mySet();
		const firstSet = this.values();

		firstSet.forEach((e) => {
			if (otherSet.has(e)) {
				intersectionSet.add(e);
			}
		});

		return intersectionSet;
	};

	// returns the difference of the two sets as a new set
	this.difference = function (otherSet) {
		const differenceSet = new mySet();
		const firstSet = this.values();

		firstSet.forEach((e) => {
			if (!otherSet.has(e)) {
				differenceSet.add(e);
			}
		});

		return differenceSet;
	};

	// tests if the set is a subset of a different set
	this.subset = function (otherSet) {
		const firstSet = this.values();

		// checks if all the elements in one set are contained in the other set
		return firstSet.every((e) => {
			return otherSet.has(e);
		});
	};
}

const setA = new mySet();

console.log(setA.values());
setA.add(2);
setA.add(4);
setA.add(6);
setA.add(8);
console.log(setA.values());
console.log('duplicate:', setA.has(8));
setA.add(8);
console.log(setA.values());
setA.remove(8);
console.log(setA.values());
console.log('set size:', setA.size());

const setB = new mySet();
setB.add(4);
setB.add(6);
setB.add(8);
setB.add(10);
setB.add(12);
setB.add(14);
console.log(setB.values());
console.log(setA.union(setB).values());
console.log(setA.intersection(setB).values());
console.log(setA.difference(setB).values());
console.log(setB.difference(setA).values());

const setC = new mySet();
const setD = new mySet();

setC.add(2);
setC.add(4);
setC.add(6);

setD.add(2);
setD.add(4);
setD.add(6);
setD.add(8);

console.log(setC.subset(setD));