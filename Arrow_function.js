//Nhac lai cac loai function
// 1. Function Expression
    const logger = function(log) {
        console.log(log);
    }
//  2. Function Declaration
    function logger(log) {
        console.log(log);
    }
//  3.  Arrow Function
    const logger = (log) => {
        console.log(log);
    }

const course = {
    name: 'Javascript basic !',
    getName: function() {
        return this.name; //course.name
    }
}

console.log(course.getName());