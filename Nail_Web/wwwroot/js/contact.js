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
          slidesToShow: 2,
          slidesToScroll: 2
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
