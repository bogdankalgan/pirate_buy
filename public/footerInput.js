const footerInput = document.getElementById("footerInput");
const label = document.getElementById("footerLabel");

// Обработка ввода текста
footerInput.addEventListener("input", () => {
  if (footerInput.value.trim() !== "") {
    label.classList.add("hidden-label");
    footerInput.style.paddingLeft = "2.1rem";
  } else {
    label.classList.remove("hidden-label");
    if (window.innerWidth == 375) {
      footerInput.style.paddingLeft = "4.7rem";
    } else {
      footerInput.style.paddingLeft = "6.1rem";
    }
  }
});

// Показ лейбла при потере фокуса, если инпут пуст
footerInput.addEventListener("blur", () => {
  if (footerInput.value.trim() === "") {
    label.classList.remove("hidden-label");
    if (window.innerWidth == 375) {
      footerInput.style.paddingLeft = "4.7rem";
    } else {
      footerInput.style.paddingLeft = "6.1rem";
    }
  }
});

const form = document.querySelector(".footer-form");

form.addEventListener("click", (form) => {
  form.preventDefault();
});
