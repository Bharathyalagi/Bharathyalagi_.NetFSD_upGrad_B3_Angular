function getCart() {
  return JSON.parse(localStorage.getItem("cart")) || [];
}

function saveCart(cart) {
  localStorage.setItem("cart", JSON.stringify(cart));
}

function updateCartCount() {
  let cart = getCart();
  $("#cartCount").text(cart.length);
}

$(document).ready(function () {
  updateCartCount();
});
