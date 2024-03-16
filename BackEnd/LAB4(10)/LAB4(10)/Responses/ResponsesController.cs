using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace LAB4_10_.Responses
{
    [ApiController]
    [Route("[controller]")]
    public class ResponsesController : Controller
    {

        // Метод для возвращения HTML-страницы
        [HttpGet("html")] // Определяем маршрут для GET запросов
        public IActionResult GetHtmlPage()
        {
            // Создаем HTML страницу
            var htmlContent = @"
            <html>
                <body>
                    <h1>Заголовок маленькой страницы</h1>
                    <p>Возврат HTML контента</p>
                    <ul>
                        <li>Смысловая нагрузка</li>
                        <li>Смысловая нагрузка x2</li>
                    </ul>
                </body>
            </html>";
            return Content(htmlContent, "text/html"); // Возвращаем HTML-контент с MIME - типом text / html
        }



        [HttpGet("json")]
        public IActionResult GetJsonData()
        {
            // Создаем данные о пользователе для вывода
            var userData = new
            {
                Id = 7,
                Name = "Тима",
                Email = "timofeyezhov@gmail.com",
                Roles = new[] { "Бог-Император", "Омниссия", "Еретик" },
                Preferences = new
                {
                    Language = "Высокий готик",
                    Theme = "Имперская тема"
                }
            };
            return Ok(userData); // Возвращаем данные JSON со статусом 200
        }



        [HttpGet("file")]
        public IActionResult GetFile()
        {
            var filePath = @"Response.txt"; //Путь к файлу
            var bytes = System.IO.File.ReadAllBytes(filePath); // Считываем файл вмассив байтов
            return File(bytes, "text/plain", Path.GetFileName(filePath)); //Возвращаемфайл с MIME - типом text / plain
        }



        // Метод для возвращения изображения
        [HttpGet("image")]
        public IActionResult GetImage()
        {
            var filePath = @"HEHE.jpeg"; // Путь к изображению
            var bytes = System.IO.File.ReadAllBytes(filePath); // Считываем изображение в массив байтов
            return File(bytes, "image/jpeg"); // Возвращаем изображение с MIME-типом  image / jpg
        }
    }
}
