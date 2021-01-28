using Microsoft.EntityFrameworkCore;

namespace DevShop2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Front-end" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Back-end" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Programming Languages" });

            //seed pies

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                Name = "The Ultimate HTML5",
                Price = 12.95M,
                ShortDescription = "Everything you need to build fast and stunning websites with HTML 5 and CSS3 in one bundle!",
                LongDescription =
                    "A fun, comprehensive and beginner-friendly course that teaches you all the skills you need to build professional-quality websites with HTML5 and CSS3.Say goodbye to long, boring, repetitive courses with outdated content that spend too much time on the basics.This is the only HTML5 / CSS3 you'll ever need!",
                CategoryId = 1,
                ImageUrl = "https://amazingsoftbd.com/wp-content/uploads/2018/10/htmlcss.jpg",
                InStock = true,
                IsCourseOfTheWeek = true,
                ImageThumbnailUrl = "https://amazingsoftbd.com/wp-content/uploads/2018/10/htmlcss.jpg",
               
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 2,
                Name = "React",
                Price = 18.95M,
                ShortDescription = "Let’s face it – all the cool kids are using React…You'll love it!",
                LongDescription =
                    "Both new and seasoned developers are using it to build app front-ends that are fast, dynamic and stand out. If you want to see what React apps are like, just think of the big popular sites like Facebook, Instagram, Netflix, Yahoo, the list goes on.",
                CategoryId = 1,
                ImageUrl = "https://cdn.evilmartians.com/front/posts/optimizing-react-virtual-dom-explained/cover-a1d5b40.png",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://th.bing.com/th/id/R66657f5dc34703daceb62cb80cf2f7d4?rik=leC2w0XocKzzXw&riu=http%3a%2f%2fwww.jsweet.org%2fwp-content%2fuploads%2f2016%2f04%2freact-logo-300x289.png&ehk=8VP5WneINrDRKOGLup9KChH5HsoEQWor%2bDYkJIHeRmI%3d&risl=&pid=ImgRaw",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 3,
                Name = "Angular 4",
                Price = 18.95M,
                ShortDescription = "Angular is one of the most popular frameworks for building client apps with HTML, CSS and TypeScript.",
                LongDescription =
                    "Highly technical with a perfect mix of theory and practice. It covers absolutely every detail you could possibly need to take you from beginner Angular developer to expert .",
                CategoryId = 1,
                ImageUrl = "https://railsware.com/blog/wp-content/uploads/2014/09/Make-AngularJS-180x180.png",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl = "https://miro.medium.com/max/3798/1*eOE7VhXBlqdIJ9weEdHbQQ.jpeg",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 4,
                Name = "Xamarin",
                Price = 15.95M,
                ShortDescription = "Learn to build native mobile apps for Android, iOS and Windows using your existing C# skills",
                LongDescription =
                    "Xamarin Forms is a UI framework for building native cross-platform mobile apps with C#. You code your app only once, and let Xamarin compiler build your app for each platform. As simple as that! You don't need to learn 4 different languages and presentation frameworks!",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/8EdPMrdshGQ/maxresdefault.jpg",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl = "https://tse4.mm.bing.net/th/id/OIP.pqM_0olkXUm0-cT8GbDloQHaHa?pid=Api&rs=1",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 5,
                Name = "SQL",
                Price = 13.95M,
                ShortDescription = "Everything You Need to Design and Query Databases in One Course",
                LongDescription =
                    "Big databases are everywhere these days. Facebook, Netflix, Uber, Airbnb use SQL-driven databases - to name just a few.",
                CategoryId = 2,
                ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.6TY7jrUm-uvol1yC63LUSAHaEC?pid=Api&rs=1",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://freecourses.site/wp-content/uploads/2020/06/SQL-Course.jpg",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 6,
                Name = "Node.js",
                Price = 17.95M,
                ShortDescription = "Learn to build highly-scalable, fast and secure RESTful APIs with Node, Express, and MongoDB",
                LongDescription =
                    "Learn to build RESTful APIs with Node, Express and MongoDB with confidence. Includes best practices that pros apply, as well as going over common mistakes that many Node.js developers make.",
                CategoryId = 2,
                ImageUrl = "https://www.webrexstudio.com/wp-content/uploads/2019/06/Node-js.jpg",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl = "https://www.ict.social/images/5728/nodejs_logo.png",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 7,
                Name = "ASP.NET MVC 5",
                Price = 15.95M,
                ShortDescription = "Learn to build and deploy fast and secure web applications with ASP.NET MVC 5",
                LongDescription =
                    "Mastering ASP.NET MVC will really boost your career, especially if you’re looking to work at companies using Microsoft technologies.",
                CategoryId = 2,
                ImageUrl = "https://maxtrain.com/wp-content/uploads/2019/02/ASP-MVC-WEB-API-COURSEWARE-IMAGE.jpg",
                InStock = false,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl = "https://www.johndaniel.com/content/wp-content/uploads/2017/07/lg_aspmvc5-e1499097981117.png",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 8,
                Name = "Entity Framework 6",
                Price = 12.95M,
                ShortDescription = "Connect your applications to a SQL Server database",
                LongDescription =
                    "Entity Framework is an Object / Relational Mapper (O/RM) that helps you read and write data from and to a database. Whether you're new to Entity Framework, or been using it for a while but are looking for a comprehensive course with a clean structure to fill the missing parts, you're going to love this course. ",
                CategoryId = 2,
                ImageUrl = "https://th.bing.com/th/id/Rfa42c76ac12493610aeda4903e5abcbc?rik=TBSbadW91P1%2fog&riu=http%3a%2f%2fwww.rishabhsoft.com%2fwp-content%2fuploads%2f2016%2f07%2fMicrosoft-e1467354180645.png&ehk=r4s8FraCFJdDV%2bnRl8aAXPkfvKGYRRT9U1WKA6xNIsM%3d&risl=&pid=ImgRaw",
                InStock = true,
                IsCourseOfTheWeek = true,
                ImageThumbnailUrl = "https://msdnshared.blob.core.windows.net/media/2016/06/entityframework.png",
                
            });


            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 9,
                Name = "C#",
                Price = 15.95M,
                ShortDescription = "From C# zero to hero - Master one of the world's most versatile programming languages",
                LongDescription =
                    "C# is one of the most versatile programming languages in the world. It's used to build websites, apps and games through the Unity game engine. Just C#, explained clearly from the basics to the advanced concepts. ",
                CategoryId = 3,
                ImageUrl = "https://i.imgur.com/sxLGBl4.jpg",
                InStock = true,
                IsCourseOfTheWeek = true,
                ImageThumbnailUrl = "https://tse2.mm.bing.net/th/id/OIP.rFGBRk4AK42s4GBkYdYD0wAAAA?pid=Api&rs=1",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 10,
                Name = "Java",
                Price = 15.95M,
                ShortDescription = "Learn to write Java code with confidence",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://www.eginnovations.com/blog/wp-content/uploads/2019/06/how-to-troubleshoot-java-cpu.jpg",
                InStock = true,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl = "https://www.logolynx.com/images/logolynx/0a/0afbc6d4113a6aebd982ddbcc4d5eb91.jpeg",
                
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 11,
                Name = "Javascript",
                Price = 18.95M,
                ShortDescription = "If you're looking for a career in web or mobile app development, you MUST know JavaScript well.",
                LongDescription =
                    "Master the Fundamentals of JavaScript - The Language Behind Millions of Websites & Apps. Companies like Walmart, Netflix, and PayPal run big internal applications around JavaScript.",
                CategoryId = 3,
                ImageUrl = "https://th.bing.com/th/id/R75e2eabc740e265e22f1513186a26db1?rik=j6jZ50wJB%2b4T9Q&riu=http%3a%2f%2falpharayaneh.com%2fwp-content%2fuploads%2f2019%2f09%2fjava-script.jpg&ehk=JXSUq0eUkBFJL9gU%2f3KdmcTTnXkdaAYzBNEFLGdFTII%3d&risl=&pid=ImgRaw",
                InStock = false,
                IsCourseOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Unofficial_JavaScript_logo_2.svg/1200px-Unofficial_JavaScript_logo_2.svg.png",
                
            });
        }

    }
}
