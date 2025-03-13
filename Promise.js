//PROMISE là 1 khái niệm sinh ra để xử lý các thao tác bất đồng bộ
//Trước khi có Promise, chúng ta sử dụng callBack, khi sử dụng callBack thì chúng ta dễ gặp phải callBack hell -> code bị rối rắm, khó nhìn
//Để tạo ra 1 promise chúng ta sử dụng từ khóa new Promise, chúng ta sẽ truyền vào trong 1 executor function
//trong executor function, chúng ta nhận được 2 tham số resolve và reject dạng hàm
//Resolve chúng ta sẽ gọi khi thao tác logic xử lý thành công và ngược lại
//Khi cta sử dụng promise thì đối tượng promise sẽ được tạo ra: .then, .catch, .finally
// 1. Sync / Async (Đồng bộ / Bất đồng bộ)

//setTimeOut, setInterval, ...

//sleep
setTimeout(function() {
    console.log(1);
}, 1000);

console.log(2);
//1. Pendding
//2. Fulfilled: trang thai khi goi resolve()
//3. Rejected: trang thai khi goi reject()
// var promise = new Promise(
//     function(resolve, reject) {
//         //Logic
//         //Thành công: resolve()
//         //Thất bại: reject()
//         resolve();
//     }
// );

// promise
//     .then(function() {//se duoc goi khi resolve duoc goi
//         console.log('Successfully !');
//     })
//     .then(function() {
//         return new Promise(function(resolve) {
//             setTimeout(function() {
//                 resolve([1, 2, 3]);
//             }, 3000);
//         })
//     })
//     .then(function(data) {
//         console.log(data)
//     })    
//     .catch(function() {//se duoc goi khi reject duoc goi
//         console.log('Failure !');
//     })
//     .finally(function() {//se duoc goi khi 1 trong 2 duoc goi
//         console.log('Done !');
//     })
//Chain
var promise1 = new Promise(
    function(resolve, reject) {
        //resolve('Success !');
        reject('Failure !');
})

promise1
    .then(function (result) {
        console.log('result : ', result);
    })
    .catch(function(error) {
        console.log('result : ',error )
    })

//Neu khong can reject thi chi can var promise = Promise.resolve() va nguoc lai
//Thư viện: output luôn luôn là 1 promise
//Nếu chúng ta muốn kết quả của 2 promise không liên quan với nhau để làm việc gì đó
//ta sử dụng Promise.all([promise1, promise2])
    //.then(function(result) {
    //  console.log(result);
    //  var result1 = result[0];
    //  var result2 = result[1];

    //  console.log(result.contat(result2));
    //});
promise1 = new Promise(
    function(resolve) {
        setTimeout(function() {
            resolve(2, 20);
        });
})