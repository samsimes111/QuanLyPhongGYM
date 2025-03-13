//Closure
//- Là 1 hàm có thể ghi nhớ nơi nó được tạo ra và truy cập được biến ở bên ngoài phạm vi của nó

function createCounter() {
    let counter = 0;
    function increase() {
        return ++counter;
    }
    return increase;
}

const counter1 = createCounter();

console.log(counter1());
console.log(counter1());
console.log(counter1());//luon tra ve bien counter moi nhat chu khong tra ve 'let counter = 0'

//nhung khi dinh nghia lai thi counter se tra ve gia tri 'let counter = 0'

const counter2 = createCounter();

console.log(counter2());
console.log(counter2());
console.log(counter2());

//Ung dung: giam thoi gian khi viet code
function createLogger(namespace) {
    function logger(message){
        console.log(`[${namespace}] [${message}]`);
    }
    return logger;
}

const logger1 = createLogger('Info');

logger1('Thong bao den Tan Tai');
logger1('Tan Tai da nhan thong bao');
logger1('Tan Tai da phan hoi');


function createAccount(namespace) {
    function logger(message){
        alert(`[${namespace}] [${message}]`);
    }
    return logger;
}

const logger2 = createAccount('Error');

logger2('dang nhap that bai');
logger2('vui long dang nhap lai');
logger2('dang nhap thanh cong');

