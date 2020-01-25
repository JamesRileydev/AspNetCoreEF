$(document).ready(function () {
    console.log("Hello");

    let theForm = $("#indexForm");
    theForm.hide();

    let buyButton = $("#buyButton");

    buyButton.on("click", function () {
        console.log("Buy Button clicked");
    });

    let productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text())
    });

    let loginToggle = $("#loginToggle");
    let popupForm = $(".popup-form");

    popupForm.hide();

    loginToggle.on("click", function () {
        popupForm.fadeToggle(1000);
    })
});