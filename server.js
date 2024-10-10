const express = require("express");
const path = require("path");
const readline = require("readline");

const expectedPassword = "kbbk946";

// Создаём интерфейс для ввода данных с изменением отображения на экране
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
  terminal: true,
});

// Функция для скрытого ввода пароля
function askPassword(query) {
  return new Promise((resolve) => {
    const stdin = process.stdin;
    const stdout = process.stdout;

    stdout.write(query);

    stdin.setRawMode(true); // Включаем "сырое" чтение ввода
    stdin.resume();
    stdin.setEncoding("utf8");

    let password = "";
    stdin.on("data", (char) => {
      char = char + "";

      switch (char) {
        case "\n":
        case "\r":
        case "\u0004": // Когда нажимается Enter
          stdin.setRawMode(false); // Возвращаем в обычный режим
          stdout.write("\n");
          stdin.pause();
          resolve(password); // Возвращаем введённый пароль
          break;
        case "\u0003": // Ctrl+C для выхода
          process.exit();
          break;
        default:
          // Стираем последний символ с помощью escape-последовательности
          stdout.write("\x1B[2K\x1B[200D"); // Стираем текущую строку
          stdout.write(query + "●".repeat(password.length + 1)); // Показываем круги
          password += char; // Добавляем символ в пароль
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
    rl.close();
  }
})();
