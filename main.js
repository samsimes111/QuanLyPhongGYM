// var fullName = 'Vo Tan Tai';
// var age = 20;

// alert(fullName);
// alert(age);

// console.log('Day la 1 dong log');//hien ra thong bao tren console

// confirm('Xac nhan ban la Anttia')//hien ra thong bao xac nhan

// prompt('Xac nhan ban la Anttia');//xac nhan hien ra hop thoai de dien vao

// setTimeout(function() {
//     alert('Ban la Anttia')
// }, 2000)//cho doan code duoc chay sau 1 khoang time, time o day la mili giay

// setInterval(function() {
//     alert('Ban co phai la Anttia')
// }, 2000);//cho doan code duoc chay sau 1 khoang time va lap lai

var myFunction = function(){
    alert('Xin chao Tan Tai');
}

//myFunction();//function type

var myObject = {
    name: "Tan Tai",
    age: 20,
    adress: "Ha Noi",
    myFunction: function (){

    }
};

console.log('myObject', myObject)//Object type

var myArray = [
    "Tan Tai",
    "Ruby",
    "Map djt"
];

console.log('myArray', myArray)

var name = "Tan Tai";

console.log(typeof name);

// cac ket qua khi in ra se tra ve false
/**
 * 0
 * ''
 * null
 * undefined
 * NaN
 * false
 */

//&&: neu dung thi tim tiep cho den khi gap sai
//|| neu dung thi lay bo qua con lai

//cach kiem tra do dai chuoi
var myName = "Vo Tan Tai";

console.log(myName.length);

//---------TOÁN TỬ CHUỖI - STRING OPERATOR--------

var firstName = "Tai";
var lastName = "Vo";

console.log(firstName + " " + lastName); 

//---------LÀM VIỆC VỚI CHUỖI---------
//1. Tìm kí tự trong chuỗi
var fullName = "   Vo Tan Tan Tan Tai   ";

console.log(fullName.indexOf('Tan'/*, vi tri muon bat dau tim*/));
//con muon tim tu sau len thi lastIndexOf
//.search tuong tu nhung khong co vi tri bat dau tim

//2. Cắt chuỗi 
console.log(fullName.slice(3,6));
//Neu muon cat tu dau den cuoi thi (0)
//cat tu cuoi len dau: 
console.log(fullName.slice(-3,-1));

//3. Thay thế chuỗi
console.log(fullName.replace('Tan', 'Tuan'));
//neu co nhieu chu Tan muon thay the thi dung bieu thuc chinh quy
console.log(fullName.replace(/Tan/g, 'Tuan'));

//4. Chuyển chuỗi thành chữ hoa, thuong
console.log(fullName.toUpperCase());
console.log(fullName.toLowerCase());

//5. Loại bỏ khoảng trắng thừa ở 2 đầu
console.log(fullName.trim());

//6. Tách thành các Array
var language = "javaScript, python, csharp";

console.log(language.split(", "));
//neu muon tach thanh tung chu thi chi can ('')

//7. Lấy kí tự từ 1 index cho trước
console.log(fullName.charAt(4));

//cach kiem tra so co phai la NaN (so khong hop le)

var result = 20 / 'ABC';

console.log(isNaN(result));
//chuyen tu number sang string
var age = 20.78875856;

console.log(age.toString());
//Note: mau trang: string, mau xanh: number

//lam tron so thap phan
console.log(age.toFixed(3));

var age1 = 10;

console.log(age1);

//sự khác nhau giữa let và var
/**
 * 1.Scope
 *  - var: chỉ hiệu lực trong hàm chứa nó
 *  - let: chỉ hiệu lực trong khối mã(block) chứa nó
 * 2.Hoisting
 *  - Cả 2 khi khai báo đều được "hoisting" lên đầu hàm hoặc toàn cục
 * 3.Re-declaration (Ghi đè)
 *  - var: có thể khai báo lại cùng 1 biến với var mà không gặp lỗi
 *  - let: sẽ gặp lỗi Syntax Error
 */