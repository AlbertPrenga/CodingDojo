function  pizzaOven(crustType, sauceType, cheese, toppings) {
var pizza ={};
pizza.crustType = crustType;
pizza.sauceType = sauceType;
pizza.cheese = cheese;
pizza.toppings = toppings;


return pizza;
}

var pizza1 = pizzaOven("deep dish", "traditional", ["mozzarela"], ["pepperoni", "sausage"]);
console.log(pizza1);

var pizza2 = pizzaOven("hand tossed", "marinara",["mozzarela", "feta"], ["mushromos", "onions", "olives"]);
console.log(pizza2);

var crustTypes = [ 
     "deep dish",
     "hand tossed",
     "thin and crispy",
     "cauliflower",
     "gluten free",
     " hawalian bread"
    ]; 

var cheeses = [
    "traditional",
    "marinara",
    "bbq",
    "white sauce",
    "nacho cheese",
    "tikka masala"
];

var toppings = [
    "pepperoni",
    "sausage",
    "chicken",
    "corn",
    "olives",
    "bell peppers",
    "onions",
    "mushrooms",
    "anchovies",
];

function randomRanga (max, min) {
    return Math.floor(arrMath.random() * max - min) + min;
}

function randomPick (arr) {
    var i = Math.floor(arr.length * Math.random());
    return arr[i];
}

function randomPizza() {
    var pizza = {};
    pizza.crustType = randomPick(crustTypes);
    pizza.sauceType = randomPick(sauceTypes);
    pizza.cheeses = [];
    pizza.toppings = [];
    for(var i=0; i<randomRange(5, 1); i++) {
        pizza.cheeses.push(randomPick(cheeses));
    }
    for(var i=0; i<randomRange(4, 0); i++) {
        pizza.toppings.push(randomPick(toppings));
    }
    return pizza;
}

console.log(randomPizza());
