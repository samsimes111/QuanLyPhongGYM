// DOM (Document Object Model) là mô hình đối tượng tài liệu, đại diện cho cấu trúc của một trang web dưới dạng cây (tree structure). 
// Nó cho phép JavaScript tương tác, thay đổi nội dung, cấu trúc và kiểu dáng của trang HTML.
// Cách hoạt động của DOM:
// Khi trình duyệt tải một trang web, nó phân tích cú pháp (parse) mã HTML và xây dựng một cây DOM.
// JavaScript có thể sử dụng DOM để thay đổi nội dung trang mà không cần tải lại trang

const title = document.querySelector("#title") //tìm phần tử đầu tiên trong tài liệu HTML có id = title
//Dấu # trong "#tittle" là cú pháp CSS chọn phần tử theo id
//Kết quả là 1 đối tượng Element đại diện cho phần tử HTML có id = "title"
console.log(title.textContent); //lấy toàn bộ nội dung văn bản có trong title

//chọn phần tử đầu tiên trong class "text"
const firstText = document.querySelectorAll(".text");
console.log(firstText[0].textContent);
console.log(firstText[1].textContent);
//Tạo 1 thẻ <p> mới 
const newParagraph = document.createElement("p");

newParagraph.textContent = "This is a text created with by Tan Tai !";

const container = document.querySelector("#container");

container.appendChild(newParagraph);// Đoạn văn đã xuất hiện trên trang

const lastParagraph = container.lastElementChild;

if(lastParagraph) {
    container.removeChild(lastParagraph);
}// xóa đoạn văn mới nhất trong container

const addBtn = document.querySelector("#add-btn") //tim phan tu co id = "add-btn" trong html

//Xử lý khi bấm nút "Thêm đoạn văn"
addBtn.addEventListener("click", function() {
    const newP = document.createElement("p");
    newP.textContent = "A new paragraph has been added!";
    container.appendChild(newP);
});
//Xử lý nút khi bấm nút "Xóa đoạn văn"
const removeBtn = document.querySelector("#remove-btn")

removeBtn.addEventListener("click", function() {
    const lastP = container.lastElementChild;
    if(lastP) {
        container.removeChild(lastP);
    }
});
//tao 1 the ul moi
const newUL = document.createElement("ul");
//tao 1 mang item
const item = [
    "Part 1",
    "Part 2",
    "Part 3"
];

//tao 1 ham tao the li va nut button
const createLI = function(text) {
    const newLI = document.createElement("li");
    newLI.textContent = text;

    //them 1 nut vao DOM
    const remove_btn = document.createElement("button");
    remove_btn.textContent = "Delete";
    
    //chinh nut Delete cach ben trai 10px
    remove_btn.style.marginLeft = "10px";

    //xu ly Delete Button
    remove_btn.addEventListener("click", function() {
        newLI.remove();
    });
    addBtn.addEventListener("click", function() {
        const text = input.value.trim();
        if (text !== "") {
            newUL.appendChild(createListItem(text));
            input.value = ""; // Xóa nội dung input sau khi thêm
        } else {
            alert("Vui lòng nhập nội dung!");
        }
    });
    newLI.appendChild(addBtn);
    //them remove_btn vao li
    newLI.appendChild(remove_btn);
    return newLI;
}; 


//gan tung item cho li
item.forEach(items => newUL.appendChild(createLI(items)));

container.appendChild(newUL);














//=======================================CÁCH TỐI ƯU HƠN==========================================
// // Tạo danh sách động
// const container = document.querySelector("#container");
// const newUL = document.createElement("ul");
// const items = ["Part 1", "Part 2", "Part 3"];

// // Hàm tạo <li> và nút xóa
// function createListItem(text) {
//     const newLI = document.createElement("li");
//     newLI.textContent = text;

//     // Tạo nút xóa
//     const removeBtn = document.createElement("button");
//     removeBtn.textContent = "Delete";
//     removeBtn.style.marginLeft = "10px";

//     // Xử lý sự kiện xóa
//     removeBtn.addEventListener("click", function() {
//         newLI.remove(); // Gọn hơn: Dùng `.remove()` thay vì `removeChild()`
//     });

//     newLI.appendChild(removeBtn);
//     return newLI;
// }

// // Thêm các mục vào danh sách
// items.forEach(item => newUL.appendChild(createListItem(item)));

// // Thêm danh sách vào container
// container.appendChild(newUL);