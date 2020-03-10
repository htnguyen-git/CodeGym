function nhanNutUp() {
    let element =document.getElementById("nobita");
    element.style.top = parseInt(element.style.top) -5 +'px';
}
function nhanNutDown(){
    let element = document.getElementById("nobita");
    element.style.top = parseInt(element.style.top) +5 +'px';
}
function nhanNutTrai() {
    let element = document.getElementById("nobita");
    element.style.left = parseInt(element.style.left) - 5 + 'px';
}
function nhanNutPhai() {
    let element = document.getElementById("nobita");
    element.style.left = parseInt(element.style.left) + 5 + 'px';

}
function diChuyen(evt){
    switch (evt.keyCode){
        case 37:
            nhanNutTrai();
            break;
        case 39:
            nhanNutPhai();
            break;
        case 38:
            nhanNutUp();
            break;
        case 40:
            nhanNutDown();
    }
}
function sanSang(){
    window.addEventListener('keydown', diChuyen);
}