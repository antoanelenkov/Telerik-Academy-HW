/**
 * Created by Antoan on 9/1/2015.
 */
import {game} from 'tasks/game.js';

var storage=localStorage,
    theGame;

function getHighScore(){
    var topPlayers=[];

    for(var i=0;i<storage.length;i+=1){
        topPlayers.push({
            name:storage.key(i),
            tries: storage.getItem( storage.key( i ))
        });
    }
    
    return topPlayers;
}

function saveToHighScore(key,value){
    storage.setItem(key,value);
}

function startGame(userName){
    theGame=Object.create(game).init(userName);

    return theGame;
}

export default {startGame,saveToHighScore,getHighScore};