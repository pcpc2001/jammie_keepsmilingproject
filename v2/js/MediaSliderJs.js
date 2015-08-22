var currentIndex = 0;
var mediaCount = 0;
var currentLeftPercent = 10;
var dxPercent = 80;
var firstSlideId;
var initialLeftPercent = 10;

function init() {
    currentIndex = 0;
    mediaCount = 0;
}

function setMediaCount(count) {
    mediaCount = count;
}

function setFirstSlideId(firstId) {
    firstSlideId = firstId;
}

function getMediaCount() {
    return mediaCount;
}

function mediaSliderOnNavLeftClicked(){
    if (currentIndex == 0)
        return;
    var slides = document.getElementById("MediaSliderFrame");
    var contentSlide = slides.getElementsByClassName("ContentSlide");

    currentIndex--;
    currentLeftPercent = currentLeftPercent + dxPercent;

    for (i = 0; i < contentSlide.length; i++) {
        contentSlide[i].style.left = (currentLeftPercent) + "%";
    }
}

function mediaSliderOnNavRightClicked() {
    if (currentIndex == mediaCount - 1)
        return;
    //var slide = document.getElementById(firstSlideId);
    var slides = document.getElementById("MediaSliderFrame");
    var contentSlide = slides.getElementsByClassName("ContentSlide");

    currentIndex++;
    currentLeftPercent = currentLeftPercent - dxPercent;

    for (i = 0; i < contentSlide.length; i++) {
         contentSlide[i].style.left = (currentLeftPercent) + "%";
    }
}