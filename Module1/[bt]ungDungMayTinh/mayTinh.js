let soHang1 =parseFloat( document.getElementById("soHang1").value);
let soHang2 =parseFloat( document.getElementById("soHang2").value);
let totaly = document.getElementById("ketQua");
function add(){
    totaly.innerHTML = soHang1 + soHang2;
}
function sub(){
    totaly.innerHTML = soHang1 -soHang2;
}
function mutiply(){
    totaly.innerHTML = soHang1 *soHang2;
}
function division(){
    totaly.innerHTML = soHang1 /soHang2;
}
