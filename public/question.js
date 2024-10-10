const faqCards = document.querySelectorAll(".faq-question");

faqCards.forEach((item) => {
  item.addEventListener("click", () => {
    item.classList.toggle("faq-question__active");
  });
});
