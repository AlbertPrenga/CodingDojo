var likeCount = 9;
var post1Likes = document.querySelector('#post-1');


function like(button){
  
 
  if(button.innerText == "Like"){
    likeCount++;
    post1Likes.innerText = likeCount + '  like(s)';
    button.innerText = "Dislike";
  }
 
  else{
    likeCount--;
    post1Likes.innerText = likeCount + '  like(s)';
    button.innerText = "Like" ;
  } ;


}

var likeCount2 = 12;
var post2Likes = document.querySelector('#post-2');


function like2(){
  likeCount2++;
  post2Likes.innerText = likeCount2 + '  like(s)';
  
}

var likeCount3 = 9;
var post3Likes = document.querySelector('#post-3');


function like3(){
  likeCount3++;
  post3Likes.innerText = likeCount3 + '  like(s)';
  
}

