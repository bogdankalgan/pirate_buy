// Подожди, пока DOM полностью загрузится
window.addEventListener("DOMContentLoaded", () => {
  const profileCashbackItems = document.querySelectorAll(
    ".profile-cashback-item"
  );
  const profileCashbackCoins = document.querySelector(
    ".profile-cashback-window-cashback-right-text"
  );

  // Добавь обработчик события для каждого элемента
  profileCashbackItems.forEach((item) => {
    item.addEventListener("click", () => {
      // Убираем класс активности со всех элементов
      profileCashbackItems.forEach((element) => {
        element.classList.remove("profile-cashback-item__active");
      });

      // Добавляем класс активности к выбранному элементу
      item.classList.add("profile-cashback-item__active");

      // Получаем текстовое содержимое элемента
      const coinValue = item
        .querySelector(".profile-cashback-item-coins")
        ?.textContent.trim();

      const profileCashbackButton = document.getElementById(
        "profileCashbackButton"
      );

      // Проверяем содержимое и меняем текст в profileCashbackCoins
      switch (coinValue) {
        case "500 coins":
          profileCashbackCoins.innerHTML = "500 <span>coins</span>";
          profileCashbackButton.innerHTML =
            "<span>BUY coupon -5% (500 COINS)</span>";
          break;
        case "1000 coins":
          profileCashbackCoins.innerHTML = "1000 <span>coins</span>";
          profileCashbackButton.innerHTML =
            "<span>BUY coupon -10% (1000 COINS)</span>";
          break;
        case "1500 coins":
          profileCashbackCoins.innerHTML = "1500 <span>coins</span>";
          profileCashbackButton.innerHTML =
            "<span>BUY coupon -15% (1500 COINS)</span>";
          break;
        case "2000 coins":
          profileCashbackCoins.innerHTML = "2000 <span>coins</span>";
          profileCashbackButton.innerHTML =
            "<span>BUY coupon -20% (2000 COINS)</span>";
          break;
        default:
          profileCashbackCoins.innerHTML = "0 <span>coins</span>"; // Опционально, если значение не найдено
      }
    });
  });
});
