const products = [
  {
    index: "01",
    image: "../../img/3ce1.jpg",
    description1: "Sơn 3CE",
    description2: "K091",
    description3: "100ml",
    price: "150.000đ",
    count: "1",
    totalprice: "150.000đ",
    iconeye: "bi bi-eye-fill",
    icondetail: "bi bi-pencil-fill",
    icondete: "bi bi-trash-fill",
  },
  {
    index: "02",
    image: "../../img/monggia1.jpg",
    description1: "Móng giả",
    description2: "K001",
    description3: " ",
    price: "50.000đ",
    count: "2",
    totalprice: "100.000đ",
    iconeye: "bi bi-eye-fill",
    icondetail: "bi bi-pencil-fill",
    icondete: "bi bi-trash-fill",
  },
  {
    index: "03",
    image: "../../img/nhumong1.jpg",
    description1: "Nhũ móng",
    description2: "KH81",
    description3: " ",
    price: "60.000đ",
    count: "3",
    totalprice: "180.000đ",
    iconeye: "bi bi-eye-fill",
    icondetail: "bi bi-pencil-fill",
    icondete: "bi bi-trash-fill",
  },

]
const product = products.map((item) => {
  return (`
       <tr>

        <td>${item.index} </td>
         <th><img src="${item.image}" alt="Nnail" style="width: 200px; height: 200px"></th>
        <td><p>${item.description1}</p><p>${item.description2}</p><p>${item.description3}</p></td>
        <td>${item.price}</td>
        <td>
         <div class="d-flex button-group-count">
           <button onclick="minius()" class="fw-bold fs-5 text-black">-</button>
           <button id="count">${item.count}</button>
           <button onclick="add()" class="fw-bold fs-5 text-black">+</button>
         </div></td>
         <td>${item.totalprice}</td>
        <td><span><i class="text-warning ${item.iconeye} "></i></span>
        <button type="button" class="btn" data-bs-toggle="modal" data-bs-target="#exampleModal1">
            <span><i class="text-danger ${item.icondete}"></i></span>
            </button>
            <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Xóa sản phẩm</h5>
                  </div>
                  <div class="modal-body">
                  Bạn có muốn xóa sản phẩm này không ?
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Trở về</button>
                    <button type="button" class="btn btn-danger">Xóa</button>
                  </div>
                </div>
              </div>
            </div>
      </tr>
`
  );
})
document.getElementById('tabel-product').innerHTML = product.join(" ");

const cart = products.map((item) => {
  return (`
      <div class="d-flex d-flex justify-content-center w-100">
      <img src="${item.image}" alt="Nnail" style="width: 150px; height: 150px">
        <div class="px-5">
         <div><p>${item.description1}</p><p>${item.description2}</p><p>${item.description3}</p></div>
                <span>Giá: ${item.price}</span>
              <button type="button" class="btn" data-bs-toggle="modal" data-bs-target="#exampleModal1">
            <span><i class="text-danger ${item.icondete}"></i></span>
            </button>
            <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Xóa sản phẩm</h5>
                  </div>
                  <div class="modal-body">
                  Bạn có muốn xóa sản phẩm này không ?
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Trở về</button>
                    <button type="button" class="btn btn-danger">Xóa</button>
                  </div>
                </div>
              </div>
            </div>
          </div>
      </div>`
  );
})
document.getElementById('cart-products').innerHTML = cart.join(" ");
const images = [
  // {image: <img src="https://cdn.shopify.com/s/files/1/2267/2385/products/pinkholographicglitteracrylic2_360x.jpg?v=1635763034"/>},
  {image: "../../img/3ce1.jpg"},
  {image: "../../img/play1.jpg"},
  {image: "../../img/imagenail1.jpg"},
  {image: "../../img/innisfree1.jpg"},
  {image: "../../img/play2.jpg"},
  {image: "../../img/detail5.jpg"},
];
document.getElementById("image-slide").innerHTML = images.map((item) => {
  var imageProduct = item.image;
  return ('<a href="#"><img class="mt-5" src=" ' + imageProduct + ' "/></a>');
})
$(document).ready(function () {
  $(".slide-product").slick({
    infinite: false,
    autoplay: false,
    autoplaySpeed: 4000,
    dots: false,
    slidesToShow: 4,
    slidesToScroll: 4,
    prevArrow: '<button class="slide-arrow prev-arrow"><i class="bi bi-arrow-left-circle-fill"></i></button>',
    nextArrow: '<button class="slide-arrow next-arrow"><i class="bi bi-arrow-right-circle-fill"></i></button>',
    responsive: [
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 2,
          infinite: true,
        }
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1
        }
      },
      {
        breakpoint: 480,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1
        }
      }
    ]
  });
});
