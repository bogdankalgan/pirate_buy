const cardModBtn = document.querySelector(
  ".header-card-mod-choose-game-button"
);

const cardModModal = document.querySelector(".card-mod-modal");

cardModBtn.addEventListener("click", () => {
  cardModBtn.classList.toggle("header-card-mod-choose-game-button__active");
  cardModModal.classList.toggle("card-mod-modal__active");
});
