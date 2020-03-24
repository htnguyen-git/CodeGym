/**
 * Created by nhatnk on 4/26/17.
 */

function Hero(image, top, left, size, speed){
  this.image = image;
  this.top = top;
  this.left = left;
  this.size = size;
  this.speed = speed;
  this.getHeroElement = function(){
    return '<img width="'+ this.size + '"' +
      ' height="'+ this.size + '"' +
      ' src="' + this.image +'"' +
      ' style="top: '+this.top+'px; left:'+this.left+'px;position:absolute;" />';
  }

  
  this.moveRandom = function () {
    this.left += this.speed*(Math.random()*20-10);
    this.top += this.speed*(Math.random()*20-10);
  }

}


var hero = new Hero('cánh cụt.png', 200, 300,100,10);

function start(){
  if(hero.left < window.innerWidth - hero.size
    && hero.top < window.innerHeight - hero.size){
    hero.moveRandom();
  }
  document.getElementById('game').innerHTML = hero.getHeroElement();
  setTimeout(start, 500)
}

start();