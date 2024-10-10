window.addEventListener("DOMContentLoaded", () => {
  const text = document.getElementById("titleFirst");
  const titleSecond = document.getElementById("titleSecond");
  const whyTitle = document.getElementById("whyTitle");
  const why = document.querySelector(".why");
  const faq = document.getElementById("faq");
  const faqContainer = document.getElementById("faqContainer");
  const modal = document.querySelector(".modal");
  const payment = document.querySelector(".payment");
  const payTitle = document.querySelector("#paymentTitle");
  const reason = document.querySelector(".reason");
  const reviewsTitle = document.getElementById("reviewsTitle");

  if (window.innerWidth == 375) {
    text.style.marginBottom = "24px";
    titleSecond.style.marginBottom = "8px";
    whyTitle.style.marginBottom = "31px";
    why.style.marginBottom = "47px";
    faq.style.textAlign = "center";
    faq.style.marginBottom = "1.8rem";
    faqContainer.style.marginBottom = "90px";
    modal.style.marginBottom = "90px";
    payTitle.style.marginBottom = "2rem";
    payment.style.marginBottom = "9rem";
    reason.style.marginBottom = "4rem";
    reviewsTitle.style.marginBottom = "1.5rem";
  }
});
