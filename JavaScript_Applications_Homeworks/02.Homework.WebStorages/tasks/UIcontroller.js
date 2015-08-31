var startGameBtn=document.getElementById('startGame'),
    guessBtn=document.getElementById('guessNumber'),
    showHighScoreBtn=document.getElementById('highScore'),
    theGame;

startGameBtn.addEventListener('click',function(ev){
    var name=document.getElementById('name').value;

    var game=solve();
    theGame=Object.create(game).init(name);
})

guessBtn.addEventListener('click',function(ev){
    var userNumber=document.getElementById('userNumber').value,
        result=document.getElementById('result'),
        sheep=theGame.guess(userNumber).sheep,
        rams=theGame.guess(userNumber).rams;

console.log(document.getElementById('userNumber'))
    result.innerHTML='sheeps: '+ sheep + ' rams: '+rams;
});

showHighScoreBtn.addEventListener('click',function(ev){
    var highScoreContainer=document.getElementById('highScoreInfo');
    var highScore=theGame.getHighScore();

    highScoreContainer.innerHTML='';

    for(var i = 0;i < highScore.length;i+=1){
        highScoreContainer.innerHTML+=' Name: '+highScore[i].name + '<br>'+ ' Result from guessed: ' + highScore[i].guessedNumber  + '<br>'+'<hr>' ;
    }
});
