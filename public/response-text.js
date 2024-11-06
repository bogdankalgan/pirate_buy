window.addEventListener("DOMContentLoaded", () => {
  const textElement = document.querySelector(
    ".blog-article-check > .title-secondary"
  );

  if ((window.innerWidth = 375)) {
    textElement.textContent = "HOT BOOST";
  }
});
