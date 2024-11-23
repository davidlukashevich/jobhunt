using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingprofile_summaryandspecializationcolumnstoprofiletable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("06b259f1-d197-4b0c-bb00-ae8c8fe919a2"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("0ac7c82f-5f1b-49ac-a2d3-111024b7c5e9"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("1537a05b-ac00-4f84-92c9-67b0b5a7ef37"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("20f19952-3bfd-4f5c-8d93-f8c7e81333cd"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("3b6e75c5-31c5-4b7e-839c-5ddbd5fb17f3"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("44441ad6-cb25-4f0d-9cc3-7470afb848a2"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("4eea75ed-57c1-431d-bcbe-378914a3a76a"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("5de9c83e-b0f2-4eaa-b0c2-c6eb504f2212"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("60dfecfd-372b-4896-b420-5e855c8d5407"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("7318dc1c-6e13-47a3-b5f8-0230c5744b3b"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("93feeaa2-63f1-41ed-925a-ff63edab5860"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("ab6b2d8d-4abf-4231-a544-d40bc06a2f6c"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bbe67608-9bb4-4a4d-92b6-ab1f4f49624b"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bda3b2cc-c91c-462f-9609-009356422365"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("c837e3fe-ff98-4143-8935-96fe1f7f1235"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("db15da62-dd1b-46c6-896f-183375514cd6"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("e2c71ce1-94e9-4184-822a-7b6fe3dabc1a"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("e5126ac7-65dc-4f32-b424-628df4da755d"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("ea97730f-c8f3-481f-a9dc-abb4fce14b55"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("f4df625e-d6e8-488f-bea0-1efb1f25d324"));

            migrationBuilder.AddColumn<string>(
                name: "profile_summary",
                table: "profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "specialization",
                table: "profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "about_company", "address_id", "company_name", "contract_type", "created_at", "created_by", "image_id", "job_level", "operation_mode", "requirements", "responsibilities", "salary", "technology", "title", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("1299cc56-179c-4c92-a00e-3661f6e9def9"), "Web dev specialists", new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "WebWorks", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), "Lead", "Hybrid", "[\"Strong proficiency in React for building dynamic, component-driven user interfaces\",\"In-depth knowledge of Redux for state management, including actions, reducers, and middlewares (such as Redux Thunk or Redux Saga)\",\"Experience with React hooks (useEffect, useState, etc.) and functional components\",\"Proficiency in JavaScript (ES6\\u002B)\",\"Familiarity with React Router for navigation and Axios for API requests\",\"Understanding of CSS\"]", "[\"Working in international Scrum Team to deliver Business critical solutions within the terminal/transit warehousing area in close cooperation with Product Owner\",\"Developing and technically owning backend (Java 17\\u002B/Spring, Event-Driven Architecture) and frontend (React for building dynamic, component-driven user interfaces) applications hosted in Azure Cloud\",\"Continuous improvement of products and internal delivery \\u0026 maintenance processes\"]", "15000-20000 zł netto", "Js", "Lead Frontend Engineer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("147b66ef-0888-4c17-8663-bec7a4bd4d99"), "Leading in AI solutions", new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Tech Innovators", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), "Senior", "Remote", "[\"7\\u002B years of experience\",\"Expert experience with HTML, CSS, React, and Node.js\",\"High fidelity HTML/CSS prototyping skills\",\"Excellent knowledge of design systems and responsive web design\",\"Strong understanding of component-based development within a shared style guide context\",\"Deep knowledge of web accessibility standards\",\"Expertise in managing cross-browser issues \"]", "[\"Collaborating with a cross-functional team of UX designers and UI developers\",\"Iteratively coding with considerations for fast-paced delivery and quality\",\"Working with multiple stakeholders including product owners and engineering leads\",\"Developing and maintaining a consistent approach to our component library and consuming applications\",\"Mentoring junior team members\",\"Ensuring UI consistency across multiple applications in collaboration with engineering leadership\",\"Adhering to best practices in our UX/UI functions\",\"Creating high-fidelity HTML/CSS prototypes\",\"Addressing cross-browser concerns and ensuring web accessibility\"]", "10000-12000 zł netto", "React", "Senior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15c479dd-5da6-4329-af99-c0b16d0cc265"), "Experts in cloud tech", new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Cloudify", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("239b185c-4d37-4b01-baba-001b4425794a"), "Senior", "Remote", "[\" Minimum 3-letnie do\\u015Bwiadczenie w budowaniu aplikacji pythonowych\",\" Do\\u015Bwiadczenie w projektowaniu i budowaniu wysoko-skalowalnych aplikacji z r\\u00F3wnoleg\\u0142ym strumieniem przetwarzania\",\" Tworzenie czytelnego kodu zgodnego z zasadami SOLID, umiej\\u0119tno\\u015B\\u0107 wykorzystywania Design Patterns w codziennej pracy\",\" Podstawowa znajomo\\u015B\\u0107 algorytm\\u00F3w i struktur danych\",\" J\\u0119zyk angielski na poziomie umo\\u017Cliwiaj\\u0105cym swobodne czytanie i pisanie dokumentacji oraz porozumiewanie si\\u0119 z wsp\\u00F3\\u0142pracownikami (min. B2)\",\" Do\\u015Bwiadczenie w pracy z JavaScript, optymalnie NestJS\",\"Do\\u015Bwiadczenie w pracy z Flask oraz relacyjnymi i nie relacyjnymi bazami danych\",\" Znajomo\\u015B\\u0107 ekosystemu AWS\"]", "[\" Wsparcie zespo\\u0142u w budowaniu architektury aplikacji\",\" Udzia\\u0142 w podejmowaniu decyzji i rozwi\\u0105zywaniu problem\\u00F3w w okre\\u015Blonych obszarach projektu\",\"Wsparcie prowadzenia zespo\\u0142u developerskiego\",\"  Dzielenie si\\u0119 wiedz\\u0105 i do\\u015Bwiadczeniami z reszt\\u0105 zespo\\u0142u\",\" Pisanie czystego, wydajnego kodu\",\" Prowadzenie procesu Code Review oraz podejmowanie decyzji na poziomie kodu\"]", "12000-15000 zł netto", "Python", "Senior Backend Engineer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("252f07ea-9219-47b6-9e13-a09cfa17992e"), "Renowned in game dev", new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "PlayMax Studios", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), "Junior", "Remote", "[\"Experience with Unity, C#\"]", "[\"Write game mechanics code\"]", "8000-9000 zł netto", "C#", "Junior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2efb7f89-ff7d-4e0e-b803-5c06cebc1268"), "Backend solutions", new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "CoreTech", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), "Lead", "Onsite", "[\"Bachelor\\u0027s or Master\\u0027s degree in computer science/engineering or last year of university degree\",\" At least 7\\u002B years of hands-on Java development experience\",\" Very Good knowledge of Java (11\\u002B)\",\" Strong Experience with Spring Framework\",\" Strong Experience with JPA/Hibernate\",\" Strong Experience with SQL/NoSQL with understanding of database design and optimization methodologies\",\" Experience with Apache Camel\",\" Experience with Messaging Queues\",\" Experience with QueryDSL or other query mapping frameworks\",\" Experience in Angular 10\\u002B\",\" Knowledge of unit testing frameworks (preferred Cucumber)\",\" Good knowledge of linux commands and scripting\"]", "[\" Core Java development and Web applications with Spring and Angular\",\" Participate in requirements analysis\",\" Work with deployment pipelines and CI/CD processes\",\"Debugging and problem solving on existing applications\",\" Working in distributed teams with Agile Frameworks (Kanban/Scrum)\",\" Feature development, code reviews, guide our developers for best development practices\"]", "15000-20000 zł brutto", "Java", "Lead Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("481b8480-85ab-4de6-8548-9c3aa90fc32f"), "A renowned leader in AAA game development", new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "PlayMax Studios", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), "Senior", "Remote", "[\" Programujesz w C\\u002B\\u002B 17\",\" Znasz STL, Git/Svn\",\"Posiadasz umiej\\u0119tno\\u015B\\u0107 analitycznego i logicznego my\\u015Blenia\",\"Masz zdolno\\u015B\\u0107 do analizy wymaga\\u0144 niezb\\u0119dnych do projektowania i wdra\\u017Cania najlepszych rozwi\\u0105za\\u0144\",\" Dysponujesz wiedz\\u0105 z zakresu zagadnie\\u0144 rachunku prawdopodobie\\u0144stwa, kombinatoryki i statystyki\",\" Microsoft Excel nie ma przed Tob\\u0105 tajemnic\",\" Komunikujesz si\\u0119 w j\\u0119zyku angielskim na poziomie komunikatywnym\"]", "[\"Develop complex game systems, mentor junior developers\",\" Nasz\\u0105 misj\\u0105 jest nie tylko wprowadzanie nowych tytu\\u0142\\u00F3w na rynek, ale tak\\u017Ce ich dostosowywanie do specyficznych wymaga\\u0144 r\\u00F3\\u017Cnych rynk\\u00F3w.\",\" Specjalizujemy si\\u0119 w zaawansowanej matematyce gier oraz tworzeniu i doskonaleniu mechanizm\\u00F3w kontrolnych.\"]", "14000-17000 zł brutto", "C#", "Senior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a57e566-7c4a-43a3-8412-706c4aa0c92e"), "Web solutions specialists", new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "App Builders", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), "Middle", "Remote", "[\"3\\u002B years with JS \\u0026 Node\",\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "7000-9000 zł netto", "Js", "Middle Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a9037e0-132d-4457-8c3f-eae7d85cc54e"), "Innovators in gaming", new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "GameForge", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), "Middle", "Onsite", "[\"3\\u002B years with Unity,C#\"]", "[\"Create engaging game logic\"]", "10000-12000 zł brutto", "C#", "Middle Game Developer", "Gamedev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b6b9d9a-1816-4218-b346-e106f37ef2b3"), "Web and mobile dev", new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Code Factory", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), "Junior", "Remote", "[\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "4000-5000 zł brutto", "Js", "Junior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7743fcad-08c3-479a-9db3-8b96ca933b82"), "Specializing in mobile tech", new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "AppSphere", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), "Lead", "Onsite", "[\"7\\u002B years in mobile dev, Swift\",\" Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\"Good communication skills\",\" Willingness to learn\",\"Basic knowhow of automotive problematics\"]", "[\"Oversee mobile development\",\"Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\"Good communication skills\",\" Willingness to learn\",\" Basic knowhow of automotive problematics\"]", "20000-25000 zł brutto", "Swift", "Lead Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("935476c5-cbd5-4feb-a60d-8493631241b4"), "Top mobile solutions", new Guid("3a55e504-11f1-4c82-8628-692982996558"), "MobiSolutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), "Senior", "Hybrid", "[\"5\\u002B years in mobile dev, , Android, Kotlin\",\" Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\" Good communication skills\",\" Willingness to learn\",\" Basic know how of automotive problematics\"]", "[\"Design mobile features\",\" Programming languages  Swift\",\" Mobile development frameworks\",\" In-depth experience with application and user interface level using at least one mobile application development language\",\" Asynchronous programming and networking protocols\"]", "15000-20000 zł brutto", "Kotlin", "Senior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9aabffcc-702b-4460-b5e8-a629cb27b50e"), "Industry leader in immersive gaming experiences", new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Epic Games Studio", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), "Lead", "Onsite", "[\"7\\u002B years in game development, experience leading large projects, Unreal Engine, C\\u002B\\u002B, Game Design\",\" Programujesz w C\\u002B\\u002B 17\",\" Znasz STL, Git/Svn\",\" Posiadasz umiej\\u0119tno\\u015B\\u0107 analitycznego i logicznego my\\u015Blenia\",\" Masz zdolno\\u015B\\u0107 do analizy wymaga\\u0144 niezb\\u0119dnych do projektowania i wdra\\u017Cania najlepszych rozwi\\u0105za\\u0144\",\" Dysponujesz wiedz\\u0105 z zakresu zagadnie\\u0144 rachunku prawdopodobie\\u0144stwa, kombinatoryki i statystyki\",\"Microsoft Excel nie ma przed Tob\\u0105 tajemnic\",\" Komunikujesz si\\u0119 w j\\u0119zyku angielskim na poziomie komunikatywnym\"]", "[\"Lead the game development team, oversee project lifecycle\",\"Nasz\\u0105 misj\\u0105 jest nie tylko wprowadzanie nowych tytu\\u0142\\u00F3w na rynek, ale tak\\u017Ce ich dostosowywanie do specyficznych wymaga\\u0144 r\\u00F3\\u017Cnych rynk\\u00F3w.\",\"Specjalizujemy si\\u0119 w zaawansowanej matematyce gier oraz tworzeniu i doskonaleniu mechanizm\\u00F3w kontrolnych.\"]", "18000-20000 zł brutto", "C++", "Lead Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e036ded-241a-43b8-b1e4-c6b091d8c599"), "Web innovation leaders", new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Web Wonders", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), "Middle", "Hybrid", "[\"3-4 years of experience in frontend development using Angular and TypeScript.\",\"Additional proficiency with Lit, Sass, Java, C\\u002B\\u002B is preferred.\",\"Openness to contributing to Google\\u0027s future success in Cloud AI.\",\"English level: min B2\\u002B.\"]", "[\"Build user interfaces using Angular and TypeScript for Google Cloud\\u0027s AI applications.\",\"Work closely with backend teams, PM, UX Researchers, and UX Designers on improvements to Cloud AI products.\",\"Design and build new frontend components and features for all Cloud AI applications and services.\",\"Opportunities to work on end-to-end features including UI, API and backend layers to develop full-stack experience.\"]", "6000-8000 zł brutto", "Typescript", "Middle Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3750fbd-7ec0-4372-b5e2-3335e92040db"), "Mobile app innovation", new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "NextGen Mobile", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), "Middle", "Hybrid", "[\"2\\u002B years in mobile dev, Kotlin\",\"Znajomo\\u015B\\u0107 Kotlin oraz Java\",\" Do\\u015Bwiadczenie z Android Studio\",\"  znajomo\\u015B\\u0107 Git, Gerrit, Gradle\",\" Do\\u015Bwiadczene z Postman lub SoapUI\",\" Do\\u015Bwiadczenie z Jira, Confluence\",\" Do\\u015Bwiadczenie z Adobexd lub podobnymi bibliotekami\",\" Do\\u015Bwiadczenie z narz\\u0119dziami CI/CD (Jenkins)\"]", "[\"Maintain mobile apps\",\"Udzia\\u0142 w rozwoju oprogramowania aplikacji mobilnych dla bran\\u017Cy finansowej\",\"Stosowanie dobrych praktyk programowania obiektowego i wzorc\\u00F3w projektowych, takich jak MVP, MVVM czy MVC\",\"Implementacja atrakcyjnych i intuicyjnych interfejs\\u00F3w u\\u017Cytkownika\",\" \\u015Acis\\u0142a wsp\\u00F3\\u0142praca z zespo\\u0142em projektant\\u00F3w UX/UI, backendowc\\u00F3w, tester\\u00F3w oraz product manager\\u00F3w, aby spe\\u0142ni\\u0107 wymagania projektowe i dostarczy\\u0107 wysokiej jako\\u015Bci produkt\"]", "10000-13000 zł netto", "Kotlin", " Middle Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afab9186-1407-4601-8131-27f915c8f067"), "Web innovation hub", new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "WebGen", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), "Junior", "Remote", "[\"Experience with HTML, CSS, JavaScript\",\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Support web projects\",\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "4000-5000 zł brutto", "Js", "Junior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd65092c-7896-4f1f-84f2-e5b246b60a43"), "Creative app developers", new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "AppLab", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), "Junior", "Onsite", "[\"Basic knowledge in Swift, iOS\",\" Znajomo\\u015B\\u0107 Kotlin oraz Java\",\" Do\\u015Bwiadczenie z Android Studio\",\" znajomo\\u015B\\u0107 Git, Gerrit, Gradle\"]", "[\"Support mobile dev team\",\" Udzia\\u0142 w rozwoju oprogramowania aplikacji mobilnych dla bran\\u017Cy finansowej\",\" Stosowanie dobrych praktyk programowania obiektowego i wzorc\\u00F3w projektowych, takich jak MVP, MVVM czy MVC\",\" Implementacja atrakcyjnych i intuicyjnych interfejs\\u00F3w u\\u017Cytkownika\",\" \\u015Acis\\u0142a wsp\\u00F3\\u0142praca z zespo\\u0142em projektant\\u00F3w UX/UI, backendowc\\u00F3w, tester\\u00F3w oraz product manager\\u00F3w, aby spe\\u0142ni\\u0107 wymagania projektowe i dostarczy\\u0107 wysokiej jako\\u015Bci produkt\"]", "7000-9000 zł netto", "Swift", "Junior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4f5edd1-e1bf-4f67-908d-f69c014e975d"), "Data science leaders", new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "DataScience Co", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), "Middle", "Remote", "[\"3\\u002B years with Python, Flask\",\"do\\u015Bwiadczenie na stanowisku programisty \\u2013 minimum 2 lata;\",\"do\\u015Bwiadczenie w pracy projektowej w zespole deweloperskim;\",\"dobra znajomo\\u015B\\u0107 wzorc\\u00F3w projektowych, zasad programowania obiektowego;\",\"znajomo\\u015B\\u0107 narz\\u0119dzi kontroli wersji Git;\",\"do\\u015Bwiadczenie w pisaniu test\\u00F3w jednostkowych, integracyjnych;\",\"samodzielno\\u015B\\u0107 i komunikatywno\\u015B\\u0107.\"]", "[\"projektowanie i implementacja rozwi\\u0105za\\u0144 informatycznych;\",\"praca w oparciu o zwinn\\u0105 metodyk\\u0119 wytwarzania oprogramowania;\",\"dbanie o jako\\u015B\\u0107 kodu \\u017Ar\\u00F3d\\u0142owego;\",\"wsp\\u00F3\\u0142praca z pozosta\\u0142ymi cz\\u0142onkami zespo\\u0142u.\"]", "7000-9000 zł brutto", "Python", "Middle Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dca2e730-a65f-4351-a96f-6184ba993678"), "Comprehensive IT services", new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "DigitalCraft", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), "Senior", "Hybrid", "[\"5\\u002B years in fullstack dev, , Ruby on Rails, JavaScript\",\" dobra znajomo\\u015B\\u0107 zasad projektowania, dost\\u0119pno\\u015Bci i testowania u\\u017Cyteczno\\u015Bci\",\"znajomo\\u015B\\u0107 kompatybilno\\u015Bci mi\\u0119dzy przegl\\u0105darkami, techniki buforowania i optymalizacji wydajno\\u015Bci, znajomo\\u015B\\u0107 podstaw SEO i umiej\\u0119tno\\u015B\\u0107 optymalizacji pod k\\u0105tem wyszukiwarek\",\" aktywna wsp\\u00F3\\u0142praca z klientami oraz zespo\\u0142ami - Twoja wiedza pozwala na konstruktywny dialog i wyb\\u00F3r odpowiednich rozwi\\u0105za\\u0144.\",\" znajomo\\u015B\\u0107 systemu kontroli wersji (GIT)\"]", "[\" tworzenie portali turystycznych dla naszych Klient\\u00F3w w Polsce i za granic\\u0105\",\"  rozw\\u00F3j i tworzenie nowych funkcjonalno\\u015Bci dotychczasowych aplikacji\",\" uczestnictwo w przegl\\u0105dach kodu oraz d\\u0105\\u017Cenie do zapewnienia wysokiej jako\\u015Bci i efektywno\\u015Bci rozwi\\u0105za\\u0144\",\" aktywne uczestnictwo w tworzeniu specyfikacji projektowych wraz z zespo\\u0142em\"]", "11000-14000 zł brutto", "JavaScript", "Senior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4b7238c-9aec-4d63-80bb-514be1dc70a2"), "Focus on data analytics", new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "DataX Solutions", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), "Junior", "Hybrid", "[\"Do\\u015Bwiadczenie w programowaniu z wykorzystaniem C# .Net\",\"Znajomo\\u015B\\u0107 Microsoft SQL Server w zakresie tworzenia zapyta\\u0144\",\"Do\\u015Bwiadczenie w projektowaniu lub tworzeniu aplikacji komercyjnych (mile widziane)\",\"Znajomo\\u015B\\u0107 j\\u0119z. angielskiego umo\\u017Cliwiaj\\u0105ca czytanie dokumentacji technicznej\"]", "[\"Assist backend development team\",\"Szukamy osoby, kt\\u00F3rej zadaniem b\\u0119dzie rozwijanie naszego produktu opartego o \\u015Brodowisko bazodanowe MS SQL oraz .Net\"]", "5000-6000 zł netto", ".Net", "Junior Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8a59eaf-8e24-40f4-a0a5-20b44a81e119"), "IT and web solutions", new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Total Solutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), "Lead", "Remote", "[\"7\\u002B years in fullstack dev, JavaScript, Node.js, React\",\" Problem-solving skills and a proactive approach to challenges\",\" Experience working in a DevSecOps environment\",\" Solid understanding of change management processes\",\" Strong Gitlab, Jira, and Confluence experience for project and code management\",\"Knowledge of HTML, CSS, and JavaScript for front-end integration\",\"Ability to work collaboratively within a globally distributed team\"]", "[\"Lead fullstack projects\",\"Solid understanding of change management processes\",\" Strong Gitlab, Jira, and Confluence experience for project and code management\",\" Knowledge of HTML, CSS, and JavaScript for front-end integration\",\" Ability to work collaboratively within a globally distributed team\"]", "16000-19000 zł brutto", "Javascript", "Lead Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("1299cc56-179c-4c92-a00e-3661f6e9def9"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("147b66ef-0888-4c17-8663-bec7a4bd4d99"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("15c479dd-5da6-4329-af99-c0b16d0cc265"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("252f07ea-9219-47b6-9e13-a09cfa17992e"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("2efb7f89-ff7d-4e0e-b803-5c06cebc1268"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("481b8480-85ab-4de6-8548-9c3aa90fc32f"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("4a57e566-7c4a-43a3-8412-706c4aa0c92e"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("5a9037e0-132d-4457-8c3f-eae7d85cc54e"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("6b6b9d9a-1816-4218-b346-e106f37ef2b3"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("7743fcad-08c3-479a-9db3-8b96ca933b82"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("935476c5-cbd5-4feb-a60d-8493631241b4"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("9aabffcc-702b-4460-b5e8-a629cb27b50e"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("9e036ded-241a-43b8-b1e4-c6b091d8c599"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("a3750fbd-7ec0-4372-b5e2-3335e92040db"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("afab9186-1407-4601-8131-27f915c8f067"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bd65092c-7896-4f1f-84f2-e5b246b60a43"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("d4f5edd1-e1bf-4f67-908d-f69c014e975d"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("dca2e730-a65f-4351-a96f-6184ba993678"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("e4b7238c-9aec-4d63-80bb-514be1dc70a2"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("f8a59eaf-8e24-40f4-a0a5-20b44a81e119"));

            migrationBuilder.DropColumn(
                name: "profile_summary",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "specialization",
                table: "profiles");

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "about_company", "address_id", "company_name", "contract_type", "created_at", "created_by", "image_id", "job_level", "operation_mode", "requirements", "responsibilities", "salary", "technology", "title", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("06b259f1-d197-4b0c-bb00-ae8c8fe919a2"), "Data science leaders", new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "DataScience Co", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), "Middle", "Remote", "[\"3\\u002B years with Python, Flask\",\"do\\u015Bwiadczenie na stanowisku programisty \\u2013 minimum 2 lata;\",\"do\\u015Bwiadczenie w pracy projektowej w zespole deweloperskim;\",\"dobra znajomo\\u015B\\u0107 wzorc\\u00F3w projektowych, zasad programowania obiektowego;\",\"znajomo\\u015B\\u0107 narz\\u0119dzi kontroli wersji Git;\",\"do\\u015Bwiadczenie w pisaniu test\\u00F3w jednostkowych, integracyjnych;\",\"samodzielno\\u015B\\u0107 i komunikatywno\\u015B\\u0107.\"]", "[\"projektowanie i implementacja rozwi\\u0105za\\u0144 informatycznych;\",\"praca w oparciu o zwinn\\u0105 metodyk\\u0119 wytwarzania oprogramowania;\",\"dbanie o jako\\u015B\\u0107 kodu \\u017Ar\\u00F3d\\u0142owego;\",\"wsp\\u00F3\\u0142praca z pozosta\\u0142ymi cz\\u0142onkami zespo\\u0142u.\"]", "7000-9000 zł brutto", "Python", "Middle Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ac7c82f-5f1b-49ac-a2d3-111024b7c5e9"), "Web innovation leaders", new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Web Wonders", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), "Middle", "Hybrid", "[\"3-4 years of experience in frontend development using Angular and TypeScript.\",\"Additional proficiency with Lit, Sass, Java, C\\u002B\\u002B is preferred.\",\"Openness to contributing to Google\\u0027s future success in Cloud AI.\",\"English level: min B2\\u002B.\"]", "[\"Build user interfaces using Angular and TypeScript for Google Cloud\\u0027s AI applications.\",\"Work closely with backend teams, PM, UX Researchers, and UX Designers on improvements to Cloud AI products.\",\"Design and build new frontend components and features for all Cloud AI applications and services.\",\"Opportunities to work on end-to-end features including UI, API and backend layers to develop full-stack experience.\"]", "6000-8000 zł brutto", "Typescript", "Middle Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1537a05b-ac00-4f84-92c9-67b0b5a7ef37"), "IT and web solutions", new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Total Solutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), "Lead", "Remote", "[\"7\\u002B years in fullstack dev, JavaScript, Node.js, React\",\" Problem-solving skills and a proactive approach to challenges\",\" Experience working in a DevSecOps environment\",\" Solid understanding of change management processes\",\" Strong Gitlab, Jira, and Confluence experience for project and code management\",\"Knowledge of HTML, CSS, and JavaScript for front-end integration\",\"Ability to work collaboratively within a globally distributed team\"]", "[\"Lead fullstack projects\",\"Solid understanding of change management processes\",\" Strong Gitlab, Jira, and Confluence experience for project and code management\",\" Knowledge of HTML, CSS, and JavaScript for front-end integration\",\" Ability to work collaboratively within a globally distributed team\"]", "16000-19000 zł brutto", "Javascript", "Lead Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20f19952-3bfd-4f5c-8d93-f8c7e81333cd"), "Backend solutions", new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "CoreTech", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), "Lead", "Onsite", "[\"Bachelor\\u0027s or Master\\u0027s degree in computer science/engineering or last year of university degree\",\" At least 7\\u002B years of hands-on Java development experience\",\" Very Good knowledge of Java (11\\u002B)\",\" Strong Experience with Spring Framework\",\" Strong Experience with JPA/Hibernate\",\" Strong Experience with SQL/NoSQL with understanding of database design and optimization methodologies\",\" Experience with Apache Camel\",\" Experience with Messaging Queues\",\" Experience with QueryDSL or other query mapping frameworks\",\" Experience in Angular 10\\u002B\",\" Knowledge of unit testing frameworks (preferred Cucumber)\",\" Good knowledge of linux commands and scripting\"]", "[\" Core Java development and Web applications with Spring and Angular\",\" Participate in requirements analysis\",\" Work with deployment pipelines and CI/CD processes\",\"Debugging and problem solving on existing applications\",\" Working in distributed teams with Agile Frameworks (Kanban/Scrum)\",\" Feature development, code reviews, guide our developers for best development practices\"]", "15000-20000 zł brutto", "Java", "Lead Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b6e75c5-31c5-4b7e-839c-5ddbd5fb17f3"), "Web dev specialists", new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "WebWorks", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), "Lead", "Hybrid", "[\"Strong proficiency in React for building dynamic, component-driven user interfaces\",\"In-depth knowledge of Redux for state management, including actions, reducers, and middlewares (such as Redux Thunk or Redux Saga)\",\"Experience with React hooks (useEffect, useState, etc.) and functional components\",\"Proficiency in JavaScript (ES6\\u002B)\",\"Familiarity with React Router for navigation and Axios for API requests\",\"Understanding of CSS\"]", "[\"Working in international Scrum Team to deliver Business critical solutions within the terminal/transit warehousing area in close cooperation with Product Owner\",\"Developing and technically owning backend (Java 17\\u002B/Spring, Event-Driven Architecture) and frontend (React for building dynamic, component-driven user interfaces) applications hosted in Azure Cloud\",\"Continuous improvement of products and internal delivery \\u0026 maintenance processes\"]", "15000-20000 zł netto", "Js", "Lead Frontend Engineer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44441ad6-cb25-4f0d-9cc3-7470afb848a2"), "Specializing in mobile tech", new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "AppSphere", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), "Lead", "Onsite", "[\"7\\u002B years in mobile dev, Swift\",\" Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\"Good communication skills\",\" Willingness to learn\",\"Basic knowhow of automotive problematics\"]", "[\"Oversee mobile development\",\"Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\"Good communication skills\",\" Willingness to learn\",\" Basic knowhow of automotive problematics\"]", "20000-25000 zł brutto", "Swift", "Lead Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4eea75ed-57c1-431d-bcbe-378914a3a76a"), "Focus on data analytics", new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "DataX Solutions", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), "Junior", "Hybrid", "[\"Do\\u015Bwiadczenie w programowaniu z wykorzystaniem C# .Net\",\"Znajomo\\u015B\\u0107 Microsoft SQL Server w zakresie tworzenia zapyta\\u0144\",\"Do\\u015Bwiadczenie w projektowaniu lub tworzeniu aplikacji komercyjnych (mile widziane)\",\"Znajomo\\u015B\\u0107 j\\u0119z. angielskiego umo\\u017Cliwiaj\\u0105ca czytanie dokumentacji technicznej\"]", "[\"Assist backend development team\",\"Szukamy osoby, kt\\u00F3rej zadaniem b\\u0119dzie rozwijanie naszego produktu opartego o \\u015Brodowisko bazodanowe MS SQL oraz .Net\"]", "5000-6000 zł netto", ".Net", "Junior Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5de9c83e-b0f2-4eaa-b0c2-c6eb504f2212"), "Comprehensive IT services", new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "DigitalCraft", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), "Senior", "Hybrid", "[\"5\\u002B years in fullstack dev, , Ruby on Rails, JavaScript\",\" dobra znajomo\\u015B\\u0107 zasad projektowania, dost\\u0119pno\\u015Bci i testowania u\\u017Cyteczno\\u015Bci\",\"znajomo\\u015B\\u0107 kompatybilno\\u015Bci mi\\u0119dzy przegl\\u0105darkami, techniki buforowania i optymalizacji wydajno\\u015Bci, znajomo\\u015B\\u0107 podstaw SEO i umiej\\u0119tno\\u015B\\u0107 optymalizacji pod k\\u0105tem wyszukiwarek\",\" aktywna wsp\\u00F3\\u0142praca z klientami oraz zespo\\u0142ami - Twoja wiedza pozwala na konstruktywny dialog i wyb\\u00F3r odpowiednich rozwi\\u0105za\\u0144.\",\" znajomo\\u015B\\u0107 systemu kontroli wersji (GIT)\"]", "[\" tworzenie portali turystycznych dla naszych Klient\\u00F3w w Polsce i za granic\\u0105\",\"  rozw\\u00F3j i tworzenie nowych funkcjonalno\\u015Bci dotychczasowych aplikacji\",\" uczestnictwo w przegl\\u0105dach kodu oraz d\\u0105\\u017Cenie do zapewnienia wysokiej jako\\u015Bci i efektywno\\u015Bci rozwi\\u0105za\\u0144\",\" aktywne uczestnictwo w tworzeniu specyfikacji projektowych wraz z zespo\\u0142em\"]", "11000-14000 zł brutto", "JavaScript", "Senior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60dfecfd-372b-4896-b420-5e855c8d5407"), "Renowned in game dev", new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "PlayMax Studios", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), "Junior", "Remote", "[\"Experience with Unity, C#\"]", "[\"Write game mechanics code\"]", "8000-9000 zł netto", "C#", "Junior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7318dc1c-6e13-47a3-b5f8-0230c5744b3b"), "Web and mobile dev", new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Code Factory", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), "Junior", "Remote", "[\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "4000-5000 zł brutto", "Js", "Junior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93feeaa2-63f1-41ed-925a-ff63edab5860"), "Innovators in gaming", new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "GameForge", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), "Middle", "Onsite", "[\"3\\u002B years with Unity,C#\"]", "[\"Create engaging game logic\"]", "10000-12000 zł brutto", "C#", "Middle Game Developer", "Gamedev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab6b2d8d-4abf-4231-a544-d40bc06a2f6c"), "Leading in AI solutions", new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Tech Innovators", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), "Senior", "Remote", "[\"7\\u002B years of experience\",\"Expert experience with HTML, CSS, React, and Node.js\",\"High fidelity HTML/CSS prototyping skills\",\"Excellent knowledge of design systems and responsive web design\",\"Strong understanding of component-based development within a shared style guide context\",\"Deep knowledge of web accessibility standards\",\"Expertise in managing cross-browser issues \"]", "[\"Collaborating with a cross-functional team of UX designers and UI developers\",\"Iteratively coding with considerations for fast-paced delivery and quality\",\"Working with multiple stakeholders including product owners and engineering leads\",\"Developing and maintaining a consistent approach to our component library and consuming applications\",\"Mentoring junior team members\",\"Ensuring UI consistency across multiple applications in collaboration with engineering leadership\",\"Adhering to best practices in our UX/UI functions\",\"Creating high-fidelity HTML/CSS prototypes\",\"Addressing cross-browser concerns and ensuring web accessibility\"]", "10000-12000 zł netto", "React", "Senior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbe67608-9bb4-4a4d-92b6-ab1f4f49624b"), "Industry leader in immersive gaming experiences", new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Epic Games Studio", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), "Lead", "Onsite", "[\"7\\u002B years in game development, experience leading large projects, Unreal Engine, C\\u002B\\u002B, Game Design\",\" Programujesz w C\\u002B\\u002B 17\",\" Znasz STL, Git/Svn\",\" Posiadasz umiej\\u0119tno\\u015B\\u0107 analitycznego i logicznego my\\u015Blenia\",\" Masz zdolno\\u015B\\u0107 do analizy wymaga\\u0144 niezb\\u0119dnych do projektowania i wdra\\u017Cania najlepszych rozwi\\u0105za\\u0144\",\" Dysponujesz wiedz\\u0105 z zakresu zagadnie\\u0144 rachunku prawdopodobie\\u0144stwa, kombinatoryki i statystyki\",\"Microsoft Excel nie ma przed Tob\\u0105 tajemnic\",\" Komunikujesz si\\u0119 w j\\u0119zyku angielskim na poziomie komunikatywnym\"]", "[\"Lead the game development team, oversee project lifecycle\",\"Nasz\\u0105 misj\\u0105 jest nie tylko wprowadzanie nowych tytu\\u0142\\u00F3w na rynek, ale tak\\u017Ce ich dostosowywanie do specyficznych wymaga\\u0144 r\\u00F3\\u017Cnych rynk\\u00F3w.\",\"Specjalizujemy si\\u0119 w zaawansowanej matematyce gier oraz tworzeniu i doskonaleniu mechanizm\\u00F3w kontrolnych.\"]", "18000-20000 zł brutto", "C++", "Lead Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bda3b2cc-c91c-462f-9609-009356422365"), "Mobile app innovation", new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "NextGen Mobile", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), "Middle", "Hybrid", "[\"2\\u002B years in mobile dev, Kotlin\",\"Znajomo\\u015B\\u0107 Kotlin oraz Java\",\" Do\\u015Bwiadczenie z Android Studio\",\"  znajomo\\u015B\\u0107 Git, Gerrit, Gradle\",\" Do\\u015Bwiadczene z Postman lub SoapUI\",\" Do\\u015Bwiadczenie z Jira, Confluence\",\" Do\\u015Bwiadczenie z Adobexd lub podobnymi bibliotekami\",\" Do\\u015Bwiadczenie z narz\\u0119dziami CI/CD (Jenkins)\"]", "[\"Maintain mobile apps\",\"Udzia\\u0142 w rozwoju oprogramowania aplikacji mobilnych dla bran\\u017Cy finansowej\",\"Stosowanie dobrych praktyk programowania obiektowego i wzorc\\u00F3w projektowych, takich jak MVP, MVVM czy MVC\",\"Implementacja atrakcyjnych i intuicyjnych interfejs\\u00F3w u\\u017Cytkownika\",\" \\u015Acis\\u0142a wsp\\u00F3\\u0142praca z zespo\\u0142em projektant\\u00F3w UX/UI, backendowc\\u00F3w, tester\\u00F3w oraz product manager\\u00F3w, aby spe\\u0142ni\\u0107 wymagania projektowe i dostarczy\\u0107 wysokiej jako\\u015Bci produkt\"]", "10000-13000 zł netto", "Kotlin", " Middle Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c837e3fe-ff98-4143-8935-96fe1f7f1235"), "Web solutions specialists", new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "App Builders", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), "Middle", "Remote", "[\"3\\u002B years with JS \\u0026 Node\",\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "7000-9000 zł netto", "Js", "Middle Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db15da62-dd1b-46c6-896f-183375514cd6"), "Web innovation hub", new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "WebGen", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), "Junior", "Remote", "[\"Experience with HTML, CSS, JavaScript\",\"Wykszta\\u0142cenie: min. student 3 roku - kierunek informatyka lub pokrewny\",\"Znajomo\\u015B\\u0107: Vue 3 \\u002B Angular \\u002B CSS \\u002B TypeScript\",\"Znajomo\\u015B\\u0107 system\\u00F3w kontroli wersji (Git)\",\"Znajomo\\u015B\\u0107 j\\u0119zyka angielskiego umo\\u017Cliwiaj\\u0105ca sprawn\\u0105 komunikacj\\u0119 w mowie i w pi\\u015Bmie\"]", "[\"Support web projects\",\"Projektowanie i implementowanie Front-endu na podstawie wymaga\\u0144 biznesowych\",\"Testowanie manualne oraz automatyczne dostarczanych rozwi\\u0105za\\u0144\",\"Udzia\\u0142 w pracach utrzymaniowych w \\u015Brodowiskach testowych i produkcyjnych\"]", "4000-5000 zł brutto", "Js", "Junior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2c71ce1-94e9-4184-822a-7b6fe3dabc1a"), "Experts in cloud tech", new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Cloudify", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("239b185c-4d37-4b01-baba-001b4425794a"), "Senior", "Remote", "[\" Minimum 3-letnie do\\u015Bwiadczenie w budowaniu aplikacji pythonowych\",\" Do\\u015Bwiadczenie w projektowaniu i budowaniu wysoko-skalowalnych aplikacji z r\\u00F3wnoleg\\u0142ym strumieniem przetwarzania\",\" Tworzenie czytelnego kodu zgodnego z zasadami SOLID, umiej\\u0119tno\\u015B\\u0107 wykorzystywania Design Patterns w codziennej pracy\",\" Podstawowa znajomo\\u015B\\u0107 algorytm\\u00F3w i struktur danych\",\" J\\u0119zyk angielski na poziomie umo\\u017Cliwiaj\\u0105cym swobodne czytanie i pisanie dokumentacji oraz porozumiewanie si\\u0119 z wsp\\u00F3\\u0142pracownikami (min. B2)\",\" Do\\u015Bwiadczenie w pracy z JavaScript, optymalnie NestJS\",\"Do\\u015Bwiadczenie w pracy z Flask oraz relacyjnymi i nie relacyjnymi bazami danych\",\" Znajomo\\u015B\\u0107 ekosystemu AWS\"]", "[\" Wsparcie zespo\\u0142u w budowaniu architektury aplikacji\",\" Udzia\\u0142 w podejmowaniu decyzji i rozwi\\u0105zywaniu problem\\u00F3w w okre\\u015Blonych obszarach projektu\",\"Wsparcie prowadzenia zespo\\u0142u developerskiego\",\"  Dzielenie si\\u0119 wiedz\\u0105 i do\\u015Bwiadczeniami z reszt\\u0105 zespo\\u0142u\",\" Pisanie czystego, wydajnego kodu\",\" Prowadzenie procesu Code Review oraz podejmowanie decyzji na poziomie kodu\"]", "12000-15000 zł netto", "Python", "Senior Backend Engineer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5126ac7-65dc-4f32-b424-628df4da755d"), "Creative app developers", new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "AppLab", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), "Junior", "Onsite", "[\"Basic knowledge in Swift, iOS\",\" Znajomo\\u015B\\u0107 Kotlin oraz Java\",\" Do\\u015Bwiadczenie z Android Studio\",\" znajomo\\u015B\\u0107 Git, Gerrit, Gradle\"]", "[\"Support mobile dev team\",\" Udzia\\u0142 w rozwoju oprogramowania aplikacji mobilnych dla bran\\u017Cy finansowej\",\" Stosowanie dobrych praktyk programowania obiektowego i wzorc\\u00F3w projektowych, takich jak MVP, MVVM czy MVC\",\" Implementacja atrakcyjnych i intuicyjnych interfejs\\u00F3w u\\u017Cytkownika\",\" \\u015Acis\\u0142a wsp\\u00F3\\u0142praca z zespo\\u0142em projektant\\u00F3w UX/UI, backendowc\\u00F3w, tester\\u00F3w oraz product manager\\u00F3w, aby spe\\u0142ni\\u0107 wymagania projektowe i dostarczy\\u0107 wysokiej jako\\u015Bci produkt\"]", "7000-9000 zł netto", "Swift", "Junior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea97730f-c8f3-481f-a9dc-abb4fce14b55"), "A renowned leader in AAA game development", new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "PlayMax Studios", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), "Senior", "Remote", "[\" Programujesz w C\\u002B\\u002B 17\",\" Znasz STL, Git/Svn\",\"Posiadasz umiej\\u0119tno\\u015B\\u0107 analitycznego i logicznego my\\u015Blenia\",\"Masz zdolno\\u015B\\u0107 do analizy wymaga\\u0144 niezb\\u0119dnych do projektowania i wdra\\u017Cania najlepszych rozwi\\u0105za\\u0144\",\" Dysponujesz wiedz\\u0105 z zakresu zagadnie\\u0144 rachunku prawdopodobie\\u0144stwa, kombinatoryki i statystyki\",\" Microsoft Excel nie ma przed Tob\\u0105 tajemnic\",\" Komunikujesz si\\u0119 w j\\u0119zyku angielskim na poziomie komunikatywnym\"]", "[\"Develop complex game systems, mentor junior developers\",\" Nasz\\u0105 misj\\u0105 jest nie tylko wprowadzanie nowych tytu\\u0142\\u00F3w na rynek, ale tak\\u017Ce ich dostosowywanie do specyficznych wymaga\\u0144 r\\u00F3\\u017Cnych rynk\\u00F3w.\",\" Specjalizujemy si\\u0119 w zaawansowanej matematyce gier oraz tworzeniu i doskonaleniu mechanizm\\u00F3w kontrolnych.\"]", "14000-17000 zł brutto", "C#", "Senior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4df625e-d6e8-488f-bea0-1efb1f25d324"), "Top mobile solutions", new Guid("3a55e504-11f1-4c82-8628-692982996558"), "MobiSolutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), "Senior", "Hybrid", "[\"5\\u002B years in mobile dev, , Android, Kotlin\",\" Advanced English (written and spoken)\",\" Expertise in software engineering toolchain (Jira, Git, CI/CD)\",\" Good communication skills\",\" Willingness to learn\",\" Basic know how of automotive problematics\"]", "[\"Design mobile features\",\" Programming languages  Swift\",\" Mobile development frameworks\",\" In-depth experience with application and user interface level using at least one mobile application development language\",\" Asynchronous programming and networking protocols\"]", "15000-20000 zł brutto", "Kotlin", "Senior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
