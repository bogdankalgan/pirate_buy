const radioBlocks = document.querySelectorAll(
  ".basket-content-choose-buttons-item"
);

// Для каждого блока добавляем обработчик событий
radioBlocks.forEach((block) => {
  block.addEventListener("click", (event) => {
    // Если кликнут не инпут, а блок или лейбл, то вручную переключаем радио
    const radio = block.querySelector('input[type="radio"]');

    // Снимаем checked у всех инпутов
    document
      .querySelectorAll('input[type="radio"]')
      .forEach((input) => (input.checked = false));

    // Отмечаем радио-инпут в кликнутом блоке
    radio.checked = true;

    // Убираем активность со всех блоков
    radioBlocks.forEach((b) =>
      b.classList.remove("basket-content-choose-buttons-item__active")
    );

    // Добавляем активность к текущему блоку
    block.classList.add("basket-content-choose-buttons-item__active");
  });
});
