/**
 * 1. Hàm ?
 * - Một khối mã
 * - Làm 1 việc cụ thể
 * 2. Tính chất
 * - Không thực thi khi định nghĩa
 * - Sẽ thực thi khi được gọi
 * - Có thể nhận tham số
 * - Có thể trả về 1 giá trị
 */
function showDialog(name/*tham so*/) {
    console.log('Hi xin chao ' + name);
}

showDialog('Ruby'/*doi so*/);

function writeDialog() {
    console.log(arguments);
}

writeDialog('Tan', 'Tai');
//su dung arguments

function writeDialog1() {
    for (var param of arguments) {
        console.log(param);
        //neu muon gop lai thanh 1 chuoi thi
        //var myString = '';
        //for (var param of arguments) {
            //myString += `${param} - `
        //} console.log(myString)
        }
    }


writeDialog1('Vo', 'Tan', 'Tai');

function cong(a, b) {
    a + b;
    console.log('Day la phep cong');
    alert('Day la phep cong');
}
var result = cong(2, 5);
//tat ca tren deu la declaration function
//duoi day la vai expression function
var showMessage = function() {

};

setTimeout(function() {

});

var myObject = {
    myFunction: function testName() {

    }
}
