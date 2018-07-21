<h2>Задание реализовать библиотеку в ASP.NET MVC </h2>
Основные классы :<br>
Publisher<br>
Name: string<br>
<br>
Author<br>
Name: string<br>
DateOfBirth: Date<br>
DateOfDeath: Date?<br>
<br>
Book<br>
Id: int<br>
Name: string<br>
Publisher: Publisher<br>
Authors : IEnumerable<Author><br>
PublishDate : Date<br>
PageCount: int<br>
ISBN : string<br>
<br>
Реализовать контроллеры для каждого из классов, на основные действия - Создание, Получение, Изменение, Удаление.<br>
<br>
Если удаляется автор или издательство, у книг использующие эти данные они должны пропасть, нап. удаляется автор, у книги где он фигурирует, удаляемый автор пропадает из списка авторов.<br>
<br>
Таблицы генерировать с помощью хелперов<br>