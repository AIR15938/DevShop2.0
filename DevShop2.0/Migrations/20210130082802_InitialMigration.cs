using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevShop2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCourseOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Front-end", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Back-end", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Programming Languages", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCourseOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://amazingsoftbd.com/wp-content/uploads/2018/10/htmlcss.jpg", "https://amazingsoftbd.com/wp-content/uploads/2018/10/htmlcss.jpg", true, true, "A fun, comprehensive and beginner-friendly course that teaches you all the skills you need to build professional-quality websites with HTML5 and CSS3.Say goodbye to long, boring, repetitive courses with outdated content that spend too much time on the basics.This is the only HTML5 / CSS3 you'll ever need!", "The Ultimate HTML5", 12.95m, "Everything you need to build fast and stunning websites with HTML 5 and CSS3 in one bundle!" },
                    { 2, 1, "https://th.bing.com/th/id/R66657f5dc34703daceb62cb80cf2f7d4?rik=leC2w0XocKzzXw&riu=http%3a%2f%2fwww.jsweet.org%2fwp-content%2fuploads%2f2016%2f04%2freact-logo-300x289.png&ehk=8VP5WneINrDRKOGLup9KChH5HsoEQWor%2bDYkJIHeRmI%3d&risl=&pid=ImgRaw", "https://cdn.evilmartians.com/front/posts/optimizing-react-virtual-dom-explained/cover-a1d5b40.png", true, false, "Both new and seasoned developers are using it to build app front-ends that are fast, dynamic and stand out. If you want to see what React apps are like, just think of the big popular sites like Facebook, Instagram, Netflix, Yahoo, the list goes on.", "React", 18.95m, "Let’s face it – all the cool kids are using React…You'll love it!" },
                    { 3, 1, "https://miro.medium.com/max/3798/1*eOE7VhXBlqdIJ9weEdHbQQ.jpeg", "https://railsware.com/blog/wp-content/uploads/2014/09/Make-AngularJS-180x180.png", true, false, "Highly technical with a perfect mix of theory and practice. It covers absolutely every detail you could possibly need to take you from beginner Angular developer to expert .", "Angular 4", 18.95m, "Angular is one of the most popular frameworks for building client apps with HTML, CSS and TypeScript." },
                    { 4, 1, "https://tse4.mm.bing.net/th/id/OIP.pqM_0olkXUm0-cT8GbDloQHaHa?pid=Api&rs=1", "https://i.ytimg.com/vi/8EdPMrdshGQ/maxresdefault.jpg", true, false, "Xamarin Forms is a UI framework for building native cross-platform mobile apps with C#. You code your app only once, and let Xamarin compiler build your app for each platform. As simple as that! You don't need to learn 4 different languages and presentation frameworks!", "Xamarin", 15.95m, "Learn to build native mobile apps for Android, iOS and Windows using your existing C# skills" },
                    { 5, 2, "https://freecourses.site/wp-content/uploads/2020/06/SQL-Course.jpg", "https://tse1.mm.bing.net/th/id/OIP.6TY7jrUm-uvol1yC63LUSAHaEC?pid=Api&rs=1", true, false, "Big databases are everywhere these days. Facebook, Netflix, Uber, Airbnb use SQL-driven databases - to name just a few.", "SQL", 13.95m, "Everything You Need to Design and Query Databases in One Course" },
                    { 6, 2, "https://www.ict.social/images/5728/nodejs_logo.png", "https://www.webrexstudio.com/wp-content/uploads/2019/06/Node-js.jpg", true, false, "Learn to build RESTful APIs with Node, Express and MongoDB with confidence. Includes best practices that pros apply, as well as going over common mistakes that many Node.js developers make.", "Node.js", 17.95m, "Learn to build highly-scalable, fast and secure RESTful APIs with Node, Express, and MongoDB" },
                    { 7, 2, "https://www.johndaniel.com/content/wp-content/uploads/2017/07/lg_aspmvc5-e1499097981117.png", "https://maxtrain.com/wp-content/uploads/2019/02/ASP-MVC-WEB-API-COURSEWARE-IMAGE.jpg", false, false, "Mastering ASP.NET MVC will really boost your career, especially if you’re looking to work at companies using Microsoft technologies.", "ASP.NET MVC 5", 15.95m, "Learn to build and deploy fast and secure web applications with ASP.NET MVC 5" },
                    { 8, 2, "https://msdnshared.blob.core.windows.net/media/2016/06/entityframework.png", "https://th.bing.com/th/id/Rfa42c76ac12493610aeda4903e5abcbc?rik=TBSbadW91P1%2fog&riu=http%3a%2f%2fwww.rishabhsoft.com%2fwp-content%2fuploads%2f2016%2f07%2fMicrosoft-e1467354180645.png&ehk=r4s8FraCFJdDV%2bnRl8aAXPkfvKGYRRT9U1WKA6xNIsM%3d&risl=&pid=ImgRaw", true, true, "Entity Framework is an Object / Relational Mapper (O/RM) that helps you read and write data from and to a database. Whether you're new to Entity Framework, or been using it for a while but are looking for a comprehensive course with a clean structure to fill the missing parts, you're going to love this course. ", "Entity Framework 6", 12.95m, "Connect your applications to a SQL Server database" },
                    { 9, 3, "https://tse2.mm.bing.net/th/id/OIP.rFGBRk4AK42s4GBkYdYD0wAAAA?pid=Api&rs=1", "https://i.imgur.com/sxLGBl4.jpg", true, true, "C# is one of the most versatile programming languages in the world. It's used to build websites, apps and games through the Unity game engine. Just C#, explained clearly from the basics to the advanced concepts. ", "C#", 15.95m, "From C# zero to hero - Master one of the world's most versatile programming languages" },
                    { 10, 3, "https://www.logolynx.com/images/logolynx/0a/0afbc6d4113a6aebd982ddbcc4d5eb91.jpeg", "https://www.eginnovations.com/blog/wp-content/uploads/2019/06/how-to-troubleshoot-java-cpu.jpg", true, false, "Learn to code in Java and improve your programming and problem-solving skills. You will learn to design algorithms as well as develop and debug programs. Using custom open-source classes, you will write programs that access and transform images, websites, and other types of data. ", "Java", 15.95m, "Learn to write Java code with confidence" },
                    { 11, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Unofficial_JavaScript_logo_2.svg/1200px-Unofficial_JavaScript_logo_2.svg.png", "https://th.bing.com/th/id/R75e2eabc740e265e22f1513186a26db1?rik=j6jZ50wJB%2b4T9Q&riu=http%3a%2f%2falpharayaneh.com%2fwp-content%2fuploads%2f2019%2f09%2fjava-script.jpg&ehk=JXSUq0eUkBFJL9gU%2f3KdmcTTnXkdaAYzBNEFLGdFTII%3d&risl=&pid=ImgRaw", false, false, "Master the Fundamentals of JavaScript - The Language Behind Millions of Websites & Apps. Companies like Walmart, Netflix, and PayPal run big internal applications around JavaScript.", "Javascript", 18.95m, "If you're looking for a career in web or mobile app development, you MUST know JavaScript well." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CourseId",
                table: "OrderDetails",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CourseId",
                table: "ShoppingCartItems",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
