var items = document.querySelectorAll(".row")
var operator = document.querySelectorAll(".operator")
var devide = document.querySelector("./") 
var plus = document.querySelector(".+")
var minus = document.querySelectorAll(".-")
var multiply = document.querySelector(".*")
var equal = document.querySelector(".#equals")
var countnumber = 0;
var countnumber2 = 2;
// function press(items){
   
//     document.querySelector("#display").innerHTML = items;
//     // countnumber += document.querySelector("#display").innerHTML;
// }

function press(nr){
    console.log(nr);
    var item = nr;
    console.log(countnumber);
    var countnumber = countnumber + item;
    // console.log(countnumber)
}