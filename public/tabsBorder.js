const tabsBorderItems = document.querySelectorAll(".tabs-border-item");

tabsBorderItems.forEach((item) => {
  item.addEventListener("click", () => {
    document.querySelectorAll(".tabs-border-item").forEach((element) => {
      element.classList.remove("tabs-border-item__active");

      item.classList.add("tabs-border-item__active");
    });
  });
});
