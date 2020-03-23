
class SourceAnh{
    constructor(){
        this.src = [];
        this.tenAnh = [];
    }
    getTenAnh(){
        return this.tenAnh;
    }
    getSrc(){
        return this.src;
    }

    setUrlAnh(tenAnh, part1, part2, part3, part4){
        this.tenAnh.push(tenAnh);
        let arrAnh = [part1, part2, part3, part4];
        this.src.push(arrAnh);
    }
    showImg(tenAnh, part){
        let i = this.tenAnh.indexOf(tenAnh);
        let url = this.src[i][part];
        return "<img src=  " + url  + "  width='200' height='200'></img>"
    }
}

function tangMot(so , ketThuc){
    if(so == ketThuc) so=-1;
    return (so+1);
}
function randomTu0(so){
    return Math.round(Math.random()*so)
}



function start() {
    //Thiết lập
    let srcAnh = new SourceAnh;
    srcAnh.setUrlAnh("Chó","image/chó/chó1.jpg", "image/chó/chó2.jpg", "image/chó/chó3.jpg", "image/chó/chó4.jpg")
    srcAnh.setUrlAnh("Đại bàng", "image/daibang/daibang1.jpg", "image/daibang/daibang2.jpg", "image/daibang/daibang3.jpg","image/daibang/daibang4.jpg" )
    srcAnh.setUrlAnh("Sói","image/sói/soi1.jpg", "image/sói/soi2.jpg", "image/sói/soi3.jpg", "image/sói/soi4.jpg")
    
    
    //Lấy id phần tử gán cho biến
    let trenTrai = document.getElementById("trenTrai");
    let trenPhai = document.getElementById("trenPhai");
    let duoiTrai = document.getElementById("duoiTrai");
    let duoiPhai = document.getElementById("duoiPhai");

    //Lấy tên ảnh, và chỉ số ảnh 
    let tenAnh = srcAnh.getTenAnh();
    let iTT = randomTu0(tenAnh.length -1);
    let iTP = randomTu0(tenAnh.length -1);
    let iDT = randomTu0(tenAnh.length -1);
    let iDP = randomTu0(tenAnh.length -1);

    // Gán ảnh ngẫu nhiên vào element 
    trenTrai.innerHTML = srcAnh.showImg(tenAnh[iTT], 0);
    trenPhai.innerHTML = srcAnh.showImg(tenAnh[iTP], 1);
    duoiTrai.innerHTML = srcAnh.showImg(tenAnh[iDT], 2);
    duoiPhai.innerHTML = srcAnh.showImg(tenAnh[iDP], 3);
    
    //Tạo sự kiện khi bấm vào ảnh 
    trenTrai.onclick = function() {
        iTT = tangMot(iTT,tenAnh.length-1);
        trenTrai.innerHTML = srcAnh.showImg(tenAnh[iTT], 0);
       
    }
    trenPhai.onclick = function() {
        iTP = tangMot(iTP,tenAnh.length-1);
        trenPhai.innerHTML = srcAnh.showImg(tenAnh[iTP], 1);
        
    }
    duoiTrai.onclick = function() {
        iDT = tangMot(iDT,tenAnh.length-1);
        duoiTrai.innerHTML = srcAnh.showImg(tenAnh[iDT], 2);
        
    }
    duoiPhai.onclick = function() {
        iDP = tangMot(iDP,tenAnh.length-1);
        duoiPhai.innerHTML = srcAnh.showImg(tenAnh[iDP], 3);
        
        
    }
  
    
    
}


start();
//

