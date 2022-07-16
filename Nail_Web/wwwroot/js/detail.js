const detailImage = [
  {image: "../../img/detail0.jpg"},
  {image: "../../img/detail1.jpg"},
  {image: "../../img/detail2.jpg"},
  {image: "../../img/detail3.jpg"},
  {image: "../../img/detail4.jpg"},
]
document.getElementById("slick-detail").innerHTML = detailImage.map((item) => {
  return (`<img src=${item.image} class="slide-image"/>`);
// || `<video  <source src=${item.image} type="video/mp4">/>`)
})
$(document).ready(function () {
  $(".slideshow").slick({
    customPaging: function (slick, index) {
      var imageDeatil = "../../../img/detail" + index.toString() + ".jpg";
      console.log(imageDeatil)
      return `<img src=${imageDeatil}/>`;
    },
    infinite: true,
    autoplay: false,
    arrows: true,
    autoplaySpeed: 4000,
    dots: true,
    infinite: false,
    slidesToShow: 1,
    slidesToScroll: 1,
  });
});
const choose_colors = [
  {color: 'Hồng phấn', style:"pink", number: '01'},
  {color: 'Hồng cánh sen',style:"purple", number: '02'},
  {color: 'Đen',style:"black", number: '03'},
  {color: 'Xanh ngọc',style:"green", number: '04'}
]
const colors = choose_colors.map((item) => {
  console.log(item.style)
  return `<button id="color-${item.number}"  style="background-color: ${item.style}; " class="colors mx-2 py-2 px-2 text-white rounded" onclick="handevend_${item.number}()"> ${item.color} </button>`
});
document.getElementById("choose-color").innerHTML = colors.join(" ");

function handevend_01() {
  document.getElementById("color-01").style.border = "2px solid #F70D0DFF"
  document.getElementById("color-02").style.border = "1px solid #cec9c9"
  document.getElementById("color-03").style.border = "1px solid #cec9c9"
  document.getElementById("color-04").style.border = "1px solid #cec9c9"

  console.log("nhi")
}

function handevend_02() {
  document.getElementById("color-02").style.border = "2px solid #F70D0DFF"
  document.getElementById("color-01").style.border = "1px solid #cec9c9"
  document.getElementById("color-03").style.border = "1px solid #cec9c9"
  document.getElementById("color-04").style.border = "1px solid #cec9c9"

  console.log("nhi")
}

function handevend_03() {
  document.getElementById("color-03").style.border = "2px solid #F70D0DFF"
  document.getElementById("color-02").style.border = "1px solid #cec9c9"
  document.getElementById("color-01").style.border = "1px solid #cec9c9"
  document.getElementById("color-04").style.border = "1px solid #cec9c9"
  console.log("nhi")
}

function handevend_04() {
  document.getElementById("color-04").style.border = "2px solid #F70D0DFF"
  document.getElementById("color-02").style.border = "1px solid #cec9c9"
  document.getElementById("color-03").style.border = "1px solid #cec9c9"
  document.getElementById("color-01").style.border = "1px solid #cec9c9"
  console.log("nhi")
}

let amount = 0;
let countid = document.getElementById("count")
countid.innerHTML = `${amount.toString()}`

function minius() {
  if (amount > 0) {
    amount = amount - 1;
    console.log("amount1", amount)
    countid.innerHTML = `${amount.toString()}`
  } else {
    amount = 0;
    countid.innerHTML = `${amount.toString()}`
  }
}

function add() {
  amount = amount + 1;
  console.log("amount2", amount)
  countid.innerHTML = `${amount.toString()}`

}

const images = [
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
          slidesToShow: 3,
          slidesToScroll: 3,
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
      // You can unslick at a given breakpoint now by adding:
      // settings: "unslick"
      // instead of a settings object
    ]
  });
});
