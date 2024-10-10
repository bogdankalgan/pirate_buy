const btn = document.querySelector(".show-more");
const container = document.querySelector(".game-cards");

btn.addEventListener("click", () => {
  const card = document.createElement("div");
  card.classList.add("game-card");
  card.classList.add("game-card__hot");
  card.innerHTML = `<div class="game-card-img">
    <img src="img/game-card/1.png" alt="" style="padding: 1.4rem 2.9rem 1.6rem 3.4rem;"/>
    </div>
    
    <div class="game-card-text">
    <p class="game-card-title">Wotlk Classic Ulduar Raid</p>
    
    <ul class="game-card-list">
    <li class="game-card-list-item">Get any desired rank</li>
    
    <li class="game-card-list-item">Top 500 boost available</li>
    
    <li class="game-card-list-item">Earn Competitive Points</li>
    </ul>
    
    <div class="game-card-price">
    <div class="game-card-price-block">
    <p class="game-card-price-text">From</p>
    
    <p class="game-card-price-number">$44.25</p>
    </div>
    
    <button class="next-button">
    <i class="fa-solid fa-arrow-right"></i>
    </button>
    </div>
    </div>`;
  container.appendChild(card);

  const card2 = document.createElement("div");
  card2.classList.add("game-card");
  card2.classList.add("game-card__hot");
  card2.classList.add("game-card__sale");
  card2.innerHTML = `<div class="game-card-img">
              <img src="img/game-card/2.png" alt="" style="padding: 1.4rem 2.9rem 1.6rem 3.4rem"/>
            </div>

            <div class="game-card-text">
              <p class="game-card-title">
                Aberrus, the Shadowed Crucible Mythic
              </p>

              <ul class="game-card-list">
                <li class="game-card-list-item">Get any desired rank</li>

                <li class="game-card-list-item">Top 500 boost available</li>

                <li class="game-card-list-item">Earn Competitive Points</li>
              </ul>

              <div class="game-card-price">
                <div class="game-card-price-block" id="priceBlock">
                  <p class="game-card-price-text" id="priceText">From</p>

                  <p class="game-card-price-number" id="priceText2">$44.25</p>
                </div>

                <button class="next-button">
                  <i class="fa-solid fa-arrow-right"></i>
                </button>
              </div>
            </div>`;
  container.appendChild(card2);

  const card3 = document.createElement("div");
  card3.classList.add("game-card");
  card3.classList.add("game-card__new");
  card3.innerHTML = `<div class="game-card-img">
              <img src="img/game-card/3.png" alt="" style="padding: 4.8rem 6.1rem 4.4rem 6.5rem"/>
            </div>

            <div class="game-card-text">
              <p class="game-card-title">Legends Unlock Boost</p>

              <ul class="game-card-list">
                <li class="game-card-list-item">Get any desired rank</li>

                <li class="game-card-list-item">Top 500 boost available</li>

                <li class="game-card-list-item">Earn Competitive Points</li>
              </ul>

              <div class="game-card-price">
                <div class="game-card-price-block">
                  <p class="game-card-price-text">From</p>

                  <p class="game-card-price-number">$44.25</p>
                </div>

                <button class="next-button">
                  <i class="fa-solid fa-arrow-right"></i>
                </button>
              </div>
            </div>`;
  container.appendChild(card3);

  const card4 = document.createElement("div");
  card4.classList.add("game-card");
  card4.classList.add("game-card__new");
  card4.classList.add("game-card__hot");
  card4.innerHTML = `<div class="game-card-img">
              <img src="img/game-card/4.png" alt="" style="padding: 2.7rem 4.6rem 3.8rem 3.3rem "/>
            </div>

            <div class="game-card-text">
              <p class="game-card-title">Overwatch Unlock Competitive</p>

              <ul class="game-card-list">
                <li class="game-card-list-item">Get any desired rank</li>

                <li class="game-card-list-item">Top 500 boost available</li>

                <li class="game-card-list-item">Earn Competitive Points</li>
              </ul>

              <div class="game-card-price">
                <div class="game-card-price-block">
                  <p class="game-card-price-text">From</p>

                  <p class="game-card-price-number">$44.25</p>
                </div>

                <button class="next-button">
                  <i class="fa-solid fa-arrow-right"></i>
                </button>
              </div>
            </div>`;
  container.appendChild(card4);

  const cards = [card, card2, card3, card4];

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
});
