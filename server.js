const express = require("express");
const path = require("path");
const readline = require("readline");

const expectedPassword = "kbbk946";

// Функция для скрытого ввода пароля
function askPassword(query) {
  return new Promise((resolve) => {
    const stdin = process.stdin;
    const stdout = process.stdout;

    stdout.write(query); // Печатаем запрос пароля

    stdin.setRawMode(true); // Включаем сырое чтение ввода
    stdin.resume();
    stdin.setEncoding("utf8");

    let password = "";
    stdin.on("data", (char) => {
      char = char + "";

      switch (char) {
        case "\n":
        case "\r":
        case "\u0004": // Когда нажимается Enter
          stdin.setRawMode(false); // Выключаем режим
          stdout.write("\n"); // Переход на новую строку
          stdin.pause();
          resolve(password); // Возвращаем пароль
          break;
        case "\u0003": // Ctrl+C для выхода
          process.exit();
          break;
        default:
          // Отключаем вывод символов на экран
          // Ничего не выводим и просто записываем символ в строку пароля
          password += char;
          break;
      }
    });
  });
}

(async () => {
  // Запрашиваем пароль у пользователя
  const inputPassword = await askPassword("Enter server password: ");

  // Проверяем пароль
  if (inputPassword === expectedPassword) {
    console.log("\nPassword is correct. Starting the server...");

    // Создаём приложение Express
    const app = express();

    // Указываем путь к статическим файлам
    app.use(express.static(path.join(__dirname, "public")));

    // Запуск сервера
    const PORT = process.env.PORT || 3000;
    const server = app.listen(PORT, () => {
      console.log(`Server is running on port ${PORT}`);
    });

    // Подключение Browsersync (только в режиме разработки)
    if (process.env.NODE_ENV !== "production") {
      const browserSync = require("browser-sync").create();
      browserSync.init({
        proxy: `http://localhost:${PORT}`,
        files: ["public/**/*.*"],
        port: 3000,
        open: false,
        notify: false,
      });
    }
  } else {
    console.log("Incorrect password. Exiting...");
    process.exit(); // Завершаем процесс при неверном пароле
  }
})();
