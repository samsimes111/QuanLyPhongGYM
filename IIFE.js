//IIFE
(function(message) {
    console.log('Xin chao Tan Tai ', message);
})('Ban khoe khong')
//function() tuong duong voi  () =>
//khong su dung duoc ngoai pham vi => su dung cho de quy

let i = 0

;(function myFunc() {
    i++;
    console.log(i);

    if(i < 10){
        myFunc();
    }
})()

// //vi la private va chi co pham vi trong ham nen su dung khi du an lon co qua nhieu bien toan cuc
// const app = {//tao 1 object de quan ly cac chuc nang
//     cars: [], //tao 1 Array car de luu tru cac loai xe
//     add(car) {//function dung de them xe lay tham so la car
//         this.cars.push(car)
//     },
//     edit(index, car){
//         this.cars[index] = car
//     },
//     delete(index) {//ham dung de xoa 1 xe da add
//         this.cars.splice(index, 1)
//     }
// }//nhung lam vay de bi tan cong, nen ta su dung IIFE

const app = (function() {
    //private
    const cars = [];

    return {
        add(car) {
            cars.push(car)
        },
        edit(index, car){
                    this.cars[index] = car
        },
        delete(index) {
            this.cars.splice(index, 1)
        }
    }
})()