const orderItemMoreButtons = document.querySelectorAll(".order-item-more");

orderItemMoreButtons.forEach((button) => {
  button.addEventListener("click", () => {
    const orderItem = button.closest(".order-item");

    orderItem.classList.toggle("order-item__active");
  });
});
