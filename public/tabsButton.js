const tabsButtonBtn = document.querySelectorAll(".tabs-buttons-item");

tabsButtonBtn.forEach((item) => {
  item.addEventListener("click", () => {
    document.querySelectorAll(".tabs-buttons-item").forEach((element) => {
      element.classList.remove("tabs-buttons-item__active");

      item.classList.add("tabs-buttons-item__active");
    });
  });
});
