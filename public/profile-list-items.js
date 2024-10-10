const profileItems = document.querySelectorAll(".profile-window-top-list-item");

profileItems.forEach((item) => {
  item.addEventListener("click", () => {
    item.classList.toggle("profile-window-top-list-item__active");
  });
});
