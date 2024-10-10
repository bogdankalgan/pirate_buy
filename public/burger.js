const burgerBtn = document.getElementById("burgerButton");
const icon = document.getElementById("burgerButtonIcon");
const burger = document.getElementById("burger");

burgerBtn.addEventListener("click", () => {
  burgerBtn.classList.toggle("header-burger-button__active");
  burger.classList.toggle("header-burger__active");
});
