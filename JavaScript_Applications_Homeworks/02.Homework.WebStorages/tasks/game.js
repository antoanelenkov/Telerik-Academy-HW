import controller from 'tasks/gameController.js'

var game=(function(){
    var gameInitialized=false;
    var gameNumber;

    var game={
        init:function(playerName, endCallback) {
            this.playerName=playerName;
            this.endCallback=endCallback;

            gameInitialized=true;
            gameNumber=generateRandomNumber();

            return this;
        },
        guess: function(number) {
            var guessed;

            if(!gameInitialized){
                throw 'game is not initialized'
            }

            console.log('my number '+number);

            guessed=getNumberOfSheepAndRams(number);


            return getNumberOfSheepAndRams(number);
        },
        getHighScore:function(count){
            var topPlayers=controller.getHighScore();

            return topPlayers;
        },
        saveToHighScore:function(tries){
            controller.saveToHighScore(this.playerName,tries);
        }
    }

    function generateRandomNumber(){
        var rand=(Math.random()*10000).toFixed(0);

        while(rand<1000){
            rand=rand+Math.random().toFixed(1)*10;
        }

        console.log('game number ' +rand)

        return rand;
    }

    function getNumberOfSheepAndRams(userNumber){
        var rams= 0,
            sheep=0;

        userNumber=userNumber+'';

        for(var i=0;i<4;i+=1){
            for(var j=0;j<4;j+=1){
                if(i===j){
                    if(gameNumber[i]===userNumber[i]){
                        rams+=1;
                    }
                }
                else{
                    if(gameNumber[i]===userNumber[j]){
                        sheep+=1;
                    }
                }
            }
        }
        console.log({
            sheep: sheep,
            rams:rams
        });
        return {
            sheep: sheep,
            rams:rams
        }
    }

    return game;
})();

export {game};

//module.exports = solve;