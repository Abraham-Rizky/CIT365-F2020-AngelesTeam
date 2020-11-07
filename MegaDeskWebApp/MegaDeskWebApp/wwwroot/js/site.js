// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// Code for tool tip with images
var Path = '/images/';
var ImgAry = new Array('image_filler.png', 'oak_3.png', 'laminate_2.png', 'pine_2.png', 'rosewood_2.png', 'veneer_2.png');

function Swap(obj, id) {
    var i = obj.selectedIndex;
    if (i < 1) { return; }
    document.getElementById(id).src = Path + ImgAry[i];
}