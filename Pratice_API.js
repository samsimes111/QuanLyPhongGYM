//Function gọi API để lấy danh sách bài viết
async function fetchPosts() {
    //async biến function này thành 1 hàm bất đồng bộ, cho phép sử dụng await bên trong nó
    //fetchPosts() là 1 hàm dùng để lấy danh sách bài viết
    try{
        //try: chạy các đoạn code bên trong để xử lý truy vấn API. Nếu có lỗi xảy ra, nó sẽ bị bắt bởi catch
        const respone = await fetch('https://jsonplaceholder.typicode.com/posts');
        //fetch(url) dùng để gửi yêu cầu HTTP đến 1 sever và nhận về 1 respone
        //fetch(url) hoạt động bất đồng bộ (asynchronous) và trả về 1 Promise
        //URL là địa chỉ API muốn gửi yêu cầu đến
        //https://jsonplaceholder.typicode.com/posts là một REST API giả lập từ JSONPlaceholder, cung cấp dữ liệu về bài viết (posts)
        //Khi gọi URL này bằng fetch(), API sẽ trả về danh sách bài viết ở định dạng JSON
        if(!respone.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`)
            //throw tạo ra 1 lỗi và ngăn chương trình tiếp tục chạy 
            //new Error tạo 1 đối tượng lỗi với thông báo cụ thể
            //response.status là mã trạng thái HTTP từ server
            //nếu thành công thì mã trạng thái HTTP từ 200 - 299, thất bại ví dụ lỗi 404, 500, 403....
        }
        const data = await respone.json(); //được dùng để chuyển đổi dữ liệu phản hồi(respone) từ API sang định dạng JSON
        //respone.json() đọc dữ liệu từ phản hồi HTTP và chuyển đổi nó thành đối tượng JavaScript (từ JSON)
        //Trả về 1 promise, vì vậy cần await để chờ kết quả
        console.log("Danh sach bai viet: ", data.slice(0,5));
    } catch(error) {
        console.log("Loi khi goi API: ", error.message);
    }
}

fetchPosts();

// 1. Dùng fetch()	Gửi yêu cầu GET đến API
// 2. Kiểm tra response.ok	Nếu lỗi, ném Error
// 3. Dùng await response.json()	Chuyển dữ liệu JSON thành object
// 4. Hiển thị kết quả	Dùng console.log() để xem dữ liệu
// 5. Xử lý lỗi với try...catch	Nếu có lỗi, in ra lỗi

//VD2:Lấy danh sách người dùng
//Viết một function gọi API https://jsonplaceholder.typicode.com/users để lấy danh sách người dùng và hiển thị ra console.

async function getList() {
    try{
        const respone = await fetch('https://jsonplaceholder.typicode.com/users');
        if(!respone.ok){
            throw new Error(`HTTP error! Status: ${response.status}`);
        }
        const data = await respone.json();
        console.log('Danh sach bai viet: ', data.slice(0, 5));
    } catch(error){
        console.log('Loi khi goi API: ', error.message);
    }
}

getList();