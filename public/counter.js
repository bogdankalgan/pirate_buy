const numberInput = document.getElementById('numberInput');
        const incrementButton = document.getElementById('increment');
        const decrementButton = document.getElementById('decrement');
        const resetButton = document.getElementById('reset');

        // Функция для безопасного получения значения из инпута
        function getNumberInputValue() {
            // Если инпут пустой или не содержит числа, возвращаем 0
            return parseInt(numberInput.value) || 0;
        }

        // Увеличить значение
        incrementButton.addEventListener('click', () => {
            numberInput.value = getNumberInputValue() + 1;
        });

        // Уменьшить значение
        decrementButton.addEventListener('click', () => {
            let currentValue = getNumberInputValue();
            if (currentValue > 0) {
                numberInput.value = currentValue - 1;
            }
        });

        // Сбросить значение на 0
        resetButton.addEventListener('click', () => {
            numberInput.value = 0;
        });