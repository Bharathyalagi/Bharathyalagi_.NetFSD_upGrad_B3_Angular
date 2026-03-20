function loadCart() {
  let cart = getCart();
  let html = "";
  let total = 0;
  cart.forEach((item, index) => {
    total += item.price;
    html += `
            <tr>
                <td>${item.name}</td>
                <td>₹${item.price}</td>
                <td>
                    <button class="btn btn-danger btn-sm removeItem" data-index="${index}">Remove</button>
                </td>
            </tr>
        `;
  });

  $("#cartItems").html(html);
  $("#totalAmount").text("₹" + total);
}

$(document).on("click", ".removeItem", function () {
  let index = $(this).data("index");
  let cart = getCart();
  cart.splice(index, 1);
  saveCart(cart);
  loadCart();
  updateCartCount();
});

$(document).ready(function () {
  if ($("#cartItems").length) {
    loadCart();
  }
});
