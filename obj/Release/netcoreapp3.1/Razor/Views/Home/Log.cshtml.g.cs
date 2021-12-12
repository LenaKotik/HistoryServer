#pragma checksum "C:\Users\User\Desktop\C#stuff\HistoryServer\Views\Home\Log.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83fd5e9a89ab1b5dce393084e2a0af68a9659b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Log), @"mvc.1.0.view", @"/Views/Home/Log.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\C#stuff\HistoryServer\Views\_ViewImports.cshtml"
using HistoryServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\C#stuff\HistoryServer\Views\_ViewImports.cshtml"
using HistoryServer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fd5e9a89ab1b5dce393084e2a0af68a9659b0e", @"/Views/Home/Log.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f17673506606ef3279c84c1267b17877683019", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Log : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\C#stuff\HistoryServer\Views\Home\Log.cshtml"
   
    ViewData["Title"] = "Ход Работы";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83fd5e9a89ab1b5dce393084e2a0af68a9659b0e3190", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <a href=""https://github.com/LenaKotik/ProektPrimakov"">Исходный код этого сайта</a><br />
        <a href=""https://github.com/LenaKotik/HistoryServer"">Исходный код приложения</a>
        <p>
            <h1>Ход работы</h1>
            Создан новый проект WinForms C# .NET 3.1
            Создан класс Node наследуемый от System.Windows.Forms.UserControl
            (Модель, хранящая и отображающая данные определённого правителя)
            Создан файл Node.cs, Авто сгенерированы файлы Node.Designer.cs и Node.resx
            В класс Node добавлены поля <code>System.Windows.Forms.Label</code> label1, label2
            <code>System.Windows.Forms.PictureBox</code> pictureBox1
            В Resources.resx добавлены фотографии всех членов семьи Романовых, указанных в древе
            На Form1 (главную форму) добавлены экземпляры Node для каждого правителя.
            Методом хардкода записанны данные о правителе, и расположении на форме для каждого Node'a
    ");
                WriteLiteral(@"        Добавлен обработчик <code>Form1.Draw(object, PaintEventArgs)</code>, для события <code>PaintEventHandler Form1.Paint</code>
            В методе <code>Form.Draw(object, PaintEventArgs)</code> прорисовываются линии между членами семьи, символизирующие кровные связи
            Добавлена форма Form2, на ней будет отображаться конкретная информация о конкретном правителе эпохи дворцовых
            переворотов. На форме присутствует <code>System.Windows.Forms.PictureBox</code> pictureBox1 и <code>System.Windows.Forms.RichTextBox</code> richTextBox1
            (Это было временное решение, в последствие мы написали цикл, проходящий по всем строчкам текста и создающий <code>System.Windows.Froms.Label</code> на каждой итерации)
            Написана перегрузка конструктора Form2, принимающая аргументы <code>string data</code> и <code>System.Drawing.Image</code> image
            И передаёт значения свойствам richTextBox1.Text и pictureBox1.Image соответственно
            Начата разработка викторины, ");
                WriteLiteral(@"создана форма Quiz, она будет отображать пользователю вопрос, и следить за событиями кнопок-ответов. Добавлена кнопка, включающая викторину в Form1(главной форме) при нажатии на неё, создаётся новый экземпляр Quiz, в контруктор передаются заранее перемешанные вопросы из переменной (см. конструктор Quiz). Кроме Label с вопросом и 4мя Button, на форму Quiz добавлены ещё три Label, первый отображает сколько вопросов решено (из 10), второй — сколько осталось времени на решение (на каждый вопрос по 10 секунд), а третий — сколько баллов стоит данный вопрос (всего 24 балла за правильные ответы на все вопросы)
            А ещё ProgressBar и Timer.
            Интервал таймера стоит на 100мс (0.1с)
            Обработчик события Timer.Tick для таймера декрементирует переменную left, проверяет её же: если значение 0, открывается следующий вопрос (или страница с результатом, если вопрос был последний) и совершает шаг ProgressBar'а а также обновляет текст Label'a-счетчика времени
            Конструктор Quiz принима");
                WriteLiteral(@"ет словарь данных для викторины (<code>Dictionary<string, int></code>)
            где ключ это строка вида ""{вопрос}:{правильный ответ};{неправильный ответ 1};{неправильный ответ 2};{неправильный ответ 3}"", а значение это цена вопроса в баллах. Кроме этого конструктор принимает время на решение и номер вопроса. Случайным образом выбирается один вопрос, удаляется из словаря, разделяется на вопрос и варианты ответов, вопрос записывается в Label.Text, ответы – в Button.Text для каждой кнопки, в случайном порядке, при нажатии на одну из кнопок, обработчик события ""отрезает"" сам себя от кнопок (таким образом, если нажать на любую из кнопок, нельзя будет нажать повторно ни на одну из них), после этого он проверяет, выбран ли правильный ответ, если да, то помечает его зелёным цветом (меняет свойство Button.BackColor) и прибавляет цену задания к общим баллам, иначе, помечает красным цветом выбранный вариант, и зелёным цветом правильный.
            Добавлена форма Result, на ней отображаются результаты викторины:");
                WriteLiteral(@"
            Количество баллов
            Процент правильных ответов
            Оценка по 5бальной шкале, которая расчитывается по следующей формуле:
            p/100 * 5, где p это процент правильных ответов
            Создан новый проект Asp.Net MVC (Model-view-controller). Изменены автоматически сгенерированные файлы Index.cshtml и _Layout.cshtml, Privacy.cshtml изменён на Result.cshtml (перемещен в папку Views/Quiz из Views/Home). Добавлен контроллер QuizController И razor страница Quiz.cshtml. Добавлены модели Database (статический), Student, Question, Questions (статический).
            Модель Student(ученик) Структура данных, для хранения и обмена данными об учениках, принявших участие в викторине.
            Модель Question (вопрос) структура данных, для хранения и обмена данными о вопросах,
            задаваемых в викторине
            Модель Questions (вопросы) синглтон (статический класс) для хранения и использования объектов Question
            Модель Database (база данных) синглт");
                WriteLiteral(@"он (статический класс) для отправки запросов SQL серверу. Для этого использует классы SQLConnection и SQLCommand из библиотеки System.Data.SqlClient.
            HomeController отвечает на запросы, начинающиеся с ""https://historyserver20211206012050.azurewebsites.net"", он имеет метод Index (GET ""https://historyserver20211206012050.azurewebsites.net""), возвращающий главную страницу, и метод Table(int?) (GET ""https://historyserver20211206012050.azurewebsites.net/Table"") || (GET ""https://historyserver20211206012050.azurewebsites.net/Table?n=0""), возвращающий страницу с таблицей для браузера в первом случае, и JSON строку для приложения во втором
            QuizController отвечает на запросы начинающиеся с ""https://historyserver20211206012050.azurewebsites.net/Quiz"". Он имеет метод Quiz(int), с атрибутом [HttpGet(""https://historyserver20211206012050.azurewebsites.net/Quiz/{num}"")] это значит, что при отправлении запроса ""https://historyserver20211206012050.azurewebsites.net/Quiz/5"" это будет вызывать Quiz(5) и");
                WriteLiteral(@" открывать 5 вопрос по списку.
            В Quiz.cshtml написан JavaScript код для frontend части, отвечающий за таймер, кнопки, и переходы.
            В Result.cshtml присутствует форма, отправляющая запрос POST, контроллер в свою очередь отправляет запрос в базу данных на добавление записи через Database.Send, и возвращает Redirect на страницу с таблицей
            На запрос ""https://historyserver20211206012050.azurewebsites.net/home/download"" контроллер Home ответит потоком данных, в буфере которого массив байтов из внедреного файла ресурсов — это архив с проектом

            После создания сайта, в приложение добавлена новая форма – LeaderBoards
            На ней присутствует DataGridView, в конструкторе она, используя класс HttpClient из библиотеки System.Net.Http
            Отправляет HTTP запрос на сервер, в качестве ответа ожидает JSON строку, сериализует полученную строку используя JsonSerializer из System.Text.Json, а после этого ставит её как источник данных у DataGridView
           ");
                WriteLiteral(" Также, созданна форма на странице с результатом, отправляющая на сервер данные об имени и результате пользователя\r\n        </p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
