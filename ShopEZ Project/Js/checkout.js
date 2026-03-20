$(document).ready(function () {
  let cart = getCart();
  let total = 0;

  cart.forEach((item) => {
    total += item.price;
  });

  $("#orderTotal").text("₹" + total);

  $("#checkoutForm").submit(function (e) {
    e.preventDefault();

    let cart = getCart();

    if (cart.length === 0) {
      alert("Cart cannot be empty. Please add products before placing order.");
      return;
    }

    alert("Order placed successfully");
    localStorage.removeItem("cart");
    window.location.href = "index.html";
  });
});
