// nếu chưa đăng nhâpj bấm icon hình người sẽ ra model đăng nhập, nếu đã đăng nhập bấm ra trang tài khoản của tôi
function handelSubmit() {
  var valueEmail = document.getElementById("email");
  var valuePassword = document.getElementById("password");
  var closeModal = document.getElementById("exampleModal")
  console.log(valuePassword.value)
  console.log(valueEmail.value)
  if (valueEmail.value === "" || valuePassword.value === "") {
    alert("Please re-enter your email and password");
  } else {
    $('#exampleModal').modal('hide');
  }
}

const titles = [
  {
    h5: "Comapay agents house real estate",
    p: "ed vitae placerat velit, non semper nib Mae cenas pharetra risus vitae sodales vulputate. Praesent accumsan, mi necorem Ipsumsus vitae sodales vulputate. Praesentaccumsan, The passage is attributed to an unknown typesetter in the 15th century.",
    h3: "Daisy Thi",
    span: "Technical"
  },
  {
    h5: "Comapay agents house real estate",
    p: "ed vitae placerat velit, non semper nib Mae cenas pharetra risus vitae sodales vulputate. Praesent accumsan, mi necorem Ipsumsus vitae sodales vulputate. Praesentaccumsan, The passage is attributed to an unknown typesetter in the 15th century.",
    h3: "Thuy Ngan",
    span: "Technical"
  },
  {
    h5: "Comapay agents house real estate",
    p: "ed vitae placerat velit, non semper nib Mae cenas pharetra risus vitae sodales vulputate. Praesent accumsan, mi necorem Ipsumsus vitae sodales vulputate. Praesentaccumsan, The passage is attributed to an unknown typesetter in the 15th century.",
    h3: "Diem Ngan",
    span: "Technical"
  },
];
document.getElementById("slick-team").innerHTML = titles.map((item) => {
  return (`
            <div class="card-body text-center">
              <h5>${item.h5}</h5>
              <p class="card-text text-muted fw-normal mt-2">${item.p}</p>
              <h3 class="mb-4">${item.h3}</h3>
              <span>${item.span}</span>
            </div>`);
})
$(document).ready(function () {
  $(".slideshow").slick({
    customPaging: function (slick, index) {
      var imagePerson = "../../../img/image" + index.toString() + ".jpg";
      return `<img src=${imagePerson}/>`;
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
const listService = [
  {
    icon: "bi bi-box-seam",
    h5: "Free Delivery",
    span: "Lorem Ipsum is simply dummy <br> text of the Testing online.",
  },
  {
    icon: "bi bi-handbag",
    h5: "Way to buy",
    span: "Lorem Ipsum is simply dummy <br> text of the Testing online.",
  },
  {
    icon: "bi bi-person",
    h5: "Personal Session",
    span: "Lorem Ipsum is simply dummy <br> text of the Testing online.",
  },
  {
    icon: "bi bi-gift",
    h5: "Gift Voucher",
    span: "Lorem Ipsum is simply dummy <br> text of the Testing online.",
  },
]
const service = listService.map((item) => {
  return (`
            <div class="col-md-3 text-center">
                <a class="icon-service text-decoration-none mt-5 text-center" href="#">
                  <div class="icon mt-5">
                    <i class="${item.icon} fw-bold"></i>
                  </div>
                  <h5 class="fw-bold">${item.h5}</h5>
                  <span class="text-muted fw-normal text-center">${item.span}</span>
                </a>
              </div>`);
})
document.getElementById("service").innerHTML = service.join(" ");

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


const listCategory = [
  {
    id: 1,
    image: "../../img/sonmong4.jpg",
    dis: "block"
  },
  {
    id: 2,
    image: "../../img/sonmong3.jpg",
    dis: "block"
  },
  {
    id: 3,
    image: "../../img/sonmong2.jpg",
    dis: "block"
  },
  {
    id: 4,
    image: "../../img/monggia9.jpg",
    dis: "none"
  },
  {
    id: 5,
    image: "../../img/monggia10.jpg",
    dis: "none"
  },
  {
    id: 6,
    image: "../../img/monggia11.jpg",
    dis: "none"
  },
  {
    id: 7,
    image: "../../img/nhumong10.jpg",
    dis: "none"
  },
  {
    id: 8,
    image: "../../img/nhumong9.jpg",
    dis: "none"
  },
  {
    id: 9,
    dis: "none",
    image: "../../img/nhumong8.jpg",

  },
]
const listcategory = listCategory.map((item) => {
  return (`
           <div class="col-md-4 text-center" id="category-${item.id}"  style="display: ${item.dis}">
              <div class="parent w-100 mx-auto">
                <div class="title" >
                  <img
                    src=${item.image} class="image border"
                    alt="Nnail">
                </div>
              </div>
            </div>`);
})
document.getElementById("categorys").innerHTML = listcategory.join(" ");

var x1 = document.getElementById("category-1");
var x2 = document.getElementById("category-2");
var x3 = document.getElementById("category-3");
var x4 = document.getElementById("category-4");
var x5 = document.getElementById("category-5");
var x6 = document.getElementById("category-6");
var x7 = document.getElementById("category-7");
var x8 = document.getElementById("category-8");
var x9 = document.getElementById("category-9");

function category1() {

  if (x1.style.display === "none" && x2.style.display === "none" && x3.style.display === "none") {
    x1.style.display = "block";
    x2.style.display = "block";
    x3.style.display = "block";
    x4.style.display = "none";
    x5.style.display = "none";
    x6.style.display = "none";
    x7.style.display = "none";
    x8.style.display = "none";
    x9.style.display = "none";
  } else {
    x1.style.display = "block";
    x2.style.display = "block";
    x3.style.display = "block";
    x4.style.display = "none";
    x5.style.display = "none";
    x6.style.display = "none";
    x7.style.display = "none";
    x8.style.display = "none";
    x9.style.display = "none";
  }
}

function category2() {

  if (x4.style.display === "none" && x5.style.display === "none" && x6.style.display === "none") {
    x4.style.display = "block";
    x5.style.display = "block";
    x6.style.display = "block";
    x1.style.display = "none";
    x2.style.display = "none";
    x3.style.display = "none";
    x7.style.display = "none";
    x8.style.display = "none";
    x9.style.display = "none";
  } else {
    x4.style.display = "block";
    x5.style.display = "block";
    x6.style.display = "block";
    x1.style.display = "none";
    x2.style.display = "none";
    x3.style.display = "none";
    x7.style.display = "none";
    x8.style.display = "none";
    x9.style.display = "none";
  }
}

function category3() {
  if (x7.style.display === "none" && x8.style.display === "none" && x9.style.display === "none") {
    x7.style.display = "block";
    x8.style.display = "block";
    x9.style.display = "block";
    x4.style.display = "none";
    x5.style.display = "none";
    x6.style.display = "none";
    x1.style.display = "none";
    x2.style.display = "none";
    x3.style.display = "none";

  } else {
    x7.style.display = "block";
    x8.style.display = "block";
    x9.style.display = "block";
    x4.style.display = "none";
    x5.style.display = "none";
    x6.style.display = "none";
    x1.style.display = "none";
    x2.style.display = "none";
    x3.style.display = "none";
  }
}

const videos = [
  {video: "../../img/video1.mp4"},
  {video: "../../img/video2.mp4"},
  {video: "../../img/video3.mp4"},
  {video: "../../img/video4.mp4"}

];
videoss = videos.map((item) => {
  var videoProduct = item.video;
  return (`<div class="col-md-3 d-flex justify-content-center">
             <video  controls>
                <source src=${item.video} type="video/mp4">
              </video>
            </div>`)
})
document.getElementById("video-slide").innerHTML = videoss.join(" ");