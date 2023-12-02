//slider
if ($('.slider').length > 0) {
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
}


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


    // Скрываем все списки при загрузке страницы
    $(".burger-menu-list").hide();
    $(".burger-long-menu-list").hide();

    // Обрабатываем клики на кнопках
    $("#raznoe-button").click(function () {
        $("#bukety-list, #cvety-list, #menu_list").slideUp();
        $("#raznoe-list").slideToggle();
    });

    $("#bukety-button").click(function () {
        $("#raznoe-list, #cvety-list, #menu_list").slideUp();
        $("#bukety-list").slideToggle();
    });

    $("#cvety-button").click(function () {
        $("#bukety-list, #raznoe-list, #menu_list").slideUp();
        $("#cvety-list").slideToggle();
    });

    $("#menu_button").click(function () {
        $("#bukety-list, #cvety-list, #raznoe-list").slideUp();
        $("#menu_list").slideToggle();
    });

function showLoader() {
    $(".bg-loader").show();
}

function hideLoader() {
    $(".bg-loader").hide();
}

$(document).ready(function () {
    hideLoader();
});


function Search() {
    showLoader();
    var params = {
        search: document.getElementById("searchInpt").value
    }
    window.location.href = 'Home/Products?' + $.param(params);
}

if ($('#searchInpt').length > 0) {
    $('#searchInpt').on('keydown', function (event) {
        if (event.key === 'Enter') {
            Search();
        }
    });
}
