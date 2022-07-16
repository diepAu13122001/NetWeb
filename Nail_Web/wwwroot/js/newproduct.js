const cartProducts = [
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "image/botnhungmong.jpg",
    imageOverlay: "image/dadinhnails1.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/3ce3.jpg",
    imageOverlay: "../../img/3ce4.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/play1.jpg",
    imageOverlay: "../../img/play3.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/nhumong4.jpg",
    imageOverlay: "../../img/nhumong5.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/monggia3.jpg",
    imageOverlay: "../../img/monggia4.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/dungcu1.jpg",
    imageOverlay: "../../img/dungcu3.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/monggia5.jpg",
    imageOverlay: "../../img/monggia6.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/nhumong6.jpg",
    imageOverlay: "../../img/nhumong7.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/monggia7.jpg",
    imageOverlay: "../../img/monggia8.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/3ce3.jpg",
    imageOverlay: "../../img/3ce4.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/play1.jpg",
    imageOverlay: "../../img/play3.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/nhumong4.jpg",
    imageOverlay: "../../img/nhumong5.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/monggia3.jpg",
    imageOverlay: "../../img/monggia4.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/dungcu1.jpg",
    imageOverlay: "../../img/dungcu3.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/monggia5.jpg",
    imageOverlay: "../../img/monggia6.jpg",
    iconStart: "bi-star-fill text-warning",

  },
  {
    iconEye: "bi-eye",
    iconHeart: "bi-heart",
    image: "../../img/nhumong6.jpg",
    imageOverlay: "../../img/nhumong7.jpg",
    iconStart: "bi-star-fill text-warning",

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
                  <span class="name text-dark fw-normal">Base Foundation</span>
                  <div class="price mt-4">
                    <span class="old-price fw-normal text-decoration-line-through">
                      $12.99
                    </span>
                    <span class="new-price ms-2">
                    $10.00
                    </span>
                  </div>
                  <div class="w3-container mb-5">
                    <button class="w3-center w3-animate-bottom add-to-cart border-0 position-absolute ms-5">
                      <a class="text-decoration-none text-uppercase text-white" href="#">add to cart</a></button>
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
      // You can unslick at a given breakpoint now by adding:
      // settings: "unslick"
      // instead of a settings object
    ]
  });
});

