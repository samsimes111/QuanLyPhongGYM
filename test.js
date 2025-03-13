//Bai 1
var obj = {
    firstName: "Tai",
    lastName: "Vo"
};
console.log(obj.firstName + ' ' + obj.lastName);
//Bai 2
var car = {
    hangXe: "BMW",
    gia: 300000,
    xuatXu: 'Duc'
};
//Bai 3
obj['mau_sac'] = 'Den';
obj['gia'] = 2500000;
console.log(obj.gia + ' ' + obj.mau_sac);

var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

for(var i = 0; i < array.length; i++){
    var item = array[i];
    if(item % 2 == 0){
        console.log(item);
    }
}

const numbers = [1, 4, 9, 16];
const doubled = numbers.map(number => {//number => {return number * 2} là 1 arrow function
    return number * 2;
});
//tạo 1 phương thức của mảng, giúp duyệt qua từng phần tử của numbers
//và tạo 1 mảng mới bằng cách áp dụng hàm lên từng phần tử

console.log(doubled);