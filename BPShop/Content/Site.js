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


function incrementQuantity(id) {
    updateCost(id, true);
    var quantityInput = document.getElementById("quantity_" + id);
    quantityInput.value = parseInt(quantityInput.value, 10) + 1;
}

function decrementQuantity(id) {
    updateCost(id, false);
    var quantityInput = document.getElementById("quantity_" + id);
    if (parseInt(quantityInput.value, 10) > 1) {
        quantityInput.value = parseInt(quantityInput.value, 10) - 1;
    }
}

function updateCost(productId, isPlus) {
    var quantity = parseInt($("#quantity_" + productId).val());
    if (!isPlus && quantity == 1)
        return;

    var productCost = parseInt($("#productCostId_" + productId).text());
    var totalCost = parseFloat($("#cost").text());
    var newCost = totalCost;

    if (isPlus)
        newCost = productCost + totalCost;
    else
        newCost = totalCost - productCost;
    $("#cost").text(newCost); 
}


