const changePageButton = document.querySelectorAll(".change-page-button");

changePageButton.forEach((button) => {
  button.addEventListener("click", () => {
    const changePageBtn = document.querySelectorAll(".change-page-button");
    changePageBtn.forEach((btn) => {
      btn.classList.remove("change-page-button__active");
    });
    button.classList.add("change-page-button__active");
  });
});
