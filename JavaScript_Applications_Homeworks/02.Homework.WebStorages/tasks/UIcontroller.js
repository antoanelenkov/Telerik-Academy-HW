import {game} from 'tasks/game.js'
import gameController from 'tasks/gameController.js'

var startGameBtn=document.getElementById('startGame'),
    guessBtn=document.getElementById('guessNumber'),
    showHighScoreBtn=document.getElementById('highScore'),
    hideHighScoreBtn=document.getElementById('hideHighScore'),
    highScoreContainer=document.getElementById('highScoreInfo'),
    gameContainer=document.getElementById('gameContainer'),
    restartGame=document.getElementById('restartGame'),
    startGameContainer=document.getElementById('startGameContainer'),
    theGame,
    guessingTries=0;

startGameBtn.addEventListener('click',function(ev){
    var userName=document.getElementById('name').value;

    theGame=gameController.startGame(userName);

    gameContainer.className='';
    startGameContainer.className='hidden';
})

guessBtn.addEventListener('click',function(ev){
    var userNumber=document.getElementById('userNumber').value,
        result=document.getElementById('result'),
        sheep=theGame.guess(userNumber).sheep,
        rams=theGame.guess(userNumber).rams;

    guessingTries+=1;

    if(rams===4){
        var congratLabel=document.getElementById('congratLabel');
        congratLabel.innerHTML='Congratulations, you guessed with ' + guessingTries +' tries.';
        theGame.saveToHighScore(guessingTries);
        guessingTries=0;
    }

    result.innerHTML='sheeps: '+ sheep + ' rams: '+rams;
});

showHighScoreBtn.addEventListener('click',function(ev){
    var highScore=theGame.getHighScore();

    highScoreContainer.innerHTML='';

    highScoreContainer.innerHTML+='<strong>'+ 'High Scores' +'</strong>' + '<br>'+'<hr>';

    for(var i = 0;i < highScore.length;i+=1){
        highScoreContainer.innerHTML+=' Name: '+highScore[i].name + '<br>'+ ' Number of tries: ' + highScore[i].tries  + '<br>'+'<hr>' ;
    }
});

hideHighScoreBtn.addEventListener('click',function(ev){
    highScoreContainer.innerHTML='';
});

restartGame.addEventListener('click',function(){
    startGameContainer.className='';
    gameContainer.className='hidden';
    highScoreContainer.innerHTML='';
})
