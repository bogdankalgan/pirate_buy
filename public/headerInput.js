const button = document.getElementById("searchButton");

const input = document.getElementById("searchInput");

if (window.innerWidth === 375) {
  button.addEventListener("click", () => {
    if (input.style.display === "none" || input.style.display === "") {
      input.style.display = "inline-block";
      button.style.marginRight = "0";
    } else {
      input.style.display = "none";
      button.style.marginRight = "40px";
    }
  });
}
