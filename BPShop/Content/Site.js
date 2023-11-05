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





