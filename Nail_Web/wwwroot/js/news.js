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
  return ('<img class="mt-5" src=" ' + imageProduct + ' "/>');
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
        breakpoint: 768,
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
