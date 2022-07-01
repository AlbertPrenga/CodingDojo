console.log("page loading...")

function loading(){
    alert("Loading weather report...")
}



function hide(){
document.querySelector("footer").remove();
}

var number = document.querySelector(".number")


var celcius = document.querySelectorAll(".temp");
function calculate(element){

if (element.value == "f"){
for(var i = 0; i < celcius.length; i++){
 console.log(celcius[i].innerText);
 celcius[i].innerText = parseInt((celcius[i].innerText) * 33.8);
}}
else{
    for(var i = 0; i < celcius.length; i++){
        console.log(celcius[i].innerText);
        celcius[i].innerText = parseInt(celcius[i].innerText / 33.8);
       }
}
}



