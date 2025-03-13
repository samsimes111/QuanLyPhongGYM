var myInfo = {
    fullName: "Vo Tan Tai",
    age: 20,
    adress: "My Tho, TG",
    //cung co the gan key cho 1 function
    myKey: function() {
        return this.fullName;
    }
};
//cach them vao Object
myInfo['my-email'] = 'tanloc01293@gmail.com';

console.log(myInfo);

//xoa key
//delete myInfo.fullName;

console.log(myInfo.myKey());

//Function --> Phương thức / method
//Others --> Thuộc tính / property