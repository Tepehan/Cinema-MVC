
 import * as bootstrap from 'bootstrap'
var multipleCardCarousel = document.querySelector(
  "#carouselExampleControls"
);
if (window.matchMedia("(min-width: 768px)").matches) {
  var carousel = new bootstrap.Carousel(multipleCardCarousel, {
    interval: false,
  });
  var carouselWidth = $(".mcontent .carousel-inner")[0].scrollWidth;
  console.log("carouselWidth "+carouselWidth);
  var cardWidth = $(".mcontent .carousel-item").width();
  console.log("cardWidth "+cardWidth);
  var scrollPosition = 0;
  var cardSlideIndex=9;
  $("#carouselExampleControls .carousel-control-next").on("click", function () {
    console.log("scrollPosition "+scrollPosition);
    var count=(carouselWidth/cardWidth);
   // if (scrollPosition < carouselWidth - cardWidth * 4) {
    if (cardSlideIndex<=count) {
      cardSlideIndex++;
      scrollPosition += cardWidth;
      $("#carouselExampleControls .carousel-inner").animate(
        { scrollLeft: scrollPosition },
        600
      );
    }
  });
  $("#carouselExampleControls .carousel-control-prev").on("click", function () {
    
    //if (scrollPosition > 0) {
      if(cardSlideIndex>9){
        cardSlideIndex--;
      scrollPosition -= cardWidth;
      $("#carouselExampleControls .carousel-inner").animate(
        { scrollLeft: scrollPosition },
        600
      );
    }
  });
} else {
  $(multipleCardCarousel).addClass("slide");
}
