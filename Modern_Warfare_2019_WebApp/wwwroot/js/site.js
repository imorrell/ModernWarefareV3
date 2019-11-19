// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    var banner = $(".animate");

    for (var i = 0; i < 999; i++) {

        banner.css("opacity", "1");
        banner.animate({ left: 400 }, 1000);

        for (var k = 0; k < 5; k++) {
            banner.animate({ opacity: 0 }, 600);
            banner.animate({ opacity: 1 }, 600);
        }

        banner.delay(2000).animate({ left: 1200 }, 1000);
        banner.animate({ left: -600 }, 0);
    }
}); 


//This function is used for the index file to show soldier layout options
//based on the user dropdown list selection
$(function () {
    $('.form-control').change(function () {
        $('.Descriptions').hide();
        $('#' + $(this).val()).show();
    });
});


function myFunction() {
    var x;
    var text;

    // Get the value of the input field with id="numb"
    x = document.getElementById("number").value;

    // If x is Not a Number or less than one or greater than 0
    if (isNaN(x) || x < 0) {
        text = "Input not valid! Please enter a number greater or equal then 0.";
    }
    document.getElementById("validation").innerHTML = text;
}
