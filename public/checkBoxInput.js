const blocks = document.querySelectorAll(".basket-content-check-item");

blocks.forEach((block) => {
  block.addEventListener("click", () => {
    block.classList.toggle("basket-content-check-item__active");

    const input = block.querySelector(".basket-content-check-item > input");

    input.checked = !input.checked;
  });

  const input = block.querySelector(".basket-content-check-item > input");

  input.addEventListener("click", () => {
    block.classList.toggle("basket-content-check-item__active");
  });
});
