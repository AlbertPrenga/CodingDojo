console.log('page loaded...');

var username = document.querySelector("#username");
var requestCount = document.querySelector("#requests");
var connectionCount = document.querySelector("#connections");
var newlist = document.querySelector("#NewMember")

function replace(){
username.innerText = "Elen A";
}

function accept(id){
    var element = document.querySelector(id);
    var emri= document.querySelector(id + " span")
    element.remove();
    requestCount.innerText--;
    console.log(id + " span")
   
    connectionCount.innerText++;
    newlist.innerHTML+= emri.innerHTML;
    

}
function ignore(id){
    document.querySelector(id).remove();
    requestCount.innerText--;
}