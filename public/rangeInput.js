// Инициализация слайдера

const slider = document.getElementById("slider");

noUiSlider.create(slider, {
  start: [300, 42200],
  step: 1,
  connect: true,
  range: {
    min: 0,
    max: 100000,
  },
});

const pips = slider.noUiSlider.pips({
  mode: "range",

  pips: {
    mode: "rtl",
  },
});

const startInput = document.getElementById("startInput");
const endInput = document.getElementById("endInput");

// Инициализируем инпуты значениями слайдера
startInput.value = slider.noUiSlider.get()[0];
endInput.value = slider.noUiSlider.get()[1];

// Обновляем значения в инпутах при перемещении ползунков
slider.noUiSlider.on("update", function (values, handle) {
  if (handle === 0) {
    startInput.value = Math.round(values[0]);
  } else {
    endInput.value = Math.round(values[1]);
  }
});

// Обновляем положение ползунков слайдера при изменении значений в инпутах
startInput.addEventListener("change", function () {
  slider.noUiSlider.set([this.value, null]);
});

endInput.addEventListener("change", function () {
  slider.noUiSlider.set([null, this.value]);
});
