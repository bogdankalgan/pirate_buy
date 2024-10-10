const modSlider = document.querySelector(
  ".basket-content-price-block-input__range"
);

noUiSlider.create(modSlider, {
  start: 300,
  step: 1,
  connect: "lower",
  range: {
    min: 0,
    max: 100000,
  },
});

const modPips = modSlider.noUiSlider.pips({
  mode: "range",

  pips: {
    mode: "rtl",
  },
});

const modStartInput = document.querySelector(
  ".basket-content-price-block-input > input"
);

modSlider.noUiSlider.on("update", function (values) {
  modStartInput.value = Math.round(values[0]); // Обновляем значение инпута
});

// Слушаем изменение инпута и обновляем слайдер
modStartInput.addEventListener("change", function () {
  modSlider.noUiSlider.set(this.value);
});
