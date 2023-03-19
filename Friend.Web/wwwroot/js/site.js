// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $(".banner").vegas(
        {
        

        slides: [
           
            { src: "./images/dog.jpg" },
            { src: "./images/couple.jpg" },
            { src: "./images/cake.jpg" },
            { src: "./images/gift.jpg" }
            ]
            
    });
})

