<a href="https://laitis.ru"><img src="http://laitis.ru/Images/Icons/android-icon-192x192.png" alt="Laitis Logo" width="192" align="right"/></a>

# [RU] Laitis Integration <a href="https://vk.com/mikolaytis"><img src="https://pp.userapi.com/c623831/v623831300/54e02/PrgWBub3yX8.jpg" align="right" alt="Developer Portrait" height="32"/></a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://vk.com/laitisgroup"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/VK.com-logo.svg/240px-VK.com-logo.svg.png" align="right" alt="VK Logo" height="32"/></a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://www.youtube.com/channel/UC0rB-gldJSlgrv26FK0lhZA"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/YouTube_logo_2015.svg/320px-YouTube_logo_2015.svg.png" align="right" alt="Youtube Logo" height="32"/></a>

### Репозиторий содержит: 

* Примеры расширений для Laitis. 
* Контракты, необходимые расширениям для общения с Laitis
* Условия распространения расширений

### Laitis поддерживает два типа расширений:

Внешние расширения | Внутренние расширения
------------------ | ---------------------
Могут быть написаны почти на любом языке программирования | Должны быть написаны на C# для .Net Framework 4.5
Компилируются в исполняемый файл, например .exe | Компилируются в .dll
Могут находиться где угодно на компьютере и состоять из нескольких файлов | Будут находится в папке AppData/Local/Laitis/Extensions и должны состоять из одного .dll файла
Запускаются вручную пользователем | Laitis запускает их самостоятельно, каждый в отдельном процессе Laitis.exe, как это делает Сhromium
Могут иметь закрытый код | Должны быть с открытым исходным кодом на gitHub в этом репозитории, в отдельной папке с названием расширения, отправлено pull реквестом
Распространяются самостоятельно создателем | Laitis их распространяет(будет распространять) через внутренний магазин расширений
Создатель Laitis не несет ответственности за расширение и его работоспособность | Создатель Laitis лично проверяет расширения перед одобрением их в магазин на добросовестность и работоспособность и несет репутационную ответственность
Требуют усилий на подключение/перенос контрактов, сериализацию и интеграцию | Требуют минимальных усилий на разработку
Пример в проекте Laitis.ExternalExtensionExample | Пример в проекте Laitis.InternalExtensionExample


# [ENG] Laitis Integration
### This repository contains:

* Examples of Laitis extensions.
* Contracts required for extensions to communicate with Laitis
* Distribution Terms for Extensions

### Laitis supports two types of extensions:

External extensions | Internal extensions
------------------- | ---------------------
Can be written in almost any programming language | Should be written in C # for .Net Framework 4.5
Compiled into an executable, for example .exe | Compiled in .dll
Can be anywhere on the computer and consist of several files | Will be in the AppData/Local/Laitis/Extensions folder and should consist of one .dll file
Run manually by the user | Laitis launches them independently, each in a separate Laitis.exe process, as does Chromium
Can have a private code | Must be open source on gitHub in this repository, in a separate folder with the name of the extension, sent by pull request
Distributed independently by the creator | Laitis distributes them (will distribute) through the internal extension store
The creator of Laitis is not responsible for the extension and its performance | The creator of Laitis personally checks the extensions before approving them in the store for working capacity and bears reputational responsibility
Require efforts to connect/transfer contracts, serialization and integration | Requires minimal development effort
Example in the project Laitis.ExternalExtensionExample | Example in the project Laitis.InternalExtensionExample





