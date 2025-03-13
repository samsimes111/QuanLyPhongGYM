// //Map()
// const array = [1, 2, 3, 4];

// //Pass a function to map
// const map1 = array.map((x) => x * 2);

// console.log(map1);
// //Reduce()
// var initialValue = 0;
// //Pass a function to reduce
// const reduce1 = map1.reduce((accumulator, currentValue) => accumulator + currentValue, initialValue);

// console.log(reduce1);

// //Filter()

// const words = [
//     "CSharp",
//     "JavaScript",
//     "Python",
//     "Ruby", 
//     "PHP"
// ];

// const result = words.filter((word) => word.length > 6);

// console.log(result);

//Bài tập thực hành
    //1.Viết function lọc số chẵn từ 1 mảng số nguyên

    const array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    const result = array.filter((filter1) => filter1 % 2 == 0);

    console.log(result);
    //2.Viết function tính tổng giá trị trong 1 mảng object(danh sách sản phẩm)

    const arrayOfObject = [
        {
            id: 1,
            name: "Book",
            price: 20000
        },
        {
            id: 2,
            name: "Pen",
            price: 10000
        },
        {
            id: 3,
            name: "Erase",
            price: 5000
        }
    ]

    const result1 = arrayOfObject.reduce(
        (totalPrice, product) => totalPrice + product.price,0
    );

    console.log(result1);
    //3.Viết 1 function sắp xếp mảng theo giá trị tăng dần
    const result2 = [...arrayOfObject].sort(
        (sort1, sort2) => sort1.price - sort2.price 
    );

    console.log(result2);
    console.log(arrayOfObject);