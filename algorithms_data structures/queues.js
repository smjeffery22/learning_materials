// Queues

// Queue data structure is a way to hold the data, similar to stack
//  Stack is FILO
//  Queue is First In, First Out (FIFO)

// function Queue() {
// 	const collection = [];

// 	this.print = function () {
// 		console.log(collection);
// 	};

// 	// adds to end of collection
// 	this.enqueue = function (element) {
// 		collection.push(element);
// 	};

// 	// removes from the beginning of collection
// 	// returns the removed element
// 	this.dequeue = function () {
// 		return collection.shift();
// 	};

// 	// returns the first item in queue
// 	this.front = function () {
// 		return collection[0];
// 	};

// 	this.size = function () {
// 		return collection.length;
// 	};

// 	this.isEmpty = function () {
// 		return collection.length === 0;
// 	};
// }

// const q = new Queue();

// q.print();
// q.enqueue('a');
// q.enqueue('b');
// q.enqueue('c');
// q.print();
// q.dequeue()
// q.print();
// console.log(q.front());
// console.log(q.size());
// console.log(q.isEmpty());

// elements with priority are sent to the beginning of the queue
function PriorityQueue() {
  const collection = [];

  this.printCollection = function () {
    console.log(collection);
  };

  this.enqueue = function (element) {
    if (this.isEmpty()) {
      collection.push(element);
    } else {
      let added = false;

      for (let i = 0; i < collection.length; i++) {
        // checks the priority
        // if the priority of the element is less than the collection element's priority
        //  add the element to the collection to that index
        // if the same priority, add the element following the previous same priority element
        if (element[1] < collection[i][1]) {
          collection.splice(i, 0, element);
          added = true;
          break;
        }
      }

      if (!added) {
        collection.push(element);
      }
    }
  }

  this.dequeue = function () {
    const value = collection.shift();
    return value[0]; // return the item without the priority number
  };

  this.front = function () {
    return collection[0];
  };

  this.size = function () {
    return collection.length;
  };

  this.isEmpty = function () {
    return (collection.length === 0);
  }
}

const pq = new PriorityQueue();

console.log(pq.printCollection());

pq.enqueue(['Beau Carnes', 2]);
pq.enqueue(['Quincy Larson', 3]);
pq.enqueue(['Ewa Mitulska', 1]);
console.log(pq.printCollection());
console.log(pq.dequeue());
console.log(pq.printCollection());
console.log(pq.front());
pq.enqueue(['Jeffery Park', 2]);
console.log(pq.printCollection());