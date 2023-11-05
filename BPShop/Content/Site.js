//slider
$('.slider').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    dots: true,
    autoplay: true,
    autoplaySpeed: 4000,
    responsive: [
        {
            breakpoint: 1300,
            settings: {
                speed: 600,
                cssEase: 'linear'
            }
        }
    ]
});

//drop menu
var showDropdownButton = document.getElementById("showDropdown");
var dropdown = document.getElementById("dropdown");
var pricema = document.getElementById("price-max");

showDropdownButton.addEventListener("click", function () {
    if (dropdown.style.display === "none" || dropdown.style.display === "") {
        dropdown.style.display = "block";
    } else {
        dropdown.style.display = "none";
    }
});
dropdown.addEventListener("click", function (event) {
    event.stopPropagation();
});
document.addEventListener("click", function (event) {
    if (event.target !== showDropdownButton && event.target !== dropdown
        && event.target !== priceRange && event.target !== pricema) {
        dropdown.style.display = "none";
    }
});






