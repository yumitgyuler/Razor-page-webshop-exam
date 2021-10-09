function changeImage(element) {
  var main_prodcut_image = document.getElementById(element.id);
  main_prodcut_image.src = element.src;
}

function showMe(box) {
  var chboxs = document.getElementsByName("BillingAdress.ShipToOtherAdress");
  var vis = "none";
  for (var i = 0; i < chboxs.length; i++) {
    if (chboxs[i].checked) {
      vis = "block";
      break;
    }
  }
  document.getElementById(box).style.display = vis;
}

$(document).ready(function () {
  var quantitiy = 0;
  $(".quantity-right-plus").click(function (e) {
    e.preventDefault();

    var quantity = parseInt($("#quantity").val());
    var max = parseInt($("#quantity").attr("max"));
    if (quantity !== max) {
      $("#quantity").val(quantity + 1);
    }
  });

  $(".quantity-left-minus").click(function (e) {
    e.preventDefault();

    var quantity = parseInt($("#quantity").val());

    if (quantity > 0) {
      $("#quantity").val(quantity - 1);
    }
  });
});

$(function () {
  $('input:radio[name="cartItem.Id"]').change(function () {
    $("#addToCart").removeAttr("disabled");
  });
});
