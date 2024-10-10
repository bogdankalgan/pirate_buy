const cards = document.querySelectorAll(".game-card");

for (let card of cards) {
  if (card.classList.contains("game-card__hot")) {
    const img = card.querySelector(".game-card-img");
    const firstLi = card.querySelector(".game-card-list li:first-child");
    if (firstLi) {
      firstLi.style.color = "#539415";
    }
    if (img) {
      const item = document.createElement("div");
      item.classList.add("game-card__hot-item");
      item.innerHTML = `<i class="fa-solid fa-bomb"></i> Hot`;

      img.appendChild(item);
    }
  }

  if (card.classList.contains("game-card__new")) {
    const img = card.querySelector(".game-card-img");
    const firstLi = card.querySelector(".game-card-list li:first-child");
    if (firstLi) {
      firstLi.style.color = "#539415";
    }
    if (img) {
      const item = document.createElement("div");
      item.classList.add("game-card__new-item");
      item.innerHTML = `<i class="fa-solid fa-bolt"></i> New`;

      img.appendChild(item);
    }
  }

  if (card.classList.contains("game-card__sale")) {
    const img = card.querySelector(".game-card-img");
    const text = card.querySelector(".game-card-price-text");
    const firstLi = card.querySelector(".game-card-list li:first-child");
    if (firstLi) {
      firstLi.style.color = "#F36B25";
    }
    if (text) {
      text.remove();
    }
    const text2 = card.querySelector(".game-card-price-number");
    if (text2) {
      text2.remove();
    }
    const block = card.querySelector(".game-card-price-block");
    block.style.alignItems = "center";
    const textGreen = document.createElement("p");
    textGreen.classList.add("game-card__sale-green");
    textGreen.innerHTML = `$90.21`;
    block.appendChild(textGreen);
    const saleNum = document.createElement("p");
    saleNum.classList.add("game-card__sale-sale");
    saleNum.innerHTML = ` $115.52 `;
    block.appendChild(saleNum);
    if (img) {
      const item = document.createElement("div");
      item.classList.add("game-card__sale-item");
      item.innerHTML = `Save 10%`;

      img.appendChild(item);
    }
  }
}
