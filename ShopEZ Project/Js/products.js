function loadProducts() {
  $.getJSON("data/products.json", function (products) {
    let html = "";

    products.forEach((p) => {
      html += `
                <div class="col-md-4 mb-4">
                    <div class="card product-card">
                        <img src="${p.image}" class="card-img-top product-img">
                        <div class="card-body">
                            <h5>${p.name}</h5>
                            <p>₹${p.price}</p>
                            <a href="product-details.html?id=${p.id}" class="btn btn-primary btn-sm">View Details</a>
                            <button class="btn btn-success btn-sm addCart" data-id="${p.id}">Add to Cart</button>
                        </div>
                    </div>
                </div>
            `;
    });

    $("#productList").html(html);
  });
}

$(document).on("click", ".addCart", function () {
  let id = $(this).data("id");

  $.getJSON("data/products.json", function (products) {
    let product = products.find((p) => p.id == id);
    let cart = getCart();
    cart.push(product);
    saveCart(cart);
    updateCartCount();

    $("body").append(`
            <div class="alert alert-success position-fixed top-0 end-0 m-3">
                Item added to cart
            </div>
        `);

    setTimeout(() => {
      $(".alert").fadeOut(300, function () {
        $(this).remove();
      });
    }, 1500);
  });
});

$(document).ready(function () {
  if ($("#productList").length) {
    loadProducts();
  }
});
