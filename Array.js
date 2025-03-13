var languages = [
    'javaScript',
    'cSharp',
    'pyThon',
    //co the chua bat ki kieu du lieu nao
    null,
    function () {
        
    },
    {},
    undefined
];
//cach khac
var languages2 = new Array(
    "Vo",
    "Tan",
    "Tai"
);

console.log(languages2);

//cach kiem tra co phai Array hay khong( khong dung typeof. de kiem tra vi luc do typeof cua Array la Object)
console.log(Array.isArray(languages));
//Lay phan tu theo Index
console.log(languages[1]);

//chuyen Array sang string
console.log(languages.toString());

//chuyen thanh string va ngan cach bang 1 dau nao do
console.log(languages.join(' . '));//muon dau gi thi bo vao ' '

//xoa phan tu cuoi mang va tra ve phan tu da xoa(dang string)
console.log(languages.pop());
console.log(languages);//neu khong co phan tu nao trong mang thi se tra ve undefined

//them vao phan tu cuoi mang va tra ve do dai mang sau khi them
console.log(languages.push('Ruby'));
console.log(languages);

//xoa di phan tu o dau mang va tra ve phan tu da xoa
console.log(languages.shift());
console.log(languages);

//them phan tu vao dau mang va tra ve so luong mang sau khi them

console.log(languages.unshift('Dart'));
console.log(languages);

//xoa,cat va chen phan tu vao mang
//1.Xoa
languages.splice(1, 1);//index bat dau xoa va so luong de xoa

console.log(languages);
//2.Chen
languages.splice(1, 0, 'C++');
console.log(languages);

//noi 2 mang lai voi nhau
console.log(languages.concat(languages2));//mang trong ngoac se bi gop vao mang .concat

//cat mang
console.log(languages2.slice(1, 2));
console.log(languages2.slice(-3,-2));

// Cú pháp reduceRight(callBack, initialValue)
//     - callBack(acc, fn) : Nhận acc (giá trị tích) và fn(hàm hiện tại)
//     - initialValue = x : Giá trị khởi tạo cho acc

array.sort((a, b) => a - b);

// .sort() sắp xếp mảng theo thứ tự chuỗi (string) mặc định, nên cần truyền một hàm so sánh ((a, b) => a - b) để sắp xếp theo giá trị số.
// Nếu a - b nhỏ hơn 0, a sẽ đứng trước b (giữ nguyên thứ tự).
// Nếu a - b lớn hơn 0, b sẽ đứng trước a (đảo thứ tự).