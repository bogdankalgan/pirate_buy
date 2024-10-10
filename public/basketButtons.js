const buttons1 = document.querySelectorAll("#buttons1 > button");

buttons1.forEach((button) => {
  button.addEventListener("click", () => {
    document.querySelectorAll("#buttons1 > button").forEach((btn) => {
      btn.classList.remove("basket-content-choose-button__active");
    });

    button.classList.add("basket-content-choose-button__active");
  });
});

const buttons2 = document.querySelectorAll("#buttons2 > button");

buttons2.forEach((button) => {
  button.addEventListener("click", () => {
    document.querySelectorAll("#buttons2 > button").forEach((btn) => {
      btn.classList.remove("basket-content-choose-button__active");
    });

    button.classList.add("basket-content-choose-button__active");
  });
});

const buttons3 = document.querySelectorAll("#buttons3 > button");

buttons3.forEach((button) => {
  button.addEventListener("click", () => {
    document.querySelectorAll("#buttons3 > button").forEach((btn) => {
      btn.classList.remove("basket-content-choose-button__active");
    });

    button.classList.add("basket-content-choose-button__active");
  });
});
