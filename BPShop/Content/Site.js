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

document.addEventListener('DOMContentLoaded', function () {
});



function incrementQuantity() {
    var quantityInput = document.getElementById("quantity");
    quantityInput.value = parseInt(quantityInput.value, 10) + 1;
}

function decrementQuantity() {
    var quantityInput = document.getElementById("quantity");
    if (parseInt(quantityInput.value, 10) > 1) {
        quantityInput.value = parseInt(quantityInput.value, 10) - 1;
    }
}


