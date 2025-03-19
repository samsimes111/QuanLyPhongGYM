    //Hien thi Cart List khi reload page
    document.addEventListener("DOMContentLoaded", function() {
        displayCart();
    });

    //Xu ly Add Item Button
    function addItem(product, price) {
        //Lay gio hang hoac tao mang rong
        let cart = JSON.parse(localStorage.getItem("cartList")) || []; //cart dang la 1 mang lay tu cartList chua cac item
        //Kiem tra xem san pham da duoc chon hay chua
        if(cart.includes(product)) {
            document.getElementById("message").textContent = "This product has been selected!";
            return;
        };
        //neu chua thi them san pham vao cart (gio hang)
        cart.push(product);
        //cap nhat lai cart (gio hang)
        localStorage.setItem("cartList", JSON.stringify(cart)); //chuyen mang cart thanh string de luu vao danh sach local
        //xoa thong bao 
        document.getElementById("message").textContent = "";
        //cap nhat gio hang
        displayCart();
    }

    // Cập nhật danh sách giỏ hàng
    function displayCart() {
        let cart = JSON.parse(localStorage.getItem("cartList")) || [];
        const cartList = document.getElementById("cartList");
        cartList.innerHTML = "";

        cart.forEach((item, index) => {
            const newLI = document.createElement("li");

            // Phần tên sản phẩm
            const productName = document.createElement("span");
            productName.classList.add("product-name");
            productName.textContent = item;

            // Tạo div chứa các nút bấm
            const btnGroup = document.createElement("div");
            btnGroup.classList.add("btn-group");

            // Ô chọn check box
            const checkbox = document.createElement("input");
            checkbox.type = "checkbox";
            checkbox.classList.add("checkbox");
            checkbox.dataset.index = index; //Gan index de  lay du lieu 

            //nut buy
            const sell_btn = document.createElement("button");
            sell_btn.textContent = "Buy";
            sell_btn.classList.add("buy-btn");
            sell_btn.addEventListener("click", function () {
            buyItem(item);
            });


            // Nút "Remove"
            const remove_btn = document.createElement("button");
            remove_btn.textContent = "Remove";
            remove_btn.classList.add("remove-btn");
            remove_btn.addEventListener("click", function() {
                removeFromCart(index);
            });

            // Thêm các nút vào btnGroup
            btnGroup.appendChild(sell_btn);
            btnGroup.appendChild(remove_btn);

            // Gán các phần tử vào <li>
            newLI.appendChild(checkbox);
            newLI.appendChild(productName);
            newLI.appendChild(btnGroup);

            cartList.appendChild(newLI);
        });
    }
    //Xu ly nut removeFromCart
    function removeFromCart(index) {
        const cart = JSON.parse(localStorage.getItem("cartList"));
        cart.splice(index, 1);
        localStorage.setItem("cartList", JSON.stringify(cart));
        document.getElementById("message").textContent = "";
        displayCart();
    }
    //Xu ly ham xoa gio hang
    function removeCart() {
        let cart = JSON.parse(localStorage.getItem("cartList")) || [];
        localStorage.removeItem("cartList");
        document.getElementById("message").textContent = "";
        displayCart();
    }
    //Xu ly nut mua hang

    function buyItem(item) {
        Swal.fire({
            title: "Purchase Successful!",
            text: item + " has been purchased!",
            icon: "success",
            confirmButtonText: "OK",
            confirmButtonColor: "#007bff",
        });

        document.getElementById("message").textContent = "";
        displayCart();
    }
