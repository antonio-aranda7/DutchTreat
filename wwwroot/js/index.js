$(document).ready(function () {// "(function () {" anonymus Function
    var x = 0;
    var s = "";

    console.log(" Pluralsight");



    /*var theForm = document.getElementById("theForm");
    theForm.hidden = false;*/

    //Jquery
    var theForm = $("#theForm");
    theForm.hide();

    /*var buyButton = document.getElementById("buyButton");
    buyButton.addEventListener("click", function() {
        alert("Buying item");
        console.log("Buying item");
    });*/

    //Jquery
    /**/var buyButton = $("#buyButton");
    buyButton.on("click", function () {
        console.log("Buying item");
        alert("Buying item");
    });



    /*var productInfo = document.getElementsByClassName("product-props");
    var listItems = productInfo.item[0].children;
    listItems.productInfo.item[0].children;*/

    //Jquery
    /**/var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        alert("You Clicked on " + this.innerText);
        console.log("You Clicked on " + $(this).text());
    });
    /**/
    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popupForm");

    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);
    })

});//"})();" anonymus Function