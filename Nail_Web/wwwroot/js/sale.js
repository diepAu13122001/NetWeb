const cartProducts = [
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/sonmongtron.jpg",
    imageOverlay: "image/sonmongtron0.png",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng",
    oldprice:"60.000đ",
    newprice:"50.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/salenew2.jpg",
    imageOverlay: "image/salenew1.jpg",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng Nnai",
    oldprice:"80.000đ",
    newprice:"70.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/salenew4.jpg",
    imageOverlay: "image/salenew31.jpg",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng",
    oldprice:"100.000đ",
    newprice:"90.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/mongchan4.jpg",
    imageOverlay: "image/toeNails1.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"Móng chân giả Nnail",
    oldprice:"120.000đ",
    newprice:"90.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/salenew5.jpg",
    imageOverlay: "image/salenew6.png",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng",
    oldprice:"80.000đ",
    newprice:"70.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/fakeNail1.jpg",
    imageOverlay: "image/fakeNails1Sale.png",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng màu xanh ngọc Nnail",
    oldprice:"80.000đ",
    newprice:"65.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/fakeNail2.jpg",
    imageOverlay: "image/fakeNails2Sale.png",
    iconStart: "bi-star-fill text-warning",
    title:"Móng tay giả cẩm thạch",
    oldprice:"110.000đ",
    newprice:"100.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/fakeNail3.jpg",
    imageOverlay: "image/fakeNails3Sale.png",
    iconStart: "bi-star-fill text-warning",
    title:"Móng tay giả nơ Nnail",
    oldprice:"150.000đ",
    newprice:"130.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/fakeNails4.jpg",
    imageOverlay: "image/fakeNails4Sale.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"Móng tay giả đính đá bản lớn",
    oldprice:"120.000đ",
    newprice:"110.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/sonmong10.jpg",
    imageOverlay: "image/sonmong10.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"Nước sơn móng Nnail",
    oldprice:"85.000đ",
    newprice:"75.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/sonmong11.jpg",
    imageOverlay: "image/sonmong11.jpg",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng Nnail",
    oldprice:"60.000đ",
    newprice:"50.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/sonmongtron0.jpg",
    imageOverlay: "image/sonmongtron0.jpg",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng",
    oldprice:"80.000đ",
    newprice:"70.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/sonmong.jpg",
    imageOverlay: "image/Sơnmóng4Sale.png",
    iconStart: "bi-star-fill text-warning",
    title:" Nước Sơn móng",
    oldprice:"80.000đ",
    newprice:"70.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/toeNail3.jpg",
    imageOverlay: "image/toeNails3Sale.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"Móng giả hột xoàn",
    oldprice:"130.000đ",
    newprice:"100.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/mongchancuoi.jpg",
    imageOverlay: "image/toeNails2.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"MÓng giả mặt cười",
    oldprice:"190.000đ",
    newprice:"155.000đ",
  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/mongchantrang.jpg",
    imageOverlay: "image/toeNails4.jpg",
    iconStart: "bi-star-fill text-warning",
    title:"Móng giả mặt trăng",
    oldprice:"180.000đ",
    newprice:"150.000đ",
  },


]
const product= cartProducts.map((item) => {
  var iconEye =[item.iconEye]
  var iconHeart =[item.iconHeart]
  var iconStart = "bi "+ [item.iconStart]
  return (`
            <div class="col-md-3 col-6">
                <div class="icon-produce position-absolute d-block">
                  <div class="w3-container">
                    <button class="icon-eye border-0 bg-white mt-3 w3-animate-right">
                     <i class="bi ${iconEye}">
                    </i>
                    </button>
                  </div>
                  <div class="w3-container">
                    <button class="icon-heart border-0 bg-white mt-1 w3-animate-right">
                        <i class= "bi ${iconHeart}" ></i>
                    </button>
                  </div>
                </div>
               <div class="container">
                 <img src= ${item.image} alt="Nnail" class="image">
                <div class="overlay">
                  <img src=${item.imageOverlay} alt="Nnail">
                </div>
                </div>
                  <div class="icon-start d-flex justify-content-center">
                    <i class="${iconStart} mx-1"></i>
                     <i class="${iconStart} mx-1"></i>
                    <i class="${iconStart} mx-1"></i>
                     <i cclass="${iconStart} mx-1"></i>
                      <i class="${iconStart} mx-1"></i>
                  </div>
                <div class="name-product mt-2 text-center">
                  <span class="name text-dark fw-normal" style="font-family: Arial">${item.title}</span>
                  <div class="price mt-4">
                    <span class="old-price fw-normal text-decoration-line-through">
                     ${item.oldprice}
                    </span>
                    <span class="new-price ms-1">
                    ${item.newprice}
                    </span>
                  </div>
                  <div class="w3-container mb-5">
                    <button class="w3-center w3-animate-bottom add-to-cart border-0 position-absolute ms-4" style="width: 180px">
                      <a class="text-decoration-none text-uppercase text-white" href="#">Thêm giỏ hàng</a></button>
                  </div>
                </div>
              </div>
            </div>
`
  );
})
document.getElementById("cart-product").innerHTML= product.join(" ");


const images = [
  {image: "../../img/monggia1.jpg"},
  {image: "../../img/3ce2.jpg"},
  {image: "../../img/monggia2.jpg"},
  {image: "../../img/nhumong2.jpg"},
  {image: "../../img/play4.jpg"},
  {image: "../../img/nhumong3.jpg"},
  {image: "../../img/rom6.jpg"},
  {image: "../../img/rom4.jpg"},
  {image: "../../img/nhumong1.jpg"},
  {image: "../../img/play2.jpg"},
];
document.getElementById("image-slide").innerHTML = images.map((item) => {
  var imageProduct = item.image;
  return ('<img class="mt-5 slideimages" src=" ' + imageProduct + ' "/>');
})
$(document).ready(function () {
  $(".slide-product").slick({
    infinite: true,
    autoplay: false,
    autoplaySpeed: 4000,
    dots: false,
    infinite: false,
    slidesToShow: 4,
    slidesToScroll: 4,
    prevArrow: '<button class="slide-arrow prev-arrow"><i class="bi bi-arrow-left-circle-fill"></i></button>',
    nextArrow: '<button class="slide-arrow next-arrow"><i class="bi bi-arrow-right-circle-fill"></i></button>',
    responsive: [
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 3,
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
      // You can unslick at a given breakpoint now by adding:
      // settings: "unslick"
      // instead of a settings object
    ]
  });
});

